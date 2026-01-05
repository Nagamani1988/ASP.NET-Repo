using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElectricityMiniProject
{
    public class DBHandler
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ElectricityBillDB;server=(localdb)\\MSSQLLocalDB");
            return con;
        }
    }
}