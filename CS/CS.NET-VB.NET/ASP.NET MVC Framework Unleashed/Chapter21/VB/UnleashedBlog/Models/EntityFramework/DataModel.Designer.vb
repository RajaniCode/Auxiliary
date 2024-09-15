﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3053
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

<Assembly: Global.System.Data.Objects.DataClasses.EdmSchemaAttribute("a9204547-6b99-4554-87f1-61a3f44ccdb4")> 

'Original file name:
'Generation date: 4/18/2009 12:30:06 PM
'''<summary>
'''There are no comments for BlogDBEntities in the schema.
'''</summary>
Partial Public Class BlogDBEntities
    Inherits Global.System.Data.Objects.ObjectContext
    '''<summary>
    '''Initializes a new BlogDBEntities object using the connection string found in the 'BlogDBEntities' section of the application configuration file.
    '''</summary>
    Public Sub New()
        MyBase.New("name=BlogDBEntities", "BlogDBEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new BlogDBEntities object.
    '''</summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "BlogDBEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new BlogDBEntities object.
    '''</summary>
    Public Sub New(ByVal connection As Global.System.Data.EntityClient.EntityConnection)
        MyBase.New(connection, "BlogDBEntities")
        Me.OnContextCreated
    End Sub
    Partial Private Sub OnContextCreated()
        End Sub
    '''<summary>
    '''There are no comments for BlogEntryEntitySet in the schema.
    '''</summary>
    Public ReadOnly Property BlogEntryEntitySet() As Global.System.Data.Objects.ObjectQuery(Of BlogEntryEntity)
        Get
            If (Me._BlogEntryEntitySet Is Nothing) Then
                Me._BlogEntryEntitySet = MyBase.CreateQuery(Of BlogEntryEntity)("[BlogEntryEntitySet]")
            End If
            Return Me._BlogEntryEntitySet
        End Get
    End Property
    Private _BlogEntryEntitySet As Global.System.Data.Objects.ObjectQuery(Of BlogEntryEntity)
    '''<summary>
    '''There are no comments for CommentEntitySet in the schema.
    '''</summary>
    Public ReadOnly Property CommentEntitySet() As Global.System.Data.Objects.ObjectQuery(Of CommentEntity)
        Get
            If (Me._CommentEntitySet Is Nothing) Then
                Me._CommentEntitySet = MyBase.CreateQuery(Of CommentEntity)("[CommentEntitySet]")
            End If
            Return Me._CommentEntitySet
        End Get
    End Property
    Private _CommentEntitySet As Global.System.Data.Objects.ObjectQuery(Of CommentEntity)
    '''<summary>
    '''There are no comments for BlogEntryEntitySet in the schema.
    '''</summary>
    Public Sub AddToBlogEntryEntitySet(ByVal blogEntryEntity As BlogEntryEntity)
        MyBase.AddObject("BlogEntryEntitySet", blogEntryEntity)
    End Sub
    '''<summary>
    '''There are no comments for CommentEntitySet in the schema.
    '''</summary>
    Public Sub AddToCommentEntitySet(ByVal commentEntity As CommentEntity)
        MyBase.AddObject("CommentEntitySet", commentEntity)
    End Sub
End Class
'''<summary>
'''There are no comments for UnleashedBlog.Models.EntityFramework.BlogEntryEntity in the schema.
'''</summary>
'''<KeyProperties>
'''Id
'''</KeyProperties>
<Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="UnleashedBlog.Models.EntityFramework", Name:="BlogEntryEntity"),  _
 Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=true),  _
 Global.System.Serializable()>  _
Partial Public Class BlogEntryEntity
    Inherits Global.System.Data.Objects.DataClasses.EntityObject
    '''<summary>
    '''Create a new BlogEntryEntity object.
    '''</summary>
    '''<param name="id">Initial value of Id.</param>
    '''<param name="name">Initial value of Name.</param>
    '''<param name="author">Initial value of Author.</param>
    '''<param name="datePublished">Initial value of DatePublished.</param>
    '''<param name="title">Initial value of Title.</param>
    '''<param name="text">Initial value of Text.</param>
    Public Shared Function CreateBlogEntryEntity(ByVal id As Integer, ByVal name As String, ByVal author As String, ByVal datePublished As Date, ByVal title As String, ByVal text As String) As BlogEntryEntity
        Dim blogEntryEntity As BlogEntryEntity = New BlogEntryEntity
        blogEntryEntity.Id = id
        blogEntryEntity.Name = name
        blogEntryEntity.Author = author
        blogEntryEntity.DatePublished = datePublished
        blogEntryEntity.Title = title
        blogEntryEntity.Text = text
        Return blogEntryEntity
    End Function
    '''<summary>
    '''There are no comments for Property Id in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Id() As Integer
        Get
            Return Me._Id
        End Get
        Set
            Me.OnIdChanging(value)
            Me.ReportPropertyChanging("Id")
            Me._Id = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("Id")
            Me.OnIdChanged
        End Set
    End Property
    Private _Id As Integer
    Partial Private Sub OnIdChanging(ByVal value As Integer)
        End Sub
    Partial Private Sub OnIdChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Name in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Name() As String
        Get
            Return Me._Name
        End Get
        Set
            Me.OnNameChanging(value)
            Me.ReportPropertyChanging("Name")
            Me._Name = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Name")
            Me.OnNameChanged
        End Set
    End Property
    Private _Name As String
    Partial Private Sub OnNameChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnNameChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Author in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Author() As String
        Get
            Return Me._Author
        End Get
        Set
            Me.OnAuthorChanging(value)
            Me.ReportPropertyChanging("Author")
            Me._Author = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Author")
            Me.OnAuthorChanged
        End Set
    End Property
    Private _Author As String
    Partial Private Sub OnAuthorChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnAuthorChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property DatePublished in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property DatePublished() As Date
        Get
            Return Me._DatePublished
        End Get
        Set
            Me.OnDatePublishedChanging(value)
            Me.ReportPropertyChanging("DatePublished")
            Me._DatePublished = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("DatePublished")
            Me.OnDatePublishedChanged
        End Set
    End Property
    Private _DatePublished As Date
    Partial Private Sub OnDatePublishedChanging(ByVal value As Date)
        End Sub
    Partial Private Sub OnDatePublishedChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property DateModified in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property DateModified() As Global.System.Nullable(Of Date)
        Get
            Return Me._DateModified
        End Get
        Set
            Me.OnDateModifiedChanging(value)
            Me.ReportPropertyChanging("DateModified")
            Me._DateModified = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("DateModified")
            Me.OnDateModifiedChanged
        End Set
    End Property
    Private _DateModified As Global.System.Nullable(Of Date)
    Partial Private Sub OnDateModifiedChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
    Partial Private Sub OnDateModifiedChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Title in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Title() As String
        Get
            Return Me._Title
        End Get
        Set
            Me.OnTitleChanging(value)
            Me.ReportPropertyChanging("Title")
            Me._Title = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Title")
            Me.OnTitleChanged
        End Set
    End Property
    Private _Title As String
    Partial Private Sub OnTitleChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnTitleChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Description in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Description() As String
        Get
            Return Me._Description
        End Get
        Set
            Me.OnDescriptionChanging(value)
            Me.ReportPropertyChanging("Description")
            Me._Description = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Description")
            Me.OnDescriptionChanged
        End Set
    End Property
    Private _Description As String
    Partial Private Sub OnDescriptionChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnDescriptionChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Text in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Text() As String
        Get
            Return Me._Text
        End Get
        Set
            Me.OnTextChanging(value)
            Me.ReportPropertyChanging("Text")
            Me._Text = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Text")
            Me.OnTextChanged
        End Set
    End Property
    Private _Text As String
    Partial Private Sub OnTextChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnTextChanged()
        End Sub
End Class
'''<summary>
'''There are no comments for UnleashedBlog.Models.EntityFramework.CommentEntity in the schema.
'''</summary>
'''<KeyProperties>
'''Id
'''</KeyProperties>
<Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="UnleashedBlog.Models.EntityFramework", Name:="CommentEntity"),  _
 Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=true),  _
 Global.System.Serializable()>  _
Partial Public Class CommentEntity
    Inherits Global.System.Data.Objects.DataClasses.EntityObject
    '''<summary>
    '''Create a new CommentEntity object.
    '''</summary>
    '''<param name="id">Initial value of Id.</param>
    '''<param name="blogEntryId">Initial value of BlogEntryId.</param>
    '''<param name="title">Initial value of Title.</param>
    '''<param name="name">Initial value of Name.</param>
    '''<param name="datePublished">Initial value of DatePublished.</param>
    '''<param name="text">Initial value of Text.</param>
    Public Shared Function CreateCommentEntity(ByVal id As Integer, ByVal blogEntryId As Integer, ByVal title As String, ByVal name As String, ByVal datePublished As Date, ByVal text As String) As CommentEntity
        Dim commentEntity As CommentEntity = New CommentEntity
        commentEntity.Id = id
        commentEntity.BlogEntryId = blogEntryId
        commentEntity.Title = title
        commentEntity.Name = name
        commentEntity.DatePublished = datePublished
        commentEntity.Text = text
        Return commentEntity
    End Function
    '''<summary>
    '''There are no comments for Property Id in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Id() As Integer
        Get
            Return Me._Id
        End Get
        Set
            Me.OnIdChanging(value)
            Me.ReportPropertyChanging("Id")
            Me._Id = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("Id")
            Me.OnIdChanged
        End Set
    End Property
    Private _Id As Integer
    Partial Private Sub OnIdChanging(ByVal value As Integer)
        End Sub
    Partial Private Sub OnIdChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property BlogEntryId in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property BlogEntryId() As Integer
        Get
            Return Me._BlogEntryId
        End Get
        Set
            Me.OnBlogEntryIdChanging(value)
            Me.ReportPropertyChanging("BlogEntryId")
            Me._BlogEntryId = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("BlogEntryId")
            Me.OnBlogEntryIdChanged
        End Set
    End Property
    Private _BlogEntryId As Integer
    Partial Private Sub OnBlogEntryIdChanging(ByVal value As Integer)
        End Sub
    Partial Private Sub OnBlogEntryIdChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Title in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Title() As String
        Get
            Return Me._Title
        End Get
        Set
            Me.OnTitleChanging(value)
            Me.ReportPropertyChanging("Title")
            Me._Title = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Title")
            Me.OnTitleChanged
        End Set
    End Property
    Private _Title As String
    Partial Private Sub OnTitleChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnTitleChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Name in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Name() As String
        Get
            Return Me._Name
        End Get
        Set
            Me.OnNameChanging(value)
            Me.ReportPropertyChanging("Name")
            Me._Name = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Name")
            Me.OnNameChanged
        End Set
    End Property
    Private _Name As String
    Partial Private Sub OnNameChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnNameChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Email in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Email() As String
        Get
            Return Me._Email
        End Get
        Set
            Me.OnEmailChanging(value)
            Me.ReportPropertyChanging("Email")
            Me._Email = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Email")
            Me.OnEmailChanged
        End Set
    End Property
    Private _Email As String
    Partial Private Sub OnEmailChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnEmailChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Url in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Url() As String
        Get
            Return Me._Url
        End Get
        Set
            Me.OnUrlChanging(value)
            Me.ReportPropertyChanging("Url")
            Me._Url = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Url")
            Me.OnUrlChanged
        End Set
    End Property
    Private _Url As String
    Partial Private Sub OnUrlChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnUrlChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property DatePublished in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property DatePublished() As Date
        Get
            Return Me._DatePublished
        End Get
        Set
            Me.OnDatePublishedChanging(value)
            Me.ReportPropertyChanging("DatePublished")
            Me._DatePublished = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("DatePublished")
            Me.OnDatePublishedChanged
        End Set
    End Property
    Private _DatePublished As Date
    Partial Private Sub OnDatePublishedChanging(ByVal value As Date)
        End Sub
    Partial Private Sub OnDatePublishedChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Text in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Text() As String
        Get
            Return Me._Text
        End Get
        Set
            Me.OnTextChanging(value)
            Me.ReportPropertyChanging("Text")
            Me._Text = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Text")
            Me.OnTextChanged
        End Set
    End Property
    Private _Text As String
    Partial Private Sub OnTextChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnTextChanged()
        End Sub
End Class
