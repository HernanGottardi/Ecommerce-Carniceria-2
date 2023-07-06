using ClasesCarniceria;
using ClasesCarniceria.SQL;

namespace formularios
{
    public partial class FrmAgregarCorte : Form
    {
        private string nuevoCorte;
        private bool criterioEspacios;
        public FrmAgregarCorte()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string NuevoCorte { get => nuevoCorte; set => nuevoCorte = value; }

        /// <summary>
        /// Evento encargado de comprobar si el nuevo corte ingresado es correcto.
        /// </summary>
        private void btn_aceptar_Click_1(object sender, EventArgs e)
        {
            this.NuevoCorte = this.txb_agregarCorteNuevo.Text.ToString();
            criterioEspacios = this.NuevoCorte.Contains(" ");
            if (!(string.IsNullOrWhiteSpace(NuevoCorte)) && !criterioEspacios)
            {
                if (!DB_Corte.Corte_existe(nuevoCorte))
                {
                    DB_Corte.Agregar_corte(nuevoCorte);
                    this.DialogResult = DialogResult.OK;
                }
                else 
                {
                    MessageBox.Show("El 'tipo de corte' ingresado ya existe.");
                }   
            }
            else
            {
                MessageBox.Show("Error, no estas ingresando un texto.");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}