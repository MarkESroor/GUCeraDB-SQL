<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCredit.aspx.cs" Inherits="GUCera.AddCredit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter your credit card details:<br />
            <br />
            <br />
            Card Number:<br />
            <asp:TextBox ID="number" runat="server" MaxLength="15"></asp:TextBox>
            <br />
            Card Holder Name:<br />
            <asp:TextBox ID="name" runat="server" MaxLength="16"></asp:TextBox>
            <br />
            Expiry Date:
            <br />
            <asp:Label ID="expdate" runat="server"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged1" ></asp:Calendar>
            &nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            CVV:<br />
            <asp:TextBox ID="cvv" runat="server" MaxLength="3"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="register" runat="server" Text="Register" OnClick="register_Click" />
        </div>
    </form>
</body>
</html>
