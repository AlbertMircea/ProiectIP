using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace ExempluDB
{
    public partial class InsertData : System.Web.UI.Page
    {

        ConectareDB u = new ConectareDB();
        MySqlConnection sql;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected List<string> ValidateInputs()
        {
            List<string> errorMessages = new List<string>();

            // Validate CNP
            if (txtCNP.Text.Length != 13)
            {
                errorMessages.Add("CNP should have exactly 13 characters.");
            }

            // Validate PhoneNumber
            if (txtPhoneNumber.Text.Length != 10)
            {
                errorMessages.Add("Phone number should have exactly 10 digits.");
            }

            // Validate Email
            if (!txtEmail.Text.Contains("@") || !(txtEmail.Text.EndsWith(".com") || txtEmail.Text.EndsWith(".ro")))
            {
                errorMessages.Add("Invalid email!");
            }

            return errorMessages;
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            string cnp = txtCNP.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmail.Text;
            string job = txtJob.Text;
            string company = txtCompany.Text;
            string floor = txtFloor.Text;
            string rFID = txtRFID.Text;
            string room = txtRoom.Text;
            string county = txtCounty.Text;
            string city = txtCity.Text;
            string street = txtStreet.Text;
            string number = txtNumber.Text;


            // Perform validation
            List<string> errorMessages = ValidateInputs();

            if (errorMessages.Count == 0)
            {
                lblErrorMessage.Text = "";
                u.conectare();
                sql = u.getConnection();

                using (var conn = sql)
                {
                    conn.Open();
                    var transaction = conn.BeginTransaction();

                    try
                    {
                        // Insert into Pacient table
                        var pacientComm = conn.CreateCommand();
                        pacientComm.CommandText = @"INSERT INTO Pacient (CNP, Firstname, Lastname, PhoneNumber, Email, Job, Company) 
                                        VALUES (@CNP, @Firstname, @Lastname, @PhoneNumber, @Email, @Job, @Company)";
                        pacientComm.Parameters.AddWithValue("@CNP", cnp);
                        pacientComm.Parameters.AddWithValue("@Firstname", firstName);
                        pacientComm.Parameters.AddWithValue("@Lastname", lastName);
                        pacientComm.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        pacientComm.Parameters.AddWithValue("@Email", email);
                        pacientComm.Parameters.AddWithValue("@Job", job);
                        pacientComm.Parameters.AddWithValue("@Company", company);

                        Debug.WriteLine("pacient");

                        pacientComm.ExecuteNonQuery();
                        Debug.WriteLine("pacient");

                        // Insert into Bed table
                        var bedComm = conn.CreateCommand();
                        bedComm.CommandText = @"INSERT INTO Bed (Floor, Room, RFID, PacientCNP) 
                                    VALUES (@Floor, @Room, @RFID, @PacientCNP)";
                        bedComm.Parameters.AddWithValue("@Floor", floor);
                        bedComm.Parameters.AddWithValue("@Room", room);
                        bedComm.Parameters.AddWithValue("@RFID", rFID);
                        bedComm.Parameters.AddWithValue("@PacientCNP", cnp);


                        Debug.WriteLine("bed");
                        bedComm.ExecuteNonQuery();
                        Debug.WriteLine("bed");

                        // Insert into Address table
                        var addressComm = conn.CreateCommand();
                        addressComm.CommandText = @"INSERT INTO Address (County, City, Street, Number, PacientCNP) 
                                         VALUES (@County, @City, @Street, @Number, @PacientCNP)";
                        addressComm.Parameters.AddWithValue("@County", county);
                        addressComm.Parameters.AddWithValue("@City", city);
                        addressComm.Parameters.AddWithValue("@Street", street);
                        addressComm.Parameters.AddWithValue("@Number", number);
                        addressComm.Parameters.AddWithValue("@PacientCNP", cnp);


                        Debug.WriteLine("Address");
                        addressComm.ExecuteNonQuery();
                        Debug.WriteLine("Address");


                        // Get the last inserted BedId
                        var bedIdComm = conn.CreateCommand();
                        bedIdComm.CommandText = "SELECT LAST_INSERT_ID()";
                        int bedId = Convert.ToInt32(bedIdComm.ExecuteScalar());

                        // Get the last inserted AddressId
                        var addressIdComm = conn.CreateCommand();
                        addressIdComm.CommandText = "SELECT LAST_INSERT_ID()";
                        int addressId = Convert.ToInt32(addressIdComm.ExecuteScalar());

                        // Update the Pacient table with the AddressId and BedId
                        var updateComm = conn.CreateCommand();
                        updateComm.CommandText = @"UPDATE Pacient SET AddressId = @AddressId, BedId = @BedId WHERE CNP = @CNP";
                        updateComm.Parameters.AddWithValue("@AddressId", addressId);
                        updateComm.Parameters.AddWithValue("@BedId", bedId);
                        updateComm.Parameters.AddWithValue("@CNP", cnp);

                        Debug.WriteLine("gata");
                        updateComm.ExecuteNonQuery();
                        Debug.WriteLine("gata");

                        transaction.Commit();
                        Debug.WriteLine("gata");

                        // Redirect to success page
                        Response.Redirect("SuccessPage.aspx");
                    }
                    catch (Exception ex)
                    {
                        // transaction.Rollback();
                        // Handle the exception
                        Debug.WriteLine("Error adding data to tables: " + ex.Message);
                    }
                }
            }
            else
            {
                // Display error messages on the web page
                lblErrorMessage.Text = string.Join("<br>", errorMessages);
            }
            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuccessPage.aspx");
        }



        




    }
}

            