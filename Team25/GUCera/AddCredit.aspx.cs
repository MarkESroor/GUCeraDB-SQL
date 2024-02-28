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
    
    public partial class AddCredit : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
       
        protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {

            expdate.Text = Calendar1.SelectedDate.ToString();
           

        }


        protected void register_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                String Number = number.Text;
                Int32.Parse(Number);
                String Name = name.Text;
                String Cvv = cvv.Text;
                Int32.Parse(Cvv);
                String Date = expdate.Text;
                int Id = Int16.Parse((Session["user"].ToString()));
                //int Id = 8;

                if (Number == "" || Name == "" || Cvv == "")
                    Response.Write("<script>alert('Please Enter the Missing data!')</script>");
                else if (Date == "")
                    Response.Write("<script>alert('Missing Date')</script>");
                else if (Number.Length > 15)
                    Response.Write("<script>alert('The Card Number is too long')</script>");
                else if (Name.Length > 16)
                    Response.Write("<script>alert('The Name is too long')</script>");
                else if (Cvv.Length > 3)
                    Response.Write("<script>alert('The CVV is too long')</script>");
                else
                {
                    SqlCommand addCreditCard = new SqlCommand("addCreditCard", conn);
                    addCreditCard.CommandType = System.Data.CommandType.StoredProcedure;

                    addCreditCard.Parameters.Add(new SqlParameter("@sid", Id));
                    addCreditCard.Parameters.Add(new SqlParameter("@number", Number));
                    addCreditCard.Parameters.Add(new SqlParameter("@cardHolderName", Name));
                    addCreditCard.Parameters.Add(new SqlParameter("@expiryDate", Date));
                    addCreditCard.Parameters.Add(new SqlParameter("@cvv", Cvv));

                    conn.Open();
                    addCreditCard.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("<script>alert('Credit Card Added!')</script>");
                }
            }
            catch (Exception)
            {
                Response.Write("Invalid Input!");
            }
            
        }

        
    }
}