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

        .col-sm-6 {
        }

        .col-sm-4 {
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
                        <h4><b>Employee Id:
                            <asp:TextBox ID="empIdText" runat="server"></asp:TextBox></h4>

                        <h4><b>SSS Number:
                            <asp:TextBox ID="sssText" runat="server"></asp:TextBox></h4>

                        <h4><b>TIN Number:
                            <asp:TextBox ID="tinText" runat="server"></asp:TextBox></h4>

                        <h4><b>Date Employed:
                            <asp:TextBox ID="dateEmployedText" runat="server"></asp:TextBox></h4>

                        <h4><b>Effective Date:</h4>
                        <h4><b>From:<asp:TextBox ID="fromText" runat="server" ReadOnly="True"></asp:TextBox></h4>


                        <h4><b>To:<asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox></h4>

                        <h4><b>Signature:</h4>
                        <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" ImageUrl="~/signatue.PNG" />


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
                                <h4>Image: &nbsp;<br>
                                    <br>
                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="200px" ImageUrl="~/upload.PNG" />

                                </h4>

                                <br>
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem>Mr.</asp:ListItem>
                                    <asp:ListItem>Ms.</asp:ListItem>
                                    <asp:ListItem>Mrs.</asp:ListItem>
                                    <asp:ListItem>Extra Mrs.</asp:ListItem>
                                </asp:DropDownList>
                                <h4><b>First Name:<asp:TextBox ID="firstNameText" runat="server"></asp:TextBox></h4>
                                <h4><b>Middle Name:<asp:TextBox ID="middleNameText" runat="server"></asp:TextBox></h4>
                                <h4><b>Last Name:<asp:TextBox ID="lastNameText" runat="server"></asp:TextBox></h4>
                                <h4><b>Date of Birth:<asp:TextBox ID="birthdayText" runat="server" ReadOnly="True"></asp:TextBox>
                                    <asp:ImageButton ID="birthdayButton" runat="server" Height="25px" ImageUrl="~/calendar-512.png" />
                                    <asp:Calendar ID="birthdayCalendar" runat="server" Visible="False"></asp:Calendar>
                                    <br/>
                                    <br/>
                                    <br/>
                                    <h4><b>In case of emergency, please notify,</h4>
                                    <h4><b>Name:<asp:TextBox ID="emergencyName" runat="server"></asp:TextBox></h4>

                                    <h4><b>Address:<asp:TextBox ID="emergencyAddress" runat="server"></asp:TextBox></h4>
                                    <h4><b>Contact No:<asp:TextBox ID="emergencyContact" runat="server"></asp:TextBox></h4>
                            </ul>
                            <br>
                        </div>
                    </div>

                    <div class="container-fluid">
                        <div class="row content">
                            <div class="col-sm-6">
                                <h2 class="Details">Login Information</h2>
                                <br />
                                <ul>
                                    <h4><b>UserName:<asp:TextBox ID="userNameText" runat="server"></asp:TextBox></h4>
                                    <h4><b>Email:<asp:TextBox ID="emailText" runat="server"></asp:TextBox></h4>
                                    <h4><b>Confirm Email:
                                        <asp:TextBox ID="confirmEmailText" runat="server"></asp:TextBox></h4>
                                    <h4><b>Password:<asp:TextBox ID="passwordText" runat="server"></asp:TextBox></h4>
                                    <h4><b>Confirm Password:<asp:TextBox ID="confirmPassText" runat="server"></asp:TextBox></h4>
                                </ul>

                                <br>
                                </span>
                            </div>
                        </div>
                        <br>
                        <div class="container">
                            <div class="row content">
                                <div class="auto-style2">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Button ID="Button1" runat="server" Text="Create" BackColor="#333333" ForeColor="White" Width="90px" />
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
    </form>


    <footer class="container-fluid">

        <center>The information contained herein is the confidential and proprietary property of Computer Aid, Incorporated.</center>

    </footer>

</body>
</html>
