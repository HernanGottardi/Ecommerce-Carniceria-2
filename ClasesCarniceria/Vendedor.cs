using ClasesCarniceria.Interfaces;
using System.Text;

namespace ClasesCarniceria
{
    public class Vendedor : Usuario
    {
        private string mail;
        private string contraseña;
        private List<Cliente> listaClientes;

        public List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }
        public override string Mail { get => mail; set => mail = value; }
        public override string Contraseña { get => contraseña; set => contraseña = value; }

        public Vendedor()
        {
            // Inicializo los clientes traidos de la base de datos.
            ListaClientes = DB_Cliente.Leer_clientes();
        }

        public Vendedor(string mail, string contraseña) : this()
        {
            this.mail = mail;
            this.contraseña = contraseña;
        }

        public void FijarPrecioPorkilo(Carne producto, decimal precio)
        {
            producto.PrecioPorKilo = precio;
        }

        public void ReponerProducto(Carne producto, int kilos)
        {
            producto.CantidadKilos = kilos;
        }

        public void CambiarTipoDeCarne(Carne producto, string tipo)
        {
            producto.TipoDeCorte = tipo;
        }

        /// <summary>
        /// Crear una cadena de texto con todos los mails de los clientes separados por coma.
        /// </summary>
        /// <returns> retorna una cadena de texto.</returns>
        public string MostrarClientes()
        {
            List<string> mailClientes = new List<string>();

            for (int i = 0; i < listaClientes.Count; i++)
            {
                string nombre = listaClientes[i].Mail;
                mailClientes.Add(nombre);
            }
            string mails = string.Join(", ", mailClientes);
            return mails;
        }

        //public Cliente MostarCliente(int index)
        //{ 
        //    return listaClientes[index];
        //}

        /// <summary>
        /// Buscar y encontrar el indice del objeto de tipo Cliente dentro de la lista de clientes.                  
        /// </summary>
        /// <param name="mail"> string que se usara para comparar con los atributos mails de la lista de objetos del tipo Cliente</param>
        /// <returns> Indice del objeto del tipo Cliente o -1 si no lo encontro</returns>
        public int IndexCliente(string mail)
        {
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].Mail == mail)
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Buscar y encontrar objeto del tipo Cliente.
        /// </summary>
        /// <param name="mail"> string a comparar con el atributo mail de los objetos del tipo cliente</param>
        /// <returns> retorna objeto del tipo Cliente de encontrarlo o null en caso de no encontrarlo</returns>
        public Cliente BuscarClientePorMail(string mail)
        {
            int indexCliente = this.IndexCliente(mail);
            if (indexCliente != -1)
            {
                Cliente clienteSelec = this.ListaClientes[indexCliente];
                return clienteSelec;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Convertir en una sola cadena de texto todas las propiedades del objeto Cliente.
        /// </summary>
        /// <returns> Cadena de texto </returns>
        public override string Detallar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Vendedor: ");
            sb.AppendLine($"Mail: {this.Mail}");
            sb.AppendLine($"Lista de clientes: {this.MostrarClientes()}");

            return sb.ToString();
        }

        public static bool operator ==(Cliente c, Vendedor vendedor)
        {
            foreach (var cliente in vendedor.ListaClientes)
            {
                if (cliente.Mail == c.Mail && cliente.Contraseña == c.Contraseña)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Cliente c, Vendedor vendedor)
        {
            return !(c == vendedor);
        }

        public bool MailClienteExiste(string mail) 
        {
            foreach (Cliente c in listaClientes)
            {
                if (c.Mail == mail) 
                {
                    return true;
                    break;
                }
            }
            return false;
        }

    }

}
