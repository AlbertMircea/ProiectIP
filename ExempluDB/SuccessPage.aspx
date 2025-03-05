<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuccessPage.aspx.cs" Inherits="ExempluDB.SuccessPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Success Page</title>
    <style>
        html, body {
            height: 100%;
        }

        body {
            display: flex;
            align-items: center;
            justify-content: center;
            flex-direction: column;
        }

        .success-message {
            font-size: 24px;
            margin-bottom: 20px;
        }
        .dropdown {
            width: 250px; /* Set the desired width */
            font-size: 18px; /* Set the desired font size */
        }

        .welcome-label {
            font-size: 18px;
            margin-bottom: 10px;
        }

        .button-container {
            display: flex;
            justify-content: center;
            margin-bottom: 20px; /* Add margin-bottom for spacing */
        }

        .styled-button {
            padding: 10px 20px;
            font-size: 16px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            margin: 0 10px;
        }

        table {
            border-collapse: collapse;
            width: 80%;
            max-width: 600px;
            margin-top: 20px;
        }

        th, td {
            text-align: left;
            padding: 8px;
            border-bottom: 1px solid #ddd;
        }

        th {
            background-color: #4CAF50;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        


        <div>
            <table id="tblPacientDetails" runat="server"></table>
        </div>

        <div class="success-message">
            <h2>Welcome, <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>!</h2>
        </div>
        <div class="button-container">
            <asp:Button ID="Button1" runat="server" Text="Vizualizare pacienti" CssClass="styled-button" OnClick="Vizualizare_Click" />
            <asp:Button ID="Button2" runat="server" Text="Adaugare pacient" CssClass="styled-button" OnClick="AdaugarePacienti_Click" />
            <asp:Button ID="Button3" runat="server" Text="Vizualizare istoric transporturi" CssClass="styled-button" OnClick="VizualizareIstoric_Click" />
        </div>
        <div>
            <asp:DropDownList ID="ddlPacients" runat="server" CssClass="dropdown" AutoPostBack="true" Value="White" OnSelectedIndexChanged="ddlPacients_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
        </div>
        <div class="button-container">
            <br />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
        <div>
           <table id="tableData" runat="server"></table> 
        </div>
        <div class="button-container">
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Send Medicine" CssClass="styled-button" OnClick="SendMedicine_Click" Visible="false"/>
        </div>
    </form>
</body>
</html>
