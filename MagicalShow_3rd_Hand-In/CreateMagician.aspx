<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateMagician.aspx.cs" Inherits="MagicalShow_3rd_HandIn.CreateMagician" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Magician</title>
    <link rel="stylesheet" media="screen" href="template.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
            <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxMagic" runat="server"></asp:TextBox>
            <asp:Label ID="LabelMagic" runat="server" Text="Favorite Trick"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add Magician" />
        </div>
    </form>
</body>
</html>
