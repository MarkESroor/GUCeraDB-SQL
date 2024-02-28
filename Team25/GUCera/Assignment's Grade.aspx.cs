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
    public partial class Assignment_s_Grade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = Int16.Parse((Session["user"].ToString()));



           try
            {
                Label4.Text = "";
                int CourseID = Int16.Parse(TextBox1.Text);
                String AssignmentType = TextBox2.Text;
                Char test = AssignmentType[0];
                int AssignmentNumber = Int16.Parse(TextBox3.Text);
                SqlCommand viewAssignGrades = new SqlCommand("viewAssignGrades", conn);
                viewAssignGrades.CommandType = System.Data.CommandType.StoredProcedure;
                viewAssignGrades.Parameters.Add(new SqlParameter("@assignType", AssignmentType));
                viewAssignGrades.Parameters.Add(new SqlParameter("@assignnumber", AssignmentNumber));
                viewAssignGrades.Parameters.Add(new SqlParameter("@cid", CourseID));
                viewAssignGrades.Parameters.Add(new SqlParameter("@sid", id));
                SqlParameter Grade= viewAssignGrades.Parameters.Add("@assignGrade", System.Data.SqlDbType.Int);
                Grade.Direction = System.Data.ParameterDirection.Output;
                SqlCommand checkenroll = new SqlCommand("Select 1 from StudentTakeCourse Where cid=@cid AND sid=@sid", conn);
                checkenroll.Parameters.Add(new SqlParameter("@cid", CourseID));
                checkenroll.Parameters.Add(new SqlParameter("@sid", id));
                conn.Open();
                viewAssignGrades.ExecuteNonQuery();

                var check = checkenroll.ExecuteScalar();
                if (check == null)
                    Response.Write("<script>alert('You Are Not Enrolled In This Course!')</script>");


                else
                {
                    SqlCommand checkAssig = new SqlCommand("Select 1 from Assignment Where cid=@cid AND number=@assignnumber AND type=@assignType", conn);
                    checkAssig.Parameters.Add(new SqlParameter("@cid", CourseID));
                    checkAssig.Parameters.Add(new SqlParameter("@assignnumber", AssignmentNumber));
                    checkAssig.Parameters.Add(new SqlParameter("@assignType", AssignmentType));

                    var check2=checkAssig.ExecuteScalar();
                    if (check2 == null)
                    {
                        Response.Write("<script>alert('That Assignment Does Not Exist!')</script>");
                    }
                    else
                    {


                        if (Grade.Value.ToString() == "")
                        {
                            Response.Write("<script>alert('Grade Not Entered Yet!')</script>");
                        }
                        else
                        {
                            Label4.Text = "Your Grade is: " + Grade.Value.ToString();
                        }
                    }
                }                //check if course not taken or Assignment doesn't exist grade not entered yet




                


            }

              catch (Exception)
              {
                 Response.Write("<script>alert('Please Enter Valid inputs')</script>");
              }
            conn.Close();


        }

        private string SqlParameter(string v, int id)
        {
            throw new NotImplementedException();
        }
    }
}