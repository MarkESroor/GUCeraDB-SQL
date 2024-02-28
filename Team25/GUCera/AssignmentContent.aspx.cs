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
    public partial class AssignmentContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetContent_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = Int16.Parse((Session["user"].ToString()));
            bool flag = false;

            if (TextBox1.Text != " ")
            {
                try
                {
                    int CourseID = Int16.Parse(TextBox1.Text);

                    SqlCommand viewAssign = new SqlCommand("viewAssign", conn);
                    viewAssign.CommandType = System.Data.CommandType.StoredProcedure;
                    viewAssign.Parameters.Add(new SqlParameter("@courseId", CourseID));
                    viewAssign.Parameters.Add(new SqlParameter("@Sid", id));


                    SqlCommand checkenroll = new SqlCommand("Select 1 from StudentTakeCourse Where cid=@cid AND sid=@sid", conn);
                    checkenroll.Parameters.Add(new SqlParameter("@cid", CourseID));
                    checkenroll.Parameters.Add(new SqlParameter("@sid", id));
                    conn.Open();
                    viewAssign.ExecuteNonQuery();

                    var check = checkenroll.ExecuteScalar();
                    if (check == null)
                    {
                        Response.Write("<script>alert('You Are Not Enrolled In This Course!')</script>");
                        flag = true;
                    }


                    else
                    {
                        SqlDataReader rdr = viewAssign.ExecuteReader(CommandBehavior.CloseConnection);
                        while (rdr.Read())
                        {
                            flag = true;
                            int cid = rdr.GetInt32(rdr.GetOrdinal("cid"));
                            Label cID = new Label();
                            cID.Text = "CourseID: " + cid + " | ";
                            Panel1.Controls.Add(cID);

                            int number = rdr.GetInt32(rdr.GetOrdinal("number"));
                            Label Number = new Label();
                            Number.Text = "Course Number: " + number + " | ";
                            Panel1.Controls.Add(Number);

                            String type = rdr.GetString(rdr.GetOrdinal("type"));
                            Label Type = new Label();
                            Type.Text = "Type: " + type + " | ";
                            Panel1.Controls.Add(Type);

                            int fullgrade = rdr.GetInt32(rdr.GetOrdinal("fullGrade"));
                            Label fullGrade = new Label();
                            fullGrade.Text = "Full Grade: " + fullgrade + " | ";
                            Panel1.Controls.Add(fullGrade);

                            decimal weight = rdr.GetDecimal(rdr.GetOrdinal("weight"));
                            Label Weight = new Label();
                            Weight.Text = "Weight: " + weight + " | ";
                            Panel1.Controls.Add(Weight);

                            DateTime deadline = rdr.GetDateTime(rdr.GetOrdinal("deadline"));
                            Label Deadline = new Label();
                            Deadline.Text = "Deadline: " + deadline + " | ";
                            Panel1.Controls.Add(Deadline);

                            String content = rdr.GetString(rdr.GetOrdinal("content"));
                            Label Content = new Label();
                            Content.Text = "Content: " + content + "<br />";
                            Panel1.Controls.Add(Content);


                        }
                    }
                   

                }
                catch (System.FormatException)
                {
                    Response.Write("<script>alert('Please Enter a Valid Course ID')</script>");
                    flag = true;
                }
                if (flag == false)
                    Response.Write("<script>alert('No assignments to be shown in this course')</script>");

            }
            else
                Response.Write("<script>alert('Please Enter a Course ID')</script>");


            conn.Close();




        }
    }
}