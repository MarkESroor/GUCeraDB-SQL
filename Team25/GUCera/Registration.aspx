<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="GUCera.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Registration:<br />
            <br />
            First Name:<br />
            <asp:TextBox ID="firstName" runat="server" MaxLength="20"></asp:TextBox>
            <br />
            Last Name:<br />
            <asp:TextBox ID="lastName" runat="server" MaxLength="20"></asp:TextBox>
            <br />
            <br />
            Password:<br />
            <asp:TextBox ID="password" runat="server" MaxLength="20"></asp:TextBox>
            <br />
            Gender:<br />
            <br />
            <asp:RadioButton ID="Male" runat="server" Text="Male" GroupName="Gender" OnCheckedChanged="Male_CheckedChanged" />
            <asp:RadioButton ID="Female" runat="server" Text="Female" GroupName="Gender" OnCheckedChanged="Female_CheckedChanged" />
            &nbsp;<br />
            <br />
            Email:<br />
            <asp:TextBox ID="email" runat="server" MaxLength="10"></asp:TextBox>
            <br />
            Address:<br />
            <asp:TextBox ID="address" runat="server" MaxLength="10"></asp:TextBox>
            <br />
            <br />
            Register as:<br />
            <br />
            <asp:RadioButton ID="student" runat="server" OnCheckedChanged="student_CheckedChanged" Text="Student" GroupName="Type"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="instructor" runat="server" Text="Instructor" OnCheckedChanged="instructor_CheckedChanged" GroupName="Type" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register!" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            <asp:Label ID="selectedGender" runat="server" Text="Label" Visible="False"></asp:Label>
            <asp:Label ID="selectedType" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Go To Login Page" OnClick="Button2_Click" />
            <br />
        </div>
    </form>
</body>
</html>
