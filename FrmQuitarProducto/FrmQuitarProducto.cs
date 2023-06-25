using ClasesCarniceria;

namespace formularios
{
    public partial class FrmQuitarProducto : Form
    {
        public FrmQuitarProducto()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ConfigurarListBoxProductos()
        {
            lsb_listaProductos.Items.Clear();
            foreach (var item in Carniceria.listaProductos)
            {
                this.lsb_listaProductos.Items.Add(item.TipoDeCorte);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ConfigurarListBoxProductos();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (this.lsb_listaProductos.SelectedItem != null)
            {
                string corteSeleccionado = this.lsb_listaProductos.SelectedItem.ToString();
                int indexProducto = Carniceria.IndexCarne(corteSeleccionado);
                if (indexProducto != -1)
                {
                    Carne c = Carniceria.listaProductos[indexProducto];
                    if (Carniceria.listaProductos.Remove(c))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_detallar_Click(object sender, EventArgs e)
        {
            if (this.lsb_listaProductos.SelectedItem != null)
            {
                string corte = this.lsb_listaProductos.SelectedItem.ToString();
                Carne c = Carniceria.BuscarCarnePorCorte(corte);
                this.txb_detallar.Text = c.Mostrar_carne();
            }
        }
    }
}