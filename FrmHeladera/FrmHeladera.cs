using ClasesCarniceria;
using ClasesCarniceria.SQL;

namespace formularios
{
    public partial class FrmHeladera : Form
    {
        private string mail;
        public string Mail { get => mail; set => mail = value; }

        private List<Factura> listaFacturas;
        public List<Factura> ListaFacturas { get => listaFacturas; set => listaFacturas = value; }
       

        public FrmHeladera()
        {
            InitializeComponent();

            this.ListaFacturas = new List<Factura>();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmHeladera(string mail) : this()
        {
            this.Mail = mail;
        }

        /// <summary>
        /// Limpio y cargo de elementos al List Box para carnes.
        /// </summary>
        public void ConfigurarListBoxProductos()
        {
            lsb_productos.Items.Clear();
            foreach (var item in DB_Carne.Leer_carnes())
            {
                this.lsb_productos.Items.Add(item.TipoDeCorte);
            }
        }
        /// <summary>
        /// Limpio y cargo de elementos al List Box para clientes.
        /// </summary>
        public void ConfigurarListBoxClientes()
        {
            lsb_clientes.Items.Clear();
            Vendedor v = new Vendedor();
            foreach (var item in v.ListaClientes)
            {
                this.lsb_clientes.Items.Add(item.Mail);
            }
        }
        /// <summary>
        /// Compruebo si se selecciono un item y en consecuencia lo muestro en la seccion detalles.
        /// </summary>

        private void btn_detallar_Click(object sender, EventArgs e)
        {
            if (this.lsb_productos.SelectedItem != null)
            {
                string tipoDeCorteSelec = this.lsb_productos.SelectedItem.ToString();
                Carne c = DB_Carne.Leer_carne(tipoDeCorteSelec);
                if (c != null)
                {
                    this.txb_detallarProducto.Text = c.Mostrar();
                }
            }
        }

        private void FrmHeladera_Load(object sender, EventArgs e)
        {
            this.lb_vendedor.Text = $"Hola {this.Mail}";
            this.ConfigurarListBoxClientes();
            this.ConfigurarListBoxProductos();
        }
        /// <summary>
        /// Realizo las cuentas necesarias para saber si el cliente puede pagar y tambien chequeo si completo todos los pasos necesarios.
        /// </summary>

        private void btn_vender_Click(object sender, EventArgs e)
        {

            if (lsb_productos.SelectedItem is not null && lsb_clientes.SelectedItem is not null)
            {
                string mailCliente = lsb_clientes.SelectedItem.ToString();
                string tipoCorte = lsb_productos.SelectedItem.ToString();

                if (mailCliente != null && tipoCorte != null)
                {
                    int indexCarne = Carniceria.IndexCarne(tipoCorte);
                    Carne carneSelec = Carniceria.listaProductos[indexCarne];

                    Vendedor v = new Vendedor();
                    int indexCliente = v.IndexCliente(mailCliente);
                    Cliente clienteSelec = v.ListaClientes[indexCliente];

                    int cantidadkilos = (int)this.nud_cantidadKilosVender.Value;

                    if (cantidadkilos > 0 && cantidadkilos <= carneSelec.CantidadKilos)
                    {
                        decimal precio = carneSelec.PrecioPorKilo * cantidadkilos;
                        if (precio <= clienteSelec.CantidadDinero)
                        {
                            //MessageBox.Show("Todo salio bien y hay que descontar la plata al cliente");
                            carneSelec.CantidadKilos -= cantidadkilos;
                            clienteSelec.CantidadDinero -= precio;
                            // Lo agregamos al historial.
                            MessageBox.Show("Listo! Su compra ha sido realizada con exito.");
                            Factura f = new Factura(mailCliente, cantidadkilos, carneSelec.PrecioPorKilo, precio, tipoCorte, DateTime.Now);
                            DB_Factura.Agregar_Factura(f);
                            this.listaFacturas.Add(f);
                        }
                        else
                        {
                            MessageBox.Show("El cliente no puede pagar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: la cantidad de kilos no puede ser 0 y/o mayor a su cantidad");
                    }
                }
                else
                {
                    MessageBox.Show("No seleccionaste un cliente y/o producto.");
                }
            }
            else
            {
                MessageBox.Show("Error: No se seleccionaste un cliente y/o producto");
            }
        }

        /// <summary>
        /// Instancia al formulario agregar productos y efectua una accion en respuesta
        /// </summary>

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarProductos form = new FrmAgregarProductos();

            DialogResult resultado = form.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                //Carniceria.listaProductos.Add(form.NuevaCarne());
                this.ConfigurarListBoxProductos();
                MessageBox.Show("El producto se agrego con exito!");
            }
        }
        /// <summary>
        /// Instancia al formulario modificar productos y efectua una accion en respuesta
        /// </summary>
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarProducto form = new FrmModificarProducto();
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                this.ConfigurarListBoxProductos();
            }
        }
        /// <summary>
        /// Instancia al formulario quitar productos y efectua una accion en respuesta
        /// </summary>
        private void quitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuitarProducto form = new FrmQuitarProducto();
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                this.ConfigurarListBoxProductos();
            }
        }
        /// <summary>
        /// Instancia al formulario agregar corte y efectua una accion en respuesta
        /// </summary>
        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAgregarCorte form = new FrmAgregarCorte();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Carniceria.tiposCortes.Add(form.NuevoCorte);
                this.ConfigurarListBoxProductos();
            }
        }
        /// <summary>
        /// Muestro los detalles del cliente seleccionado a la hora de apretar el boton detallar.
        /// </summary>
        private void btn_detallarCliente_Click(object sender, EventArgs e)
        {
            if (this.lsb_clientes.SelectedItem != null)
            {
                string mailCliente = this.lsb_clientes.SelectedItem.ToString();
                Vendedor v = new Vendedor();
                Cliente c = v.BuscarClientePorMail(mailCliente);

                if (c != null)
                {
                    this.txb_detallarCliente.Text = c.Detallar();
                }
            }
        }
        /// <summary>
        /// Instancia y me desplaza al formulario en donde se podra ver el historial de facturaciones.
        /// </summary>

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorial form = new FrmHistorial(listaFacturas);
            form.Show();
        }
        /// <summary>
        /// Instancia al formulario quitar corte y efectua una accion en respuesta
        /// </summary>

        private void quitarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmQuitarCorte form = new FrmQuitarCorte();
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("El corte de carne se quito con exito!");
                this.ConfigurarListBoxProductos();
            }

        }
        /// <summary>
        /// Instancia al formulario modificar corte y efectua una accion en respuesta
        /// </summary>
        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmModificarCorte form = new FrmModificarCorte();
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("El corte de carne se modifico con exito!");
                this.ConfigurarListBoxProductos();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSerializarProducto form = new FrmSerializarProducto();
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("El archivo se serializo con exito!");
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSerializarCliente form = new FrmSerializarCliente();
            
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("El archivo se serializo con exito!");
            }
        }
    }
}