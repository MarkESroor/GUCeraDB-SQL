<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCourse.aspx.cs" Inherits="GUCera.AddCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Adding Courses<div>
            <br />
                Name:
        </div>
        <p>
            <asp:TextBox ID="Name" runat="server" OnTextChanged="Name_TextChanged" MaxLength="50"></asp:TextBox>
        </p>
        <div>
            Credit Hours:
        </div>
        <p>
            <asp:TextBox ID="CreditHours" runat="server" OnTextChanged="CreditHours_TextChanged"></asp:TextBox>
        </p>
            <div>
                Price: </div>
        <p>
            <asp:TextBox ID="Price" runat="server" OnTextChanged="Price_TextChanged" MaxLength="12"></asp:TextBox>
        </p>
            <div>
        </div>
        </div>
        <p>
            <asp:Button ID="Add" runat="server" OnClick="Add_Click" Text="Add Course" style="height: 26px" />
        </p>
    </form>
</body>
</html>
