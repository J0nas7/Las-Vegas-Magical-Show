<%@ Page Language="C#" Inherits="MagicalShow_3rd_HandIn.Overview" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Default</title>
    <link rel="stylesheet" media="screen" href="template.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
            <asp:Button id="button1" class="fltLft wdth49P" runat="server" Text="See your profile" OnClick="button1Clicked" />
            <asp:Button id="button2" class="fltRght wdth49P" runat="server" Text="Log out" OnClick="logOut" />
            <asp:ListBox id="ListBoxOverview" runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>
