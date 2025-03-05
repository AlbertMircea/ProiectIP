using System;
using System.Web.UI.HtmlControls;
using MySql.Data.MySqlClient;

namespace ExempluDB
{
    public partial class TransportHistoryPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HtmlTableRow headerRow = new HtmlTableRow();
                headerRow.Cells.Add(CreateTableCell("Number of medicine"));
                headerRow.Cells.Add(CreateTableCell("Drug prescription"));
                headerRow.Cells.Add(CreateTableCell("Mail's doctor"));
                headerRow.Cells.Add(CreateTableCell("Pacient's firstname"));
                headerRow.Cells.Add(CreateTableCell("Pacient's Lastname"));
                headerRow.Cells.Add(CreateTableCell("Floor"));
                headerRow.Cells.Add(CreateTableCell("Room"));
                headerRow.Cells.Add(CreateTableCell("RFID"));
                headerRow.Cells.Add(CreateTableCell("Trasnport started"));
                headerRow.Cells.Add(CreateTableCell("Trasnport finished"));
                headerRow.Cells.Add(CreateTableCell("Errors"));
                headerRow.Cells.Add(CreateTableCell("The number of the robot"));
                tableData.Rows.Add(headerRow);

                HtmlTableRow dataRow = new HtmlTableRow();
                dataRow.Cells.Add(CreateTableCell("3"));
                dataRow.Cells.Add(CreateTableCell("Algocalmin"));
                dataRow.Cells.Add(CreateTableCell("albertmircea@rocketmail.com"));
                dataRow.Cells.Add(CreateTableCell("Albert"));
                dataRow.Cells.Add(CreateTableCell("Mircea"));
                dataRow.Cells.Add(CreateTableCell("1"));
                dataRow.Cells.Add(CreateTableCell("2"));
                dataRow.Cells.Add(CreateTableCell("43432223"));
                dataRow.Cells.Add(CreateTableCell("Done"));
                dataRow.Cells.Add(CreateTableCell("Not ready"));
                dataRow.Cells.Add(CreateTableCell("No"));
                dataRow.Cells.Add(CreateTableCell("1"));
                tableData.Rows.Add(dataRow);

            }
        }

        private HtmlTableCell CreateTableCell(string text)
        {
            HtmlTableCell cell = new HtmlTableCell();
            cell.InnerText = text;
            return cell;
        }
        protected void btnBackButton(object sender, EventArgs e)
        {
            // Redirect to the view transport history page or perform desired action
            Response.Redirect("SuccessPage.aspx");
        }


    }
}
