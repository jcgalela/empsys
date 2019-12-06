using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpSysLibrary
{
    public class DBRelated
    {
        public void DbInsert(string id,  string fName, string MName, string lName, DateTime bdate, string name, string address, Int64 contact, string drop,
            Int64 sss, Int64 tin, DateTime dateEmp, DateTime from, DateTime to, byte signature, string Uname, string email, string password, byte image)
        {
            try
            {
                #region connect
                string connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                String sql = "";
                #endregion
                sql = "Insert into Employee(employeeId," +
                    "firstName," +
                    "middleName," +
                    "lastName," +
                    "birthday," +
                    "emergencyName," +
                    "emergencyAddress," +
                    "emergencyContact," +
                    "employeeStatus," +
                    "sssnum," +
                    "tinnum," +
                    "dateEmployed," +
                    "dateFrom," +
                    "dateTo," +
                    "signature," +
                    "userName," +
                    "email," +
                    "password," +
                    "image) " +
                    "values ( '" + id + "','" + fName + "','" + MName + "','" + lName + "','" +  bdate + "','" + name + 
                    "','" + address + "','" + contact + "','" + drop + "','" + sss + "','" + tin + "','" + dateEmp + "','" + from + "','" + to 
                    + "','" + signature + "','" + Uname + "','" + email + "','" + password + "','" + image + "')";
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                cnn.Close();
                MessageBox.Show("Inserted SUccessfully");
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
