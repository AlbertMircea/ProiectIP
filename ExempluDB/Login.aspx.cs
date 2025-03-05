using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace ExempluDB
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            
            GridAfisare.Visible = false;
        }

       
        protected void Login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (!username.Contains("@"))
            {
                username = username + "@gmail.com";
            }
            string password = txtPassword.Text;

            Session["Username"] = username;
            Response.Redirect("SuccessPage.aspx");
        
           
}

       

    }
}
