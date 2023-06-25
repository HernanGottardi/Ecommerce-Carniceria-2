using System.Data.SqlClient;

namespace ClasesCarniceria.SQL
{
    public static class DB_Factura
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;


        static DB_Factura()
        {
            connectionString = @"Data Source = .;Database = Carniceria_DB; Trusted_Connection = True; TrustServerCertificate=True;";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }
        public static List<Factura> Leer_facturas()
        {
            List<Factura> facturasAux = new List<Factura>();
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM Factura";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    facturasAux.Add(new Factura(dataReader["Mail_cliente"].ToString(), (int)dataReader["Cantidad_kilos"], 
                        (decimal)dataReader["Precio_Por_kilo"], (decimal)dataReader["Precio_final"], 
                        dataReader["Corte_de_carne"].ToString(), (DateTime)dataReader["Fecha_factura"]));
                }
                return facturasAux;
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

        public static void Agregar_Factura(Factura f)
        {

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = @"INSERT INTO Factura(Mail_cliente, Cantidad_kilos, 
                Precio_final, Corte_de_carne, Precio_por_kilo, Fecha_factura) 
                values (@mail, @cantidad, @precioFinal, @corte, @precioKilo, @fecha)";
                
                command.Parameters.AddWithValue("@mail", f.MailCliente);
                command.Parameters.AddWithValue("@cantidad", f.CantidadDeKilos);
                command.Parameters.AddWithValue("@precioFinal", f.PrecioFinal);
                command.Parameters.AddWithValue("@corte", f.CorteDeCarne);
                command.Parameters.AddWithValue("@precioKilo", f.PrecioPorKilo);
                command.Parameters.AddWithValue("@fecha", f.FechaFactura);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { connection.Close(); }

            }
    }

}

