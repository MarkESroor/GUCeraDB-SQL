using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class ViewFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewFeedback_Click(object sender, EventArgs e)
        {
            try { 
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand ViewFeedbacksAddedByStudentsOnMyCourse = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
            ViewFeedbacksAddedByStudentsOnMyCourse.CommandType = System.Data.CommandType.StoredProcedure;

            String courseId = CourseId.Text;
            int instructorId = Int16.Parse((Session["user"].ToString()));



                if (courseId == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");

                else
                {
                    ViewFeedbacksAddedByStudentsOnMyCourse.CommandType = System.Data.CommandType.StoredProcedure;
                    ViewFeedbacksAddedByStudentsOnMyCourse.Parameters.Add(new SqlParameter("@cid", courseId));
                    ViewFeedbacksAddedByStudentsOnMyCourse.Parameters.Add(new SqlParameter("@instrId", instructorId));

                    conn.Open();
                    ViewFeedbacksAddedByStudentsOnMyCourse.ExecuteNonQuery();
                    SqlDataReader rdr = ViewFeedbacksAddedByStudentsOnMyCourse.ExecuteReader(CommandBehavior.CloseConnection);

                    Boolean flag = false;
                    while (rdr.Read())
                    {

                        String Number = rdr.GetInt32(rdr.GetOrdinal("number")).ToString();
                        String Comments = rdr.GetString(rdr.GetOrdinal("comment")).ToString();
                        String NumberOfLikes = rdr.GetInt32(rdr.GetOrdinal("numberOfLikes")).ToString();

                        Label info = new Label();
                        info.Text = "Number: " + Number + "| Comments: " + Comments + "| Number of likes: " + NumberOfLikes;
                        form1.Controls.Add(info);
                        flag = true;
                    }
                    if (flag == false)
                    {
                        Response.Write("No Feedback to show");
                    }

                    conn.Close();
                }
            }
            catch (Exception)
            {
                Response.Write("Invalid Input!");
            }
        }
            

   

        protected void InstructorId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CourseId_TextChanged(object sender, EventArgs e)
        {

        }

    }
}