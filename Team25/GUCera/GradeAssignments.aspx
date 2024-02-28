<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GradeAssignments.aspx.cs" Inherits="GUCera.GradeAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            Grade Assignments
            <p>
            Student ID:</p>
        <p>
            <asp:TextBox ID="StudentId" runat="server" OnTextChanged="StudentId_TextChanged"></asp:TextBox>
        </p>
        <p>
            Course ID:</p>
        <p>
            <asp:TextBox ID="CourseId" runat="server" OnTextChanged="CourseId_TextChanged"></asp:TextBox>
        </p>
        <p>
            Assignment Number:</p>
        <p>
            <asp:TextBox ID="AssignmentNumber" runat="server" OnTextChanged="AssignmentNumber_TextChanged"></asp:TextBox>
        </p>
        <p>
            Assignment Type:</p>
        <p>
            <asp:TextBox ID="AssignmentType" runat="server" OnTextChanged="AssignmentType_TextChanged"></asp:TextBox>
        </p>
        <p>
            Grade:</p>
        <p>
            <asp:TextBox ID="Grade" runat="server" OnTextChanged="Grade_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="AddGrade" runat="server" OnClick="AddGrade_Click" Text="Add Grade" />
        </p>
            </div>
        </form>
</body>
</html>
