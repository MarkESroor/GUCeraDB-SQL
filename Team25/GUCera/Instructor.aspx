<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instructor.aspx.cs" Inherits="GUCera.Instructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Instructor</div>
        <p>
            <asp:Button ID="Addnumber" runat="server" OnClick="Addnumber_Click" Text="Add your mobile number" />
        </p>
        <p>
            <asp:Button ID="AddCourse" runat="server" OnClick="AddCourse_Click" Text="Add Course" />
        </p>
        <p>
            <asp:Button ID="AddCourseDescriptionAndContent" runat="server" OnClick="AddCourseDescriptionAndContent_Click" Text="Add Course Description and Content" />
        </p>
        <p>
            <asp:Button ID="AddInstructor" runat="server" OnClick="AddInstructor_Click" Text="Add Another Instructor to Course" />
        </p>
        <p>
            <asp:Button ID="DefineAssignments" runat="server" OnClick="DefineAssignments_Click" Text="Define Assignments" />
        </p>
        <p>
            <asp:Button ID="IssueCertificate" runat="server" OnClick="IssueCertificate_Click" Text="Issue Certificate" />
        </p>
        <p>
            <asp:Button ID="ViewAssignments" runat="server" OnClick="ViewAssignments_Click" Text="View Assignments" />
        </p>
        <p>
            <asp:Button ID="GradeAssignments" runat="server" OnClick="GradeAssignments_Click" Text="Grade Assignments" />
        </p>
        <p>
            <asp:Button ID="ViewFeedback" runat="server" OnClick="ViewFeedback_Click" Text="View Feedback" />
        </p>
    </form>
</body>
</html>
