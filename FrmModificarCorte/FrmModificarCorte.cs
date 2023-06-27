
using ClasesCarniceria;
using ClasesCarniceria.SQL;

namespace formularios
{
    public partial class FrmModificarCorte : Form
    {
        public FrmModificarCorte()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lsb_listaDeCortes.Items.Clear();
            List<string> lista = DB_Corte.Leer_cortes();
            foreach (string corte in lista)
            {
                this.lsb_listaDeCortes.Items.Add(corte);
            }
        }
        /// <summary>
        /// Evento encargado de verificar si se selecciono un tipo de carne y si el nuevo es correcto.
        /// </summary>

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (this.lsb_listaDeCortes.SelectedItem != null)
            {
                string corteSelec = this.lsb_listaDeCortes.SelectedItem.ToString();

                // modifico.
                if (!(string.IsNullOrEmpty(txb_nuevoNombre.Text)))
                {
                    bool res = DB_Corte.Modificar_corte(this.txb_nuevoNombre.Text, corteSelec);
                    if (res) 
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else { MessageBox.Show("Error: Falto ingresar un nuevo nombre para el corte seleccionado."); }
            }
            else { MessageBox.Show("Error: No seleccionaste un corte de carne."); }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}