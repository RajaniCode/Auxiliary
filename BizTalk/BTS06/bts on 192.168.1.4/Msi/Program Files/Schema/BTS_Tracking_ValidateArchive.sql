/**********************************************
**
*	This script contains logic for validating the archival of the tracking database
*	and communicating back to the tracking database that the archive was either successfull
*	or failed and so allowing the backup and purge jobs to continue. Linked server privledges are required
*	between this server and the tracking database server
**
************************************************/

if exists (select * from sysobjects where id = object_id(N'[dbo].[dtasp_ValidateArchive]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
  	DROP PROCEDURE [dbo].[dtasp_ValidateArchive]
GO

CREATE PROCEDURE [dbo].[dtasp_ValidateArchive]
@nvcServer sysname,
@nvcDatabase sysname
AS

	declare @nvcLastBackupLocation nvarchar(2000),
		@nID int,
		@nvcRemotePrefix nvarchar(512),
		@tsql nvarchar(1024)

	declare @localized_string_EmptyParams nvarchar(256)
	set @localized_string_EmptyParams = N'The Tracking server and database parameters cannot be null.'

	declare @localized_string_ArchiveSuccessfull nvarchar(256)
	set @localized_string_ArchiveSuccessfull = N'The Tracking database archive has been successfully restored.  '

	if ( (@nvcServer IS NULL) OR (@nvcDatabase IS NULL) )
		RAISERROR(@localized_string_EmptyParams, 16, 1)
	set @nvcRemotePrefix = null


	--let's build the string which we are going to execute. Given that we are using the server and db name to construct
	--a tsql string to execute, access to this sproc should be restricted since if anyone were able to call
	--this they could get us to execute arbitrary sql.
	set @nvcRemotePrefix = '[' + @nvcServer + '].[' + @nvcDatabase + '].'
	set @tsql = @nvcRemotePrefix + 'dbo.dtasp_GetLastArchiveLocation'

	exec @tsql @nvcLastBackupLocation OUTPUT, @nID OUTPUT
	if (@nvcLastBackupLocation IS NOT NULL)
	BEGIN
		declare @ldf nvarchar(200)
		set @ldf = @nvcDatabase + '_log'
		--lets try to restore this backup
		RESTORE DATABASE ArchivedTrackingData FROM DISK = @nvcLastBackupLocation
		 WITH 	REPLACE 
			
		if (@@error = 0)
		BEGIN
			set @tsql = @nvcRemotePrefix + 'dbo.dtasp_ArchiveSuccessfull'

			exec @tsql @nID

			--lets add to the log that we successfully restored this file
			RAISERROR(@localized_string_ArchiveSuccessfull, 10, 1)
		END
		ELSE
		BEGIN
			set @tsql = @nvcRemotePrefix + 'dbo.dtasp_ArchiveFailed'

			exec @tsql @nID
		END
	END
GO

BEGIN TRANSACTION            
  DECLARE @JobID BINARY(16)  
  DECLARE @ReturnCode INT 
  DECLARE @dbname sysname

  set @dbname = db_name()   
  SELECT @ReturnCode = 0     
IF (SELECT COUNT(*) FROM msdb.dbo.syscategories WHERE name = N'Database Maintenance') < 1 
  EXECUTE msdb.dbo.sp_add_category @name = N'Database Maintenance'

  -- Delete the job with the same name (if it exists)
  SELECT @JobID = job_id     
  FROM   msdb.dbo.sysjobs    
  WHERE (name = N'ValidateArchive')       
  IF (@JobID IS NOT NULL)    
  BEGIN  
  -- Check if the job is a multi-server job  
  IF (EXISTS (SELECT  * 
              FROM    msdb.dbo.sysjobservers 
              WHERE   (job_id = @JobID) AND (server_id <> 0))) 
  BEGIN 
    -- There is, so abort the script 
    RAISERROR (N'Unable to import job ''ValidateArchive'' since there is already a multi-server job with this name.', 16, 1) 
    GOTO QuitWithRollback  
  END 
  ELSE 
    -- Delete the [local] job 
    EXECUTE msdb.dbo.sp_delete_job @job_name = N'ValidateArchive' 
    SELECT @JobID = NULL
  END 

BEGIN 

  -- Add the job
  EXECUTE @ReturnCode = msdb.dbo.sp_add_job @job_id = @JobID OUTPUT , @job_name = N'ValidateArchive',  @description = N'Validates the archive generated by the backup and purge scripts for the tracking database.', @category_name = N'Database Maintenance', @enabled = 1, @notify_level_email = 0, @notify_level_page = 0, @notify_level_netsend = 0, @notify_level_eventlog = 2, @delete_level= 0
  IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback 

  -- Add the job steps
  EXECUTE @ReturnCode = msdb.dbo.sp_add_jobstep @job_id = @JobID, @step_id = 1, @step_name = N'validate', @command = N'exec dtasp_ValidateArchive null, null', @database_name = @dbname, @server = N'', @database_user_name = N'', @subsystem = N'TSQL', @cmdexec_success_code = 0, @flags = 0, @retry_attempts = 0, @retry_interval = 1, @output_file_name = N'', @on_success_step_id = 0, @on_success_action = 1, @on_fail_step_id = 0, @on_fail_action = 2
  IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback 
  EXECUTE @ReturnCode = msdb.dbo.sp_update_job @job_id = @JobID, @start_step_id = 1 

  IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback 

  -- Add the Target Servers
  EXECUTE @ReturnCode = msdb.dbo.sp_add_jobserver @job_id = @JobID, @server_name = N'(local)' 
  IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback 

END
COMMIT TRANSACTION          
GOTO   EndSave              
QuitWithRollback:
  IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION 
EndSave: 


