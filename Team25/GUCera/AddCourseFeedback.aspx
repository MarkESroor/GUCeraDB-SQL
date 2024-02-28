<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCourseFeedback.aspx.cs" Inherits="GUCera.AddCourseFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 274px;
        }
        .auto-style2 {
            position: absolute;
            top: 95px;
            left: 10px;
            z-index: 1;
            width: 324px;
            height: 45px;
        }
        .auto-style3 {
            position: absolute;
            top: 37px;
            left: 10px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 68px;
            left: 11px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 163px;
            left: 12px;
            z-index: 1;
            right: 783px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Course ID:<asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2" MaxLength="100"></asp:TextBox>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Feedback:"></asp:Label>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style5" Text="Submit" OnClick="Button1_Click" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
