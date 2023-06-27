using ClasesCarniceria;
using ClasesCarniceria.SQL;

namespace formularios
{
    public partial class FrmAgregarProductos : Form
    {
        private Carne nuevaCarne;
        public FrmAgregarProductos()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Carne NuevaCarne()
        {
            return this.nuevaCarne;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            string corte = this.cb_tipoDeCorte.Text;
            decimal precio = this.nud_precioPorKilogramo.Value;
            int cantidad = (int)this.nud_cantidadKilogramos.Value;

            try 
            {
                nuevaCarne = new Carne(cantidad, corte, precio);
                if (corte != null && precio > 0 && cantidad > 0)
                {
                    DB_Carne.Agregar_carne(nuevaCarne);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error, algunos datos no fueron rellenos.");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmAgregarProductos_Load(object sender, EventArgs e)
        {
            foreach (var cortes in DB_Corte.Leer_cortes())
            {
                this.cb_tipoDeCorte.Items.Add(cortes);
            }
            // Dejamos una opcion para que este puesta por defecto (por indice).
            this.cb_tipoDeCorte.SelectedIndex = 0;
        }
    }
}