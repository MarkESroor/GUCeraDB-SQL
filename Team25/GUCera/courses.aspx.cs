using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace GUCera
{
    public partial class courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand("availableCourses", conn);
            courses.CommandType = System.Data.CommandType.StoredProcedure;
            int Id = Int16.Parse((Session["user"].ToString()));
           // int Id = 8;

            conn.Open();
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                String courseID = rdr.GetInt32(rdr.GetOrdinal("id")).ToString();

                SqlCommand MycheckStudentEnrolledInCourse = new SqlCommand("MycheckStudentEnrolledInCourse", conn);
                MycheckStudentEnrolledInCourse.CommandType = System.Data.CommandType.StoredProcedure;
                MycheckStudentEnrolledInCourse.Parameters.Add(new SqlParameter("@sid", Id));
                MycheckStudentEnrolledInCourse.Parameters.Add(new SqlParameter("@cid", courseID));

                SqlParameter returnValue = MycheckStudentEnrolledInCourse.Parameters.Add("@returnValue", System.Data.SqlDbType.Int);
                returnValue.Direction = System.Data.ParameterDirection.Output;

                MycheckStudentEnrolledInCourse.ExecuteNonQuery();

                Console.WriteLine(returnValue);

                if (returnValue.Value.ToString() == "0")
                {
                    Label name = new Label();
                    name.Text = "Course Name: " + courseName + " | Course ID: " + courseID + "<br />" + "    The available instructors for this course are: " + "<br />";
                    SqlCommand courseInstructors = new SqlCommand("courseInstructors", conn);
                    courseInstructors.CommandType = System.Data.CommandType.StoredProcedure;
                    courseInstructors.Parameters.Add(new SqlParameter("@id", courseID));
                    //add read loop
                    SqlDataReader rdr2 = courseInstructors.ExecuteReader(CommandBehavior.CloseConnection);  // configured connection string
                    while (rdr2.Read())
                    {
                        String instructorID = rdr2[0].ToString();
                        String first_name = rdr2[1].ToString();
                        String last_name = rdr2[2].ToString();

                        name.Text += "      Instructor ID: " + instructorID + " | " + "Instructor's First Name: " + first_name + " | " + "Instructor's Last Name: " + last_name + "<br/>";
                    }
                    name.Text += "<br/>";
                    form1.Controls.Add(name);

                }
                
                
            }

           // Response.Write(Session["user"]);
        }

        protected void enrol_Click(object sender, EventArgs e)
        {
            Response.Redirect("Enroll.aspx");
        }
    }
}