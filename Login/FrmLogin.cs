using ClasesCarniceria;
using ClasesCarniceria.Excepctions;
using ClasesCarniceria.MetodosDeExt;

namespace formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Rellenar los campos para entrar como cliente.
        /// </summary>
        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            string mailAutomatico = "LeonelMessi@gmail.com";
            string contraAutomatica = "12345678";

            if (DB_Cliente.Leer_cliente(mailAutomatico, contraAutomatica) == null)
            {
                Cliente c = new Cliente(mailAutomatico, contraAutomatica);
                DB_Cliente.Agregar_cliente(c);
            }
            this.txb_mail.Text = mailAutomatico;
            this.txb_contrase�a.Text = contraAutomatica;
        }

        /// <summary>
        /// Rellenar los campos para entrar como vendedor.
        /// </summary>
        private void btn_Vendedor_Click(object sender, EventArgs e)
        {
            // Relleno los datos para vendedor con datos que se que existe.
            string mailAutomatico = "SoyFulanito@gmail.com";
            string contraAutomatica = "12345678";

            if (DB_vendedor.Leer_vendedor(mailAutomatico, contraAutomatica) == null)
            {
                Vendedor v = new Vendedor(mailAutomatico, contraAutomatica);
                DB_vendedor.Agregar_vendedor(v);
            }
            this.txb_mail.Text = mailAutomatico;
            this.txb_contrase�a.Text = contraAutomatica;
        }

        /// <summary>
        /// Boton usado, una vez los datos de los campos son completados. 
        /// Verificando que tipo de usuario es.
        /// </summary>
        private void btn_ingresoManual_Click(object sender, EventArgs e)
        {
            // Informacion capturada en el formulario.
            string mail = this.txb_mail.Text;
            string contrase�a = this.txb_contrase�a.Text;

            try
            {
                // Validacion de formato MAIL-CONTRASE�A y de que tipo de USUARIO es.
                if (mail.ValidarCorreoElectronico() && contrase�a.ValidarContrase�a())
                {
                    if (DB_Cliente.Leer_cliente(mail, contrase�a) != null)
                    {
                        FrmVenta paginaVenta = new FrmVenta(mail, contrase�a);
                        paginaVenta.Show();
                        this.Hide();
                    }
                    else if (DB_vendedor.Leer_vendedor(mail, contrase�a) != null)
                    {
                        FrmHeladera paginaHeladera = new FrmHeladera(mail);
                        paginaHeladera.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario ingresado no existen");
                    }
                }             
            }
            catch (TextoNuloException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CorreoCaracteresInvalidos ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Contrase�aCaracteresInvalidos ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CantidadDeCaracteresException ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}