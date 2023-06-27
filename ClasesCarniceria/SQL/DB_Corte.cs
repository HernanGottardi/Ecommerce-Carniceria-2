using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.SQL
{
    public static class DB_Corte
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;


        static DB_Corte()
        {
            connectionString = @"Data Source = .;Database = Carniceria_DB; Trusted_Connection = True; TrustServerCertificate=True;";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<string> Leer_cortes()
        {
            List<string> lista = new List<string>(); ;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM Corte";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    lista.Add(dataReader["tipo_de_corte"].ToString());
                }
                return lista;

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

        public static List<string> Leer_corte(string tipo_corte)
        {
            List<string> lista = new List<string>(); ;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM Corte WHERE Corte.tipo_de_corte = @corte";
                command.Parameters.AddWithValue("@corte", tipo_corte);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    lista.Add(dataReader["tipo_de_corte"].ToString());
                }
                return lista;

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

        public static void Agregar_corte(string tipo_corte)
        {
            if (Corte_existe(tipo_corte))
            {
                throw new Exception("El 'Tipo de corte' ya existe.");
            }
            else
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = "INSERT INTO Corte(tipo_de_corte) values (@corte)";
                    command.Parameters.AddWithValue("@corte", tipo_corte);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally { connection.Close(); }
            }
        }

        public static bool Modificar_corte(string nuevo_tipo_corte, string tipo_corte_actual)
        {
            if (!Corte_existe(nuevo_tipo_corte))
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = $"UPDATE Corte SET Corte.tipo_de_corte = @corte where Corte.tipo_de_corte = @tipo_corte_actual";
                    command.Parameters.AddWithValue("@corte", nuevo_tipo_corte);
                    command.Parameters.AddWithValue("@tipo_corte_actual", tipo_corte_actual);
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

        public static void Borrar_corte(string corte)
        {
            if (Corte_existe(corte))
            {
                try
                {
                    connection.Open();
                    command.Parameters.Clear();
                    command.CommandText = "DELETE from Corte where Corte.tipo_de_corte = @corte";
                    command.Parameters.AddWithValue("@corte", corte);
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
                throw new Exception("Los datos ingresados son invalidos. No corresponden a ningun tipo de corte.");
            }
        }

        public static bool Corte_existe(string tipo_corte)
        {
             string aux = "";
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM Corte WHERE Corte.tipo_de_corte = @corte";
                command.Parameters.AddWithValue("@corte", tipo_corte);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    aux = (dataReader["tipo_de_corte"].ToString());
                }
                if (string.IsNullOrEmpty(aux))
                {
                    return false;
                }
                else 
                {
                    return true;
                }
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




    }
}


