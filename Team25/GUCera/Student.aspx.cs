using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddingPhones.aspx");
        }

        protected void viewMyProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyProfile.aspx");
        }

        protected void viewCourses_Click1(object sender, EventArgs e)
        {
            Response.Redirect("courses.aspx");
        }

        protected void addcredit_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCredit.aspx");
        }

        

        protected void promo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPromos.aspx");
        }
        protected void AssignContent_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("AssignmentContent.aspx");
        }

        protected void SubmitAssignment_Click(object sender, EventArgs e)

        {
         
            Response.Redirect("SubmitAssignment.aspx");
        }

        protected void AssigGrade_Click(object sender, EventArgs e)
        {
         

            Response.Redirect("Assignment's Grade.aspx");
        }

        protected void Feedback_Click(object sender, EventArgs e)
        {
          

            Response.Redirect("AddCourseFeedback.aspx");
        }

        protected void Certificates_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("GetCertificates.aspx");
        }

    }
}