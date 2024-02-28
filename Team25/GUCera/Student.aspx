<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="GUCera.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            Student<br />
            <br />
            My Profile:<br />
            <asp:Button ID="viewMyProfile" runat="server" Text="View My Profile" OnClick="viewMyProfile_Click" Width="213px" />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add your mobile number" Width="212px" />
            <br />
            <asp:Button ID="addcredit" runat="server" Text="Add credit card" OnClick="addcredit_Click" Width="212px" />
            <br />
            <asp:Button ID="promo" runat="server" Text="View my Promo Codes" OnClick="promo_Click" Width="212px" />
            <br />


            <asp:Button ID="Certificates" runat="server" 
                
              
                Text="List My Certificates" OnClick="Certificates_Click" Width="212px" />
          

            <br />
            <br />
          

            <br />
            Courses:<br />
            <asp:Button ID="viewCourses" runat="server" Text="View and Enrol in Courses" OnClick="viewCourses_Click1" Width="225px" />
            <br />


            <asp:Button ID="SubmitAssignment" runat="server" 
                
                

                Text="Submit Assignment" OnClick="SubmitAssignment_Click" Width="224px" />
          

            <br />

            <asp:Button ID="AssignContent" runat="server"  OnClick="AssignContent_Click" Text="View Assignment's Content" Width="225px" />


            <br />
          

            <asp:Button ID="AssigGrade" runat="server" 
              
                Text="View Assignment's Grade" OnClick="AssigGrade_Click" Width="224px" />
          

            <br />


            <asp:Button ID="Feedback" runat="server" 
                
               
                Text="Add Course Feedback" OnClick="Feedback_Click" Width="224px" />
          

            <br />


        </div>
       
    </form>
</body>
</html>
