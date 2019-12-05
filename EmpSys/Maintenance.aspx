<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Maintenance.aspx.cs" Inherits="EmpSys.Maintenance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Maintenance</title>
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

        .auto-style1 {
            font-family: Verdana, Geneva, sans-serif;
            font-weight: bold;
            font-size: xx-large;
        }

        .searchby {
            margin: auto;
            border: 2px solid;
            border-color: Gray;
            border-left-width: 2px;
            border-right-width: 2px;
        }

        .panel {
            margin: auto;
            border: 3px solid;
            border-color: black;
        }

        .auto-style6 {
            width: 94%;
            height: 97px;
            margin-left: 32px;
            margin-top: 0px;
        }

        .auto-style7 {
            width: 153px;
            text-align: center;
            font-family: Verdana, Geneva, sans-serif;
            font-size: 18px;
            font-weight: bold;
        }

        .auto-style8 {
            width: 279px;
            text-align: center;
        }

        .auto-style10 {
            margin-right: -15px;
            margin-left: -15px;
            text-align: center;
            font-family: Verdana, Geneva, sans-serif;
            font-size: 18px;
        }

        .search {
            font-family: Verdana, Geneva, sans-serif;
            font-size: 18px;
        }

        .clear {
            font-family: Verdana, Geneva, sans-serif;
            font-size: 18px;
        }

        .auto-style11 {
            border-radius: 4px;
            -webkit-box-shadow: 0 1px 1px rgba(0, 0, 0, .05);
            box-shadow: 0 1px 1px rgba(0, 0, 0, .05);
            border: 3px solid black;
            margin: auto;
            background-color: #fff;
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


    <form id="form1" runat="server">

        <div class="content">
            <p></p>
            <p></p>
        </div>

        <div class="container">
            <div class="container">
                <div class="row content">
                    &nbsp;
                    <asp:Image ID="Image1" runat="server" Height="40px" ImageUrl="~/Settings_black-512.png" />
                    <span class="auto-style1">USER MAINTENANCE</span>
                    <br />
                    <br />
                    <br />
                </div>
            </div>
        </div>

        <div class="container">
            <div class="auto-style10">
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="addUserButton" runat="server" Text="Add New User" BackColor="#333333" BorderColor="#333333" ForeColor="White" Height="41px" Width="144px" OnClick="addUserButton_Click" />
            </div>
        </div>
        <br />

        <div class="container">
            <asp:Panel ID="Panel1" runat="server" CssClass="auto-style11" Height="155px" Width="928px">
                &nbsp;<table class="auto-style6">
                    <tr>
                        <td class="auto-style7">Search By:</td>
                        <td class="auto-style8">&nbsp;<asp:DropDownList ID="searchDropDown" runat="server" CssClass="auto-style9" Height="30px" Width="256px">
                            <asp:ListItem>Username</asp:ListItem>
                            <asp:ListItem>E-Mail_Address</asp:ListItem>
                            <asp:ListItem>Name</asp:ListItem>
                            <asp:ListItem>Contact_Number</asp:ListItem>
                        </asp:DropDownList>
                            &nbsp;</td>
                        <td class="text-center">&nbsp;&nbsp;<asp:TextBox ID="searchTextBox" runat="server" MaxLength="100" Width="386px" Height="30px"></asp:TextBox>
                        </td>
                    </tr>
                </table>


            </asp:Panel>
        </div>

        <br />

        <div>
            <center>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="searchButton" runat="server" CssClass="search" Text="Search" BackColor="#333333" BorderColor="#333333" ForeColor="White" Height="41px" Width="82px" OnClick="searchButton_Click" />
                &nbsp;
                <asp:Button ID="clearButton" runat="server" CssClass="clear" Text="Clear" BackColor="#333333" BorderColor="#333333" ForeColor="White" Height="41px" Width="82px" OnClick="clearButton_Click" />
            </center>
        </div>
        <br />
        <br />
        <br />
        <div align="center">
            <nav aria-label="Page navigation example">
                <asp:GridView ID="dataGrid" runat="server" ShowHeaderWhenEmpty="true" AutoGenerateColumns="False" DataKeyNames="employeeId" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="1036px" OnSelectedIndexChanged="dataGrid_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="Username" SortExpression="Username">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("userName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Name" SortExpression="Name">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("firstName") %>'></asp:Label>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("middleName") %>'></asp:Label>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("lastName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="E-Mail Address" SortExpression="E-Mail Address">
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("email") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Mobile Number" SortExpression="Mobile Number">
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("emergencyContact") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="User Status" SortExpression="User Status">
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" Text='<%# Eval("employeeStatus") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:Button ID="editButton" runat="server" CausesValidation="false" CommandName="Edit" Text="Edit" />
                                <asp:Button ID="deleteButton" runat="server" CausesValidation="false" CommandName="Delete" Text="Delete" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <%--<asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:EISConnectionStrings %>" SelectCommand="SELECT [userName], [firstName], [middleName], [lastName], [email], [emergencyContact], [employeeStatus] FROM [Employee]"></asp:SqlDataSource>
               --%>
            </nav>
        </div>
    </form>
</body>
</html>
