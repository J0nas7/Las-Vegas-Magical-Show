<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateStaff.aspx.cs" Inherits="MagicalShow_3rd_HandIn.CreateStaff" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Staff Member</title>
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
            <asp:TextBox ID="TextBoxSalary" runat="server"></asp:TextBox>
            <asp:Label ID="LabelSalary" runat="server" Text="Monthly Salary"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add Staff Member" />
        </div>
    </form>
</body>
</html>
