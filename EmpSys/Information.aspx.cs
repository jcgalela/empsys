using EmpSysLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace EmpSys
{
    public partial class Information : System.Web.UI.Page
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

        protected void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                CultureInfo provider = CultureInfo.InvariantCulture;
                string drop = DropDownList2.SelectedValue;
                string id = empIdText.Text;
                long sss = Convert.ToInt64(sssText.Text);
                long tin = Convert.ToInt64(tinText.Text);

                string dateEmp = DateTime.ParseExact(dateEmployedText.Text, "MM/dd/yyyy", provider).ToShortDateString();
                string from = DateTime.ParseExact(fromText.Text, "MM/dd/yyyy", provider).ToShortDateString();
                string to = DateTime.ParseExact(toText.Text, "MM/dd/yyyy", provider).ToShortDateString();
                string fName = firstNameText.Text;
                string MName = middleNameText.Text;
                string lName = lastNameText.Text;
                string bdate = DateTime.ParseExact(birthdayText.Text, "MM/dd/yyyy", provider).ToShortDateString();
                string name = emergencyName.Text;
                long contact = Convert.ToInt64(emergencyContact.Text);
                string address = emergencyAddress.Text;
                string Uname = userNameText.Text;
                string email = emailText.Text;
                string password = passwordText.Text;
                string confirm = confirmPassText.Text;
                if(password != confirm)
                {
                    MessageBox.Show("Passwords not match.");
                }
                DBRelated db = new DBRelated();
                db.DbInsert(id, fName, MName, lName, bdate, name, address, contact, drop, sss,
                    tin, dateEmp, from, to, 0, Uname, email, password, 0);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred." + ex.Message);
                Response.Redirect("/Information.aspx");
            }
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
            Response.Redirect("/Maintenance.aspx");
        }
        protected void fromButton_Click(object sender, ImageClickEventArgs e)
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
        protected void toButton_Click(object sender, ImageClickEventArgs e)
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
        protected void birthdayButton_Click(object sender, ImageClickEventArgs e)
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
        protected void dateEmployedButton_Click(object sender, ImageClickEventArgs e)
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
        protected void fromCalendar_SelectionChanged(object sender, EventArgs e)
        {
            fromText.Text = fromCalendar.SelectedDate.ToString("MM/dd/yyyy");
            fromCalendar.Visible = false;
            fromButton.Visible = true;
        }
        protected void toCalendar_SelectionChanged(object sender, EventArgs e)
        {
            toText.Text = toCalendar.SelectedDate.ToString("MM/dd/yyyy");
            toCalendar.Visible = false;
            toButton.Visible = true;
        }
        protected void birthdayCalendar_SelectionChanged(object sender, EventArgs e)
        {
            birthdayText.Text = birthdayCalendar.SelectedDate.ToString("MM/dd/yyyy");
            birthdayCalendar.Visible = false;
            birthdayButton.Visible = true;
        }
        protected void dateEmployedCalendar_SelectionChanged(object sender, EventArgs e)
        {
            dateEmployedText.Text = dateEmployedCalendar.SelectedDate.ToString("MM/dd/yyyy");
            dateEmployedCalendar.Visible = false;
            dateEmployedButton.Visible = true;
        }


    }
}
    
