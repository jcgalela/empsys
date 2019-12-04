using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSysLibrary
{
    public class DBRelated
    {
        public void DbInsert(string drop, string id,  string fName, string MName, string lName, DateTime bdate, string name, 
            string address, string contact, string sss, string tin, DateTime dateEmp, DateTime from, DateTime to,  string Uname, string email, string password)
        {
            try
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = @"Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                String sql = "";

                sql = "Insert into Employee(employeeId," +
                    "employeeStatus," +
                    "firstName," +
                    "middleName," +
                    "lastName," +
                    "birthday," +
                    "emergencyName," +
                    "emergencyAddress," +
                    "emergencyContact," +
                    "sssnum," +
                    "tinnum," +
                    "dateEmployed," +
                    "dateFrom," +
                    "dateTo," +
                    "userName," +
                    "email," +
                    "password" +
                    ") " +
                    "values ( '" + id + "','" + drop + "','" + fName + "','" + MName + "','" + lName + "'," +
                    "'" + bdate + "','" + name + "','" + address + "','" + contact + "','" + sss + "'," +
                    "'" + tin + "','" + dateEmp + "','" + to + "','" + from + "','" + Uname + "','" + email + "','" + password + "')";
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                cnn.Close();
                
            } catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
    }
}
