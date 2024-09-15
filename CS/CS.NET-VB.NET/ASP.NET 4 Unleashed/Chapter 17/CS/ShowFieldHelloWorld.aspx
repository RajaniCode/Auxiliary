<%@ Page Language="C#" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<script runat="server">

    void Page_Load()
    {
        FieldHelloWorld objFieldHelloWorld = new FieldHelloWorld();
        objFieldHelloWorld.Message = "Good Day!";
        lblMessage.Text = objFieldHelloWorld.SayMessage();
    }
    
</script>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Show Field Hello World</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:Label
        id="lblMessage"
        Runat="server" />
    
    </div>
    </form>
</body>
</html>
