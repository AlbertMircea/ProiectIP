<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="ExempluDB.EditPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Page</title>
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

        .edit-form {
            width: 400px;
            padding: 20px;
            border: 1px solid #ddd;
            border-radius: 4px;
            background-color: #f5f5f5;
        }

        .edit-form input[type="text"],
        .edit-form input[type="password"] {
            width: 100%;
            padding: 8px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .edit-form .submit-button {
            padding: 10px 20px;
            font-size: 16px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        .edit-form .cancel-button {
            padding: 10px 20px;
            font-size: 16px;
            background-color: #ccc;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            margin-left: 10px;
        }

        .error-message {
            color: red;
            margin-top: 10px;
        }
        .multiline-textbox {
            width: 100%;
            height: 60px;
            resize: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="edit-form">
            <h2>Add Transport</h2>
            <asp:Label ID="lblErrorMessage" runat="server" CssClass="error-message" Visible="false"></asp:Label>
            <asp:Label ID="lblDrug" runat="server" Text="*Drug text:" AssociatedControlID="txtDrug"></asp:Label>
            <asp:TextBox ID="txtDrug" runat="server" placeholder="Drug" TextMode="MultiLine" CssClass="multiline-textbox"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="*Which Robot should do the job:" AssociatedControlID="txtRobotId"></asp:Label>
            <asp:TextBox ID="txtRobotId" runat="server" placeholder="The number of the robot(1 to 5)"></asp:TextBox>
            <br />

            <asp:Label ID="lblMail" runat="server" Text="Mail:" AssociatedControlID="txtDrug"></asp:Label>
            <asp:TextBox ID="txtMail" runat="server" placeholder="Mail"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="CNP:" AssociatedControlID="txtDrug"></asp:Label>
            <asp:TextBox ID="txtCNP" runat="server" placeholder="CNP"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Firstname:" AssociatedControlID="txtDrug"></asp:Label>
            <asp:TextBox ID="txtFirstnamePacient" runat="server" placeholder="Firstname"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Lastname:" AssociatedControlID="txtDrug"></asp:Label>
            <asp:TextBox ID="txtLastnamePacient" runat="server" placeholder="Lastname"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Floor:" AssociatedControlID="txtDrug"></asp:Label>
            <asp:TextBox ID="txtFloor" runat="server" placeholder="Floor"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Room:" AssociatedControlID="txtDrug"></asp:Label>
            <asp:TextBox ID="txtRoom" runat="server" placeholder="Room"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="RFID:" AssociatedControlID="txtDrug"></asp:Label>
            <asp:TextBox ID="txtRFID" runat="server" placeholder="RFID"></asp:TextBox>
            <br />
            
            <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="submit-button" OnClick="btnAdd_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="submit-button" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
