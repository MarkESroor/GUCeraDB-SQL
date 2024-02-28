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
    public partial class AddCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Add_Click(object sender, EventArgs e)
        {

            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                String name = Name.Text;
                String price = Price.Text;
                int instructorId = Int16.Parse((Session["user"].ToString()));
                String creditHours = CreditHours.Text;

                if (name == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (price == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (creditHours == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else
                {

                    SqlCommand InstAddCourse = new SqlCommand("InstAddCourse", conn);
                    InstAddCourse.CommandType = System.Data.CommandType.StoredProcedure;
                    InstAddCourse.Parameters.Add(new SqlParameter("@creditHours", creditHours));
                    InstAddCourse.Parameters.Add(new SqlParameter("@name", name));
                    InstAddCourse.Parameters.Add(new SqlParameter("@price", price));
                    InstAddCourse.Parameters.Add(new SqlParameter("@instructorId", instructorId));


                    conn.Open();
                    int a = InstAddCourse.ExecuteNonQuery();
                    conn.Close();

                    if (a > 0)
                    {
                        Response.Write("Course Added Successfully.");
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
            

            protected void Name_TextChanged(object sender, EventArgs e)
            {

            }

            protected void CreditHours_TextChanged(object sender, EventArgs e)
            {

            }

            protected void InstructorId_TextChanged(object sender, EventArgs e)
            {

            }

            protected void Price_TextChanged(object sender, EventArgs e)
            {

            }
        
    }
}