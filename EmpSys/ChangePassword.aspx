<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="EmpSys.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Password Please.

    </title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 327px;
            text-align: left;
            margin-top: 27px;
        }
       
        .auto-style2 {
            margin: auto;
            border: 2px solid;
            border-color: Gray;
            border-left-width: 2px;
            border-right-width: 2px;
        }

        .auto-style3 {
            width: 99%;
            height: 105px;
        }

        .auto-style4 {
            width: 234px;
        }

        .auto-style5 {
            width: 100%;
        }


        .auto-style6 {
            font-size: xx-large;
            font-weight: normal;
            color: #333333;
        }

        .changepassbutton {
            border-top-left-radius: 10px 10px;
            border-bottom-right-radius: 10px 10px;
            border-bottom-left-radius: 10px 10px;
            border-top-right-radius: 10px 10px;
            font-size: 14px;
            padding: 10px 5px;
            width: 200px;
        }

        .confirm {
            border-color: white;
        }

        .auto-style7 {
            height: 27px;
            text-align: center;
        }

        .auto-style8 {
            width: 234px;
            height: 27px;
        }

        .Panel1 {
            border-color: black;
            border-radius: 25px;
        }

        .auto-style9 {
            text-align: center;
        }

        .topnav {
             overflow: hidden;
            background-color:#363940;
            background-repeat: no-repeat !important;
            background-image: url("navline.png");
            background-position: left;
        }

            .topnav a {
                float: left;
                color: #f2f2f2;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
                font-size: 17px;
            }

                .topnav a:hover {
                    background-color: #ddd;
                    color: black;
                }

                .topnav a.active {
                    background-color: #4CAF50;
                    color: white;
                }

        .topnav-right {
            float: right;
        }

        .footer {
            position: fixed;
            left: 0;
            bottom: 0;
            width: 100%;
            font-family: Arial;
            font-size: 14px;
            font-weight: bold;
            color: black;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="topnav">
                <div class="topnav-right">
                    <a href="#Changepass">Change Password</a>
                    <a href="#Logout">Logout</a>
                    <a>Welcome, "Lebron"</a>
                </div>
            </div>

            <div class="auto-style1">
                &nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" color="#333333" Height="25px" ImageUrl="~/61457.png" Width="39px" />

                &nbsp;&nbsp;<strong><span class="auto-style6">&nbsp;CHANGE PASSWORD<br />
                    <hr />
                </span></strong>
                &nbsp;<asp:Panel ID="Panel1" runat="server" CssClass="auto-style2" Height="248px" Width="638px">
                    <br />
                    <table cellspacing="3" class="auto-style3">
                        <tr>
                            <td class="auto-style9">CURRENT PASSWORD:</td>
                            <td class="auto-style4">
                                <asp:TextBox ID="currentPassText" runat="server" BorderColor="White" Width="224px" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">NEW PASSWORD:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                            <td class="auto-style8">
                                <asp:TextBox ID="newPassText" runat="server" BorderColor="White" Width="224px" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CONFIRM NEW PASSWORD:</td>
                            <td class="auto-style4">
                                <asp:TextBox ID="confirmNewPassText" runat="server" class="confirm" BorderColor="White" Width="224px" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table cellspacing="3" class="auto-style5" style="text-align: center">
                        <tr>
                            <td>
                                <asp:Button ID="changePasswordButton" class="changepassbutton" runat="server" Text="CHANGE PASSWORD" BackColor="#333333" ForeColor="White" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </div>
    </form>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
    <br />

     <footer class="container-fluid">

        <center>The information contained herein is the confidential and proprietary property of Computer Aid, Incorporated.</center>
        
    </footer>

</body>
</html>






