using ClasesCarniceria;
using ClasesCarniceria.Excepctions;

namespace formularios
{
    public partial class FrmModificarMail : Form
    {
        private string correoNuevo;
        private string correoActual;

        public string CorreoNuevo { get => correoNuevo; set => correoNuevo = value; }

        public FrmModificarMail(string correoActual)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.correoActual = correoActual;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string nuevoCorreo = txb_nuevoMail.Text;
            Vendedor v = new Vendedor();
            try
            {
                if (v.MailClienteExiste(nuevoCorreo))
                {
                    MessageBox.Show("El Correo Electrónico ingresado ya existe!");
                }
                else
                {
                    if (nuevoCorreo.ValidarCorreoElectronico())
                    {
                        if (DB_Cliente.Modificar_mail_cliente(nuevoCorreo, correoActual))
                        {
                            correoNuevo = nuevoCorreo;
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("El nuevo Correo Electrónico no se pudo guardar.");
                        }
                    }
                }
            }
            catch (CorreoCantidadDeCaracteresException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CorreoCaracteresInvalidos ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (TextoNuloException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void MostrarMailActual() 
        {
            if (!string.IsNullOrEmpty(correoNuevo))
            {
                lb_mailActual.Text = $"Tu Correo Electrónico actual es: {correoNuevo}";
            }
            else
            {
                lb_mailActual.Text = $"Tu Correo Electrónico actual es: {correoActual}";
            }
        }

        private void FrmModificarMail_Load(object sender, EventArgs e)
        {
            this.MostrarMailActual();
        }
    }
}