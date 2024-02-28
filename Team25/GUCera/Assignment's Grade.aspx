<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment's Grade.aspx.cs" Inherits="GUCera.Assignment_s_Grade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 375px;
        }
        .auto-style2 {
            position: absolute;
            top: 15px;
            left: 10px;
        }
        .auto-style3 {
            position: absolute;
            top: 54px;
            left: 7px;
            z-index: 1;
            width: 114px;
        }
        .auto-style4 {
            position: absolute;
            top: 15px;
            left: 196px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 52px;
            left: 192px;
            z-index: 1;
            width: 114px;
        }
        .auto-style6 {
            position: absolute;
            top: 15px;
            left: 370px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 49px;
            left: 370px;
            z-index: 1;
            width: 114px;
        }
        .auto-style8 {
            position: absolute;
            top: 85px;
            left: 10px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 153px;
            left: 10px;
            z-index: 1;
        }
    </style>
</head>
<body style="height: 175px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" CssClass="auto-style2" style="z-index: 1" Text="Course ID:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" CssClass="auto-style4" Text="Assignment Type"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style5"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" CssClass="auto-style6" Text="Assignment Number"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style7"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style8" OnClick="Button1_Click1" Text="View Grade" />
            <asp:Label ID="Label4" runat="server" CssClass="auto-style9" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
