<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="SignUp.aspx.cs" Inherits="WebPortal.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Sign Up</h1>
            <p>Please fill in this form to create an account.</p>
            <hr>
            <label for="UserSmartspace"><b>User Smartspace</b></label>
            <input id="txt_UserSmartspace" type="text" runat="server" placeholder="Enter Smartspace" name="txt_UserSmartspace" >

            <label for="UserName"><b>User Name</b></label>
            <input id="txt_UserName" type="text" runat="server" placeholder="Enter Username" name="txt_UserName" >

            <label for="Avatar"><b>Avatar</b></label>
            <input id="txt_Avatar" type="text" runat="server" placeholder="Enter Avatar" name="txt_Avatar" >
            
            <label for="Role"><b>Role</b></label>
            <input id="txt_Role" type="text" runat="server" placeholder="Enter Role" name="txt_Role" >
            
            <label for="Email"><b>Email</b></label>
            <input id="txt_Email" type="text" runat="server" placeholder="Enter Email" name="txt_Role" >


            
            <br />
            <asp:Button ID="SignUp_Button" runat="server" OnClick="SignUp_ClickAsync" Text="Sign Up" Width="318px" style="margin-bottom: 0px" />
            </div>
    
        <asp:Button ID="HomePage_Button" runat="server" OnClick="HomePage_Button_ClickAsync" Text="Home_Page" Width="318px" />
    </form>

</body>
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

/* Set a style for all buttons */
button {
  background-color: #4CAF50;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
  opacity: 0.9;
}

button:hover {
  opacity:1;
}

/* Add padding to container elements */
.container {
  padding: 16px;
}

/* Clear floats */
.clearfix::after {
  content: "";
  clear: both;
  display: table;
}

</style>
<script type="text/javascript">
    function alertMessage() {
        alert('JavaScript Function Called!');
    }
</script>
</html>
