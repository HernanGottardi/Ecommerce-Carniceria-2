using ClasesCarniceria;
using ClasesCarniceria.SQL;

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

                Carne c = DB_Carne.Leer_carne(tipoDeCorteABuscar);

                if (c != null)
                {
                    string tipoDeCorte = this.cb_tipoCorte.Text.ToString();
                    decimal precioPorKilo = this.nud_precioKilo.Value;
                    int cantidadKilos = (int)this.nud_cantidadKilos.Value;

                    if (tipoDeCorte != null && precioPorKilo > 0 && cantidadKilos > 0)
                    {
                        try 
                        {
                            DB_Carne.Modificar_Corte(c, tipoDeCorte);
                            DB_Carne.Modificar_precio(c, precioPorKilo);
                            DB_Carne.Modificar_CantidadKilos(c, cantidadKilos);
                            configurarListBoxProductos();
                            this.DialogResult = DialogResult.OK;
                        }
                        catch(Exception ex) 
                        {
                            MessageBox.Show(ex.Message);
                        }
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
            foreach (Carne item in DB_Carne.Leer_carnes())
            {
                this.lsb_listaProductos.Items.Add(item.TipoDeCorte);
            }
        }

        private void ConfigurarComboBoxCortesCarnes()
        {
            foreach (string item in DB_Corte.Leer_cortes())
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
                Carne c = DB_Carne.Leer_carne(tipoDeCorteSelec);
                if (c != null) 
                {
                    this.txb_detallarProducto.Text = c.Mostrar();
                }
            }
        }
    }
}