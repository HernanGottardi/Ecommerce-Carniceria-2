using ClasesCarniceria;
using ClasesCarniceria.Excepctions;
using ClasesCarniceria.MetodosDeExt;

namespace formularios
{
    public partial class FrmModificarContraseña : Form
    {
        private string nuevaContraseña;
        private string mail;

        public string NuevaContraseña { get => nuevaContraseña; set => nuevaContraseña = value; }
        public string Mail { get => mail; set => mail = value; }
        public FrmModificarContraseña(string mail)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Mail = mail;
        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {

            this.NuevaContraseña = txb_nuevaContraseña.Text;
            try
            {
                Cliente c = DB_Cliente.Leer_cliente(this.Mail);
                if (c.Contraseña == this.NuevaContraseña)
                {
                    MessageBox.Show("Tu contraseña debe ser diferente a tu contraseña actual!");
                }
                else
                {
                    if (c != null)
                    {
                        if (this.nuevaContraseña.ValidarContraseña())
                        {
                            if (DB_Cliente.Modificar_contraseña_cliente(this.Mail, this.NuevaContraseña))
                            {
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, el Usuario no fue encontrado.");
                    }
                }
            }
            catch (CantidadDeCaracteresException ex)
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
            catch (ContraseñaCaracteresInvalidos ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}