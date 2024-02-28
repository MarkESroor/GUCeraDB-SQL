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
    public partial class GradeAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddGrade_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                int instructorId = Int16.Parse((Session["user"].ToString()));
                String studentId = StudentId.Text;
                String courseId = CourseId.Text;
                String assignmentNumber = AssignmentNumber.Text;
                String assignmentType = AssignmentType.Text;
                String grade = Grade.Text;

                if (studentId == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (courseId == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (assignmentNumber == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (assignmentType == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (grade == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");


                else
                {

                    SqlCommand InstructorgradeAssignmentOfAStudent = new SqlCommand("InstructorgradeAssignmentOfAStudent ", conn);
                    InstructorgradeAssignmentOfAStudent.CommandType = System.Data.CommandType.StoredProcedure;
                    InstructorgradeAssignmentOfAStudent.Parameters.Add(new SqlParameter("@instrId", instructorId));
                    InstructorgradeAssignmentOfAStudent.Parameters.Add(new SqlParameter("@sid", studentId));
                    InstructorgradeAssignmentOfAStudent.Parameters.Add(new SqlParameter("@cid", courseId));
                    InstructorgradeAssignmentOfAStudent.Parameters.Add(new SqlParameter("@assignmentNumber", assignmentNumber));
                    InstructorgradeAssignmentOfAStudent.Parameters.Add(new SqlParameter("@type", assignmentType));
                    InstructorgradeAssignmentOfAStudent.Parameters.Add(new SqlParameter("@grade", grade));


                    conn.Open();
                    int a = InstructorgradeAssignmentOfAStudent.ExecuteNonQuery();
                    conn.Close();

                    if (a > 0)
                    {
                        Response.Write("Grade Added Successfully.");
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

        protected void InstructorId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void StudentId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CourseId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void AssignmentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        protected void AssignmentType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Grade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}