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
    public partial class Admincourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand AdminViewAllCourses = new SqlCommand("AdminViewAllCourses", conn);
            AdminViewAllCourses.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = AdminViewAllCourses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = "Course Name: " + courseName + " | ";
                form1.Controls.Add(name);

                String creditHours = rdr.GetInt32(rdr.GetOrdinal("creditHours")).ToString();
                Label CreditHours = new Label();
                CreditHours.Text = "Credit Hours: " +  creditHours + " | ";
                form1.Controls.Add(CreditHours);

                String price = rdr.GetDecimal(rdr.GetOrdinal("price")).ToString();
                Label Price = new Label();
                Price.Text = "Price: " +  price + " | ";
                form1.Controls.Add(Price);
                try
                {
                    String content = rdr.GetString(rdr.GetOrdinal("content"));
                Label Content = new Label();
                Content.Text = "Content: " + content + " | ";
                form1.Controls.Add(Content);

                }
                catch (Exception)
                {
                    String content = "Not Defined";
                    Label Content = new Label();
                    Content.Text = "Content: " + content + " | ";
                    form1.Controls.Add(Content);
                }

                try
                {
                    String accepted = rdr.GetBoolean(rdr.GetOrdinal("accepted")).ToString();
                    Label Accepted = new Label();
                    Accepted.Text = "Acceptance: " + accepted + "<br />";
                    form1.Controls.Add(Accepted);
                }
                catch (Exception)
                {
                    String accepted = "False";
                    Label Accepted = new Label();
                    Accepted.Text = "Acceptance: " + accepted + "<br />";
                    form1.Controls.Add(Accepted);
                }


                }

        
        }
    }
}