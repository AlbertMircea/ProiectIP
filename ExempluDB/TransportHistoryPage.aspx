<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransportHistoryPage.aspx.cs" Inherits="ExempluDB.TransportHistoryPage" %>

<!DOCTYPE html>

<html>
<head>
    <title>Transport History Page</title>
    <style>
    /* CSS styles for table and buttons */
    #tableData {
        margin: 0 auto;
        border-collapse: collapse;
        width: 80%;
    }
    
    
    #tableData th,
    #tableData td {
        padding: 8px;
        text-align: center;
        border: 1px solid #ddd;
    }
    #tableData th {
        background-color: #f2f2f2;
        font-weight: bold;
    }
    .buttonContainer {
        text-align: center;
        margin-top: 20px;
    }
    .buttonContainer .backButton,
    .buttonContainer .addButton {
        display: inline-block;
        margin: 0 10px;
        padding: 10px 20px;
        background-color: #4CAF50;
        color: white;
        border: none;
        border-radius: 4px;
        cursor: pointer;
    }
</style>




</head>
<body>
    <form id="form1" runat="server">
    <table id="tableData" runat="server" class="tableData">
    </table>
    <div class="buttonContainer">
        <asp:Button ID="backButton" runat="server" Text="Back" CssClass="backButton" OnClick="btnBackButton" />
    </div>
</form>

</body>
</html>
