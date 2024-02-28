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
    public partial class MyProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int Id = Int16.Parse((Session["user"].ToString()));
           // int Id = 8;
            SqlCommand viewMyProfile = new SqlCommand("viewMyProfile", conn);
            viewMyProfile.CommandType = System.Data.CommandType.StoredProcedure;
            viewMyProfile.Parameters.Add(new SqlParameter("@id", Id));


            conn.Open();
            SqlDataReader rdr = viewMyProfile.ExecuteReader(CommandBehavior.CloseConnection);
           
                while (rdr.Read())
                {

                    String GPA = rdr.GetDecimal(rdr.GetOrdinal("gpa")).ToString();
                    String FN = rdr.GetString(rdr.GetOrdinal("firstName"));
                    String LN = rdr.GetString(rdr.GetOrdinal("lastName"));
                    String Pass = rdr.GetString(rdr.GetOrdinal("password"));
                    String Gender = rdr.GetBoolean(rdr.GetOrdinal("gender")).ToString();

                    String Email = rdr.GetString(rdr.GetOrdinal("email"));
                    String Address = rdr.GetString(rdr.GetOrdinal("address"));

                    id.Text = Id.ToString();
                    gpa.Text = GPA.ToString();
                    fn.Text = FN.ToString();
                    ln.Text = LN.ToString();
                    pass.Text = Pass.ToString();
                    if (Gender.ToString() == "True")
                        gender.Text = "Female";
                    else
                        gender.Text = "Male";
                    email.Text = Email.ToString();
                    address.Text = Address.ToString();
                }

                conn.Close();
            
           
        }
    }
}