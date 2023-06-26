using ClasesCarniceria;

namespace formularios
{
    public partial class FrmVenta : Form
    {

        private string email;
        private string contra;

        public FrmVenta()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmVenta(string email, string contra) : this()
        {
            this.email = email;
            this.contra = contra;
        }
        /// <summary>
        /// Al momento de cargarse el formulario se cargara el saludo.
        /// </summary>

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.lb_saludo.Text = $"Hola {this.email}!";
        }
        /// <summary>
        /// Si el campo monto fue completado con exito iremos al proximo formulario.
        /// </summary>
        private void bt_enviarMonto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tx_saldo.Text))
            {
                string saldoStr = this.tx_saldo.Text;
                bool resp = decimal.TryParse(saldoStr, out decimal saldoDec);

                if (saldoDec == 0 || resp != true)
                {
                    MessageBox.Show("El Monto ingresado es incorrecto");
                }
                else
                {
                    if (resp == true)
                    {
                        // Cambio su monto.
                        Cliente c = DB_Cliente.Leer_cliente(email, contra);
                        DB_Cliente.Modificar_monto_cliente(c, saldoDec);

                        // Abro nueva seccion.
                        FrmElegirProducto form = new FrmElegirProducto(saldoDec, this.email);
                        form.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}