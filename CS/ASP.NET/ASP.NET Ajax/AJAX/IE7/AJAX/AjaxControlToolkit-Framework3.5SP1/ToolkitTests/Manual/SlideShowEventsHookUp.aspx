<%@ Page Language="C#" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="Server" type="text/C#">
    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod]
    public static AjaxControlToolkit.Slide[] GetSlides()
    {
        return new AjaxControlToolkit.Slide[] { 
            new AjaxControlToolkit.Slide("../images/Blue hills.jpg", "Blue Hills", "Go Blue"),
            new AjaxControlToolkit.Slide("../images/Sunset.jpg", "Sunset", "Setting sun"),
            new AjaxControlToolkit.Slide("../images/Winter.jpg", "Winter", "Wintery...")};
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SlideShowEventArgs test</title>
</head>
<body>
    <form id="form1" runat="server">
        <ajaxToolkit:ToolkitScriptManager runat="server" ID="scriptManager1">
        </ajaxToolkit:ToolkitScriptManager>
        <div style="text-align: left">
            Test to show how to hook into the SlideChanging event and use the SlideShowEventArgs.
            AutoPlay is set to true and the label should update automatically as the slides
            change.

            <script type="text/javascript">
        Sys.Application.add_load(setupSlideShowHandler);
        
        function setupSlideShowHandler() { 
            var slideShowBehavior = $find('slideShowBehavior');
            slideShowBehavior.add_slideChanging(updateSlideLabel); 
        }
        
        function updateSlideLabel(sender, ev) {
            var slideLabel = $get('slideInfoLabel');
            var nextSlide = ev.get_nextSlide();
            if(nextSlide) {
                slideLabel.innerHTML = 'Photo ' + (ev.get_slideIndex() + 1) + ' ' + nextSlide.Name + ': ' + nextSlide.Description;
            }
        }
            </script>

            <asp:Image runat="server" ID="slideShowImage" Width="150" />
            <asp:Label runat="server" ID="slideInfoLabel"></asp:Label>
            <ajaxToolkit:SlideShowExtender runat="server" ID="slideShowExtender" BehaviorID="slideShowBehavior"
                TargetControlID="slideShowImage" Loop="True" AutoPlay="true" SlideShowServiceMethod="GetSlides">
            </ajaxToolkit:SlideShowExtender>
        </div>
    </form>
</body>
</html>
