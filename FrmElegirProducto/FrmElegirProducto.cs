using ClasesCarniceria;
using ClasesCarniceria.SQL;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace formularios
{
    public partial class FrmElegirProducto : Form
    {
        private decimal monto;
        private string mail;

        public string Mail { get => mail; set => mail = value; }
        public decimal Monto { get => monto; set => monto = value; }

        public FrmElegirProducto()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmElegirProducto(decimal monto, string mail) : this()
        {
            this.Monto = monto;
            this.Mail = mail;
        }

        private Thread hiloActualizacionMonto;

        public event MontoActualizadoEventHandler MontoActualizado;

        public delegate void MontoActualizadoEventHandler(object sender, EventArgs e);

        // ##########################################################################################################
        // Aca inicializo la nueva tareaa
        private void IniciarHiloActualizacion()
        {
            hiloActualizacionMonto = new Thread(ActualizarMonto);
            hiloActualizacionMonto.Start();
        }

        // Este es el metodo que dispara el evento
        private void ActualizarMonto()
        {
            while (true)
            {
                // disparo el evento MontoActualizado
                MontoActualizado?.Invoke(this, EventArgs.Empty);

                // Hago que Espere un tiempo antes de la siguiente actualizacion
                Thread.Sleep(1000);
            }
        }

        // Metodo para manejar el evento MontoActualizado y actualizar el Label
        private void OnMontoActualizado(object sender, EventArgs e)
        {
            // si la condicion es verdadera, significa que el metodo se esta ejecutando en un hilo diferentee.
            // entonces se necesita realizar una invocación para actualizar el control.
            if (lb_montoActual.InvokeRequired)
            {
                MontoActualizadoEventHandler handler = OnMontoActualizado;
                // lo invoco en el hilo principal.
                lb_montoActual.Invoke(handler, sender, e);
            }
            else
            {
                lb_montoActual.Text = "Monto actual: $" + Monto.ToString();
            }
        }
        /// <summary>
        /// Aplico las configuraciones necesarias para los controladores.
        /// </summary>
        private void FrmElegirProducto_Load_1(object sender, EventArgs e)
        {

            this.ConfigurarListaProductos();
            this.ConfiguracionComboBoxPagos();

            // aca asocio el metodo OnMontoActualizado con el evento MontoActualizado
            MontoActualizado += OnMontoActualizado;

            // aca inicio el hilo de actualización
            IniciarHiloActualizacion();
        }
        // #########################################################################################################

        /// <summary>
        /// Llenar list box con los elementos de la lista productos.
        /// Siempre y cuando sean diferentes a 0 sus atributos stock kilos.
        /// </summary>
        private void ConfigurarListaProductos()
        {
            this.lsb_listaProductos.Items.Clear();
            foreach (var item in DB_Carne.Leer_carnes())
            {
                if (item.CantidadKilos >= 0)
                {
                    this.lsb_listaProductos.Items.Add(item.TipoDeCorte);
                }

            }
        }
        /// <summary>
        /// LLenar combo box con los tipos de pago existentes.
        /// </summary>
        private void ConfiguracionComboBoxPagos()
        {
            foreach (FormasDePago item in Enum.GetValues(typeof(FormasDePago)))
            {
                this.cb_formasDePago.Items.Add(item);
            }
        }

        /// <summary>
        /// Mostrar informacion del producto a buscar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buscadorProductos_Click(object sender, EventArgs e)
        {
            if (this.txb_buscadorProductos.Text.Length != 0)
            {
                string nombreBuscado = txb_buscadorProductos.Text;
                int indiceEncontrado = lsb_listaProductos.FindString(nombreBuscado);

                if (indiceEncontrado != ListBox.NoMatches)
                {
                    // Aca lo que hago es fijar en la lista el elemento encontrado.
                    lsb_listaProductos.SetSelected(indiceEncontrado, true);
                    Carne c = Carniceria.listaProductos[indiceEncontrado];
                    this.txb_detalles.Text = c.Mostrar();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún nombre que coincida con la búsqueda.");
                }
            }
            else
            {
                MessageBox.Show("Error: Debes escribir algo en el buscador.");
            }
        }

        private decimal ValidarPuedePagar(Cliente c, decimal precio, FormasDePago forma)
        {
            decimal precioAux;
            decimal recarga;

            if (forma == FormasDePago.TarjetaCredito)
            {
                recarga = precio * 5 / 100;
                precioAux = recarga + precio;
                if (precioAux <= c.CantidadDinero)
                {
                    return precioAux;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (precio <= c.CantidadDinero)
                {
                    return precio;
                }
                else
                {
                    return -1;
                }
            }

        }


        // Banderita para verificar si se cancelo una compra previa
        private bool compraCancelada = false;

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            if (compraCancelada)
            {
                // Verificar si el campo de cantidad de kilos está vacío
                if (string.IsNullOrEmpty(nud_cantidadKilos.Text))
                {
                    MessageBox.Show("Error: Debes ingresar la cantidad de kilos.");
                    return;
                }
            }

            if (lsb_listaProductos.SelectedItem is null)
            {
                MessageBox.Show("Error: Tenes que seleccionar un producto.");
                return;
            }

            string tipoCorte = lsb_listaProductos.SelectedItem.ToString();
            Carne carneSelec = DB_Carne.Leer_carne(tipoCorte);

            if (carneSelec is null)
            {
                MessageBox.Show("Error: Producto no encontrado.");
                return;
            }

            Cliente clienteSelec = DB_Cliente.Leer_cliente(Mail);
            if (clienteSelec is null)
            {
                MessageBox.Show("Error: Cliente no encontrado.");
                return;
            }

            int cantidadkilos = 0;

            if (!string.IsNullOrEmpty(nud_cantidadKilos.Text))
            {
                cantidadkilos = Convert.ToInt32(nud_cantidadKilos.Value);
            }

            if (cantidadkilos <= 0)
            {
                MessageBox.Show("Error: La cantidad de kilos no puede ser 0.");
                return;
            }

            if (cantidadkilos > carneSelec.CantidadKilos)
            {
                MessageBox.Show("Error: La cantidad de kilos no puede ser mayor a la cantidad fijada.");
                return;
            }

            decimal precio = carneSelec.PrecioPorKilo * cantidadkilos;

            if (cb_formasDePago.SelectedItem is null)
            {
                MessageBox.Show("Error: Tenes que seleccionar un tipo de pago.");
                return;
            }

            FormasDePago forma = (FormasDePago)Enum.Parse(typeof(FormasDePago), cb_formasDePago.SelectedItem.ToString());

            decimal res = ValidarPuedePagar(clienteSelec, precio, forma);
            if (res < 0)
            {
                MessageBox.Show("Error: El precio supera el monto del usuario.");
                return;
            }

            FrmFactura form = new FrmFactura(forma, tipoCorte, cantidadkilos, carneSelec.PrecioPorKilo, res);
            DialogResult resForm = form.ShowDialog();
            if (resForm == DialogResult.OK)
            {
                // actualizo informacion en cliente y carne.
                int cantidadDeKilosAhora = carneSelec.CantidadKilos - cantidadkilos;
                DB_Carne.Modificar_CantidadKilos(carneSelec, cantidadDeKilosAhora);
                Monto -= res;
                DB_Cliente.Modificar_monto_cliente(clienteSelec, Monto);
                // Actualizo informacion a la vista del usuario.
                txb_detalles.Text = carneSelec.Mostrar();
                ConfigurarListaProductos();
            }
            else
            {
                // Se canceló la compra, establecer la variable de control en true
                compraCancelada = true;
            }
        }



        private void btn_detallar_Click(object sender, EventArgs e)
        {
            
            if (this.lsb_listaProductos.SelectedItem != null)
            {
                string corteCarne = this.lsb_listaProductos.SelectedItem.ToString();
                Carne c = DB_Carne.Leer_carne(corteCarne);
                if (c != null)
                {
                    this.txb_detalles.Text = c.Mostrar();
                }
            }
            else 
            {
                MessageBox.Show("Ningun producto fue seleecionado.");
            }
        }

        private void modificarCorreoElectronicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarMail form = new FrmModificarMail(Mail);

            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {

                string nuevoCorreo = form.CorreoNuevo;
                this.Mail = nuevoCorreo;
                MessageBox.Show("El Correo Electronico se modifico con exito!");
            }
        }

        private void modificarMontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarMonto form = new FrmModificarMonto(Mail, Monto);


            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                decimal nuevoMonto = form.NuevoMonto;
                this.Monto = nuevoMonto;
                MessageBox.Show("El Monto se modifico con exito!");
            }
        }

        private void modificarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarContraseña form = new FrmModificarContraseña(this.mail);


            DialogResult res = form.ShowDialog();
            
            if (res == DialogResult.OK)
            {
                MessageBox.Show("La contraseña se modifico con exito!");
            }
            
        }

        private void verTusDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmResumenDatosUsuario form = new FrmResumenDatosUsuario(this.mail);

            DialogResult res = form.ShowDialog();
            
            if (res == DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}