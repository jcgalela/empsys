<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="EmpSys.Information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            background-position: left;
            font-family: Verdana, Geneva, sans-serif;
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
            position: relative;
            min-height: 1px;
            float: left;
            width: 100%;
            text-align: center;
            padding-left: 15px;
            padding-right: 15px;
        }

        .Details {
            color: dodgerblue;
        }

        .container-fluid {
            font-family: Verdana, Geneva, sans-serif;
        }

        .container {
            font-family: Verdana, Geneva, sans-serif;
        }

        .auto-style8 {
            font-family: Verdana, Geneva, sans-serif;
            font-weight: bold;
             font-size: x-large;
        }
        .auto-style9 {
            font-weight: bold;
            text-align: center;
        }
    </style>
</head>
<body>

    <div class="topnav">
        <a>Employee Registration</a>
        <div class="topnav-right">
            <a href="#Changepass">Change Password</a>
            <a href="#Logout">Logout</a>
            <a>Welcome, "Lebron"</a>
        </div>
    </div>


    <div class="container">
        <div class="container">
            <asp:Image ID="Image2" runat="server" Height="40px" ImageUrl="~/Settings_black-512.png" Width="25px" />
            <span class="auto-style8">&nbsp;&nbsp; ADD USERS</span>
            <hr />
        </div>
    </div>

    <form id="form1" runat="server">
        <div class="container">
            <div class="row content">
                <div class="col-sm-6">
                    <h2 class="Details">Employee Information</h2>
                    <br />
                    <ul>

                        <h4><b>Employee Status:
                            <asp:DropDownList ID="DropDownList2" runat="server">
                                <asp:ListItem>Regular</asp:ListItem>
                                <asp:ListItem>Trainee</asp:ListItem>
                            </asp:DropDownList></h4>
                        <br>
                        <h4><b>Employee Id:</b>
                            <asp:TextBox ID="empIdText" runat="server"></asp:TextBox></h4>
                        <br>
                        <h4><b>SSS Number:</b>
                            <asp:TextBox ID="sssText" runat="server"></asp:TextBox></h4>
                        <br>
                        <h4><b>TIN Number:</b>
                            <asp:TextBox ID="tinText" runat="server"></asp:TextBox></h4>
                        <br>
                        <h4><b>Date Employed:</b><asp:TextBox ID="dateEmployedText" runat="server" ReadOnly="True"></asp:TextBox>
                            <asp:ImageButton ID="dateEmployedButton" runat="server" Height="25px" ImageUrl="~/calendar-512.png" OnClick="dateEmployedButton_Click" />
                            <asp:Calendar ID="dateEmployedCalendar" runat="server" Visible="False" OnSelectionChanged="dateEmployedCalendar_SelectionChanged"></asp:Calendar></h4>
                        <br>

                        <h4><b>Effective Date:</b></h4>
                        <h4><b>From:</b><asp:TextBox ID="fromText" runat="server" ReadOnly="True"></asp:TextBox>
                            <asp:ImageButton ID="fromButton" runat="server" Height="25px" ImageUrl="~/calendar-512.png" OnClick="fromButton_Click" />
                            <asp:Calendar ID="fromCalendar" runat="server" Visible="False" OnSelectionChanged="fromCalendar_SelectionChanged"></asp:Calendar></h4>
                        <br>
                        <h4><b>To:</b><asp:TextBox ID="toText" runat="server" ReadOnly="True"></asp:TextBox>
                            <asp:ImageButton ID="toButton" runat="server" Height="25px" ImageUrl="~/calendar-512.png" OnClick="toButton_Click" />
                            <asp:Calendar ID="toCalendar" runat="server" Visible="False" OnSelectionChanged="toCalendar_SelectionChanged"></asp:Calendar></h4>
                        <br>
                        <h4><b>Signature:</b></h4>
                        <asp:ImageButton ID="uploadSignature" runat="server" Height="50px" ImageUrl="~/sig.PNG" />
                    </ul>
                    <br>

                    <div class="input-group">
                        <span>
                            <br>
                        </span>
                    </div>
                </div>


                <div class="container-fluid">
                    <div class="row content">

                        <div class="col-sm-6">
                            <h2 class="Details">Contact Details</h2>
                            <br />
                            <ul>
                                <h4><b>Image:</b> &nbsp;<br>
                                    <br>
                                    <asp:ImageButton ID="uploadImage" runat="server" Height="200px" ImageUrl="~/upload.PNG" />

                                </h4>

                                <br>
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem>Mr.</asp:ListItem>
                                    <asp:ListItem>Ms.</asp:ListItem>
                                    <asp:ListItem>Mrs.</asp:ListItem>
                                </asp:DropDownList>
                                <h4><b>First Name:</b><asp:TextBox ID="firstNameText" runat="server"></asp:TextBox></h4>
                                <br>
                                <h4><b>Middle Name:</b><asp:TextBox ID="middleNameText" runat="server"></asp:TextBox></h4>
                                <br>
                                <h4><b>Last Name:</b><asp:TextBox ID="lastNameText" runat="server"></asp:TextBox></h4>
                                 <br>
                                <h4><b>Date of Birth:</b><asp:TextBox ID="birthdayText" runat="server" ReadOnly="True"></asp:TextBox>
                                    <asp:ImageButton ID="birthdayButton" runat="server" Height="25px" ImageUrl="~/calendar-512.png" OnClick="birthdayButton_Click" />
                                    <asp:Calendar ID="birthdayCalendar" runat="server" Visible="False" OnSelectionChanged="birthdayCalendar_SelectionChanged"></asp:Calendar>
                                    <br />
                                    <br />
                                    <br />
                                    <h4><b>In case of emergency, please notify,</b></h4>
                                    <h4><b>Name:</b><asp:TextBox ID="emergencyName" runat="server"></asp:TextBox></h4>
                                     <br>
                                    <h4><b>Address:</b><asp:TextBox ID="emergencyAddress" runat="server"></asp:TextBox></h4>
                                     <br>
                                    <h4><b>Contact No:</b><asp:TextBox ID="emergencyContact" runat="server"></asp:TextBox></h4>
                            </ul>
                            <br>
                        </div>
                    </div>

                    <div class="container-fluid">
                        <div class="row content">
                            <div class="col-sm-8">
                                <h2 class="Details">Login Information</h2>
                                <br />
                                <ul>
                                    <h4><b>UserName:</b><asp:TextBox ID="userNameText" runat="server"></asp:TextBox></h4>
                                    <h4><b>Email:</b><asp:TextBox ID="emailText" runat="server"></asp:TextBox></h4>
                                    <h4><b>Confirm Email:</b>
                                        <asp:TextBox ID="confirmEmailText" runat="server"></asp:TextBox></h4>
                                    <h4><b>Password:</b><asp:TextBox ID="passwordText" runat="server"></asp:TextBox></h4>
                                    <h4><b>Confirm Password:</b><asp:TextBox ID="confirmPassText" runat="server"></asp:TextBox></h4>
                                    <h4 class="auto-style9">
                        <center><b><asp:Button ID="Button1" runat="server" Text="Create" BackColor="#333333" ForeColor="White" Width="163px" OnClick="Button1_Click" Height="46px" /></b></center>
                                    </h4>
                                </ul>

                                <br>
                                </span>
                            </div>
                        </div>
                        <br>
                        <div class="container">
                            <div class="row content">
                            </div>
                        </div>
                    </div>
    </form>


    <footer class="container-fluid">

        <center>The information contained herein is the confidential and proprietary property of Computer Aid, Incorporated.</center>

    </footer>

</body>
</html>
