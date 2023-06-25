namespace formularios
{
    partial class FrmModificarProducto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsb_listaProductos = new ListBox();
            lb_listarProductos = new Label();
            lb_modificarProducto = new Label();
            nud_cantidadKilos = new NumericUpDown();
            nud_precioKilo = new NumericUpDown();
            cb_tipoCorte = new ComboBox();
            lb_TipoCorte = new Label();
            lb_cantidadKilos = new Label();
            lb_precioPorkilo = new Label();
            button_modificar = new Button();
            btn_cancelar = new Button();
            txb_detallarProducto = new TextBox();
            btn_detallar = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_cantidadKilos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_precioKilo).BeginInit();
            SuspendLayout();
            // 
            // lsb_listaProductos
            // 
            lsb_listaProductos.FormattingEnabled = true;
            lsb_listaProductos.ItemHeight = 20;
            lsb_listaProductos.Location = new Point(12, 106);
            lsb_listaProductos.Name = "lsb_listaProductos";
            lsb_listaProductos.Size = new Size(350, 184);
            lsb_listaProductos.TabIndex = 0;
            // 
            // lb_listarProductos
            // 
            lb_listarProductos.AutoSize = true;
            lb_listarProductos.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_listarProductos.ForeColor = Color.White;
            lb_listarProductos.Location = new Point(12, 57);
            lb_listarProductos.Name = "lb_listarProductos";
            lb_listarProductos.Size = new Size(350, 26);
            lb_listarProductos.TabIndex = 1;
            lb_listarProductos.Text = "Seleccionar producto a modificar:";
            // 
            // lb_modificarProducto
            // 
            lb_modificarProducto.AutoSize = true;
            lb_modificarProducto.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_modificarProducto.ForeColor = Color.White;
            lb_modificarProducto.Location = new Point(482, 57);
            lb_modificarProducto.Name = "lb_modificarProducto";
            lb_modificarProducto.Size = new Size(174, 26);
            lb_modificarProducto.TabIndex = 2;
            lb_modificarProducto.Text = "Modificar datos:";
            // 
            // nud_cantidadKilos
            // 
            nud_cantidadKilos.Location = new Point(482, 238);
            nud_cantidadKilos.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nud_cantidadKilos.Name = "nud_cantidadKilos";
            nud_cantidadKilos.Size = new Size(282, 27);
            nud_cantidadKilos.TabIndex = 3;
            // 
            // nud_precioKilo
            // 
            nud_precioKilo.Location = new Point(482, 327);
            nud_precioKilo.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nud_precioKilo.Name = "nud_precioKilo";
            nud_precioKilo.Size = new Size(282, 27);
            nud_precioKilo.TabIndex = 4;
            // 
            // cb_tipoCorte
            // 
            cb_tipoCorte.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipoCorte.FormattingEnabled = true;
            cb_tipoCorte.Location = new Point(482, 152);
            cb_tipoCorte.Name = "cb_tipoCorte";
            cb_tipoCorte.Size = new Size(282, 28);
            cb_tipoCorte.TabIndex = 5;
            // 
            // lb_TipoCorte
            // 
            lb_TipoCorte.AutoSize = true;
            lb_TipoCorte.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_TipoCorte.ForeColor = Color.White;
            lb_TipoCorte.Location = new Point(482, 121);
            lb_TipoCorte.Name = "lb_TipoCorte";
            lb_TipoCorte.Size = new Size(207, 28);
            lb_TipoCorte.TabIndex = 6;
            lb_TipoCorte.Text = "Tipo de corte de carne";
            // 
            // lb_cantidadKilos
            // 
            lb_cantidadKilos.AutoSize = true;
            lb_cantidadKilos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_cantidadKilos.ForeColor = Color.White;
            lb_cantidadKilos.Location = new Point(482, 207);
            lb_cantidadKilos.Name = "lb_cantidadKilos";
            lb_cantidadKilos.Size = new Size(163, 28);
            lb_cantidadKilos.TabIndex = 7;
            lb_cantidadKilos.Text = "Cantidad de kilos";
            // 
            // lb_precioPorkilo
            // 
            lb_precioPorkilo.AutoSize = true;
            lb_precioPorkilo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_precioPorkilo.ForeColor = Color.White;
            lb_precioPorkilo.Location = new Point(482, 296);
            lb_precioPorkilo.Name = "lb_precioPorkilo";
            lb_precioPorkilo.Size = new Size(139, 28);
            lb_precioPorkilo.TabIndex = 8;
            lb_precioPorkilo.Text = "Precio por kilo";
            // 
            // button_modificar
            // 
            button_modificar.BackColor = Color.Black;
            button_modificar.ForeColor = Color.White;
            button_modificar.Location = new Point(482, 385);
            button_modificar.Name = "button_modificar";
            button_modificar.Size = new Size(124, 45);
            button_modificar.TabIndex = 9;
            button_modificar.Text = "Modificar";
            button_modificar.UseVisualStyleBackColor = false;
            button_modificar.Click += button_modificar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Black;
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Location = new Point(642, 385);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(124, 45);
            btn_cancelar.TabIndex = 10;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // txb_detallarProducto
            // 
            txb_detallarProducto.Location = new Point(12, 352);
            txb_detallarProducto.Multiline = true;
            txb_detallarProducto.Name = "txb_detallarProducto";
            txb_detallarProducto.ReadOnly = true;
            txb_detallarProducto.Size = new Size(350, 78);
            txb_detallarProducto.TabIndex = 11;
            // 
            // btn_detallar
            // 
            btn_detallar.Location = new Point(12, 306);
            btn_detallar.Name = "btn_detallar";
            btn_detallar.Size = new Size(174, 29);
            btn_detallar.TabIndex = 12;
            btn_detallar.Text = "Detallar producto";
            btn_detallar.UseVisualStyleBackColor = true;
            btn_detallar.Click += btn_detallar_Click;
            // 
            // FrmModificarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_detallar);
            Controls.Add(txb_detallarProducto);
            Controls.Add(btn_cancelar);
            Controls.Add(button_modificar);
            Controls.Add(lb_precioPorkilo);
            Controls.Add(lb_cantidadKilos);
            Controls.Add(lb_TipoCorte);
            Controls.Add(cb_tipoCorte);
            Controls.Add(nud_precioKilo);
            Controls.Add(nud_cantidadKilos);
            Controls.Add(lb_modificarProducto);
            Controls.Add(lb_listarProductos);
            Controls.Add(lsb_listaProductos);
            Name = "FrmModificarProducto";
            Text = "Modificar Producto";
            Load += FrmModificarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)nud_cantidadKilos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_precioKilo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsb_listaProductos;
        private Label lb_listarProductos;
        private Label lb_modificarProducto;
        private NumericUpDown nud_cantidadKilos;
        private NumericUpDown nud_precioKilo;
        private ComboBox cb_tipoCorte;
        private Label lb_TipoCorte;
        private Label lb_cantidadKilos;
        private Label lb_precioPorkilo;
        private Button button_modificar;
        private Button btn_cancelar;
        private TextBox txb_detallarProducto;
        private Button btn_detallar;
    }
}