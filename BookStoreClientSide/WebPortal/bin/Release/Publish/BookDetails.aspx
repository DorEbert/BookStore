<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="BookDetails.aspx.cs" Inherits="WebPortal.BookDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 567px">
    <form id="form1" runat="server">
        <div class="container">
            <h1>Book Details</h1>
            <hr>
            <p class="auto-style1">
                Book Id<input id="txt_BookID" type="text" runat="server" placeholder="" name="txt_BookID" >
                Name<input id="txt_BookName" type="text" runat="server" placeholder="" name="txt_BookName" >
                Book Creator&nbsp;
            <input id="txt_BookCreator" type="text" runat="server" placeholder="" name="txt_BookCreator" >
                Properties
            <input id="txt_Properties" type="text" runat="server" placeholder="" name="txt_Properties" >
             <asp:Button ID="CheckIn_Button" runat="server" OnClick="CheckInButtonAsync" Text="CheckIn" Width="318px" style="margin-bottom: 0px" />
             <asp:Button ID="CheckOut_Button" runat="server" OnClick="CheckOutButtonAsync" Text="CheckOut" Width="318px" style="margin-bottom: 0px" />
             <asp:Button ID="Read_Book_Summary_Button" runat="server" OnClick="ReadBookSummaryButtonAsync" Text="Read Book Summary" Width="318px" style="margin-bottom: 0px" />
             <asp:Button ID="Purchase_Button" runat="server" OnClick="PurchaseButtonAsync" Text="Purchase" Width="318px" style="margin-bottom: 0px" />
            <br />          
            <asp:Label ID="Msg_For_User" runat="server" Text=" "></asp:Label>
            <p class="auto-style1">
                &nbsp;</div>
    
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

    .auto-style1 {
        margin-left: 40px;
    }

    .auto-style2 {
        margin-bottom: 0px;
    }

</style>
</html>
