using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSysLibrary
{
    public class Search
    {
        public string Drop(string type)
        {
            string drop = "";

            if (type == "Username")
            {
                drop = "userName";
            }
            else if (type == "Name")
            {
                drop = "lastName";
            }
            else if (drop == "Contact_Number")
            {
                drop = "emergencyContact";
            }
            else if (drop == "E-Mail_Address")
            {
                drop = "email";
            }
            return drop;
        }
        public void SearchUser(string drop, string type)
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

                sql = "Select * from Employee where " + drop + "= " + type;
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                cnn.Close();

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

    }
}

