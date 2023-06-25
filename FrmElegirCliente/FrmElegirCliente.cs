using ClasesCarniceria;


namespace formularios
{
    public partial class FrmElegirCliente : Form
    {
        public FrmElegirCliente()
        {
            InitializeComponent();
        }

        public FrmElegirCliente(string nombreProducto) : this()
        {
            this.lb_nombreProducto.Text = "Seleccionaste vender: " + nombreProducto;
        }

        public void ConfigurarListBoxClientes()
        {
            Vendedor vendedor = new Vendedor();
            List<Cliente> listaClientes = vendedor.ListaClientes;
            foreach (var item in listaClientes)
            {
                this.lsb_clientes.Items.Add(item.Mail);
            }
        }

        private void FrmElegirCliente_Load(object sender, EventArgs e)
        {
            this.ConfigurarListBoxClientes();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            

        }
    }
}
