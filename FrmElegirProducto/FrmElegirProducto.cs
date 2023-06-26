using ClasesCarniceria;
using System.Reflection.Metadata.Ecma335;

namespace formularios
{
    public partial class FrmElegirProducto : Form
    {
        private decimal monto;
        private string mail;

        // 1
        private Thread hiloActualizacionMonto;
        // 2
        public event EventHandler MontoActualizado;


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
            this.monto = monto;
            this.mail = mail;
        }


        // ##########
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
                Thread.Sleep(2000);
            }
        }

        // Método para manejar el evento MontoActualizado y actualizar el Label
        private void MontoActualizadoEventHandler(object sender, EventArgs e)
        {
            // Actualiza el texto del Label con el nuevo monto
            if (lb_montoActual.InvokeRequired)
            {
                Action<object, EventArgs> montoActualizarEventHandler = MontoActualizadoEventHandler;
                lb_montoActual.Invoke(montoActualizarEventHandler, sender, e);

            }
            else
            {
                lb_montoActual.Text = "Monto actual: $" + monto.ToString();
            }

        }

        // ##########

        /// <summary>
        /// Aplico las configuraciones necesarias para los controladores.
        /// </summary>

        private void FrmElegirProducto_Load_1(object sender, EventArgs e)
        {

            this.ConfigurarListaProductos();
            this.ConfiguracionComboBoxPagos();
            //this.rellenarTitulo(this.mail, this.monto);

            // Asocia el método MontoActualizadoEventHandler con el evento MontoActualizado
            MontoActualizado += MontoActualizadoEventHandler;

            // Inicia el hilo de actualización
            IniciarHiloActualizacion();

        }

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
                    this.txb_detalles.Text = c.Mostrar_carne();
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
                Cliente clienteSelec = v.BuscarClientePorMail(this.mail);
                // Los clientes traen un valor por defecto que debe ser modificado por el monto que ingreso el usuario. 
                clienteSelec.CantidadDinero = this.monto;


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
                                    this.monto -= res;
                                    // actualizo informacion en pantalla.
                                    //this.rellenarTitulo(this.mail, this.monto);
                                    this.txb_detalles.Text = carneSelec.Mostrar_carne();
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
                this.txb_detalles.Text = c.Mostrar_carne();
            }
        }

        private void modificarCorreoElectronicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarMail form = new FrmModificarMail(mail);
            

            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK) 
            {
                MessageBox.Show("El Correo Electronico se modifico con exito!");
            }
        }
    }
}