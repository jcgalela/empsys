﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPass.aspx.cs" Inherits="EmpSys.ForgotPass" %>

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
            font-family: Verdana, Geneva, sans-serif;
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
            font-family: Verdana, Geneva, sans-serif;
            font-weight: bold;
        }

        .confirm {
            border-color: white;
        }

        .Panel1 {
            border-color: black;
            border-radius: 25px;
        }

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

        .auto-style10 {
            text-align: left;
            font-weight: bold;
            width: 255px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="topnav">
            <a>Employee Registration System</a>
            <div class="topnav-right">
                <asp:HyperLink ID="LoginHome" runat="server" NavigateUrl="LogIn.aspx">Home </asp:HyperLink>
            </div>
        </div>

        <div class="auto-style1">
            &nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" color="#333333" Height="25px" ImageUrl="~/61457.png" Width="39px" />

            <strong><span class="auto-style6">FORGOT PASSWORD<br />
                <hr />
            </span></strong>
            &nbsp;<asp:Panel ID="Panel1" runat="server" CssClass="auto-style2" Height="248px" Width="638px">
                <br />
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style10">&nbsp;ENTER YOUR EMAIL ADDRESS:</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="emailText" runat="server" BorderColor="#333333" Width="266px" TextMode="Email"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <table class="auto-style5" style="text-align: center">
                    <tr>
                        <td>
                            <asp:Button ID="sendButton" class="changepassbutton" runat="server" Text="SEND" BackColor="#333333" ForeColor="White" OnClick="sendButton_Click" />
                            <br />
                            <br />
                            <asp:Label ID="lblMessage" runat="server" />
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

        <p>The information contained herein is the confidential and proprietary property of Computer Aid, Incorporated.</p>

    </footer>

</body>
</html>






