﻿namespace WF_TransactionScope
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Activities;
    using System.Activities.Statements;

    using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent syncEvent = new AutoResetEvent(false);

            WorkflowInstance myInstance = new WorkflowInstance(new WF_TransactionScope.WF_TransactionScopeSequence());
            myInstance.OnCompleted = delegate(WorkflowCompletedEventArgs e) { syncEvent.Set(); };
            myInstance.OnUnhandledException = delegate(WorkflowUnhandledExceptionEventArgs e)
            {
                Console.WriteLine(e.UnhandledException.ToString());
                return UnhandledExceptionAction.Terminate;
            };
            myInstance.OnAborted = delegate(WorkflowAbortedEventArgs e)
            {
                Console.WriteLine(e.Reason);
                syncEvent.Set();
            };

            myInstance.Run();

            syncEvent.WaitOne();

        }
    }
}
