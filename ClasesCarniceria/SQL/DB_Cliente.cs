using System.Data.SqlClient;

namespace ClasesCarniceria
{
    public static class DB_Cliente
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;


        static DB_Cliente()
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
        public static List<Cliente> Leer_clientes()
        {
            List<Cliente> clientesAux = new List<Cliente>();
            try
            {
                command.Parameters.Clear();
                // Abrimos la conexion.
                connection.Open();
                // Consultamos.
                command.CommandText = "SELECT * FROM Usuario where Usuario.Id_tipoDeUsuario = 1";
                // Esto ejecuta una consulta en la base de datos.
                SqlDataReader dataReader = command.ExecuteReader();
                // Se puede iterar sobre los resultados utilizando métodos como Read() para avanzar a la siguiente fila 
                while (dataReader.Read())
                {
                    clientesAux.Add(new Cliente(dataReader["Mail"].ToString(), dataReader["Contraseña"].ToString(), (decimal)dataReader["Cantidad_dinero"]));
                }
                return clientesAux;
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

        public static Cliente Leer_cliente(string mail, string contraseña)
        {
            Cliente c = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM Usuario where Usuario.Id_tipoDeUsuario = 1 and Usuario.Mail = @Mail and Usuario.Contraseña = @Contraseña";
                command.Parameters.AddWithValue("@Mail", mail);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    c = new Cliente(dataReader["Mail"].ToString(), dataReader["Contraseña"].ToString(), (decimal)dataReader["Cantidad_dinero"]);
                }
                return c;
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

        public static void Agregar_cliente(Cliente c, decimal monto)
        {
            if (Mail_cliente_existe(c.Mail))
            {
                throw new Exception("El Mail ya existe");
            }
            else
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = "INSERT INTO Usuario(Mail, Contraseña, Id_tipoDeUsuario, Cantidad_dinero) values (@mail, @contra, @id, @monto)";
                    command.Parameters.AddWithValue("@mail", c.Mail);
                    command.Parameters.AddWithValue("@contra", c.Contraseña);
                    command.Parameters.AddWithValue("@monto", c.CantidadDinero);
                    command.Parameters.AddWithValue("@id", 1);

                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally { connection.Close(); }

            }
        }

        public static bool Modificar_contraseña_cliente(string mail, string nuevaContraseña)
        {
            if (Mail_cliente_existe(mail))
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();

                    command.CommandText = $"UPDATE Usuario SET Usuario.Contraseña = @Contra WHERE Usuario.Mail = @Mail and Usuario.Id_tipoDeUsuario = 1";

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
            if (Mail_cliente_existe(nuevoMail))
            {
                throw new Exception("El Mail ya existe");
            }
            else if (Mail_cliente_existe(mailActual))
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = $"UPDATE Usuario SET Usuario.Mail = @nuevoMail where Usuario.Mail = @mailActual and Usuario.Id_tipoDeUsuario = 1";
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

        public static bool Modificar_monto_cliente(Cliente c, decimal montoNuevo)
        {
            if (Mail_cliente_existe(c.Mail))
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = $"UPDATE Usuario SET Usuario.Cantidad_dinero = @monto where Usuario.Id_tipoDeUsuario = 1 and Mail = @mail and Contraseña = @contra";
                    command.Parameters.AddWithValue("@monto", montoNuevo);
                    command.Parameters.AddWithValue("@mail", c.Mail);
                    command.Parameters.AddWithValue("@contra", c.Contraseña);
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

        public static bool Mail_cliente_existe(string mail)
        {
            Cliente cAux = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM Usuario where Usuario.Id_tipoDeUsuario = 1 and Usuario.Mail = @Mail";
                command.Parameters.AddWithValue("@Mail", mail);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cAux = (new Cliente(dataReader["Mail"].ToString(), dataReader["Contraseña"].ToString()));
                }
                return cAux != null;
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
            Cliente cAux = null;
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM Usuario where Usuario.Id_tipoDeUsuario = 1 and Usuario.Contraseña = @Contraseña";
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cAux = (new Cliente(dataReader["Mail"].ToString(), dataReader["Contraseña"].ToString()));
                }
                return cAux != null;
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

        public static void Borrar_cliente(string mail, string contraseña)
        {
            if (Mail_cliente_existe(mail) && Contraseña_vendedor_existe(contraseña))
            {
                try
                {
                    connection.Open();
                    command.Parameters.Clear();
                    command.CommandText = "DELETE from Usuario where Id_tipoDeUsuario = 1 and Mail = @Mail and Contraseña = @Contraseña";
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
                throw new Exception("Los datos ingresados son invalidos. No corresponden a ningun Cliente.");
            }
        }




    }
}

