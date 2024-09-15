<%@ Page Language="C#" ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<script runat="server">

    protected void grdDirectories_SelectedIndexChanged(object sender, EventArgs e)
    {
        ltlPath.Text = grdDirectories.SelectedValue.ToString();
    }

    protected void valDirectory_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (VirtualPathUtility.IsAppRelative(args.Value))
            args.IsValid = true;
        else
            args.IsValid = false;
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <style type="text/css">
        html
        {
            background-color:silver;
            font:14px Georgia,Serif;
        }
        a
        {
            color:blue;
        }
        .columnTitle
        {
            font-weight:bold;
            color:white;
            padding:3px;
        }
        .column
        {
            width:350px;
            float:left;
            border:solid 1px black;
            padding:5px;
            background-color:blue;
        }

        .columnContent
        {
            padding:5px;
            width:auto;
            background-color:white;
        }
        .grid td
        {
            border-left:Solid 1px black;
            padding:5px;
        }
    </style>
    <title>Admin</title>
</head>
<body>
    <form id="form1" runat="server">
    
   
    <div class="column">
    <div class="columnTitle">
        Virtual Directories
    </div>
    <div class="columnContent">
    
    <asp:GridView
        id="grdDirectories"
        DataSourceId="srcDirectories"
        DataKeyNames="AppPath"
        AutoGenerateColumns="false"
        GridLines="None"
        ShowHeader="false"
        AutoGenerateSelectButton="true"
        AutoGenerateDeleteButton="true"
        OnSelectedIndexChanged="grdDirectories_SelectedIndexChanged"
        CssClass="grid"
        Runat="server">
        <Columns>
        <asp:BoundField
            DataField="AppPath" />
        </Columns>
    </asp:GridView>   
    <br />
    <asp:FormView
        id="frmDirectory"
        DataSourceID="srcDirectories"
        DefaultMode="Insert"
        Runat="server">
        <InsertItemTemplate>
        <fieldset>
        <legend>New Directory</legend>
        <asp:TextBox
            id="txtDirectory"
            Text='<%# Bind("VirtualPath") %>'
            Columns="40"
            Runat="server" />
        <asp:Button
            id="btnAddDirectory"
            Text="Add"
            CommandName="Insert"
            Runat="server" />
        <br />    
        <asp:CustomValidator
            id="valDirectory"
            ControlToValidate="txtDirectory"
            ErrorMessage="Invalid Directory"
            Display="Static"
            OnServerValidate="valDirectory_ServerValidate"
            Runat="server" />    
        </fieldset> 
        </InsertItemTemplate>
    </asp:FormView>    
    </div>
    </div>
    
    <div class="column">
    <div class="columnTitle">
    <asp:Literal
        id="ltlPath"
        Text="~/"
        Runat="server" />
    </div>    
    <div class="columnContent">
    <asp:GridView
        id="grdFiles"
        DataSourceID="srcFiles"
        GridLines="None"
        AutoGenerateColumns="false"
        AutoGenerateDeleteButton="true"
        CssClass="grid"
        Runat="server">
        <Columns>
        <asp:HyperLinkField
            DataTextField="Name"
            DataNavigateUrlFields="VirtualPath" 
            Target="_blank" />
        </Columns>
    </asp:GridView>    
    <br />
    <asp:FormView
        id="frmFile"
        DataSourceID="srcFiles"
        DefaultMode="Insert"
        Runat="server">
        <InsertItemTemplate>
        <fieldset>
        <legend>New File</legend>
        <asp:Label
            id="lblFileName"
            Text="File Name:"
            AssociatedControlID="txtFileName"
            Runat="server" />
        <br />    
        <asp:TextBox
            id="txtFileName"
            Text='<%# Bind("Name") %>'
            Columns="40"
            Runat="server" />
        <br /><br />    
        <asp:Label
            id="lblFileContent"
            Text="File Content:"
            AssociatedControlID="txtFileContent"
            Runat="server" />
        <br />    
        <asp:TextBox
            id="txtFileContent"
            Text='<%# Bind("Content") %>'
            Columns="35"
            Rows="10"
            TextMode="MultiLine"
            Runat="server" />
        <br /><br />    
        <asp:Button
            id="btnAddFile"
            Text="Add"
            CommandName="Insert"
            Runat="server" />
        </fieldset> 
        </InsertItemTemplate>
    </asp:FormView>    
    
    </div>
    </div>
    
       
    <asp:ObjectDataSource
        id="srcDirectories"
        TypeName="AspNetUnleashed.VirtualFiles"
        SelectMethod="DirectorySelect"
        InsertMethod="DirectoryInsert"
        Runat="server" />

    <asp:ObjectDataSource
        id="srcFiles"
        TypeName="AspNetUnleashed.VirtualFiles"
        SelectMethod="DirectorySelectFiles"
        InsertMethod="FileInsert"
        Runat="server">
        <SelectParameters>
        <asp:ControlParameter
            Name="VirtualPath"
            DefaultValue="~/"
            ControlID="grdDirectories" />
        </SelectParameters>
        <InsertParameters>
        <asp:ControlParameter
            Name="VirtualPath"
            DefaultValue="~/"
            ControlID="grdDirectories" />
        </InsertParameters>
    </asp:ObjectDataSource>    

    
    </form>
</body>
</html>
