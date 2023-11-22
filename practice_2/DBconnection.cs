using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace practice_2
{
    public class DBconnection
    {

        public SqlConnection createConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection();
            return con;
        }
    }
}