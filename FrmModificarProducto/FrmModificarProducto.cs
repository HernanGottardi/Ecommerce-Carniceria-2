using ClasesCarniceria;

namespace formularios
{
    public partial class FrmModificarProducto : Form
    {
        public FrmModificarProducto()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_modificar_Click(object sender, EventArgs e)
        {

            if (this.lsb_listaProductos.SelectedItem != null)
            {
                string tipoDeCorteABuscar = this.lsb_listaProductos.SelectedItem.ToString();
                int index = Carniceria.IndexCarne(tipoDeCorteABuscar);

                if (index != -1)
                {
                    Carne carne = Carniceria.listaProductos[index];

                    string tipoDeCorte = this.cb_tipoCorte.Text.ToString();
                    carne.TipoDeCorte = tipoDeCorte;

                    decimal precioPorKilo = this.nud_precioKilo.Value;
                    carne.PrecioPorKilo = precioPorKilo;

                    int cantidadKilos = (int)this.nud_cantidadKilos.Value;
                    carne.CantidadKilos = cantidadKilos;

                    if (tipoDeCorte != null && precioPorKilo > 0 && cantidadKilos > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Error: Alguna opcion no fue bien seleccionada.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: No se selecciono un producto a modificar.");
            }

        }
        private void configurarListBoxProductos()
        {
            this.lsb_listaProductos.Items.Clear();
            foreach (var item in Carniceria.listaProductos)
            {
                this.lsb_listaProductos.Items.Add(item.TipoDeCorte);
            }
        }

        private void ConfigurarComboBoxCortesCarnes()
        {
            foreach (var item in Carniceria.tiposCortes)
            {
                cb_tipoCorte.Items.Add(item);
            }
        }

        private void FrmModificarProducto_Load(object sender, EventArgs e)
        {

            this.configurarListBoxProductos();
            this.ConfigurarComboBoxCortesCarnes();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_detallar_Click(object sender, EventArgs e)
        {
            if (this.lsb_listaProductos.SelectedItem != null)
            {
                string tipoDeCorteSelec = this.lsb_listaProductos.SelectedItem.ToString();
                int index = Carniceria.IndexCarne(tipoDeCorteSelec);

                if (index != -1)
                {
                    Carne c = Carniceria.listaProductos[index];
                    this.txb_detallarProducto.Text = c.Mostrar_carne();
                }
            }
        }
    }
}