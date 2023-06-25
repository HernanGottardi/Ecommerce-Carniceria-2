namespace formularios
{
    partial class FrmElegirProducto
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
            lb_montoActual = new Label();
            lsb_listaProductos = new ListBox();
            txb_buscadorProductos = new TextBox();
            btn_buscadorProductos = new Button();
            txb_detalles = new TextBox();
            lb_detalles = new Label();
            lb_cantidadKilos = new Label();
            nud_cantidadKilos = new NumericUpDown();
            btn_comprar = new Button();
            cb_formasDePago = new ComboBox();
            lb_formaDePago = new Label();
            btn_detallar = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_cantidadKilos).BeginInit();
            SuspendLayout();
            // 
            // lb_montoActual
            // 
            lb_montoActual.AutoSize = true;
            lb_montoActual.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_montoActual.Location = new Point(12, 19);
            lb_montoActual.Name = "lb_montoActual";
            lb_montoActual.Size = new Size(121, 25);
            lb_montoActual.TabIndex = 0;
            lb_montoActual.Text = "Monto actual:";
            // 
            // lsb_listaProductos
            // 
            lsb_listaProductos.FormattingEnabled = true;
            lsb_listaProductos.ItemHeight = 20;
            lsb_listaProductos.Location = new Point(12, 117);
            lsb_listaProductos.Name = "lsb_listaProductos";
            lsb_listaProductos.Size = new Size(371, 184);
            lsb_listaProductos.TabIndex = 1;
            // 
            // txb_buscadorProductos
            // 
            txb_buscadorProductos.Location = new Point(12, 84);
            txb_buscadorProductos.Name = "txb_buscadorProductos";
            txb_buscadorProductos.PlaceholderText = "Producto a buscar...";
            txb_buscadorProductos.Size = new Size(230, 27);
            txb_buscadorProductos.TabIndex = 2;
            // 
            // btn_buscadorProductos
            // 
            btn_buscadorProductos.Location = new Point(248, 84);
            btn_buscadorProductos.Name = "btn_buscadorProductos";
            btn_buscadorProductos.Size = new Size(135, 27);
            btn_buscadorProductos.TabIndex = 3;
            btn_buscadorProductos.Text = "Buscar";
            btn_buscadorProductos.UseVisualStyleBackColor = true;
            btn_buscadorProductos.Click += btn_buscadorProductos_Click;
            // 
            // txb_detalles
            // 
            txb_detalles.Location = new Point(12, 360);
            txb_detalles.Multiline = true;
            txb_detalles.Name = "txb_detalles";
            txb_detalles.ReadOnly = true;
            txb_detalles.Size = new Size(371, 73);
            txb_detalles.TabIndex = 4;
            // 
            // lb_detalles
            // 
            lb_detalles.AutoSize = true;
            lb_detalles.Location = new Point(159, 318);
            lb_detalles.Name = "lb_detalles";
            lb_detalles.Size = new Size(156, 20);
            lb_detalles.TabIndex = 5;
            lb_detalles.Text = "Detalles del producto:";
            // 
            // lb_cantidadKilos
            // 
            lb_cantidadKilos.AutoSize = true;
            lb_cantidadKilos.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_cantidadKilos.Location = new Point(508, 87);
            lb_cantidadKilos.Name = "lb_cantidadKilos";
            lb_cantidadKilos.Size = new Size(198, 25);
            lb_cantidadKilos.TabIndex = 6;
            lb_cantidadKilos.Text = "Elegir cantidad de kilos:";
            // 
            // nud_cantidadKilos
            // 
            nud_cantidadKilos.Location = new Point(508, 128);
            nud_cantidadKilos.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_cantidadKilos.Name = "nud_cantidadKilos";
            nud_cantidadKilos.Size = new Size(255, 27);
            nud_cantidadKilos.TabIndex = 7;
            // 
            // btn_comprar
            // 
            btn_comprar.BackColor = Color.SteelBlue;
            btn_comprar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_comprar.ForeColor = Color.White;
            btn_comprar.Location = new Point(508, 360);
            btn_comprar.Name = "btn_comprar";
            btn_comprar.Size = new Size(255, 73);
            btn_comprar.TabIndex = 8;
            btn_comprar.Text = "Comprar";
            btn_comprar.UseVisualStyleBackColor = false;
            btn_comprar.Click += btn_comprar_Click;
            // 
            // cb_formasDePago
            // 
            cb_formasDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_formasDePago.FormattingEnabled = true;
            cb_formasDePago.Location = new Point(508, 273);
            cb_formasDePago.Name = "cb_formasDePago";
            cb_formasDePago.Size = new Size(255, 28);
            cb_formasDePago.TabIndex = 9;
            // 
            // lb_formaDePago
            // 
            lb_formaDePago.AutoSize = true;
            lb_formaDePago.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_formaDePago.Location = new Point(508, 237);
            lb_formaDePago.Name = "lb_formaDePago";
            lb_formaDePago.Size = new Size(174, 25);
            lb_formaDePago.TabIndex = 10;
            lb_formaDePago.Text = "Modalidad de pago:";
            // 
            // btn_detallar
            // 
            btn_detallar.Location = new Point(12, 314);
            btn_detallar.Name = "btn_detallar";
            btn_detallar.Size = new Size(135, 29);
            btn_detallar.TabIndex = 11;
            btn_detallar.Text = "Detallar";
            btn_detallar.UseVisualStyleBackColor = true;
            btn_detallar.Click += btn_detallar_Click;
            // 
            // FrmElegirProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_detallar);
            Controls.Add(lb_formaDePago);
            Controls.Add(cb_formasDePago);
            Controls.Add(btn_comprar);
            Controls.Add(nud_cantidadKilos);
            Controls.Add(lb_cantidadKilos);
            Controls.Add(lb_detalles);
            Controls.Add(txb_detalles);
            Controls.Add(btn_buscadorProductos);
            Controls.Add(txb_buscadorProductos);
            Controls.Add(lsb_listaProductos);
            Controls.Add(lb_montoActual);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmElegirProducto";
            Text = "Comprar Producto";
            Load += FrmElegirProducto_Load_1;
            ((System.ComponentModel.ISupportInitialize)nud_cantidadKilos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_montoActual;
        private ListBox lsb_listaProductos;
        private TextBox txb_buscadorProductos;
        private Button btn_buscadorProductos;
        private TextBox txb_detalles;
        private Label lb_detalles;
        private Label lb_cantidadKilos;
        private NumericUpDown nud_cantidadKilos;
        private Button btn_comprar;
        private ComboBox cb_formasDePago;
        private Label lb_formaDePago;
        private Button btn_detallar;
    }
}