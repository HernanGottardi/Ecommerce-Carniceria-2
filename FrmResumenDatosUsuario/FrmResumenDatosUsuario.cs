using ClasesCarniceria;

namespace formularios
{
    public partial class FrmResumenDatosUsuario : Form
    {
        Cliente c;
        private string mail;

        public string Mail { get => mail; set => mail = value; }

        public FrmResumenDatosUsuario(string mail)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Mail = mail;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar su Usuario?", "Confirmación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                DB_Cliente.Borrar_cliente(c.Mail, c.Contraseña);
                this.DialogResult = DialogResult.OK;
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Has seleccionado Cancelar");
            }
            

        }

        private void FrmResumenDatosUsuario_Load(object sender, EventArgs e)
        {
            this.c = DB_Cliente.Leer_cliente(this.Mail);

            if (c != null)
            {
                lb_mail.Text = "# Correo Electronico: " + c.Mail;
                lb_contraseña.Text = "# Contraseña: " + c.Contraseña;
                lb_monto.Text = "# Monto: $" + c.CantidadDinero;  
            }
            else
            {
                MessageBox.Show("El Usuario no fue encontrado.");
            }

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}