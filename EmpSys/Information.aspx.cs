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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string drop = DropDownList2.SelectedValue;
            string id = empIdText.Text;
            string sss = sssText.Text;
            string tin = tinText.Text;
            string dateEmp = dateEmployedText.Text;
            string from = fromText.Text;
            string to = TextBox1.Text;
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
    }
}