<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssuePromo.aspx.cs" Inherits="GUCera.IssuePromo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PromoCode:<br />
            <asp:TextBox ID="PromoCode" runat="server" OnTextChanged="PromoCode_TextChanged"></asp:TextBox>
            <br />
            Student ID:<br />
            <asp:TextBox ID="StudentID" runat="server" OnTextChanged="StudentID_TextChanged"></asp:TextBox>
            <br />
            <asp:Button ID="Issue" runat="server" Text="Issue" OnClick="Issue_Click" />
        </div>
    </form>
</body>
</html>
