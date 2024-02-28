using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class ViewUnAcceptedCources : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand courses = new SqlCommand("AdminViewNonAcceptedCourses", conn);
                courses.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
                bool flag = false;
                while (rdr.Read())
                {
                    flag = true;
                    string courseName = rdr.GetString(rdr.GetOrdinal("name"));
                    Label name = new Label();
                    name.Text = courseName + "<br />";
                    form1.Controls.Add(name);
                }

                if (!flag)
                    Response.Write("No Unaccepted Courses!");
            }
        }
    }
}