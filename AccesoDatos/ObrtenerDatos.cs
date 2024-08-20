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
        public void AgregarBusinessEntityID()
        {
            using (var conexion = DataBase.GetSqlConnection())
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

                        // Ejecutar el comando
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Registro agregado exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo agregar el registro.");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Ocurrio un error");
                }

            }
        }

        public int EliminarPersona(int BusinessEntityID)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                string sql = @"
                DELETE FROM [Person].[Person] 
                WHERE BusinessEntityID = @BusinessEntityID";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    // Asignar valores a los parámetros, manejando valores nulos con condicionales
                    comando.Parameters.AddWithValue("BusinessEntityID", BusinessEntityID);

                    // Ejecutar el comando
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("Registro eliminado exitosamente.");
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine("No se pudo eliminar el registro.");
                        return 0;
                    }
                }
            }
        }

        public int EditarRegistro(int BusinessEntityID, string personType, bool nameStyle, string title, string firstName, string middleName, string lastName, string suffix, int emailPromotion)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String sql = "";
                sql = sql + "UPDATE [Person].[Person] " + "\n";
                sql = sql + "   SET [PersonType] = @personType " + "\n";
                sql = sql + "      ,[NameStyle] = @nameStyle " + "\n";
                sql = sql + "      ,[Title] = @title " + "\n";
                sql = sql + "      ,[FirstName] = @firstName " + "\n";
                sql = sql + "      ,[MiddleName] = @middleName " + "\n";
                sql = sql + "      ,[LastName] = @lastName " + "\n";
                sql = sql + "      ,[Suffix] = @suffix " + "\n";
                sql = sql + "      ,[EmailPromotion] = @emailPromotion " + "\n";
                sql = sql + "      ,[ModifiedDate] = @ModifiedDate " + "\n";
                sql = sql + " WHERE [BusinessEntityID] = @BusinessEntityID";

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
                    comando.Parameters.AddWithValue("@ModifiedDate", DateTime.Now);

                    // Ejecutar el comando
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("Registro eliminado exitosamente.");
                        return filasAfectadas;
                    }
                    else
                    {
                        Console.WriteLine("No se pudo eliminar el registro.");
                        return 0;
                    }
                }
            }
        }

        public string AgregarPersona(int BusinessEntityID, string personType, bool nameStyle, string title, string firstName, string middleName, string lastName, string suffix, int emailPromotion)
        {
            using (var conexion = DataBase.GetSqlConnection())
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

        List<Person> personas = new List<Person>();
        public List<Person> ObtenerPersonas()
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
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

                using (SqlCommand lector = new SqlCommand(sql, conexion))
                {
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
                    return personas;
                }
            }
        }

        public Person ObtenerPorID(int businessEntityID)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                string sql = "";
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
                sql = sql + "  FROM [Person].[Person] " + "\n";
                sql = sql + " WHERE [BusinessEntityID] = @BusinessEntityID";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    // Añadir parámetro para BusinessEntityID
                    comando.Parameters.AddWithValue("@BusinessEntityID", businessEntityID);

                    SqlDataReader reader = comando.ExecuteReader();
                    

                    if (reader.Read())
                    {
                        // Asignar valores a las propiedades del objeto Person                
                        Person personaPorID = new Person
                        {
                            BusinessEntityID = reader["BusinessEntityID"] != DBNull.Value ? Convert.ToInt32(reader["BusinessEntityID"]) : 0,
                            PersonType = reader["PersonType"] != DBNull.Value ? reader["PersonType"].ToString() : string.Empty,
                            NameStyle = reader["NameStyle"] != DBNull.Value && Convert.ToBoolean(reader["NameStyle"]),
                            Title = reader["Title"] != DBNull.Value ? reader["Title"].ToString() : string.Empty,
                            FirstName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : string.Empty,
                            MiddleName = reader["MiddleName"] != DBNull.Value ? reader["MiddleName"].ToString() : string.Empty,
                            LastName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : string.Empty,
                            Suffix = reader["Suffix"] != DBNull.Value ? reader["Suffix"].ToString() : string.Empty,
                            EmailPromotion = reader["EmailPromotion"] != DBNull.Value ? Convert.ToInt32(reader["EmailPromotion"]) : 0,
                            AdditionalContactInfo = reader["AdditionalContactInfo"] != DBNull.Value ? reader["AdditionalContactInfo"] as string : null,
                            Demographics = reader["Demographics"] != DBNull.Value ? reader["Demographics"] as string : null,
                            Rowguid = reader["rowguid"] != DBNull.Value ? Guid.Parse(reader["rowguid"].ToString()) : Guid.Empty,
                            ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? Convert.ToDateTime(reader["ModifiedDate"]) : DateTime.MinValue
                        };
                        return personaPorID;
                    }

                    else
                    {
                        // Si no se encuentra ningún registro
                        return null;
                    }
                }
            }
        }

        public List<Person> Filtrar(string palabra)
        {
            ObtenerPersonas();
            var filtro = personas.FindAll(x => x.FirstName.StartsWith(palabra));
            return filtro;
        }

    }
}
