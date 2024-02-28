using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewCourses_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admincourses.aspx");
        }

        protected void acceptCourses_Click(object sender, EventArgs e)
        {
            Response.Redirect("AcceptCources.aspx");
        }

        protected void unaccepted_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUnAcceptedCources.aspx");
        }

        protected void createPromos_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreatePromo.aspx");
        }

        protected void issuePromos_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssuePromo.aspx");
        }
    }
}