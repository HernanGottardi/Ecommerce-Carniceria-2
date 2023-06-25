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
            string mailAutomatico = "nora@gmail.com";
            string contraAutomatica = "12345678";

            if (DB_Cliente.Leer_cliente(mailAutomatico, contraAutomatica) == null)
            {
                Cliente c = new Cliente(mailAutomatico, contraAutomatica);
                DB_Cliente.Agregar_cliente(c, 0);
            }
            this.txb_mail.Text = mailAutomatico;
            this.txb_contraseña.Text = contraAutomatica;
        }

        /// <summary>
        /// Rellenar los campos para entrar como vendedor.
        /// </summary>
        private void btn_Vendedor_Click(object sender, EventArgs e)
        {
            // Relleno los datos para vendedor con datos que se que existe.
            string mailAutomatico = "messi@gmail.com";
            string contraAutomatica = "12345678";

            if (DB_vendedor.Leer_vendedor(mailAutomatico, contraAutomatica) == null)
            {
                Vendedor v = new Vendedor(mailAutomatico, contraAutomatica);
                DB_vendedor.Agregar_vendedor(v);
            }
            this.txb_mail.Text = mailAutomatico;
            this.txb_contraseña.Text = contraAutomatica;
        }

        /// <summary>
        /// Boton usado, una vez los datos de los campos son completados. 
        /// Verificando que tipo de usuario es.
        /// </summary>
        private void btn_ingresoManual_Click(object sender, EventArgs e)
        {
            // Informacion capturada en el formulario.
            string mail = this.txb_mail.Text;
            string contraseña = this.txb_contraseña.Text;

            try
            {
                // Validacion de formato MAIL y CONTRASEÑA
                if (mail.ValidarCorreoElectronico() && contraseña.CantidadCaracteresEnRango(8, 10))
                {
                    if (DB_Cliente.Leer_cliente(mail, contraseña) != null)
                    {
                        // Invoco y muestro el formulario Venta.
                        FrmVenta paginaVenta = new FrmVenta(mail, contraseña);
                        paginaVenta.Show();
                        // Oculto el formulario Login.
                        this.Hide();
                    }
                    else if (DB_vendedor.Leer_vendedor(mail, contraseña) != null)
                    {
                        // Invoco y muestro el formulario Heladera.
                        FrmHeladera paginaHeladera = new FrmHeladera(mail);
                        paginaHeladera.Show(this);
                        // Oculto el formulario Login.
                        this.Hide();
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