﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPCS2010ViewState.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:Label ID="Label1" runat="server" Text="Enter Integer: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Text="0"></asp:TextBox>        
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Increment" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Pass To Next Page" onclick="Button2_Click" />  
    </div>
    </form>
</body>
</html>
