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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (username.Text == "" || password.Text == "")
                Response.Write("<script>alert('Please enter the missing data!')</script>");
            else
            {
                try
                {
                    int id = Int16.Parse(username.Text);
                    String pass = password.Text;
                    SqlCommand loginproc = new SqlCommand("userLogin", conn);
                    loginproc.CommandType = System.Data.CommandType.StoredProcedure;
                    loginproc.Parameters.Add(new SqlParameter("@id", id));
                    loginproc.Parameters.Add(new SqlParameter("@password", pass));
                    SqlParameter success = loginproc.Parameters.Add("@success", System.Data.SqlDbType.Int);
                    SqlParameter type = loginproc.Parameters.Add("@type", System.Data.SqlDbType.Int);
                    success.Direction = System.Data.ParameterDirection.Output;
                    type.Direction = System.Data.ParameterDirection.Output;

                    conn.Open();
                    loginproc.ExecuteNonQuery();
                    conn.Close();
                    // Console.WriteLine("batates");
                    //Response.Write("<script>alert('cool')</script>");
                    //  Response.Write("hello");
                    if (success.Value.ToString() == "1")
                    {
                        //Response.Write("<script>alert('cool')</script>");
                        Session["user"] = id;
                        Response.Write("Welcome!");


                        if (type.Value.ToString() == "0")
                            Response.Redirect("Instructor.aspx");
                        else if (type.Value.ToString() == "1")
                            Response.Redirect("Admin.aspx");
                        else
                            Response.Redirect("Student.aspx");

                    }
                    else
                    {
                        Response.Write("Enter a valid id/password");
                    }
                }
                catch (Exception)
                {
                    Response.Write("Please Enter a Valid ID");
                }
            }
        }
    }
}