﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSysLibrary
{
    public class Search
    {
        
        public string SearchUser(string drop, string type)
        {
            string query = string.Empty;

            if (drop == "Username")
            {
                query = "SELECT* FROM Employee WHERE userName = '" + type + "'";
            }
            else if (drop == "Name")
            {
                query = "SELECT* FROM Employee WHERE lastName = '" + type + "'";
            }
            else if (drop == "Contact_Number")
            {
                query = "SELECT* FROM Employee WHERE emergencyContact = '" + type + "'";
            }
            else if (drop == "E-Mail_Address")
            {
                query = "SELECT* FROM Employee WHERE email = '" + type + "'";
            }
            else
            {
                query = "SELECT * FROM Employee";
            }
            return query;
        }

    }
}
