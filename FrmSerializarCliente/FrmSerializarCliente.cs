using ClasesCarniceria;
using ClasesCarniceria.Excepctions;

namespace formularios
{
    public partial class FrmSerializarCliente : Form
    {
        public FrmSerializarCliente()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> listaClientes = DB_Cliente.Leer_clientes();

                if (rb_xml.Checked == true && rb_serializar.Checked == true)
                {
                    SerializarDeserializar<List<Cliente>>.Serializar_lista_XML(listaClientes, "clientesXML");
                    this.DialogResult = DialogResult.OK;
                }
                else if (rb_xml.Checked == true && rb_deserializar.Checked == true)
                {
                    List<Cliente> lista = SerializarDeserializar<List<Cliente>>.Deserializar_lista_XML<Cliente>("clientesXML");
                    // mostrar lista
                    if (lista != null)
                    {
                        this.rtb_deserializado.Text = Carniceria.MostrarCliente(lista);
                    }
                    else
                    {
                        MessageBox.Show("Lista es nula.");
                    }
                }
                else if (rb_json.Checked == true && rb_serializar.Checked == true)
                {
                    SerializarDeserializar<List<Cliente>>.Serializar_lista_JSON(listaClientes, "clientesJSON");
                    this.DialogResult = DialogResult.OK;
                }
                else if (rb_json.Checked == true && rb_deserializar.Checked == true)
                {
                    List<Cliente> lista = SerializarDeserializar<List<Cliente>>.Deserializar_lista_JSON<Cliente>("clientesJSON");
                    if (lista != null)
                    {
                        this.rtb_deserializado.Text = Carniceria.MostrarCliente(lista);
                    }
                    else
                    {
                        MessageBox.Show("Lista es nula.");
                    }
                }
                else
                {
                    MessageBox.Show("Algun dato no fue seleccionado.");
                }
            }
            catch (ArchivoNoEncontradoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}