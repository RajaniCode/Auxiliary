﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Projection Operator Demo</title>
		<link href="StyleSheet.css" rel="stylesheet" type="text/css" />
		<style type="text/css">
		.itemContent
		{
			height: 305px;
			width: 450px;
		}
		</style>
</head>
<body>
	<form id="Form" runat="server">
		<div id="header">
			<h1>
				ASP.NET 4.0 Black Book
			</h1>
		</div>
		<div id="sidebar">
			<div id="nav">
				&nbsp;
			</div>
		</div>
		<div id="content">
			<div class ="itemContent">
				<asp:ListBox ID="ListBox1" runat="server" Font-Bold="True" Font-
 				Italic="True" 
				Height="131px" style="margin-left: 119px; margin-top: 41px" 
 				Width="251px">
				</asp:ListBox>
				<br />
				<br />
				<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
				style="margin-left: 122px" Text="Display" Width="107px" />
			</div>
			<div id="footer">
				<p class="left">
				All content copyright &copy; Kogent Solutions Inc.</p>
			</div>
		</div>
	</div>
	</form>
</body>
</html>
