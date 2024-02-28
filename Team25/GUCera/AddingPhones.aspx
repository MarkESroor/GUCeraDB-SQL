<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddingPhones.aspx.cs" Inherits="GUCera.AddingPhones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add your telephone Number<br />
            <br />
            <p>
                Phone Number:</p>
        <p>
            <asp:TextBox ID="phone" runat="server" OnTextChanged="phone_TextChanged" MaxLength="11"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="button1" Text="Add" />
        </p>
        </div>
    </form>
</body>
</html>
