using ClasesCarniceria;
using ClasesCarniceria.Excepctions;

namespace formularios
{
    public partial class FrmModificarMonto : Form
    {
        private decimal montoActual;
        private decimal nuevoMonto;
        private string correo;

        public decimal NuevoMonto { get => nuevoMonto; set => nuevoMonto = value; }
        public decimal MontoActual { get => montoActual; set => montoActual = value; }
        public string Correo { get => correo; set => correo = value; }

        public FrmModificarMonto(string correo, decimal montoActual)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.MontoActual = montoActual;
            this.Correo = correo;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

            if (decimal.TryParse(txb_nuevoMonto.Text, out this.nuevoMonto) && this.nuevoMonto != 0)
            {
                try
                {
                    Cliente c = DB_Cliente.Leer_cliente(this.Correo);
                    if (c != null)
                    {
                        if (DB_Cliente.Modificar_monto_cliente(c, nuevoMonto))
                        {
                            this.MontoActual = nuevoMonto;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Usuario no fue encontrado.");
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
            else
            {
                MessageBox.Show("El Monto ingresado es incorrecto.");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Mostrar()
        {
            if (this.NuevoMonto != 0)
            {
                lb_montoActual.Text = $"Tu Monto actual es de: ${this.NuevoMonto}";
            }
            else
            {
                lb_montoActual.Text = $"Tu Monto actual es de: ${this.montoActual}";
            }
        }

        private void FrmModificarMonto_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }
    }
}