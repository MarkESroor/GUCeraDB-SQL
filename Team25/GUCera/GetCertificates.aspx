<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetCertificates.aspx.cs" Inherits="GUCera.GetCertificates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 156px;
        }
        .auto-style3 {
            position: absolute;
            top: 41px;
            left: 10px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 78px;
            left: 8px;
            z-index: 1;
            width: 100px;
        }
        .auto-style5 {
            width: 836px;
            height: 213px;
            position: absolute;
            top: 138px;
            left: 10px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            Course ID:<br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style4" Text="Get Certificate" OnClick="Button1_Click" />
            <asp:Panel ID="Panel1" runat="server" CssClass="auto-style5">
            </asp:Panel>
        </div>
    </form>
</body>
</html>
