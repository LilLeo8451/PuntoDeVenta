using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PuntoDeVenta
{
    public static class DbConnection
    {
        private static string connectionString = "Server=localhost;Database=PuntoDeVenta;Uid=root;Pwd=root;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
