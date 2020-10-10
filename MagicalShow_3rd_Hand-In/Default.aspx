<%@ Page Language="C#" Inherits="MagicalShow_3rd_HandIn.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
    <link rel="stylesheet" media="screen" href="template.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
    		<asp:Button id="button1" class="fltLft wdth49P" runat="server" Text="Create new Staff member!" OnClick="button1Clicked" />
            <asp:Button id="button2" class="fltRght wdth49P" runat="server" Text="Create new Magician!" OnClick="buttonNewMagician" /><br/><br/>
           
            <asp:TextBox ID="TextBoxName" placeholder="Username" runat="server"></asp:TextBox><br/>
            <asp:TextBox ID="TextBoxPassword" TextMode="Password" placeholder="Password" runat="server"></asp:TextBox><br/>
            <asp:Button id="button3" runat="server" Text="Login" OnClick="buttonLoginClicked" />
            <asp:Label id="LoginMsg" runat="server"></asp:Label>
        </div>
	</form>
</body>
</html>
