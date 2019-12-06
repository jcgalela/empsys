using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSysLibrary
{
    public class Search
    {
        public string SearchQuery(string drop, string type)
        {
            string query = string.Empty;

            if (drop == "(Default)")
            {
                query = "SELECT * FROM Employee";
            }
            else if (drop == "Username")
            {
                query = "SELECT * FROM Employee WHERE userName = '" + type + "'";
            }
            else if (drop == "Name")
            {
                query = "SELECT * FROM Employee WHERE lastName = '" + type + "'";
            }
            else if (drop == "Contact_Number")
            {
                query = "SELECT* FROM Employee WHERE emergencyContact = '" + type + "'";
            }
            else if (drop == "E-Mail_Address")
            {
                query = "SELECT* FROM Employee WHERE email = '" + type + "'";
            }

            return query;
        }

        public DataTable UserSearch(string query)
        {
            string connectionString = @"Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
            sqlDa.Fill(dtbl);
            return dtbl;
        }
    }
}

