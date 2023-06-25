namespace formularios
{
    partial class FrmAgregarProductos
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
            lb_tituloAgregarProducto = new Label();
            lb_PrecioPorKilo = new Label();
            nud_precioPorKilogramo = new NumericUpDown();
            nud_cantidadKilogramos = new NumericUpDown();
            lb_cantidadKilos = new Label();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            cb_tipoDeCorte = new ComboBox();
            lb_tipoDeCorteDeCarne = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_precioPorKilogramo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_cantidadKilogramos).BeginInit();
            SuspendLayout();
            // 
            // lb_tituloAgregarProducto
            // 
            lb_tituloAgregarProducto.AutoSize = true;
            lb_tituloAgregarProducto.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tituloAgregarProducto.ForeColor = Color.White;
            lb_tituloAgregarProducto.Location = new Point(176, 36);
            lb_tituloAgregarProducto.Name = "lb_tituloAgregarProducto";
            lb_tituloAgregarProducto.Size = new Size(401, 60);
            lb_tituloAgregarProducto.TabIndex = 0;
            lb_tituloAgregarProducto.Text = "Agregar producto...";
            // 
            // lb_PrecioPorKilo
            // 
            lb_PrecioPorKilo.AutoSize = true;
            lb_PrecioPorKilo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_PrecioPorKilo.ForeColor = Color.White;
            lb_PrecioPorKilo.Location = new Point(176, 276);
            lb_PrecioPorKilo.Name = "lb_PrecioPorKilo";
            lb_PrecioPorKilo.Size = new Size(201, 28);
            lb_PrecioPorKilo.TabIndex = 4;
            lb_PrecioPorKilo.Text = "Precio por kilogramo:";
            lb_PrecioPorKilo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nud_precioPorKilogramo
            // 
            nud_precioPorKilogramo.Location = new Point(176, 307);
            nud_precioPorKilogramo.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_precioPorKilogramo.Name = "nud_precioPorKilogramo";
            nud_precioPorKilogramo.Size = new Size(399, 27);
            nud_precioPorKilogramo.TabIndex = 3;
            // 
            // nud_cantidadKilogramos
            // 
            nud_cantidadKilogramos.Location = new Point(176, 238);
            nud_cantidadKilogramos.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_cantidadKilogramos.Name = "nud_cantidadKilogramos";
            nud_cantidadKilogramos.Size = new Size(399, 27);
            nud_cantidadKilogramos.TabIndex = 5;
            // 
            // lb_cantidadKilos
            // 
            lb_cantidadKilos.AutoSize = true;
            lb_cantidadKilos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_cantidadKilos.ForeColor = Color.White;
            lb_cantidadKilos.Location = new Point(176, 207);
            lb_cantidadKilos.Name = "lb_cantidadKilos";
            lb_cantidadKilos.Size = new Size(227, 28);
            lb_cantidadKilos.TabIndex = 6;
            lb_cantidadKilos.Text = "Cantidad de Kilogramos:";
            lb_cantidadKilos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.Black;
            btn_aceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_aceptar.ForeColor = Color.White;
            btn_aceptar.Location = new Point(176, 365);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(141, 43);
            btn_aceptar.TabIndex = 7;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Black;
            btn_cancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Location = new Point(434, 365);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(141, 43);
            btn_cancelar.TabIndex = 8;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // cb_tipoDeCorte
            // 
            cb_tipoDeCorte.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipoDeCorte.FormattingEnabled = true;
            cb_tipoDeCorte.Location = new Point(176, 165);
            cb_tipoDeCorte.Name = "cb_tipoDeCorte";
            cb_tipoDeCorte.Size = new Size(399, 28);
            cb_tipoDeCorte.TabIndex = 9;
            // 
            // lb_tipoDeCorteDeCarne
            // 
            lb_tipoDeCorteDeCarne.AutoSize = true;
            lb_tipoDeCorteDeCarne.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tipoDeCorteDeCarne.ForeColor = Color.White;
            lb_tipoDeCorteDeCarne.Location = new Point(176, 134);
            lb_tipoDeCorteDeCarne.Name = "lb_tipoDeCorteDeCarne";
            lb_tipoDeCorteDeCarne.Size = new Size(211, 28);
            lb_tipoDeCorteDeCarne.TabIndex = 10;
            lb_tipoDeCorteDeCarne.Text = "Tipo de corte de carne:";
            // 
            // FrmAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(772, 450);
            Controls.Add(lb_tipoDeCorteDeCarne);
            Controls.Add(cb_tipoDeCorte);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(lb_cantidadKilos);
            Controls.Add(nud_cantidadKilogramos);
            Controls.Add(lb_PrecioPorKilo);
            Controls.Add(nud_precioPorKilogramo);
            Controls.Add(lb_tituloAgregarProducto);
            ForeColor = Color.Black;
            Name = "FrmAgregarProductos";
            Text = "Agregar Producto";
            Load += FrmAgregarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)nud_precioPorKilogramo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_cantidadKilogramos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_tituloAgregarProducto;
        private Label lb_PrecioPorKilo;
        private NumericUpDown nud_precioPorKilogramo;
        private NumericUpDown nud_cantidadKilogramos;
        private Label lb_cantidadKilos;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private ComboBox cb_tipoDeCorte;
        private Label lb_tipoDeCorteDeCarne;
    }
}