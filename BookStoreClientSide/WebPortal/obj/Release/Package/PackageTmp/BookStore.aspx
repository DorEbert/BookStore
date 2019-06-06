<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="BookStore.aspx.cs" Inherits="WebPortal.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<head>
    <style>
#BookTable #FilesTable {
  font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

/*#UserBoundarysTable td, #UserBoundarysTable th #FilesTable td, #FilesTable th {*/
  border: 1px solid #ddd;
  padding: 8px;
}

#BookTable tr:nth-child(even){background-color: #f2f2f2;}
#FilesTable tr:nth-child(even){background-color: #f2f2f2;}

#BookTable tr:hover {background-color: #ddd;}
#FilesTable tr:hover {background-color: #ddd;}

#BookTable th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #4CAF50;
  color: white;
}
#FilesTable th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #4CAF50;
  color: white;
}
</style>
</head>
<body>
     <form id="form1" runat="server">
     <h1>Books</h1>
         <br />
         <asp:TextBox ID="txt_Search" name="txt_Search" placeholder="search book name..." runat="server" Visible="True"></asp:TextBox>
         <asp:Button ID="SearchButton" runat="server" OnClick="SearchButton_OnClickAsync" Text="Search By Name" Width="318px" style="margin-bottom: 0px" />
         <br />
         <br />
        <table id="BookTable" runat="server" class="auto-style1" style="width:100%; margin-top: 0px;">
            <thead>
                <tr>   
                    <th>id</th> 
                    <th>name</th>        
                </tr>
            </thead>
        </table>
     <asp:TextBox ID="Book_ID" type="hidden" name="ApplicationUserBoundary_ID" runat="server" ></asp:TextBox>
         
         <br />
         <asp:Panel ID="Panel1" runat="server" Height="175px" Width="689px">
             <label for="BookName"><b>Chosen Book</b></label>
             <asp:TextBox ID="txt_BookName" name="txtBookName" runat="server" Visible="True"></asp:TextBox>            
             <asp:Button ID="txt_Options" runat="server" OnClick="MovePageToBookDetails" Text="Options" Width="318px" style="margin-bottom: 0px" />
         </asp:Panel>
         
         <br />
         <br />
     <h1>Files</h1>
     
         </form>
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
        width: 100%;
    }

    </style>    
<script>
    var table = document.getElementById('BookTable');       
    for(var i = 1; i < table.rows.length; i++)
    {
        table.rows[i].onclick = function()
        {
            //rIndex = this.rowIndex;
            document.getElementById("Book_ID").value = this.cells[0].innerHTML;   
            document.getElementById("txt_BookName").value = this.cells[1].innerHTML;            
        };
    }
    
</script>
      </body>
</html> 
