using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class AddCourseFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = Int16.Parse((Session["user"].ToString()));






            try
            {
                int CourseID = Int16.Parse(TextBox1.Text);
                String Feedback = TextBox2.Text;
                Char test = Feedback[0];
                SqlCommand addFeedback = new SqlCommand("addFeedback", conn);
                addFeedback.CommandType = System.Data.CommandType.StoredProcedure;
                addFeedback.Parameters.Add(new SqlParameter("@comment", Feedback));
                addFeedback.Parameters.Add(new SqlParameter("@cid", CourseID));
                addFeedback.Parameters.Add(new SqlParameter("@sid", id));

                SqlCommand checkenroll = new SqlCommand("Select 1 from StudentTakeCourse Where cid=@cid AND sid=@sid", conn);
                checkenroll.Parameters.Add(new SqlParameter("@cid", CourseID));
                checkenroll.Parameters.Add(new SqlParameter("@sid", id));
                conn.Open();
                addFeedback.ExecuteNonQuery();

            var check = checkenroll.ExecuteScalar();
                if (check == null)
                    Response.Write("<script>alert('You Are Not Enrolled In This Course!')</script>");


                else
                {

                   
                    Response.Write("<script>alert('Feedback Submitted Successfully!')</script>");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Invalid Input')</script>");
           }
            conn.Close();
        }
    }
}