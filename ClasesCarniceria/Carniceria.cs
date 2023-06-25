using ClasesCarniceria.SQL;
using System.Text;

namespace ClasesCarniceria
{

    public static class Carniceria
    {

        public static List<string> tiposCortes;
        public static List<Carne> listaProductos;
        public static List<Vendedor> listaVendedores;

        static Carniceria()
        {
            // Inicializo
            listaProductos = DB_Carne.Leer_carnes();
            listaVendedores = DB_vendedor.Leer_vendedores();
            tiposCortes = ExtraerCortesDeListaProductos(listaProductos);
        }

        /// <summary>
        /// Buscar el indice de un producto carne a traves de su nombre/tipo de corte.
        /// </summary>
        /// <param name="tipoCorte"> utilizado para verificar si existe o no</param>
        /// <returns>
        /// Retorna el indice de la carne encontrada, o -1 cuando no la encuentra.
        /// </returns>
        public static int IndexCarne(string tipoCorte)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].TipoDeCorte == tipoCorte)
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Encargada de buscar dentro de la lista de productos, el que cumpla con el tipo de corte.
        /// </summary>
        /// <param name="corte"> palabra clave a buscar.</param>
        /// <returns> retorna la Carne si todo salio bien y null si algo salio mal</returns>
        public static Carne BuscarCarnePorCorte(string corte)
        {

            int indexProducto = IndexCarne(corte);
            if (indexProducto != -1)
            {
                Carne c = listaProductos[indexProducto];
                return c;
            }
            else
            {
                return null;
            }
        }

        private static List<string> ExtraerCortesDeListaProductos(List<Carne> lista)
        {
            List<string> cortes = new List<string>();

            foreach (var carne in lista)
            {
                cortes.Add(carne.TipoDeCorte);
            }

            return cortes;
        }

        public static int IndexCorteCarne(string tipoCorte)
        {
            for (int i = 0; i < tiposCortes.Count; i++)
            {
                if (tiposCortes[i] == tipoCorte)
                {
                    return i;
                }
            }
            return -1;
        }

        public static string MostrarProductos(List<Carne> lista)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Carne c in lista)
            {
                sb.AppendLine($"Corte: {c.TipoDeCorte}");
                sb.AppendLine($"Kilos: {c.CantidadKilos}");
                sb.AppendLine($"Precio por Kg: {c.PrecioPorKilo}");
                sb.AppendLine("##############################");
            }
            return sb.ToString();
        }

        public static string MostrarCliente(List<Cliente> lista)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Cliente c in lista)
            {
                sb.AppendLine($"Corte: {c.Mail}");
                sb.AppendLine($"Kilos: {c.CantidadDinero}");
                sb.AppendLine("##############################");
            }
            return sb.ToString();
        }
    }
}
