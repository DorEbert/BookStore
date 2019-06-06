<%@ Page Language="C#" AutoEventWireup="true" Async="true"  CodeBehind="HomePage.aspx.cs" Inherits="WebPortal.MenuPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1 align="center">BookStore</h1>
    <form id="form2" runat="server">

        <asp:Panel ID="Panel1" runat="server" Height="76px" Width="689px" CssClass="auto-style1">
            <label for="UserBoundaryEmail"><b>User Email</b></label>
            <asp:TextBox ID="txt_UserEmail" name="txtUserBoundaryEmail" runat="server" Visible="True"></asp:TextBox>
            <label for="Smartspace"><b>Smartspace</b></label>
            <asp:TextBox ID="txt_Smartspace" name="txt_Smartspace" runat="server" Visible="True"></asp:TextBox>
            <asp:Button ID="Login_Button" runat="server" OnClick="LoginButtonAsync" Text="Login" Width="318px" style="margin-bottom: 0px" />       
            <asp:Button ID="SignUp_Button" runat="server" OnClick="SignUpButtonAsync" Text="SignUp" Width="318px" style="margin-bottom: 0px" />            

        </asp:Panel>

    </form>
</body>
<style>
.vertical-menu {
  width: 200px;
}

.vertical-menu a {
  background-color: #eee;
  color: black;
  display: block;
  padding: 12px;
  text-decoration: none;
}

.vertical-menu a:hover {
  background-color: #ccc;
}

.vertical-menu a.active {
  background-color: #4CAF50;
  color: white;
}
    .auto-style1 {
        margin-right: 0px;
    }
<style>
body {font-family: Arial, Helvetica, sans-serif;}
* {box-sizing: border-box}

/* Full-width input fields */
input[type=text], input[type=password] {
  width: 100%;
  padding: 15px;
  margin: 5px 0 22px 0;
  display: inline-block;
  border: none;
  background: #f1f1f1;
}

input[type=text]:focus, input[type=password]:focus {
  background-color: #ddd;
  outline: none;
}

hr {
  border: 1px solid #f1f1f1;
  margin-bottom: 25px;
}
</style>
</html>
