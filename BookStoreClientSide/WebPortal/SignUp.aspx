<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="SignUp.aspx.cs" Inherits="WebPortal.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script
        src="https://code.jquery.com/jquery-3.4.1.min.js"
        integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="
        crossorigin="anonymous"></script>

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js" integrity="sha384-aJ21OjlMXNL5UyIl/XNwTMqvzeRMZH2w8c5cRVpzpU8Y5bApTppSuUkhZXN0VxHd" crossorigin="anonymous"></script>

    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" integrity="sha384-HSMxcRTRxnN+Bdg0JdbxYKrThecOKuH5zCYotlSAcp1+c8xmyTe9GYg1l9a69psu" crossorigin="anonymous">


    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        * {
            box-sizing: border-box
        }

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
                opacity: 1;
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
        function openModal() {
            $('#myModal').modal('show');
        }
    </script>
</head>
<body>

    <form id="form1" runat="server">
        <div class="container">
            <h1>Sign Up</h1>
            <p>Please fill in this form to create an account.</p>
            <hr />
            <label for="UserSmartspace"><b>User Smartspace</b></label>
            <input id="txt_UserSmartspace" type="text" runat="server" placeholder="Enter Smartspace" name="txt_UserSmartspace" />

            <label for="UserName"><b>User Name</b></label>
            <input id="txt_UserName" type="text" runat="server" placeholder="Enter Username" name="txt_UserName" />

            <label for="Avatar"><b>Avatar</b></label>
            <input id="txt_Avatar" type="text" runat="server" placeholder="Enter Avatar" name="txt_Avatar" />

            <label for="Role"><b>Role</b></label>
            <input id="txt_Role" type="text" runat="server" placeholder="Enter Role" name="txt_Role" />

            <label for="Email"><b>Email</b></label>
            <input id="txt_Email" type="text" runat="server" placeholder="Enter Email" name="txt_Role" />
            <br />
            <asp:Button ID="SignUp_Button" runat="server" OnClick="SignUp_ClickAsync" Text="Sign Up" Width="318px" Style="margin-bottom: 0px" />
            <asp:Button ID="HomePage_Button" runat="server" OnClick="HomePage_Button_ClickAsync" Text="Home_Page" Width="318px" />

        </div>
        <!-- Modal -->
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="myModalLabel"></h4>
                    </div>
                    <div class="modal-body">
                        <asp:Label ID="lblModalMessage" runat="server" />
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
