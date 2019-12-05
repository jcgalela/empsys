using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpSys
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (Session["UserName"] != null)
                {
                    this.lblWelcomeMessage.Text = string.Format("Welcome, {0}", Session["UserName"].ToString());
                }
            }
        }

        protected void changePasswordButton_Click(object sender, EventArgs e)
        {
            
            string currentPassword = currentPassText.Text;
            string newPassword = newPassText.Text;
            string confirmPassword = confirmNewPassText.Text;

            lblmsg.Text = "";
            SqlConnection SQLConn = new SqlConnection("Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2");
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("select * from Employee where password='" + currentPassword + "'", SQLConn);
            DataTable DT = new DataTable();
            SQLAdapter.Fill(DT);

            if (DT.Rows.Count == 0)
            {
                lblmsg.Text = "Invalid Current Password!!";

            }
            else
            {
                SQLAdapter = new SqlDataAdapter("update Employee set password='" + newPassword + "' where userName='" + Session["userName"].ToString() + "'", SQLConn);
                SQLAdapter.Fill(DT);
                lblmsg.Text = "Password changed successfully";

            }

        }
    }
}