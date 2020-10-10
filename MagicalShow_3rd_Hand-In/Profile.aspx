<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="MagicalShow_3rd_HandIn.Profile" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Profile</title>
    <link rel="stylesheet" media="screen" href="template.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
            <asp:Button id="button1" class="fltLft wdth49P" runat="server" Text="Go back" OnClick="backButton" />
            <asp:Button id="button2" class="fltRght wdth49P" runat="server" Text="Edit your profile" OnClick="editProfile" />
                
            <asp:Label ID="LabelName" runat="server" Text="Name:"></asp:Label>
            <asp:Label ID="TheName" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelPassword" runat="server" Text="Password:"></asp:Label>
            <asp:Label ID="ThePassword" runat="server" Text="********"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelSpecific" runat="server" Text=":"></asp:Label><br/>
            <asp:ListBox id="ListBoxSpecific" runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>
