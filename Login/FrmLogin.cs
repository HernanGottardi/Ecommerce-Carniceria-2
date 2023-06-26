using ClasesCarniceria;
using ClasesCarniceria.Excepctions;

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
            this.txb_contraseņa.Text = contraAutomatica;
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
            this.txb_contraseņa.Text = contraAutomatica;
        }

        /// <summary>
        /// Boton usado, una vez los datos de los campos son completados. 
        /// Verificando que tipo de usuario es.
        /// </summary>
        private void btn_ingresoManual_Click(object sender, EventArgs e)
        {
            // Informacion capturada en el formulario.
            string mail = this.txb_mail.Text;
            string contraseņa = this.txb_contraseņa.Text;

            try
            {
                Vendedor vendedor = new Vendedor();

                // validamos que exista.
                if (!vendedor.MailClienteExiste(mail) && !Carniceria.MailVendedorExiste(mail))
                {
                    MessageBox.Show("El usuario ingresado no existe!");
                }
                else
                {
                    // Validacion de formato MAIL-CONTRASEŅA y de que tipo de USUARIO es.
                    if (mail.ValidarCorreoElectronico() && contraseņa.CantidadCaracteresEnRango(8, 10))
                    {
                        if (DB_Cliente.Leer_cliente(mail, contraseņa) != null)
                        {
                            FrmVenta paginaVenta = new FrmVenta(mail, contraseņa);
                            paginaVenta.Show();
                            this.Hide();
                        }
                        else if (DB_vendedor.Leer_vendedor(mail, contraseņa) != null)
                        {
                            FrmHeladera paginaHeladera = new FrmHeladera(mail);
                            paginaHeladera.Show(this);
                            this.Hide();
                        }
                        else 
                        {
                            MessageBox.Show("Contraseņa incorrecta!");
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

    }
}