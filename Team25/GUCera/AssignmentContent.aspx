<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssignmentContent.aspx.cs" Inherits="GUCera.AssignmentContent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 113px">
    <form id="form1" runat="server">
        Enter course ID<p>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 9px; top: 41px; position: absolute; height: 16px"></asp:TextBox>
        </p>
        <asp:Button ID="GetContent" runat="server" style="z-index: 1; left: 8px; top: 78px; position: absolute" Text="Get Content" OnClick="GetContent_Click" />

        <asp:Panel ID="Panel1" runat="server" 
            style="z-index: 1; left: 10px; top: 110px; position: absolute; height: 19px; width: 836px">
        </asp:Panel>

    </form>

     
</body>
</html>
