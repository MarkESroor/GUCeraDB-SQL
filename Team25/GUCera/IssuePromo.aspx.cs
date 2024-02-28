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
    public partial class IssuePromo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StudentID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void PromoCode_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Issue_Click(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String Code = PromoCode.Text;
            String Student_ID = StudentID.Text;

            if (Code == "" || Student_ID == "")
                Response.Write("<script>alert('Please Enter the Missing data!')</script>");

            else
            {
                try
                {
                    SqlCommand Promocode = new SqlCommand("AdminIssuePromocodeToStudent", conn);
                    Promocode.CommandType = System.Data.CommandType.StoredProcedure;
                    Promocode.Parameters.Add(new SqlParameter("@pid", Code));
                    Promocode.Parameters.Add(new SqlParameter("@sid", Student_ID));



                    conn.Open();
                    Promocode.ExecuteNonQuery();
                    conn.Close();

                    Response.Write("Promocode Issued!");
                }
                catch (Exception)
                {
                    Response.Write("Invalid Input");
                }
            }
        }
    }
}