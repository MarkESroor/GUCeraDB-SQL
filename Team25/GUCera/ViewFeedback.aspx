<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewFeedback.aspx.cs" Inherits="GUCera.ViewFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            Feedback
            <br />
                Course ID:
        <p>
            <asp:TextBox ID="CourseId" runat="server" OnTextChanged="CourseId_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="View" runat="server" OnClick="ViewFeedback_Click" Text="View Feedback" style="height: 26px" />
        </p>
    </form>
</body>
</html>
