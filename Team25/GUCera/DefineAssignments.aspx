<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefineAssignments.aspx.cs" Inherits="GUCera.DefineAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div>
            Assignments<div>
            <br />
                Course Id: </div>
        <p>
            <asp:TextBox ID="CourseId" runat="server" OnTextChanged="CourseId_TextChanged"></asp:TextBox>
        </p>
        <div>
            Number:
        </div>
        <p>
            <asp:TextBox ID="Number" runat="server" OnTextChanged="Number_TextChanged"></asp:TextBox>
        </p>
        <div>
            Type:
        </div>
        <p>
            <asp:TextBox ID="Type" runat="server" OnTextChanged="Type_TextChanged" MaxLength="10"></asp:TextBox>
        </p>
            <div>
                Full Grade: </div>
        <p>
            <asp:TextBox ID="FullGrade" runat="server" OnTextChanged="FullGrade_TextChanged"></asp:TextBox>
        </p>
            <div>
                Weight: </div>
        <p>
            <asp:TextBox ID="Weight" runat="server" OnTextChanged="Weight_TextChanged" MaxLength="5"></asp:TextBox>
        </p>
            <div>
                Deadline:<br />
&nbsp;<asp:Label ID="Label" runat="server" Text=""></asp:Label>
            </div>
        <p>
            <asp:Calendar ID="Calendar" runat="server" OnSelectionChanged="Calendar_SelectionChanged"></asp:Calendar>
        </p>
            <div>
                Content: </div>
        <p>
            <asp:TextBox ID="Content" runat="server" OnTextChanged="Content_TextChanged" MaxLength="200"></asp:TextBox>
        </p>
        </div>
        <p>
            <asp:Button ID="AddAssignment" runat="server" OnClick="AddAssignment_Click" Text="Add Assignment" style="height: 26px" />
        </p>
        </div>
    </form>
</body>
</html>
