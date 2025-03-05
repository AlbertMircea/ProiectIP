<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ExempluDB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style>
        html, body {
            height: 100%;
        }

        body {
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .login-form {
            max-width: 500px;
            padding: 40px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .login-form h2 {
            font-size: 24px;
            margin-bottom: 20px;
        }

        .login-form label {
            font-size: 18px;
        }

        .login-form input[type="text"],
        .login-form input[type="password"] {
            width: 100%;
            padding: 10px;
            font-size: 16px;
            margin-bottom: 10px;
        }

        .login-form button {
            padding: 10px 20px;
            font-size: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="login-form">
        <div>
            <h2>Login</h2>
            <asp:Label ID="lblErrorMessage" runat="server" Text="" CssClass="error-message"></asp:Label>
            <asp:Label ID="lblUsername" runat="server" Text="Email:"></asp:Label>
            <br />
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Login" runat="server" OnClick="Login_Click" Text="Login" />
            <br />
            <br />
            <asp:GridView ID="GridAfisare" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="username" HeaderText="username" />
                    <asp:BoundField DataField="password" HeaderText="password" />
                </Columns>
            </asp:GridView>
            
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
