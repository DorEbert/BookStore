<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="HomePage.aspx.cs" Inherits="WebPortal.MenuPage" %>

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
    </style>
    <script type="text/javascript">
        function openModal() {
            $('#myModal').modal('show');
        }
    </script>
</head>
<body>
    <form id="form2" runat="server">
        <h1 align="center">BookStore</h1>
        <%--<asp:Panel ID="Panel1" runat="server" Height="76px" Width="689px" CssClass="auto-style1">--%>
        <label for="UserBoundaryEmail"><b>User Email</b></label>
        <asp:TextBox ID="txt_UserEmail" name="txtUserBoundaryEmail" runat="server" Visible="True"></asp:TextBox>
        <label for="Smartspace"><b>Smartspace</b></label>
        <asp:TextBox ID="txt_Smartspace" name="txt_Smartspace" runat="server" Visible="True"></asp:TextBox>
        <asp:Button ID="Login_Button" runat="server" OnClick="LoginButtonAsync" Text="Login" Width="318px" Style="margin-bottom: 0px" />
        <asp:Button ID="SignUp_Button" runat="server" OnClick="SignUpButtonAsync" Text="SignUp" Width="318px" Style="margin-bottom: 0px" />

        <%--</asp:Panel>--%>
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
