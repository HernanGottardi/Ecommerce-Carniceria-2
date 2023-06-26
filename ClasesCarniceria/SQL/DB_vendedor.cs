using System.Data.SqlClient;

namespace ClasesCarniceria
{
    public static class DB_vendedor
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;


        static DB_vendedor()
        {
            connectionString = @"Data Source = .;Database = Carniceria_DB; Trusted_Connection = True; TrustServerCertificate=True;";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            /*
             Esto indica que se utilizará texto plano como tipo de comando. En este caso, 
             se espera que se escriban consultas SQL como texto plano en el objeto command antes de ejecutarlas.
            */
            command.CommandType = System.Data.CommandType.Text;
        }
        public static List<Vendedor> Leer_vendedores()
        {
            List<Vendedor> vendedoresAux = new List<Vendedor>();
            try
            {
                command.Parameters.Clear();
                // Abrimos la conexion.
                connection.Open();
                // Consultamos.
                command.CommandText = "SELECT * FROM Usuario where Usuario.Id_tipoDeUsuario = 2";
                // Esto ejecuta una consulta en la base de datos.
                SqlDataReader dataReader = command.ExecuteReader();
                // Se puede iterar sobre los resultados utilizando métodos como Read() para avanzar a la siguiente fila 
                while (dataReader.Read())
                {
                    vendedoresAux.Add(new Vendedor(dataReader["Mail"].ToString(), dataReader["Contraseña"].ToString()));
                }
                return vendedoresAux;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Vendedor Leer_vendedor(string mail, string contraseña)
        {
            Vendedor v = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM Usuario where Usuario.Id_tipoDeUsuario = 2 and Usuario.Mail = @Mail and Usuario.Contraseña = @Contraseña";
                command.Parameters.AddWithValue("@Mail", mail);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    v = new Vendedor(dataReader["Mail"].ToString(), dataReader["Contraseña"].ToString());
                }
                return v;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool Agregar_vendedor(Vendedor v)
        {
            if (Mail_vendedor_existe(v.Mail))
            {
                return false;
            }
            else
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();

                    command.CommandText = "INSERT INTO Usuario(Mail, Contraseña, Id_tipoDeUsuario) values (@mail, @contra, @id)";
                    command.Parameters.AddWithValue("@mail", v.Mail);
                    command.Parameters.AddWithValue("@contra", v.Contraseña);
                    command.Parameters.AddWithValue("@id", 2);

                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
                finally { connection.Close(); }

            }
        }

        public static bool Modificar_contraseña_vendedor(string mail, string nuevaContraseña)
        {
            if (Mail_vendedor_existe(mail))
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();

                    command.CommandText = $"UPDATE Usuario SET Usuario.Contraseña = @Contra WHERE Usuario.Mail = @Mail and Usuario.Id_tipoDeUsuario = 2";

                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@Contra", nuevaContraseña);

                    command.ExecuteNonQuery();
                    return true;

                }
                catch (Exception) { throw; }
                finally { connection.Close(); }
            }
            else
            {
                return false;
            }

        }

        public static bool Modificar_mail_cliente(string nuevoMail, string mailActual)
        {
            if (Mail_vendedor_existe(nuevoMail))
            {
                throw new Exception("El Mail ya existe");
            }
            else if (Mail_vendedor_existe(mailActual))
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = $"UPDATE Usuario SET Usuario.Mail = @nuevoMail where Usuario.Mail = @mailActual and Usuario.Id_tipoDeUsuario = 2";
                    command.Parameters.AddWithValue("@nuevoMail", nuevoMail);
                    command.Parameters.AddWithValue("@mailActual", mailActual);
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception) { throw; }
                finally { connection.Close(); }
            }
            else
            {
                return false;
            }
        }

        public static bool Mail_vendedor_existe(string mail)
        {
            Vendedor vAux = null;
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = $"SELECT * FROM Usuario where Usuario.Id_tipoDeUsuario = 2 and Usuario.Mail COLLATE Latin1_General_CI_AI = @Mail COLLATE Latin1_General_CI_AI";
                command.Parameters.AddWithValue("@Mail", mail);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    vAux = (new Vendedor(dataReader["Mail"].ToString(), dataReader["Contraseña"].ToString()));
                }
                return vAux != null;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool Contraseña_vendedor_existe(string contraseña)
        {
            Vendedor vAux = null;
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = $"SELECT * FROM Usuario where Usuario.Id_tipoDeUsuario = 2 and Usuario.Contraseña = @Contraseña";
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    vAux = (new Vendedor(dataReader["Mail"].ToString(), dataReader["Contraseña"].ToString()));
                }
                return vAux != null;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Borrar_vendedor(string mail, string contraseña)
        {
            if (Mail_vendedor_existe(mail) && Contraseña_vendedor_existe(contraseña))
            {
                try
                {
                    connection.Open();
                    command.Parameters.Clear();
                    command.CommandText = "DELETE from Usuario where Id_tipoDeUsuario = 2 and Mail = @Mail and Contraseña = @Contraseña";
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }

                finally { connection.Close(); }
            }
            else
            {
                throw new Exception("Los datos no corresponden a ningun Vendedor.");
            }
        }


    }
}

