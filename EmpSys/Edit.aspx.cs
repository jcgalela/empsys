using EmpSysLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EmpSys
{
    public partial class Edit : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            string employeeId = Request.QueryString["employeeId"];
            string connectionString = @"Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2";
            SqlConnection sqlCon = new SqlConnection(connectionString);

            string selectSql = "select * from Employee where employeeId =" + employeeId;
            SqlCommand command = new SqlCommand(selectSql, sqlCon);

            try
            {
                sqlCon.Open();

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        firstNameText.Text = (dataReader["firstName"].ToString()); ;
                        middleNameText.Text = (dataReader["middleName"].ToString());
                        lastNameText.Text = (dataReader["lastName"].ToString());
                        birthdayText.Text = (dataReader["birthday"].ToString());
                        emergencyName.Text = (dataReader["emergencyName"].ToString());
                        emergencyAddress.Text = (dataReader["emergencyAddress"].ToString());
                        emergencyContact.Text = (dataReader["emergencyContact"].ToString());
                        DropDownList2.SelectedValue = (dataReader["employeeStatus"].ToString());
                        sssText.Text = (dataReader["sssnum"].ToString());
                        tinText.Text = (dataReader["tinnum"].ToString());
                        dateEmployedText.Text = (dataReader["dateEmployed"].ToString());
                        fromText.Text = (dataReader["dateFrom"].ToString());
                        toText.Text = (dataReader["dateTo"].ToString());
                        userNameText.Text = (dataReader["userName"].ToString());
                        emailText.Text = (dataReader["email"].ToString());
                        empIdText.Text = (dataReader["employeeId"].ToString());
                    }
                }
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                CultureInfo provider = CultureInfo.InvariantCulture;
                string fName = firstNameText.Text;
                string MName = middleNameText.Text;
                string lName = lastNameText.Text;
                string bdate = birthdayText.Text;
                string name = emergencyName.Text;
                string address = emergencyAddress.Text;
                Int64 contact = Convert.ToInt64(emergencyContact.Text);
                string drop = DropDownList2.SelectedValue;
                Int64 sss = Convert.ToInt64(sssText.Text);
                Int64 tin = Convert.ToInt64(tinText.Text);
                string dateEmp = dateEmployedText.Text;
                string from = fromText.Text;
                string to = toText.Text;
                string Uname = userNameText.Text;
                string email = emailText.Text;
                string employeeId = empIdText.Text;

                Update update = new Update();
                update.DbUpdate(fName, MName, lName, bdate, name, address, contact, drop, sss, tin, dateEmp, from, to, 0, Uname,
                    email, 0, employeeId);

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Updated Successfully')", true);
                Response.Redirect("/Maintenance.aspx");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred." + ex.Message);
            }
        }

        public void fromButton_Click(object sender, ImageClickEventArgs e)
        {
            if (fromCalendar.Visible == false)
            {
                fromCalendar.Visible = true;
            }
            else if (fromCalendar.Visible == true)
            {
                fromCalendar.Visible = false;
            }
        }
        public void toButton_Click(object sender, ImageClickEventArgs e)
        {
            if (toCalendar.Visible == false)
            {
                toCalendar.Visible = true;
            }
            else if (toCalendar.Visible == true)
            {
                toCalendar.Visible = false;
            }
        }
        public void birthdayButton_Click(object sender, ImageClickEventArgs e)
        {
            if (birthdayCalendar.Visible == false)
            {
                birthdayCalendar.Visible = true;
            }
            else if (birthdayCalendar.Visible == true)
            {
                birthdayCalendar.Visible = false;
            }
        }
        public void dateEmployedButton_Click(object sender, ImageClickEventArgs e)
        {
            if (dateEmployedCalendar.Visible == false)
            {
                dateEmployedCalendar.Visible = true;
            }
            else if (dateEmployedCalendar.Visible == true)
            {
                dateEmployedCalendar.Visible = false;
            }
        }
        public void fromCalendar_SelectionChanged(object sender, EventArgs e)
        {
            fromText.Text = fromCalendar.SelectedDate.ToString("MM/dd/yyyy");
            fromCalendar.Visible = false;
            fromButton.Visible = true;
        }
        public void toCalendar_SelectionChanged(object sender, EventArgs e)
        {
            toText.Text = toCalendar.SelectedDate.ToString("MM/dd/yyyy");
            toCalendar.Visible = false;
            toButton.Visible = true;
        }
        public void birthdayCalendar_SelectionChanged(object sender, EventArgs e)
        {
            birthdayText.Text = birthdayCalendar.SelectedDate.ToString("MM/dd/yyyy");
            birthdayCalendar.Visible = false;
            birthdayButton.Visible = true;
        }
        public void dateEmployedCalendar_SelectionChanged(object sender, EventArgs e)
        {
            dateEmployedText.Text = dateEmployedCalendar.SelectedDate.ToString("MM/dd/yyyy");
            dateEmployedCalendar.Visible = false;
            dateEmployedButton.Visible = true;
        }
    }
}