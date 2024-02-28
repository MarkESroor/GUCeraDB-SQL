using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class AcceptCources : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void CourseID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {

                int course_id = Int16.Parse(CourseID.Text);
                int admin_id = Int16.Parse((Session["user"].ToString()));

                SqlCommand Cources = new SqlCommand("AdminAcceptRejectCourse", conn);
                Cources.CommandType = System.Data.CommandType.StoredProcedure;
                Cources.Parameters.Add(new SqlParameter("@courseId", course_id));
                Cources.Parameters.Add(new SqlParameter("@adminid", admin_id));
                conn.Open();
                int a =Cources.ExecuteNonQuery();
                conn.Close();

                if (a > 0)
                    Response.Write("Course Accepted!");
                else
                    Response.Write("Invalid input");
            }
            catch (Exception)
            {
                Response.Write("Please Enter a Valid Course ID");
            }
        }
    }
}