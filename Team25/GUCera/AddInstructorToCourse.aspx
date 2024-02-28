<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddInstructorToCourse.aspx.cs" Inherits="GUCera.AddInstructorToCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            Adding Another Instructor To Course:<div>
            <br />
                Course ID:
        </div>
        <p>
            <asp:TextBox ID="CourseId" runat="server" OnTextChanged="CourseId_TextChanged"></asp:TextBox>
        </p>
            <div>
                New Instructor ID: </div>
        <p>
            <asp:TextBox ID="NewInstructorID" runat="server" OnTextChanged="NewInstructorID_TextChanged"></asp:TextBox>
        </p>
        </div>
        <p>
            <asp:Button ID="AddInstructor" runat="server" OnClick="AddInstructor_Click" Text="Add Instructor" style="height: 26px" />
        </p>
    </form>
</body>
</html>
