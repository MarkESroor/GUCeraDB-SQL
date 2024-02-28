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
    public partial class IssueCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Issue_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                String courseId = CourseId.Text;
                String studentId = StudentId.Text;
                String issueDate = Label.Text;
                int Id = Int16.Parse((Session["user"].ToString()));

                if (courseId == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (studentId == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (issueDate == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");

                else
                {

                    SqlCommand InstructorIssueCertificateToStudent = new SqlCommand("InstructorIssueCertificateToStudent", conn);
                    InstructorIssueCertificateToStudent.CommandType = System.Data.CommandType.StoredProcedure;
                    InstructorIssueCertificateToStudent.Parameters.Add(new SqlParameter("@cid", courseId));
                    InstructorIssueCertificateToStudent.Parameters.Add(new SqlParameter("@sid", studentId));
                    InstructorIssueCertificateToStudent.Parameters.Add(new SqlParameter("@insId", Id));
                    InstructorIssueCertificateToStudent.Parameters.Add(new SqlParameter("@issueDate", issueDate));

                    conn.Open();
                    int a = InstructorIssueCertificateToStudent.ExecuteNonQuery();
                    conn.Close();

                    if (a > 0)
                    {
                        Response.Write("Certificate Issued Successfully.");
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

 
        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            Label.Text = Calendar.SelectedDate.ToString();
        }

        protected void StudentId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CourseId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}