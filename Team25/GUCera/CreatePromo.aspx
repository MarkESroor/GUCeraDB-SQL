<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePromo.aspx.cs" Inherits="GUCera.CreatePromo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Code:<br />
            <asp:TextBox ID="code" runat="server" OnTextChanged="code_TextChanged" MaxLength="6"></asp:TextBox>
            <br />
            Issue Date:<br />
            <asp:TextBox ID="Issue_date" runat="server" OnTextChanged="Issue_date_TextChanged"></asp:TextBox>
            <br />
            Expiry Date:<br />
            <asp:TextBox ID="Expiry_date" runat="server" OnTextChanged="Expiry_date_TextChanged"></asp:TextBox>
            <br />
            Discount:<br />
            <asp:TextBox ID="discount" runat="server" OnTextChanged="discount_TextChanged" MaxLength="4"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Create" runat="server" Text="Create" OnClick="Create_Click" />
            <br />
        </div>
    </form>
</body>
</html>
