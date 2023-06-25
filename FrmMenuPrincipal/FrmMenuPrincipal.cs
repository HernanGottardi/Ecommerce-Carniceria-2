using formularios;

namespace formularios
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            FrmLogin form = new FrmLogin();
            form.Show(this);
            this.Hide();
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            FrmRegistro form = new FrmRegistro();
            DialogResult res = form.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                FrmLogin formL = new FrmLogin();
                formL.Show(this);
                this.Hide();
            }
            //this.Hide();
        }
    }
}