<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssueCertificate.aspx.cs" Inherits="GUCera.IssueCertificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            Issue Certificate<div>
                <br />
                Course ID:
        </div>
        <p>
            <asp:TextBox ID="CourseId" runat="server" OnTextChanged="CourseId_TextChanged"></asp:TextBox>
        </p>
        <div>
            Student ID:
        </div>
        <p>
            <asp:TextBox ID="StudentId" runat="server" OnTextChanged="StudentId_TextChanged"></asp:TextBox>
        </p>
            <div>
                Issue Date:<br />
&nbsp;<asp:Label ID="Label" runat="server" Text=""></asp:Label>
            </div>
        <p>
            <asp:Calendar ID="Calendar" runat="server" OnSelectionChanged="Calendar_SelectionChanged"></asp:Calendar>
        </p>
        </div>
        <p>
            <asp:Button ID="Issue" runat="server" OnClick="Issue_Click" Text="Issue Certificate" style="height: 26px" />
        </p>
    </form>
</body>
</html>
