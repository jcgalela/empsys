using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace EmpSysLibrary
{
    public class Update
    {
        public void DbUpdate(string fName, string MName, string lName, string bdate, string name, string address, Int64 contact, string drop,
            Int64 sss, Int64 tin, string dateEmp, string from, string to, byte signature, string Uname, string email, byte image, string employeeId)
        {
            try
            {
                #region connect
                string connectionString = @"Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                #endregion
                String sql = "Update Employee Set " +
                    "firstName = '" + fName + "', " +
                    "middleName = '" + MName + "', " +
                    "lastName = '" + lName + "', " +
                    "birthday = '" + bdate + "', " +
                    "emergencyName = '" + name + "', " +
                    "emergencyAddress = '" + address + "', " +
                    "emergencyContact = '" + contact + "', " +
                    "employeeStatus = '" + drop + "', " +
                    "sssnum = '" + sss + "', " +
                    "tinnum = '" + tin + "', " +
                    "dateEmployed = '" + dateEmp + "', " +
                    "dateFrom = '" + from + "', " +
                    "dateTo = '" + to + "', " +
                    "signature = '" + signature + "', " +
                    "userName = '" + Uname + "', " +
                    "email = '" + email + "', " +
                    "image = '" + image + "' " +
                    "where employeeId = '" + employeeId + "'";

                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("          An error occured.         " + "\n" + ex.Message);
            }
        }
    }
}
