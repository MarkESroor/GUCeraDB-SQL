<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmitAssignment.aspx.cs" Inherits="GUCera.SubmitAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 159px">
            Course ID:<asp:TextBox 
                ID="TextBox1" runat="server" 
                
                
                style="z-index: 1; left: 10px; top: 45px; position: absolute; right: 732px; width: 114px;"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" 
                
                style="z-index: 1; top: 46px; position: absolute; left: 331px; width: 114px;"></asp:TextBox>
                  <asp:TextBox ID="TextBox2" runat="server" 
                
                style="z-index: 1; left: 170px; top: 43px; position: absolute; width: 114px;"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Assignment Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Assignment Number:<asp:Button ID="Submit" runat="server" 
                
                style="z-index: 1; left: 17px; top: 82px; position: absolute; right: 778px;" 
                Text="Submit" OnClick="Submit_Click" />
      
        </div>
    </form>
</body>
</html>
