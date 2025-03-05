<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertData.aspx.cs" Inherits="ExempluDB.InsertData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Entry Page</title>
     <style>
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            font-family: Arial, sans-serif;
        }

         .container {
             width: 400px;
             padding: 20px;
             background-color: #f5f5f5;
             border-radius: 5px;
             box-shadow: 0 2px 5px rgba(0, 0, 0, 0.2);
             overflow: hidden; 
         }


        .container h2 {
            margin-top: 0;
        }

        .form-group {
            margin-bottom: 10px;
        }

        .form-group label {
            display: block;
            font-weight: bold;
        }

        .form-group input[type="text"] {
            width: 100%;
            padding: 5px;
            font-size: 14px;
            border-radius: 3px;
            border: 1px solid #ccc;
        }

         .btn-save {
             padding: 10px 20px;
             font-size: 16px;
             background-color: #4CAF50;
             color: white;
             border: none;
             border-radius: 4px;
             cursor: pointer;
             float: left;
             margin-right: 10px; 
         }


         .btn-cancel {
             padding: 10px 20px;
             font-size: 16px;
             background-color: #4CAF50;
             color: white;
             border: none;
             border-radius: 4px;
             cursor: pointer;
             float: right;
         }
         .error-message {
            color: red;
            font-weight: bold;
         }


    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Patient Information</h2>
            <asp:Label ID="lblErrorMessage" runat="server" Text="" CssClass="error-message"></asp:Label>

            <div class="form-group">
                <label for="txtCNP">*CNP:</label>
                <asp:TextBox ID="txtCNP" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtFirstName">First Name:</label>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtLastName">Last Name:</label>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtPhoneNumber">*Phone Number:</label>
                <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                
            </div>
            <div class="form-group">

             <label for="txtEmail">*Email:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>


            </div>
            <div class="form-group">

            <label for="txtJob">Job:</label>
            <asp:TextBox ID="txtJob" runat="server"></asp:TextBox>


            </div>
            <div class="form-group">

            <label for="txtCompany">Company:</label>
            <asp:TextBox ID="txtCompany" runat="server"></asp:TextBox>


            </div>
            <div class="form-group">

            <label for="txtFloor">Floor:</label>
            <asp:TextBox ID="txtFloor" runat="server"></asp:TextBox>


            </div>
            <div class="form-group">

            <label for="txtRoom">Room:</label>
            <asp:TextBox ID="txtRoom" runat="server"></asp:TextBox>


            </div>
            <div class="form-group">

            <label for="txtRFID">RFID:</label>
            <asp:TextBox ID="txtRFID" runat="server"></asp:TextBox>


            <label for="txtCounty">County:</label>
            <asp:TextBox ID="txtCounty" runat="server"></asp:TextBox>


            </div>
            <div class="form-group">

            <label for="txtCity">City:</label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>


            </div>
            <div class="form-group">

            <label for="txtStreet">Street:</label>
            <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>

            </div>
            <div class="form-group">

            <label for="txtNumber">Number:</label>
            <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>

            </div>
            


            <!-- Add the rest of the form groups for the other fields -->
            <!-- PhoneNumber, Email, Job, Company, BedId, Floor, Room, RFID, County, City, Street, Number -->
            <div>
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn-save" OnClick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn-cancel" OnClick="btnCancel_Click" />
            </div>
        </div>
    </form>
</body>
</html>

