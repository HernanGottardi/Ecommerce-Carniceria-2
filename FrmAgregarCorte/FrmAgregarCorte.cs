namespace formularios
{
    public partial class FrmAgregarCorte : Form
    {
        private string nuevoCorte;
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
            if (!(String.IsNullOrWhiteSpace(NuevoCorte)))
            {
                this.DialogResult = DialogResult.OK;
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