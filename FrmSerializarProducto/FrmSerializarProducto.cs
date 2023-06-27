using ClasesCarniceria;
using ClasesCarniceria.Excepctions;
using ClasesCarniceria.Serializacion;
using ClasesCarniceria.SQL;
using System.Collections.Generic;

namespace formularios
{
    public partial class FrmSerializarProducto : Form
    {
        public FrmSerializarProducto()
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
                List<Carne> listaProducto = DB_Carne.Leer_carnes();

                if (rb_xml.Checked == true && rb_serializar.Checked == true)
                {
                    SerializarDeserializar<List<Carne>>.Serializar_lista_XML(listaProducto, "productosXML");
                    this.DialogResult = DialogResult.OK;
                }
                else if (rb_xml.Checked == true && rb_deserializar.Checked == true)
                {
                    List<Carne> lista = SerializarDeserializar<List<Carne>>.Deserializar_lista_XML<Carne>("productosXML");
                    // mostrar lista
                    if (lista != null)
                    {
                        this.rtb_deserializado.Text = Carniceria.MostrarProductos(lista);
                    }
                    else 
                    {
                        MessageBox.Show("Lista es nula.");
                    }
                }
                else if (rb_json.Checked == true && rb_serializar.Checked == true)
                {
                    SerializarDeserializar<List<Carne>>.Serializar_lista_JSON(listaProducto, "productosJSON");
                    this.DialogResult = DialogResult.OK;
                }
                else if (rb_json.Checked == true && rb_deserializar.Checked == true)
                {
                    List<Carne> lista = SerializarDeserializar<List<Carne>>.Deserializar_lista_JSON<Carne>("productosJSON");
                    if (lista != null)
                    {
                        this.rtb_deserializado.Text = Carniceria.MostrarProductos(lista);
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

        //private void btn_cancelar_Click(object sender, EventArgs e)
        //{
        //    this.DialogResult = DialogResult.Cancel;
        //}

    }
}