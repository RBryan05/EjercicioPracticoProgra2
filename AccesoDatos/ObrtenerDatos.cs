using AccesoDatos.AdventureWorks2019DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ObtenerDatos
    {
        private string connectionString = "Data Source=DESKTOP-03PS3SB\\SQLEXPRESS;Initial Catalog=AdventureWorks2019;Integrated Security=True";

        public void AgregarBusinessEntityID()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string sql = @"
                INSERT INTO [Person].[BusinessEntity] 
                (RowGuid, ModifiedDate)
                VALUES
                (@RowGuid, @ModifiedDate)";

                try
                {
                    using (SqlCommand comando = new SqlCommand(sql, conexion))
                    {
                        // Asignar valores a los parámetros, manejando valores nulos con condicionales
                        comando.Parameters.AddWithValue("@RowGuid", Guid.NewGuid()); // Genera un nuevo GUID
                        comando.Parameters.AddWithValue("@ModifiedDate", DateTime.Now);

                        // Abrir la conexión
                        conexion.Open();

                        // Ejecutar el comando
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Registro agregado exitosamente.");
                            conexion.Close();
                        }
                        else
                        {
                            Console.WriteLine("No se pudo agregar el registro.");
                            conexion.Close();
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Ocurrio un error");
                }

            }
        }

        public string AgregarPersona(int BusinessEntityID, string personType, bool nameStyle, string title, string firstName, string middleName, string lastName, string suffix, int emailPromotion)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string sql = @"
                INSERT INTO [Person].[Person] 
                (BusinessEntityID, PersonType, NameStyle, Title, FirstName, MiddleName, LastName, Suffix, EmailPromotion, rowguid, ModifiedDate)
                VALUES
                (@BusinessEntityID, @PersonType, @NameStyle, @Title, @FirstName, @MiddleName, @LastName, @Suffix, @EmailPromotion, @RowGuid, @ModifiedDate)";

                
                    using (SqlCommand comando = new SqlCommand(sql, conexion))
                    {
                        // Asignar valores a los parámetros, manejando valores nulos con condicionales
                        comando.Parameters.AddWithValue("BusinessEntityID", BusinessEntityID);
                        comando.Parameters.AddWithValue("@PersonType", personType);
                        comando.Parameters.AddWithValue("@NameStyle", nameStyle);
                        comando.Parameters.AddWithValue("@Title", string.IsNullOrEmpty(title) ? (object)DBNull.Value : title);
                        comando.Parameters.AddWithValue("@FirstName", firstName);
                        comando.Parameters.AddWithValue("@MiddleName", string.IsNullOrEmpty(middleName) ? (object)DBNull.Value : middleName);
                        comando.Parameters.AddWithValue("@LastName", lastName);
                        comando.Parameters.AddWithValue("@Suffix", string.IsNullOrEmpty(suffix) ? (object)DBNull.Value : suffix);
                        comando.Parameters.AddWithValue("@EmailPromotion", emailPromotion);
                        comando.Parameters.AddWithValue("@RowGuid", Guid.NewGuid()); // Genera un nuevo GUID
                        comando.Parameters.AddWithValue("@ModifiedDate", DateTime.Now);

                        // Abrir la conexión
                        conexion.Open();

                        // Ejecutar el comando
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Registro agregado exitosamente.");
                            conexion.Close();
                            return "true";
                        }
                        else
                        {
                            Console.WriteLine("No se pudo agregar el registro.");
                            conexion.Close();
                            return "false";
                        }
                    }
                

            }
        }

        public List<Person> ObtenerPersonas()
        {
            var personas = new List<Person>();

            SqlConnection conexion = new SqlConnection
                (connectionString);

            conexion.Open();

            String sql = "";
            sql = sql + "SELECT [BusinessEntityID] " + "\n";
            sql = sql + "      ,[PersonType] " + "\n";
            sql = sql + "      ,[NameStyle] " + "\n";
            sql = sql + "      ,[Title] " + "\n";
            sql = sql + "      ,[FirstName] " + "\n";
            sql = sql + "      ,[MiddleName] " + "\n";
            sql = sql + "      ,[LastName] " + "\n";
            sql = sql + "      ,[Suffix] " + "\n";
            sql = sql + "      ,[EmailPromotion] " + "\n";
            sql = sql + "      ,[AdditionalContactInfo] " + "\n";
            sql = sql + "      ,[Demographics] " + "\n";
            sql = sql + "      ,[rowguid] " + "\n";
            sql = sql + "      ,[ModifiedDate] " + "\n";
            sql = sql + "  FROM [Person].[Person]";

            SqlCommand lector = new SqlCommand(sql, conexion);
            SqlDataReader reader = lector.ExecuteReader();

            while (reader.Read())
            {
                var persona = new Person
                {
                    BusinessEntityID = Convert.ToInt32(reader["BusinessEntityID"]),
                    PersonType = reader["PersonType"].ToString(),
                    NameStyle = Convert.ToBoolean(reader["NameStyle"]),
                    Title = reader["Title"].ToString(),
                    FirstName = reader["FirstName"].ToString(),
                    MiddleName = reader["MiddleName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Suffix = reader["Suffix"].ToString(),
                    EmailPromotion = Convert.ToInt32(reader["EmailPromotion"]),
                    AdditionalContactInfo = reader["AdditionalContactInfo"] as string,
                    Demographics = reader["Demographics"] as string,
                    Rowguid = Guid.Parse(reader["rowguid"].ToString()),
                    ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"])
                };

                personas.Add(persona);
            }
            conexion.Close();

            return personas;
        }

    }
}
