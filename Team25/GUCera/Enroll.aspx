<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Enroll.aspx.cs" Inherits="GUCera.Enroll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enrol in:<br />
            <br />
            Course ID:<br />
            <asp:TextBox ID="courseID" runat="server"></asp:TextBox>
            <br />
            Instructor ID:<br />
            <asp:TextBox ID="instID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="enrol" runat="server" Text="Enrol" OnClick="enrol_Click" />
        </div>
    </form>
</body>
</html>
