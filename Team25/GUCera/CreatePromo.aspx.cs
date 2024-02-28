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
    public partial class CreatePromo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Create_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String Code = code.Text;
            String issue = Issue_date.Text;
            String expiry = Expiry_date.Text;
            String dis = discount.Text;
            
            int adminid = Int16.Parse((Session["user"].ToString()));

            if (Code == "" || issue == "" || expiry == "" ||  dis == "")
                Response.Write("<script>alert('Please Enter the Missing data!')</script>");

            else
            {
                try
                {
                    DateTime iDate = DateTime.Parse(issue);
                    DateTime eDate = DateTime.Parse(expiry);
                    SqlCommand Promocode = new SqlCommand("AdminCreatePromocode", conn);
                    Promocode.CommandType = System.Data.CommandType.StoredProcedure;
                    Promocode.Parameters.Add(new SqlParameter("@code", Code));
                    Promocode.Parameters.Add(new SqlParameter("@isuueDate", iDate));
                    Promocode.Parameters.Add(new SqlParameter("@expiryDate", eDate));
                    Promocode.Parameters.Add(new SqlParameter("@discount", dis));
                    Promocode.Parameters.Add(new SqlParameter("@adminId", adminid));


                    conn.Open();
                    Promocode.ExecuteNonQuery();
                    conn.Close();

                    Response.Write("Promocode Created");
                }

                catch (Exception)
                {
                    Response.Write("Please Enter Valid Data!");
                }
            }
        }

        protected void admin_id_TextChanged(object sender, EventArgs e)
        {

        }

        protected void discount_TextChanged(object sender, EventArgs e)
        {

        }

        protected void code_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Expiry_date_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Issue_date_TextChanged(object sender, EventArgs e)
        {

        }
    }


}