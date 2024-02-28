using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Instructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Addnumber_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddingPhones.aspx");
        }

        protected void AddCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCourse.aspx");
        }

        protected void DefineAssignments_Click(object sender, EventArgs e)
        {
            Response.Redirect("DefineAssignments.aspx");
        }

        protected void ViewAssignments_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAssignments.aspx");
        }

        protected void GradeAssignments_Click(object sender, EventArgs e)
        {
            Response.Redirect("GradeAssignments.aspx");
        }

        protected void ViewFeedback_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewFeedback.aspx");
        }


        protected void IssueCertificate_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssueCertificate.aspx");
        }

        protected void AddCourseDescriptionAndContent_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCourseDescriptionAndContent.aspx");
        }

        protected void AddInstructor_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddInstructorToCourse.aspx");
        }
    }
}