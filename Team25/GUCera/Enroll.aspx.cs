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
    public partial class Enroll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enrol_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if (courseID.Text == "" || instID.Text == "")
                Response.Write("<script>alert('Please Enter the Missing data!')</script>");
            else
            {
                try
                {
                    int CourseID = Int16.Parse(courseID.Text);
                    int InstID = Int16.Parse(instID.Text);

                    int Id = Int16.Parse((Session["user"].ToString()));
                    //int Id = 1;


                    SqlCommand enrollInCourse = new SqlCommand("enrollInCourse", conn);
                    enrollInCourse.CommandType = System.Data.CommandType.StoredProcedure;

                    enrollInCourse.Parameters.Add(new SqlParameter("@sid", Id));
                    enrollInCourse.Parameters.Add(new SqlParameter("@cid", CourseID));
                    enrollInCourse.Parameters.Add(new SqlParameter("@instr", InstID));

                    SqlParameter message = enrollInCourse.Parameters.Add("@message", System.Data.SqlDbType.VarChar, 50);

                    message.Direction = System.Data.ParameterDirection.Output;


                    conn.Open();
                    enrollInCourse.ExecuteNonQuery();
                    conn.Close();

                    Response.Write(message.Value.ToString());
                }
                catch (Exception)
                {
                    Response.Write("Please Enter Valid Data!");
                }


            }
        }

    }
}
