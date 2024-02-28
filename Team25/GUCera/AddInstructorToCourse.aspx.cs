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
    public partial class AddInstructorToCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddInstructor_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);



                String courseId = CourseId.Text;
                String newInstructorId = NewInstructorID.Text;
                int instructorId = Int16.Parse((Session["user"].ToString()));

                if (courseId == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (newInstructorId == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else
                {

                    SqlCommand AddAnotherInstructorToCourse = new SqlCommand("AddAnotherInstructorToCourse", conn);
                    AddAnotherInstructorToCourse.CommandType = System.Data.CommandType.StoredProcedure;
                    AddAnotherInstructorToCourse.Parameters.Add(new SqlParameter("@cid", courseId));
                    AddAnotherInstructorToCourse.Parameters.Add(new SqlParameter("@adderIns", instructorId));
                    AddAnotherInstructorToCourse.Parameters.Add(new SqlParameter("@insid", newInstructorId));


                    conn.Open();
                    int a = AddAnotherInstructorToCourse.ExecuteNonQuery();
                    conn.Close();

                    if (a > 0)
                    {
                        Response.Write("Instructor Added Successfully.");
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

        protected void NewInstructorID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CourseId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}