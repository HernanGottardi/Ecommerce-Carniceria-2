namespace formularios
{
    partial class FrmFactura
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
            lb_tituloFactura = new Label();
            txb_nombreKilos = new TextBox();
            txb_formaDePago = new TextBox();
            txb_precioFinal = new TextBox();
            btn_confirmar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // lb_tituloFactura
            // 
            lb_tituloFactura.AutoSize = true;
            lb_tituloFactura.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tituloFactura.Location = new Point(58, 36);
            lb_tituloFactura.Name = "lb_tituloFactura";
            lb_tituloFactura.Size = new Size(295, 46);
            lb_tituloFactura.TabIndex = 0;
            lb_tituloFactura.Text = "Detalle de compra";
            // 
            // txb_nombreKilos
            // 
            txb_nombreKilos.BackColor = Color.White;
            txb_nombreKilos.ForeColor = Color.Black;
            txb_nombreKilos.Location = new Point(58, 121);
            txb_nombreKilos.Margin = new Padding(3, 4, 3, 4);
            txb_nombreKilos.Name = "txb_nombreKilos";
            txb_nombreKilos.ReadOnly = true;
            txb_nombreKilos.Size = new Size(290, 27);
            txb_nombreKilos.TabIndex = 1;
            // 
            // txb_formaDePago
            // 
            txb_formaDePago.Location = new Point(58, 207);
            txb_formaDePago.Margin = new Padding(3, 4, 3, 4);
            txb_formaDePago.Name = "txb_formaDePago";
            txb_formaDePago.ReadOnly = true;
            txb_formaDePago.Size = new Size(290, 27);
            txb_formaDePago.TabIndex = 2;
            // 
            // txb_precioFinal
            // 
            txb_precioFinal.Location = new Point(58, 293);
            txb_precioFinal.Margin = new Padding(3, 4, 3, 4);
            txb_precioFinal.Name = "txb_precioFinal";
            txb_precioFinal.ReadOnly = true;
            txb_precioFinal.Size = new Size(290, 27);
            txb_precioFinal.TabIndex = 3;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(58, 369);
            btn_confirmar.Margin = new Padding(3, 4, 3, 4);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(121, 53);
            btn_confirmar.TabIndex = 4;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click_1;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(227, 369);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(121, 53);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 476);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_confirmar);
            Controls.Add(txb_precioFinal);
            Controls.Add(txb_formaDePago);
            Controls.Add(txb_nombreKilos);
            Controls.Add(lb_tituloFactura);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmFactura";
            Text = "Detalles Compra";
            Load += FrmFactura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_tituloFactura;
        private TextBox txb_nombreKilos;
        private TextBox txb_formaDePago;
        private TextBox txb_precioFinal;
        private Button btn_confirmar;
        private Button btn_cancelar;
    }
}