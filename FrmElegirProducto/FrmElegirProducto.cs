using ClasesCarniceria;
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

        // 1
        private Thread hiloActualizacionMonto;

        public event MontoActualizadoEventHandler MontoActualizado;

        public delegate void MontoActualizadoEventHandler(object sender, EventArgs e);

        // ##########################################################################################################
        private void IniciarHiloActualizacion()
        {
            hiloActualizacionMonto = new Thread(ActualizarMonto);
            hiloActualizacionMonto.Start();
        }

        // Método que dispara el evento
        private void ActualizarMonto()
        {
            while (true)
            {
                // Dispara el evento MontoActualizado
                MontoActualizado?.Invoke(this, EventArgs.Empty);

                // Espera un tiempo antes de la siguiente actualización
                Thread.Sleep(1000);
            }
        }

        // Método para manejar el evento MontoActualizado y actualizar el Label
        private void OnMontoActualizado(object sender, EventArgs e)
        {
            // Actualiza el texto del Label con el nuevo monto
            if (lb_montoActual.InvokeRequired)
            {
                MontoActualizadoEventHandler handler = OnMontoActualizado;
                lb_montoActual.Invoke(handler, sender, e);
            }
            else
            {
                lb_montoActual.Text = "Monto actual: $" + Monto.ToString();
            }
        }

        private void FrmElegirProducto_Load_1(object sender, EventArgs e)
        {

            this.ConfigurarListaProductos();
            this.ConfiguracionComboBoxPagos();

            // Asocia el método MontoActualizadoEventHandler con el evento MontoActualizado
            MontoActualizado += OnMontoActualizado;

            // Inicia el hilo de actualización
            IniciarHiloActualizacion();

        }

        // #########################################################################################################

        /// <summary>
        /// Aplico las configuraciones necesarias para los controladores.
        /// </summary>


        /// <summary>
        /// Llenar list box con los elementos de la lista productos.
        /// Siempre y cuando sean diferentes a 0 sus atributos stock kilos.
        /// </summary>
        private void ConfigurarListaProductos()
        {
            this.lsb_listaProductos.Items.Clear();
            foreach (var item in Carniceria.listaProductos)
            {
                if (item.CantidadKilos > 0)
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


        private void btn_comprar_Click(object sender, EventArgs e)
        {

            if (lsb_listaProductos.SelectedItem is not null)
            {

                string tipoCorte = this.lsb_listaProductos.SelectedItem.ToString();
                Carne carneSelec = Carniceria.BuscarCarnePorCorte(tipoCorte);

                Vendedor v = new Vendedor();
                Cliente clienteSelec = v.BuscarClientePorMail(this.Mail);
                // Los clientes traen un valor por defecto que debe ser modificado por el monto que ingreso el usuario. 
                clienteSelec.CantidadDinero = this.Monto;


                if (carneSelec != null && clienteSelec != null)
                {
                    int cantidadkilos = (int)this.nud_cantidadKilos.Value;

                    if (cantidadkilos != -1 && cantidadkilos <= carneSelec.CantidadKilos && cantidadkilos != 0)
                    {
                        decimal precio = carneSelec.PrecioPorKilo * cantidadkilos;

                        if (cb_formasDePago.SelectedItem != null)
                        {
                            FormasDePago forma = (FormasDePago)Enum.Parse(typeof(FormasDePago), this.cb_formasDePago.SelectedItem.ToString());

                            decimal res = this.ValidarPuedePagar(clienteSelec, precio, forma);
                            if (res >= 0)
                            {
                                FrmFactura form = new FrmFactura(forma, tipoCorte, cantidadkilos, carneSelec.PrecioPorKilo, res);
                                DialogResult resForm = form.ShowDialog();
                                if (resForm == DialogResult.OK)
                                {
                                    // actualizo informacion en cliente y carne.
                                    carneSelec.CantidadKilos -= cantidadkilos;
                                    clienteSelec.CantidadDinero -= res;
                                    this.Monto -= res;
                                    // actualizo informacion en pantalla.
                                    //this.rellenarTitulo(this.mail, this.monto);
                                    this.txb_detalles.Text = carneSelec.Mostrar();
                                    this.ConfigurarListaProductos();
                                }
                            }
                            else { MessageBox.Show("Error: El precio supera el monto del usuario."); }
                        }
                        else { MessageBox.Show("Error: Tenes que seleccionar un tipo de pago."); }
                    }
                    else { MessageBox.Show("Error: La cantidad de kilos no puede ser 0 o mayor a la cantidad fijada."); }
                }
            }
            else { MessageBox.Show("Error: Tenes que seleccionar un producto."); }
        }


        private void btn_detallar_Click(object sender, EventArgs e)
        {
            string corteCarne = this.lsb_listaProductos.SelectedItem.ToString();
            Carne c = Carniceria.BuscarCarnePorCorte(corteCarne);
            if (c != null)
            {
                this.txb_detalles.Text = c.Mostrar();
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