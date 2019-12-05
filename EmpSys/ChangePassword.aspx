<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="EmpSys.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Password

    </title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <style type="text/css">
        .topnav {
            overflow: hidden;
            background-color: #363940;
            background-repeat: no-repeat !important;
            background-image: url("navline.png");
            font-family: Verdana, Geneva, sans-serif;
            background-position: left;
        }

            .topnav a {
                float: left;
                color: #f2f2f2;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
                font-size: 17px;
                font-family: Verdana, Geneva, sans-serif;
            }

                .topnav a:hover {
                    background-color: #1976d2;
                    color: white;
                }

                .topnav a.active {
                    background-color: #4CAF50;
                    color: white;
                }

        .topnav-right {
            float: right;
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
            font-family: Verdana, Geneva, sans-serif;
        }

        .PassTF {
            width: 234px;
        }

        .auto-style5 {
            width: 100%;
        }


        .changepass {
            font-size: xx-large;
            font-weight: normal;
            color: #333333;
            font-family: Verdana, Geneva, sans-serif;
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

        .Panel1 {
            border-color: black;
            border-radius: 25px;
        }

        .container-fluid {
            position: absolute;
            left: 0;
            bottom: 0;
            width: 100%;
            font-family: Verdana, Geneva, sans-serif;
            font-size: 14px;
            font-weight: bold;
            color: black;
            text-align: center;
        }

        .PassFont {
            text-align: center;
            font-weight: bold;
            width: 197px;
            height: 34px;
        }

        .ImageCP {
            position: relative;
            min-height: 1px;
            float: left;
            width: 100%;
            left: 0px;
            top: 0px;
            height: 123px;
            padding-left: 15px;
            padding-right: 15px;
            text-align: left;
        }

        .labelmsg {
            text-align: center;
            height: 37px;
            font-size: 20px;
            font-weight: bold;
            color: red !important;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="topnav">
            <a>Employee Registration System</a>
            <div class="topnav-right">
                <asp:HyperLink ID="LoginHome" runat="server" NavigateUrl="LogIn.aspx">Home </asp:HyperLink>
                <asp:HyperLink ID="UserMaintenance" runat="server" NavigateUrl="Maintenance.aspx">User Maintenance </asp:HyperLink>
            </div>
        </div>

        <div class="container">
            <div class="row content">
                <div class="ImageCP">
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="32px" ImageUrl="~/61457.png" Width="45px" />
                    <strong><span class="changepass">&nbsp;CHANGE PASSWORD<br />
                    </span></strong>
                    <hr />
                </div>
            </div>
        </div>

        <div class="container">
            <div class="row content">
                <div class="labelmsg">
                    <asp:Label ID="lblmsg" runat="server" Height="40px" Width="258px"></asp:Label>
                </div>
            </div>
        </div>

        <div class="container">
            <div class="row content">
                <div class="col-sm-12">
                    &nbsp;<asp:Panel ID="Panel1" runat="server" CssClass="auto-style2" Height="248px" Width="638px">
                        <br />
                        <table class="auto-style3" style="text-align: center">
                            <tr>
                                <td class="PassFont">CURRENT PASSWORD:&nbsp;</td>
                                <td class="PassTF">
                                    <asp:TextBox ID="currentPassText" runat="server" BorderColor="Black" Width="285px" TextMode="Password" BorderStyle="Solid" MaxLength="32"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="PassFont">NEW PASSWORD:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                                <td class="PassTF">
                                    <asp:TextBox ID="newPassText" runat="server" BorderColor="Black" Width="285px" TextMode="Password" BorderStyle="Solid" MaxLength="32"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="PassFont">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CONFIRM NEW PASSWORD:</td>
                                <td class="PassTF">
                                    <asp:TextBox ID="confirmNewPassText" runat="server" class="confirm" BorderColor="Black" Width="285px" TextMode="Password" BorderStyle="Solid" MaxLength="32"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <table class="auto-style5" style="text-align: center">
                            <tr>
                                <td>
                                    <asp:Button ID="changePasswordButton" class="changepassbutton" runat="server" Text="CHANGE PASSWORD" BackColor="#333333" ForeColor="White" OnClick="changePasswordButton_Click" />
                                    <br />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </div>
            </div>
        </div>



    </form>
    <br />


    <footer class="container-fluid">
        <p>The information contained herein is the confidential and proprietary property of Computer Aid, Incorporated.html</p>
    </footer>


</body>
</html>







