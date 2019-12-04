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
        .auto-style1 {
            font-size: x-large;
        }

        .auto-style2 {
            width: 100%;
            height: 43px;
        }

        .auto-style3 {
            width: 268px;
        }

        .auto-style4 {
            width: 319px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Image ID="maintenanceIcon" runat="server" Height="25px" ImageUrl="~/Settings_black-512.png" />
        &nbsp;<span class="auto-style1">USER MAINTENANCE</span><div>

            <br />
            <center><asp:Button ID="addUserButton" runat="server" Text="Add New User" /></center>

        </div>
        <br />
        <div>
            <table cellspacing="3" class="auto-style2">
                <tr style="text-align:center">
                    <td class="auto-style3">Search By:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="41px" Width="300px">
                            <asp:ListItem>Username</asp:ListItem>
                            <asp:ListItem>E-Mail Address</asp:ListItem>
                            <asp:ListItem>Name</asp:ListItem>
                            <asp:ListItem>Contact Number</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" MaxLength="100" Width="301px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div>
            <center>
                <asp:Button ID="searchButton" runat="server" Text="Search" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="clearButton" runat="server" Text="Clear" />
            </center>
        </div>
        <div>



        </div>
        <nav aria-label="Page navigation example" style="text-align:right">
            <ul class="pagination justify-content-center">
                <li class="page-item disabled">
                    <a class="page-link" href="#" tabindex="-1" aria-disabled="true">Previous</a>
                </li>
                <li class="page-item"><a class="page-link" href="#">1</a></li>
                <li class="page-item"><a class="page-link" href="#">2</a></li>
                <li class="page-item"><a class="page-link" href="#">3</a></li>
                <li class="page-item">
                    <a class="page-link" href="#">Next</a>
                </li>
            </ul>
        </nav>
    </form>
</body>
</html>
