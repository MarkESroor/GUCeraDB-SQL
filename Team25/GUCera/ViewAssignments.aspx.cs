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
    public partial class ViewAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 

        }

        protected void View_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand InstructorViewAssignmentsStudents = new SqlCommand("InstructorViewAssignmentsStudents", conn);
                InstructorViewAssignmentsStudents.CommandType = System.Data.CommandType.StoredProcedure;

                String courseId = CourseId.Text;
                int instructorId = Int16.Parse((Session["user"].ToString()));

                if (courseId == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else
                {

                    InstructorViewAssignmentsStudents.CommandType = System.Data.CommandType.StoredProcedure;
                    InstructorViewAssignmentsStudents.Parameters.Add(new SqlParameter("@cid", courseId));
                    InstructorViewAssignmentsStudents.Parameters.Add(new SqlParameter("@instrId", instructorId));

                    conn.Open();
                    InstructorViewAssignmentsStudents.ExecuteNonQuery();
                    SqlDataReader rdr = InstructorViewAssignmentsStudents.ExecuteReader(CommandBehavior.CloseConnection);

                    Boolean flag = false;
                    while (rdr.Read())
                    {
                        String grade = "";
                        String sid = rdr.GetInt32(rdr.GetOrdinal("sid")).ToString();
                        try
                        {
                            grade = rdr.GetDecimal(rdr.GetOrdinal("grade")).ToString();
                        }
                        catch (Exception)
                        {
                            grade = "Not yet graded";
                        }
                        
                        String assignNumber = rdr.GetInt32(rdr.GetOrdinal("assignmentNumber")).ToString();
                        String assignType = rdr.GetString(rdr.GetOrdinal("assignmentType")).ToString();
                        String cid = rdr.GetInt32(rdr.GetOrdinal("cid")).ToString();

                        Label info = new Label();
                        info.Text = "Course ID: " + cid + "| Student ID: " + sid + "| Grade: " + grade + "| Assignment Number: " + assignNumber + "| Assignment Type: " + assignType;
                        form1.Controls.Add(info);
                        flag = true;
                    }
                    if (flag == false)
                    {
                        Response.Write("No assignments to show");
                    }

                    conn.Close();
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

    }
}