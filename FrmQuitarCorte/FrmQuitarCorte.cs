using ClasesCarniceria;
using ClasesCarniceria.SQL;

namespace formularios
{
    public partial class FrmQuitarCorte : Form
    {
        public FrmQuitarCorte()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// Limpio y cargo la list box con la lista de cortes de tipos de corte
        /// </summary>

        private void FrmQuitarCorte_Load(object sender, EventArgs e)
        {
            this.lsb_listaDeCortes.Items.Clear();
            List<string> lista = DB_Corte.Leer_cortes();
            foreach (string corte in lista)
            {
                this.lsb_listaDeCortes.Items.Add(corte);
            }
        }
        /// <summary>
        /// Compruebo si hay un elemento seleccionado y quito el que este seleccionado.
        /// </summary>
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (this.lsb_listaDeCortes.SelectedItem is not null)
            {
                string corteSelec = this.lsb_listaDeCortes.SelectedItem.ToString();
                DB_Corte.Borrar_corte(corteSelec);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}