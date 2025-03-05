using System;
using System.Diagnostics;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web;

namespace ExempluDB
{
    public partial class SuccessPage : System.Web.UI.Page
    {
        string role = null;

        protected void Page_Init(object sender, EventArgs e)
        {
            // Initialize the pacient object

            // Hide the table and dropdown initially
            tableData.Visible = false;
            ddlPacients.Visible = false;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                string aux;
                string username = null;
                if (Session["Username"] != null)
                {
                    username = Session["Username"].ToString();
                    aux = username;
                    username = username.Replace("@gmail.com", "");
                    if (username.Contains("."))
                    {
                        username = username.Replace(".", " ");
                    }

                    username = username.ToLower();
                    lblUsername.Text = username;

                    if (username == "admin")
                    {
                        role = "Admin";
                    }
                    else if (username == "medic")
                    {
                        role = "Medic";
                    }
                    else if (username == "nurse")
                    {
                        role = "Nurse";
                    }
                    else
                    {
                        Response.Redirect("Login.aspx");
                    }
                    username = aux;

                }
                else
                {
                    Response.Redirect("Login.aspx");
                }



                if (role == "Medic")
                {
                    Button2.Visible = true;
                    Button4.Visible = true;
                }
                else if (role == "Nurse")
                {
                    Button2.Visible = false;
                    Button4.Visible = false;
                }
                //}
                //else
                //{
                // The user does not have a role associated with them
                // Handle this scenario accordingly

                //}

                PopulatePacientDropdown();

            }
        }



        private void DisplayPacientDetails(string pacientId)
        {

            string cnp = "5002131343224";
            string firstname = "Albert";
            string lastname = "Mircea";
            string phoneNumber = "0731766523";
            string email = "albertmircea@rocketmail.com";
            string job = "Ready";
            string company = "Continental";

            string floor = "2";
            string room = "21";
            string rfid = "34343435123";

            string county = "Timis";
            string city = "Timisoara";
            string street = "Gheorghe Ivanescu";
            string number = "53-57";

            HtmlTableRow cnpRow = new HtmlTableRow();
            HtmlTableCell cnpCell = new HtmlTableCell();
            cnpCell.InnerText = "CNP";
            cnpRow.Cells.Add(cnpCell);

            HtmlTableRow firstnameRow = new HtmlTableRow();
            HtmlTableCell firstnameCell = new HtmlTableCell();
            firstnameCell.InnerText = "Firstname";
            firstnameRow.Cells.Add(firstnameCell);

            HtmlTableRow lastnameRow = new HtmlTableRow();
            HtmlTableCell lastnameCell = new HtmlTableCell();
            lastnameCell.InnerText = "Lastname";
            lastnameRow.Cells.Add(lastnameCell);

            HtmlTableRow PhoneNumberRow = new HtmlTableRow();
            HtmlTableCell PhoneNumberCell = new HtmlTableCell();
            PhoneNumberCell.InnerText = "PhoneNumber";
            PhoneNumberRow.Cells.Add(PhoneNumberCell);

            HtmlTableRow EmailRow = new HtmlTableRow();
            HtmlTableCell EmailCell = new HtmlTableCell();
            EmailCell.InnerText = "Email";
            EmailRow.Cells.Add(EmailCell);

            HtmlTableRow JobRow = new HtmlTableRow();
            HtmlTableCell JobCell = new HtmlTableCell();
            JobCell.InnerText = "Job";
            JobRow.Cells.Add(JobCell);

            HtmlTableRow CompanyRow = new HtmlTableRow();
            HtmlTableCell CompanyCell = new HtmlTableCell();
            CompanyCell.InnerText = "Company";
            CompanyRow.Cells.Add(CompanyCell);

            HtmlTableRow FloorRow = new HtmlTableRow();
            HtmlTableCell FloorCell = new HtmlTableCell();
            FloorCell.InnerText = "Floor";
            FloorRow.Cells.Add(FloorCell);

            HtmlTableRow RoomRow = new HtmlTableRow();
            HtmlTableCell RoomCell = new HtmlTableCell();
            RoomCell.InnerText = "Room";
            RoomRow.Cells.Add(RoomCell);

            HtmlTableRow RFIDRow = new HtmlTableRow();
            HtmlTableCell RFIDCell = new HtmlTableCell();
            RFIDCell.InnerText = "RFID";
            RFIDRow.Cells.Add(RFIDCell);

            HtmlTableRow CountyRow = new HtmlTableRow();
            HtmlTableCell CountyCell = new HtmlTableCell();
            CountyCell.InnerText = "County";
            CountyRow.Cells.Add(CountyCell);

            HtmlTableRow CityRow = new HtmlTableRow();
            HtmlTableCell CityCell = new HtmlTableCell();
            CityCell.InnerText = "City";
            CityRow.Cells.Add(CityCell);

            HtmlTableRow StreetRow = new HtmlTableRow();
            HtmlTableCell StreetCell = new HtmlTableCell();
            StreetCell.InnerText = "Street";
            StreetRow.Cells.Add(StreetCell);

            HtmlTableRow NumberRow = new HtmlTableRow();
            HtmlTableCell NumberCell = new HtmlTableCell();
            NumberCell.InnerText = "Number";
            NumberRow.Cells.Add(NumberCell);

            cnpCell = new HtmlTableCell();
            cnpCell.InnerText = cnp;
            cnpRow.Cells.Add(cnpCell);

            firstnameCell = new HtmlTableCell();
            firstnameCell.InnerText = firstname;
            firstnameRow.Cells.Add(firstnameCell);

            lastnameCell = new HtmlTableCell();
            lastnameCell.InnerText = lastname;
            lastnameRow.Cells.Add(lastnameCell);

            PhoneNumberCell = new HtmlTableCell();
            PhoneNumberCell.InnerText = phoneNumber;
            PhoneNumberRow.Cells.Add(PhoneNumberCell);

            EmailCell = new HtmlTableCell();
            EmailCell.InnerText = email;
            EmailRow.Cells.Add(EmailCell);

            JobCell = new HtmlTableCell();
            JobCell.InnerText = job;
            JobRow.Cells.Add(JobCell);

            CompanyCell = new HtmlTableCell();
            CompanyCell.InnerText = company;
            CompanyRow.Cells.Add(CompanyCell);

            FloorCell = new HtmlTableCell();
            FloorCell.InnerText = floor;
            FloorRow.Cells.Add(FloorCell);

            RoomCell = new HtmlTableCell();
            RoomCell.InnerText = room;
            RoomRow.Cells.Add(RoomCell);

            RFIDCell = new HtmlTableCell();
            RFIDCell.InnerText = rfid;
            RFIDRow.Cells.Add(RFIDCell);

            CountyCell = new HtmlTableCell();
            CountyCell.InnerText = county;
            CountyRow.Cells.Add(CountyCell);

            CityCell = new HtmlTableCell();
            CityCell.InnerText = city;
            CityRow.Cells.Add(CityCell);

            StreetCell = new HtmlTableCell();
            StreetCell.InnerText = street;
            StreetRow.Cells.Add(StreetCell);

            NumberCell = new HtmlTableCell();
            NumberCell.InnerText = number;
            NumberRow.Cells.Add(NumberCell);


            tableData.Rows.Clear();
            tableData.Rows.Add(cnpRow);
            tableData.Rows.Add(firstnameRow);
            tableData.Rows.Add(lastnameRow);
            tableData.Rows.Add(PhoneNumberRow);
            tableData.Rows.Add(EmailRow);
            tableData.Rows.Add(JobRow);
            tableData.Rows.Add(CompanyRow);
            tableData.Rows.Add(FloorRow);
            tableData.Rows.Add(RoomRow);
            tableData.Rows.Add(RFIDRow);
            tableData.Rows.Add(CountyRow);
            tableData.Rows.Add(CityRow);
            tableData.Rows.Add(StreetRow);
            tableData.Rows.Add(NumberRow);

            tableData.Visible = true;

        }
        private void InsertEditPageUrlIntoDatabase(string editPageUrl)
        {
           
        }
        protected void ddlPacients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve the selected pacient ID from the dropdown
            string selectedPacientId = ddlPacients.SelectedValue;
            Debug.WriteLine(selectedPacientId);
            Debug.WriteLine("am intrat!");

            // Retrieve the pacient details based on the selected pacient ID


            // Display the pacient details in the table
            DisplayPacientDetails(selectedPacientId);





            if (!string.IsNullOrEmpty(role))
            {
                Debug.WriteLine(role);
                // The user has a role, perform the necessary actions based on the role
                // For example, grant access to specific features or display different content
                if (role == "Medic")
                {
                    Button2.Visible = true;
                    Button4.Visible = true;
                }
                else if (role == "Nurse")
                {
                    Button2.Visible = false;
                    Button4.Visible = false;
                }
            }
            else
            {
                // The user does not have a role associated with them
                // Handle this scenario accordingly
            }
            if (role == "Nurse")
            {
                Button4.Visible = false;
            }
            else
            {
                Button4.Visible = true; // Show the button
            }
        }






        private void PopulatePacientDropdown()
        {






            var contor = 0;
            while (contor != 2)
            {
                string cnp = "cnp";
                string firstName = "albert";
                string lastName = "mircea";

                string fullName = $"{firstName} {lastName}"; // Concatenate the first and last name

                // Create a new ListItem with the full name as the text and CNP as the value
                ListItem listItem = new ListItem(fullName, cnp);
                ddlPacients.Items.Add(listItem); // Add the item to the dropdown
                contor += 1;
            }


        }



        protected void Vizualizare_Click(object sender, EventArgs e)
        {

            ddlPacients.Visible = true;





        }
        protected void SendMedicine_Click(object sender, EventArgs e)
        {
            //string url = GetLastInsertedEditPageUrl();
            Response.Redirect("EditPage.aspx");
            Button4.Visible = false;
        }







        protected void AdaugarePacienti_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertData.aspx");
        }

        protected void VizualizareIstoric_Click(object sender, EventArgs e)
        {
            // Redirect to the view transport history page or perform desired action
            Response.Redirect("TransportHistoryPage.aspx");
        }
    }
}
