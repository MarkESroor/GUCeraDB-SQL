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
    public partial class SubmitAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = Int16.Parse((Session["user"].ToString()));
            //int id = 4;
      

           
                try
                {
                int CourseID = Int16.Parse(TextBox1.Text);
                String AssignmentType = TextBox2.Text;
                Char test = AssignmentType[0];
                int AssignmentNumber = Int16.Parse(TextBox3.Text);
                SqlCommand submitAssign = new SqlCommand("submitAssign", conn);
                submitAssign.CommandType = System.Data.CommandType.StoredProcedure;
                submitAssign.Parameters.Add(new SqlParameter("@assignType", AssignmentType));
                submitAssign.Parameters.Add(new SqlParameter("@assignnumber", AssignmentNumber));
                submitAssign.Parameters.Add(new SqlParameter("@cid", CourseID));
                submitAssign.Parameters.Add(new SqlParameter("@sid", id));


                //add part for checking if student enrolled in course or not
                SqlCommand checkenroll = new SqlCommand("Select 1 from StudentTakeCourse Where cid=@cid AND sid=@sid", conn);
                checkenroll.Parameters.Add(new SqlParameter("@cid", CourseID));
                checkenroll.Parameters.Add(new SqlParameter("@sid", id));
                conn.Open();

                var check = checkenroll.ExecuteScalar();
                if (check == null)
                    Response.Write("<script>alert('You Are Not Enrolled In This Course!')</script>");

                else
                {
                    SqlCommand checkAssig = new SqlCommand("Select 1 from Assignment Where cid=@cid AND number=@assignnumber AND type=@assignType", conn);
                    checkAssig.Parameters.Add(new SqlParameter("@cid", CourseID));
                    checkAssig.Parameters.Add(new SqlParameter("@assignnumber", AssignmentNumber));
                    checkAssig.Parameters.Add(new SqlParameter("@assignType", AssignmentType));

                    var check2 = checkAssig.ExecuteScalar();
                    if (check2 == null)
                    {
                        Response.Write("<script>alert('That Assignment Does Not Exist!')</script>");
                    }
                    else
                    {


                        try
                        {
                            submitAssign.ExecuteNonQuery();
                            Response.Write("<script>alert('Assignment Submitted Successfully')</script>");

                        }
                        catch (Exception)
                        {
                            Response.Write("<script>alert('Assignment Had Been Submitted Before')</script>");
                        }
                    }
                }

            }

                catch (Exception) {
                    Response.Write("<script>alert('Invalid Input')</script>");
                }
            conn.Close();





        }

      
    }
}