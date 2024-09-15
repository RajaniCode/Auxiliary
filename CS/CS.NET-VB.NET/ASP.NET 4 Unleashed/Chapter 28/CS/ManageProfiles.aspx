<%@ Page Language="C#" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

    DateTime inactiveDate = DateTime.Now.AddMonths(-3);
    
    void Page_PreRender()
    {
        lblProfiles.Text = ProfileManager.GetNumberOfProfiles(ProfileAuthenticationOption.All).ToString();
        lblInactiveProfiles.Text = ProfileManager.GetNumberOfInactiveProfiles(ProfileAuthenticationOption.All, inactiveDate).ToString(); 
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int results = ProfileManager.DeleteInactiveProfiles(ProfileAuthenticationOption.All, inactiveDate);
        lblResults.Text = String.Format("{0} Profiles deleted!", results);
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Manage Profiles</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    Total Profiles:
    <asp:Label
        id="lblProfiles"
        Runat="server" />
    <br />
    Inactive Profiles:
    <asp:Label
        id="lblInactiveProfiles"
        Runat="server" />    
    <br /><br />
    
    <asp:Button
        id="btnDelete"
        Text="Delete Inactive Profiles"
        Runat="server" OnClick="btnDelete_Click" />
    <br />
    <asp:Label
        id="lblResults"
        EnableViewState="false"
        Runat="server" />
        
    </div>
    </form>
</body>
</html>
