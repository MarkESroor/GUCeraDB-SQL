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

    public partial class Registration : System.Web.UI.Page
    {
       // int userType = 0;
      //  bool flag = false;
      //  bool Gender = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void student_CheckedChanged(object sender, EventArgs e)
        {
            selectedType.Text = "1";
        }
        protected void instructor_CheckedChanged(object sender, EventArgs e)
        {
            selectedType.Text = "2";
        }

        protected void Male_CheckedChanged(object sender, EventArgs e)
        {
          //  flag = true;
            selectedGender.Text = "False";

        }

        protected void Female_CheckedChanged(object sender, EventArgs e)
        {
           // flag = true;
            selectedGender.Text = "True";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String first_Name = firstName.Text;
            String last_Name = lastName.Text;
            String pass = password.Text;
            String em = email.Text;
            
            String Address = address.Text;

            if (first_Name == "" || first_Name.Length>20)
                Response.Write("Please enter a valid first name!");
            else if (last_Name == "" || last_Name.Length > 20)
                Response.Write("Please enter a valid last name!");
            else if (pass == "" || pass.Length > 20)
                Response.Write("Please enter a valid password!");
            else if ( em == "" || em.Length > 10)
                Response.Write("Please enter a valid email!");
            else if (  Address == "" || Address.Length > 10)
                Response.Write("Please enter a valid address!");
            else if ( selectedType.Text != "1" && selectedType.Text != "2")
                Response.Write("Please select a  user type!");
            else if (selectedGender.Text != "False" && selectedGender.Text != "True")
                Response.Write("Please select a gender!");
            else
            {
                if (selectedType.Text == "1")
                {
                    SqlCommand studentRegister = new SqlCommand("studentRegister", conn);
                    studentRegister.CommandType = System.Data.CommandType.StoredProcedure;
                    studentRegister.Parameters.Add(new SqlParameter("@first_name", first_Name));
                    studentRegister.Parameters.Add(new SqlParameter("@last_name", last_Name));
                    studentRegister.Parameters.Add(new SqlParameter("@password", pass));
                    studentRegister.Parameters.Add(new SqlParameter("@email", em));
                    studentRegister.Parameters.Add(new SqlParameter("@gender", selectedGender.Text));
                    studentRegister.Parameters.Add(new SqlParameter("@address", Address));

                    SqlParameter ID = studentRegister.Parameters.Add("@id", System.Data.SqlDbType.Int);
                    ID.Direction = System.Data.ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        studentRegister.ExecuteNonQuery();
                        conn.Close();
                        Response.Write("Registered! Your id is: " + ID.Value.ToString());

                    }
                    catch(Exception)
                    {
                        Response.Write("Invalid Input");
                    }

                  
                }
                else if (selectedType.Text == "2")
                {
                    SqlCommand instructorRegister = new SqlCommand("instructorRegister", conn);
                    instructorRegister.CommandType = System.Data.CommandType.StoredProcedure;
                    instructorRegister.Parameters.Add(new SqlParameter("@first_name", first_Name));
                    instructorRegister.Parameters.Add(new SqlParameter("@last_name", last_Name));
                    instructorRegister.Parameters.Add(new SqlParameter("@password", pass));
                    instructorRegister.Parameters.Add(new SqlParameter("@email", em));
                    instructorRegister.Parameters.Add(new SqlParameter("@gender", selectedGender.Text));
                    instructorRegister.Parameters.Add(new SqlParameter("@address", Address));

                    SqlParameter ID = instructorRegister.Parameters.Add("@id", System.Data.SqlDbType.Int);
                    ID.Direction = System.Data.ParameterDirection.Output;

                    try
                    {
                        conn.Open();
                         instructorRegister.ExecuteNonQuery();
                    conn.Close();

                    Response.Write("Registered! Your id is: " + ID.Value.ToString());
                    }
                    catch (Exception)
                    {
                        Response.Write("Invalid Input");
                    }

                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}