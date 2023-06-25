using ClasesCarniceria;
using ClasesCarniceria.Excepctions;

namespace formularios
{
    public partial class FrmRegistro : Form
    {
        protected string correo;
        protected string contrase�a;
        public FrmRegistro()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.correo = tb_correoElectronico.Text;
            this.contrase�a = tb_contrase�a.Text;

            //  VALIDACION 
            // ------------------> Falta agregar si existe o no el correo en la DB.
            try
            {
                if (correo.ValidarCorreoElectronico() == true && contrase�a.CantidadCaracteresEnRango(8, 10))
                {
                    MessageBox.Show("Tu Registro salio exitoso!");
                    Cliente c = new Cliente(correo, contrase�a);
                    DB_Cliente.Agregar_cliente(c, 0);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("La contrase�a debe tener entre 8 y 10 caracteres!");
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}