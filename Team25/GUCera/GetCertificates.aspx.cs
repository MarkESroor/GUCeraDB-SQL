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
    public partial class GetCertificates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = Int16.Parse((Session["user"].ToString()));
          
            bool flag = false;


            try
          {
                int CourseID = Int16.Parse(TextBox1.Text);
                SqlCommand viewCertificate = new SqlCommand("viewCertificate", conn);
                viewCertificate.CommandType = System.Data.CommandType.StoredProcedure;
                viewCertificate.Parameters.Add(new SqlParameter("@cid", CourseID));
                viewCertificate.Parameters.Add(new SqlParameter("@sid", id));

                SqlCommand checkenroll = new SqlCommand("Select 1 from StudentTakeCourse Where cid=@cid AND sid=@sid", conn);
                checkenroll.Parameters.Add(new SqlParameter("@cid", CourseID));
                checkenroll.Parameters.Add(new SqlParameter("@sid", id));
                conn.Open();
                viewCertificate.ExecuteNonQuery();

                var check = checkenroll.ExecuteScalar();
                if (check == null)
                {
                    flag = true;
                    Response.Write("<script>alert('You Are Not Enrolled In This Course!')</script>");
                }
                else
                {
                 


                    SqlDataReader rdr = viewCertificate.ExecuteReader(CommandBehavior.CloseConnection);
                    while (rdr.Read())
                    {
                        flag = true;
                        int cid = rdr.GetInt32(rdr.GetOrdinal("cid"));
                        Label cID = new Label();
                        cID.Text = "CourseID: " + cid + " | ";
                        Panel1.Controls.Add(cID);


                        int sid = rdr.GetInt32(rdr.GetOrdinal("cid"));
                        Label sID = new Label();
                        sID.Text = "StudentID" + sid + "|";
                        Panel1.Controls.Add(sID);


                        DateTime issuedate = rdr.GetDateTime(rdr.GetOrdinal("issueDate"));
                        Label issueDate = new Label();
                        issueDate.Text = "IssueDate" + issuedate;
                        Panel1.Controls.Add(issueDate);


                    }
                }
            
             }

           

          catch (Exception)
           {
               flag = true;
              Response.Write("<script>alert('Invalid Input')</script>");

           }
            if (flag == false)
                Response.Write("<script>alert('Sorry, Course Not Completed Yet!')</script>");

            conn.Close();


            




        }
    }
}