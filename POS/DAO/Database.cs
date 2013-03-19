using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace POS.DAO
{
    class Database
    {
        private string MySqlConnectionString = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.opencartConnectionString"].ConnectionString;

        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = null;
            connection = new MySqlConnection(MySqlConnectionString);

            return connection;
        }
    }
}
