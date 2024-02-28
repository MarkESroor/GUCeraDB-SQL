<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="GUCera.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Admin&#39;s Home Page:<br />
            <br />
            <asp:Button ID="viewCourses" runat="server" Text="View Courses" OnClick="viewCourses_Click" />
            <br />
            <asp:Button ID="acceptCourses" runat="server" Text="Accept Courses" OnClick="acceptCourses_Click" />
            <br />
            <asp:Button ID="unaccepted" runat="server" Text="View Unaccepted Courses" OnClick="unaccepted_Click" />
            <br />
            <br />
            <asp:Button ID="createPromos" runat="server" Text="Create Promocodes" OnClick="createPromos_Click" />
            <br />
            <asp:Button ID="issuePromos" runat="server" Text="Issue Promocodes" OnClick="issuePromos_Click" />
            <br />
        </div>
    </form>
</body>
</html>
