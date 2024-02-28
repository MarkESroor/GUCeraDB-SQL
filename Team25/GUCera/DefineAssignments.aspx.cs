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
    public partial class DefineAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddAssignment_Click(object sender, EventArgs e)
        {
            try { 
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String courseId = CourseId.Text;
            String type = Type.Text;
            String fullGrade = FullGrade.Text;
            String deadline = Label.Text;
            String content = Content.Text;
            String weight = Weight.Text;
            String number = Number.Text;
            int Id = Int16.Parse((Session["user"].ToString()));

                if (courseId == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (type == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (fullGrade == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (deadline == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (content == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (weight == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (number == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else
                {


                    SqlCommand DefineAssignmentOfCourseOfCertianType = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
                    DefineAssignmentOfCourseOfCertianType.CommandType = System.Data.CommandType.StoredProcedure;
                    DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@cid", courseId));
                    DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@number", number));
                    DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@type", type));
                    DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@fullGrade", fullGrade));
                    DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@weight", weight));
                    DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@deadline", deadline));
                    DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@content", content));
                    DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@instId", Id));


                    conn.Open();
                    int a = DefineAssignmentOfCourseOfCertianType.ExecuteNonQuery();
                    conn.Close();
                    if (a>0)
                    {
                        Response.Write("Assignment Added Successfully.");
                    }
                    else
                    {
                        Response.Write("Invalid Input!");
                    }

                  
                }
            }
            catch (Exception)
            {
                Response.Write("Invalid Input!");
            }
        }
        
        protected void CourseId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Number_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Type_TextChanged(object sender, EventArgs e)
        {

        }

        protected void FullGrade_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Weight_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Deadline_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Content_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            Label.Text = Calendar.SelectedDate.ToString();
        }
    }
}