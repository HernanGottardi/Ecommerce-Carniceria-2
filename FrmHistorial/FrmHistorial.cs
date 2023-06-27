namespace formularios
{
    using ClasesCarniceria;
    using ClasesCarniceria.SQL;
    using System.Windows.Forms;

    public partial class FrmHistorial : Form
    {
        private static string ruta = AppDomain.CurrentDomain.BaseDirectory;

        private List<Factura> listaFacturasHoy;
        private List<Factura> listaFacturasTodas;

        public List<Factura> ListaFacturasHoy { get => listaFacturasHoy; set => listaFacturasHoy = value; }
        public List<Factura> ListaFacturasTodas { get => listaFacturasTodas; set => listaFacturasTodas = value; }

        public FrmHistorial()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmHistorial(List<Factura> lista) : this()
        {
            this.ListaFacturasHoy = lista;
            this.ListaFacturasTodas = DB_Factura.Leer_facturas();
        }


        private decimal CalcularTotalGanado()
        {
            decimal total = 0;
            foreach (var item in this.ListaFacturasHoy)
            {
                total += item.PrecioFinal;
            }
            return total;
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {

            this.dgv_facturaciones.AutoGenerateColumns = false;
            this.dgv_facturaciones.ColumnCount = 6;

            this.dgv_facturaciones.Columns[0].Name = "Mail";
            this.dgv_facturaciones.Columns[1].Name = "Corte Elegido";
            this.dgv_facturaciones.Columns[2].Name = "Cantidad Kilos";
            this.dgv_facturaciones.Columns[3].Name = "Precio xKG";
            this.dgv_facturaciones.Columns[4].Name = "Precio Final";
            this.dgv_facturaciones.Columns[5].Name = "Fecha-Hora";

            this.dgv_facturaciones.DataSource = ListaFacturasHoy;

            dgv_facturaciones.Columns["Mail"].DataPropertyName = "MailCliente";
            dgv_facturaciones.Columns["Corte Elegido"].DataPropertyName = "CorteDeCarne";
            dgv_facturaciones.Columns["Cantidad Kilos"].DataPropertyName = "CantidadDeKilos";
            dgv_facturaciones.Columns["Precio xKG"].DataPropertyName = "PrecioPorKilo";
            dgv_facturaciones.Columns["Precio Final"].DataPropertyName = "PrecioFinal";
            dgv_facturaciones.Columns["Fecha-Hora"].DataPropertyName = "FechaFactura";

            this.lb_totalGanado.Text = $"Total Recaudado: ${this.CalcularTotalGanado()}";

            // Ajustar el ancho de las columnas
            foreach (DataGridViewColumn column in dgv_facturaciones.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void btn_archivoTexto_Click(object sender, EventArgs e)
        {

            string nombre = "HistorialFacturas.txt";
            
            string rutaCompleta = Path.Combine(ruta, nombre);
            try 
            {
                using (StreamWriter escritor = new StreamWriter(rutaCompleta, false))
                {
                    foreach (Factura f in this.ListaFacturasTodas)
                    {
                        escritor.WriteLine(f.Mostrar());
                    }
                }
                MessageBox.Show("El archivo se cargo con exito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el archivo: {ex.Message}");
            }

            
        }
    }
}