<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAssignments.aspx.cs" Inherits="GUCera.ViewAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Submitted Assignments</p>
        <p>
            Course Id:</p>
            <asp:TextBox ID="CourseId" runat="server" OnTextChanged="CourseId_TextChanged"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="View" runat="server" OnClick="View_Click" Text="View Assignments" />
        </p>
    </form>
</body>
</html>
