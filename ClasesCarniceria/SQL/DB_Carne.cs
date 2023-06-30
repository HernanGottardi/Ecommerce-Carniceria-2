using System.Data.SqlClient;

namespace ClasesCarniceria.SQL
{
    public static class DB_Carne
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;


        static DB_Carne()
        {
            connectionString = @"Data Source = .;Database = Carniceria_DB; Trusted_Connection = True; TrustServerCertificate=True;";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }
        public static List<Carne> Leer_carnes()
        {
            List<Carne> carnesAux = new List<Carne>();
            try
            {
                command.Parameters.Clear();
                // Abrimos la conexion.
                connection.Open();
                // Consultamos.
                command.CommandText = "SELECT * FROM Carne";
                // Esto ejecuta una consulta en la base de datos.
                SqlDataReader dataReader = command.ExecuteReader();
                // Se puede iterar sobre los resultados utilizando métodos como Read() para avanzar a la siguiente fila 
                while (dataReader.Read())
                {
                    carnesAux.Add(new Carne(((int)dataReader["Cantidad_kilos"]), dataReader["Tipo_de_corte"].ToString(), (decimal)dataReader["Precio_por_kilo"]));
                }
                return carnesAux;
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

        public static Carne Leer_carne(string tipo_corte)
        {
            Carne c = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM Carne WHERE Carne.Tipo_de_corte = @corte";
                command.Parameters.AddWithValue("@corte", tipo_corte);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    c = new Carne((int)dataReader["Cantidad_kilos"], dataReader["Tipo_de_corte"].ToString(), (decimal)dataReader["Precio_por_kilo"]);
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

        public static void Agregar_carne(Carne c)
        {
            if (Corte_existe(c.TipoDeCorte))
            {
                throw new Exception("El Corte de carne ya existe");
            }
            else
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = "INSERT INTO Carne(Cantidad_kilos, Tipo_de_corte, Precio_por_kilo) values (@kilos, @corte, @precio)";
                    command.Parameters.AddWithValue("@kilos", c.CantidadKilos);
                    command.Parameters.AddWithValue("@corte", c.TipoDeCorte);
                    command.Parameters.AddWithValue("@precio", c.PrecioPorKilo);

                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally { connection.Close(); }

            }
        }

        public static bool Modificar_CantidadKilos(Carne c, int nuevaCantidad)
        {
            if (Corte_existe(c.TipoDeCorte))
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = $"UPDATE Carne SET Carne.Cantidad_kilos = @kilos where Carne.Tipo_de_corte = @corte";
                    command.Parameters.AddWithValue("@kilos", nuevaCantidad);
                    command.Parameters.AddWithValue("@corte", c.TipoDeCorte);
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

        public static bool Modificar_Corte(Carne c, string nuevoCorte)
        {

            if (Corte_existe(nuevoCorte))
            {
                if (nuevoCorte.Equals(c.TipoDeCorte))
                {
                    try
                    {
                        command.Parameters.Clear();
                        connection.Open();
                        command.CommandText = $"UPDATE Carne SET Carne.Tipo_de_Corte = @nuevocorte where Carne.Tipo_de_corte = @corte ";
                        command.Parameters.AddWithValue("@nuevocorte", nuevoCorte);
                        command.Parameters.AddWithValue("@corte", c.TipoDeCorte);
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception) { throw; }
                    finally { connection.Close(); }
                }
                else
                {
                    throw new Exception("El 'nuevo corte' ya existe");
                }
            }
            else 
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = $"UPDATE Carne SET Carne.Tipo_de_Corte = @nuevocorte where Carne.Tipo_de_corte = @corte ";
                    command.Parameters.AddWithValue("@nuevocorte", nuevoCorte);
                    command.Parameters.AddWithValue("@corte", c.TipoDeCorte);
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception) { throw; }
                finally { connection.Close(); }
            }
        }

        public static bool Modificar_precio(Carne c, decimal nuevoPrecio)
        {

            if (Corte_existe(c.TipoDeCorte))
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = $"UPDATE Carne SET Carne.Precio_por_kilo = @precio where Carne.Tipo_de_corte = @corte";
                    command.Parameters.AddWithValue("@precio", nuevoPrecio);
                    command.Parameters.AddWithValue("@corte", c.TipoDeCorte);
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

        public static bool Corte_existe(string corte)
        {
            Carne c = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM Carne WHERE Carne.Tipo_de_corte = @corte";
                command.Parameters.AddWithValue("@corte", corte);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    c = new Carne(((int)dataReader["Cantidad_kilos"]), dataReader["Tipo_de_corte"].ToString(), (decimal)dataReader["Precio_por_kilo"]);
                }
                return c != null;
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


        public static void Borrar_carne(Carne c)
        {
            if (Corte_existe(c.TipoDeCorte))
            {
                try
                {
                    connection.Open();
                    command.Parameters.Clear();
                    command.CommandText = "DELETE from Carne where Carne.Tipo_de_corte = @corte";
                    command.Parameters.AddWithValue("@corte", c.TipoDeCorte);
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
                throw new Exception("Los datos ingresados son invalidos. No corresponden a ningun producto carne.");
            }
        }


    }
}

