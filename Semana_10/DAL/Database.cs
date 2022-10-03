using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using Semana_10.Properties;
using System.Threading.Tasks;
using System.Configuration;

namespace Semana_10.DAL
{
    public class Database
    {
        public static string getStrConnection()
        {
            return Settings.Default.empleadosConnectionString;
        }

        public SqlConnection GetConnection()
        {
            SqlConnection Con = new SqlConnection(getStrConnection());
            return Con;
        }
    }
}
