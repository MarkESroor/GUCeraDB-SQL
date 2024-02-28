<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcceptCources.aspx.cs" Inherits="GUCera.AcceptCources" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Course ID:<br />
            <asp:TextBox ID="CourseID" runat="server" OnTextChanged="CourseID_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Accept" runat="server" OnClick="Button1_Click" Text="Accept" Width="69px" />
            <br />
        </div>
    </form>
</body>
</html>
