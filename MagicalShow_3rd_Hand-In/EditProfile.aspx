<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="MagicalShow_3rd_HandIn.EditProfile" %>
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
            <asp:Button id="button2" class="fltRght wdth49P" runat="server" Text="Save and go back" OnClick="editProfile" />
                
            <asp:Label ID="LabelName" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server" placeholder="Leave empty to keep current"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelSpecific" runat="server" Text=":"></asp:Label><br/>
            <asp:TextBox ID="TextBoxSpecific" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
