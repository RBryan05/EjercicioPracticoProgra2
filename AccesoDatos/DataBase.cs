using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    internal class DataBase
    {
        public static string ConnectionString
        {
            get
            {
                string CadenaConexion = ConfigurationManager
                   .ConnectionStrings["CRUD"]
                   .ConnectionString;

                SqlConnectionStringBuilder conexionBuilder =
                    new SqlConnectionStringBuilder(CadenaConexion);

                conexionBuilder.ApplicationName =
                    ApplicationName ?? conexionBuilder.ApplicationName;

                conexionBuilder.ConnectTimeout = (ConnectionTimeout > 0)
                    ? ConnectionTimeout : conexionBuilder.ConnectTimeout;
                return conexionBuilder.ToString();
            }


        }
        public static int ConnectionTimeout { get; set; }
        public static string ApplicationName { get; set; }

        public static SqlConnection GetSqlConnection()
        {

            SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();
            return conexion;

        }
    }
}
