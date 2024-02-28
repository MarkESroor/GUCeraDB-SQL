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
    public partial class AddingPhones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void phone_TextChanged(object sender, EventArgs e)
        {

        }

        protected void button1(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = (int)Session["user"];
            try
            {
                String Phone = phone.Text;
                Int32.Parse(Phone);
                if (Phone == "" || Phone.Length > 20)
                    Response.Write("<script>alert('Please enter a valid number!')</script>");
                else
                {
                    SqlCommand addMobile = new SqlCommand("addMobile", conn);
                    addMobile.CommandType = System.Data.CommandType.StoredProcedure;
                    addMobile.Parameters.Add(new SqlParameter("@id", id));
                    addMobile.Parameters.Add(new SqlParameter("@mobile_number", Phone));

                    conn.Open();
                    addMobile.ExecuteNonQuery();
                    conn.Close();

                    Response.Write("Added!");

                    
                }
            }
            catch (Exception)
            {
                Response.Write("Please Enter a Valid Number");
            }
        }
    }
}