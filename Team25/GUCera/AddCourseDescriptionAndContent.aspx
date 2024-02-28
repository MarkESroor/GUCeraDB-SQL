<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCourseDescriptionAndContent.aspx.cs" Inherits="GUCera.AddCourseDescriptionAndContent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div>
            Adding Course Description and Content:<div>
            <br />
                Course ID:
        </div>
        <p>
            <asp:TextBox ID="CourseId" runat="server" OnTextChanged="CourseId_TextChanged" style="direction: ltr"></asp:TextBox>
        </p>
        <div>
            Course Description:
        </div>
        <p>
            <asp:TextBox ID="CourseDescription" runat="server" OnTextChanged="CourseDescription_TextChanged" MaxLength="200"></asp:TextBox>
        </p>
            <div>
                Course Content: </div>
        <p>
            <asp:TextBox ID="CourseContent" runat="server" OnTextChanged="CourseContent_TextChanged" MaxLength="200"></asp:TextBox>
        </p>
        </div>
        <p>
            <asp:Button ID="AddContentAndDescription" runat="server" OnClick="AddContentAndDescription_Click" Text="Add Course Description and Content" style="height: 26px" />
        </p>
        </div>
    </form>
</body>
</html>
