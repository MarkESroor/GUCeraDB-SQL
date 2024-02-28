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
    public partial class ViewPromos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int Id = Int16.Parse((Session["user"].ToString()));
            
            SqlCommand viewPromocode = new SqlCommand("viewPromocode", conn);
            viewPromocode.CommandType = System.Data.CommandType.StoredProcedure;
            viewPromocode.Parameters.Add(new SqlParameter("@sid", Id));
            bool flag = false;
            conn.Open();
            SqlDataReader rdr = viewPromocode.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                flag = true;
                String code = rdr.GetString(rdr.GetOrdinal("code"));
                Label Code = new Label();
                Code.Text = "Code: " + code + " | ";
                form1.Controls.Add(Code);
                
                String IssueDate = rdr.GetDateTime(rdr.GetOrdinal("issueDate")).ToString();
                Label issueDate = new Label();
                issueDate.Text = "Issue Date: " + IssueDate + " | ";
                form1.Controls.Add(issueDate);

                String ExpiryDate = rdr.GetDateTime(rdr.GetOrdinal("expiryDate")).ToString();
                Label expiryDate = new Label();
                expiryDate.Text = "Expiry Date: " + ExpiryDate + " | ";
                form1.Controls.Add(expiryDate);

                String Discount = rdr.GetDecimal(rdr.GetOrdinal("discountAmount")).ToString();
                Label discount = new Label();
                discount.Text = "Discount Amount: " + Discount + " | ";
                form1.Controls.Add(discount);
                
                String adminID = rdr.GetInt32(rdr.GetOrdinal("adminId")).ToString();
                Label AdminId = new Label();
                AdminId.Text = "Issued By: " +adminID + "<br />";
                form1.Controls.Add(AdminId);
            }

            if (!flag)
            {
                String failed = "You do not have any promo codes!";
                Label Failed = new Label();
                Failed.Text = failed + "<br />";
                form1.Controls.Add(Failed);
            }
        }
    }
}