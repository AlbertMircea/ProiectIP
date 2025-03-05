using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace ExempluDB
{
    public partial class EditPage : Page
    {
        ConectareDB u = new ConectareDB();
        MySqlConnection sql;

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                string cnp = Request.QueryString["cnp"];
                string firstname = Request.QueryString["firstname"];
                string lastname = Request.QueryString["lastname"];
                string phoneNumber = Request.QueryString["phoneNumber"];
                string email = Request.QueryString["email"];
                string job = Request.QueryString["job"];
                string company = Request.QueryString["company"];
                string floor = Request.QueryString["floor"];
                string room = Request.QueryString["room"];
                string rfid = Request.QueryString["rfid"];
                string county = Request.QueryString["county"];
                string city = Request.QueryString["city"];
                string street = Request.QueryString["street"];
                string number = Request.QueryString["number"];
                string username = Request.QueryString["username"];

                txtCNP.Text = cnp;
                txtCNP.Enabled = false;

                txtFirstnamePacient.Text = firstname;
                txtFirstnamePacient.Enabled = false;

                txtLastnamePacient.Text = lastname;
                txtLastnamePacient.Enabled = false;
                txtMail.Text = username; 
                txtMail.Enabled = false;
                txtFloor.Text = floor;
                txtFloor.Enabled = false;

                txtRoom.Text = room;
                txtRoom.Enabled = false;

                txtRFID.Text = rfid;
                txtRFID.Enabled = false;


            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            u.conectare();
            sql = u.getConnection();

            using (var conn = sql)
            {
                conn.Open();
                var transaction = conn.BeginTransaction();

                try
                {
                    // Insert into Pacient table
                    var comm = conn.CreateCommand();
                    comm.CommandText = @"INSERT INTO TransportHistory (Drug, Mail, FirstnamePacient, LastnamePacient, Floor, Room, RFID, started, finished, error, RobotId) 
                                        VALUES (@Drug, @Mail, @FirstnamePacient, @LastnamePacient, @Floor, @Room, @RFID, @started, @finished, @error, @RobotId)";
                    comm.Parameters.AddWithValue("@Drug", txtDrug.Text);
                    comm.Parameters.AddWithValue("@Mail", txtMail.Text);
                    comm.Parameters.AddWithValue("@FirstnamePacient", txtFirstnamePacient.Text);
                    comm.Parameters.AddWithValue("@LastnamePacient", txtLastnamePacient.Text);
                    comm.Parameters.AddWithValue("@Floor", txtFloor.Text);
                    comm.Parameters.AddWithValue("@Room", txtRoom.Text);
                    comm.Parameters.AddWithValue("@RFID", txtRFID.Text);
                    comm.Parameters.AddWithValue("@started", 0);
                    comm.Parameters.AddWithValue("@finished", 0);
                    comm.Parameters.AddWithValue("@error", 0);
                    comm.Parameters.AddWithValue("@RobotId", txtRobotId.Text);

                    comm.ExecuteNonQuery();

                    transaction.Commit();

                    // Redirect to success page
                    Response.Redirect("SuccessPage.aspx");
                }
                catch (Exception ex)
                {
                    // transaction.Rollback();
                    // Handle the exception
                    Debug.Write("Error adding data to tables: " + ex.Message);
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuccessPage.aspx");
        }

     
    }
}
