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
    public partial class AddCourseDescriptionAndContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddContentAndDescription_Click(object sender, EventArgs e)
        {


           try
           {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                String courseId = CourseId.Text;
                String description = CourseDescription.Text;
                int instructorId = Int16.Parse((Session["user"].ToString()));
                String content = CourseContent.Text;
                Boolean cont = false;
                Boolean desc = false;
                conn.Open();
                if (courseId == "")
                    Response.Write("<script>alert('Please Enter the Course ID!')</script>");
               // else if (description == "")
                   // Response.Write("<script>alert('Please Enter the Missing data!')</script>");
               // else if (content == "")
                   // Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else
                {
                    if (content != "")
                    {
                        SqlCommand UpdateCourseContent = new SqlCommand("UpdateCourseContent", conn);
                        UpdateCourseContent.CommandType = System.Data.CommandType.StoredProcedure;
                        UpdateCourseContent.Parameters.Add(new SqlParameter("@content", content));
                        UpdateCourseContent.Parameters.Add(new SqlParameter("@courseId", courseId));
                        UpdateCourseContent.Parameters.Add(new SqlParameter("@instrId", instructorId));

                        int a = UpdateCourseContent.ExecuteNonQuery();

                       

                        if (a > 0)
                        {
                            Response.Write("Course Content Added Successfully. ");
                            cont = true;
                        }
                    }
                    if (description != "")
                    {
                        SqlCommand UpdateCourseDescription = new SqlCommand("UpdateCourseDescription", conn);
                        UpdateCourseDescription.CommandType = System.Data.CommandType.StoredProcedure;
                        UpdateCourseDescription.Parameters.Add(new SqlParameter("@courseDescription", description));
                        UpdateCourseDescription.Parameters.Add(new SqlParameter("@courseId", courseId));
                        UpdateCourseDescription.Parameters.Add(new SqlParameter("@instrId", instructorId));

                        int b = UpdateCourseDescription.ExecuteNonQuery();
                      
                        if (b > 0)
                        {
                            Response.Write("Course Description Added Successfully.");
                            desc = true;
                        }
                    }

                    
                   

                  

                    conn.Close();
                    if (cont==false && desc == false)
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

        protected void CourseContent_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CourseDescription_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CourseId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}