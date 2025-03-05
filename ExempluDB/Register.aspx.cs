using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace ExempluDB
{
    public partial class Register : System.Web.UI.Page
    {
        ConectareDB u = new ConectareDB();
        MySqlConnection sql;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validate if the passwords match
            if (password == confirmPassword)
            {
                // Perform the registration logic here
                u.conectare();
                sql = u.getConnection();

                using (var conn = sql)
                {
                    conn.Open();
                    var comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO exemplu2 (username, password) VALUES (@username, @password)";
                    comm.Parameters.AddWithValue("@username", username);
                    comm.Parameters.AddWithValue("@password", password);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }

                // Redirect to the success page or perform desired action
                //Session["Username"] = username;
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblMessage.Text = "Passwords do not match.";
            }
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            // Redirect back to the previous page (WebForm1.aspx)
            Response.Redirect("Login.aspx");
        }
    }
}
