using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpSys
{
    public partial class Information : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            string drop = DropDownList2.SelectedValue;
            string id = empIdText.Text;
            string sss = sssText.Text;
            string tin = tinText.Text;
            string dateEmp = dateEmployedText.Text;
            string from = fromText.Text;
            string to = toText.Text;
            ///*Image signature = ImageButton2.Visible*/;
            string fName = firstNameText.Text;
            string MName = middleNameText.Text;
            string lName = lastNameText.Text;
            string bdate = birthdayText.Text;
            string name = emergencyName.Text;
            string contact = emergencyContact.Text;
            string address = emergencyAddress.Text;

            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2";

            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into Employee(employeeStatus,employeeId,firstName,middleName,lastName,birthday,emergencyName,emergencyAddress," +
                "emergencyContact,sssnum,tinnum,dateEmployed,dateFrom,dateTo,signature,userName,email,password,image)" +
                "Values(drop,id,sss,tin,dateEmp,from,to,fName,MName,lName,bdate,name,contact,address)";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

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


    }
}