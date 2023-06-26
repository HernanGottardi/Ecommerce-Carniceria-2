namespace formularios
{
    partial class FrmModificarMonto
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
            lb_ingresar = new Label();
            txb_nuevoMonto = new TextBox();
            btn_modificar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // lb_montoActual
            // 
            lb_montoActual.AutoSize = true;
            lb_montoActual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_montoActual.Location = new Point(36, 53);
            lb_montoActual.Name = "lb_montoActual";
            lb_montoActual.Size = new Size(225, 28);
            lb_montoActual.TabIndex = 0;
            lb_montoActual.Text = "Tu Monto actual es de: $";
            // 
            // lb_ingresar
            // 
            lb_ingresar.AutoSize = true;
            lb_ingresar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ingresar.Location = new Point(36, 129);
            lb_ingresar.Name = "lb_ingresar";
            lb_ingresar.Size = new Size(189, 23);
            lb_ingresar.TabIndex = 1;
            lb_ingresar.Text = "Ingresar nuevo Monto: ";
            // 
            // txb_nuevoMonto
            // 
            txb_nuevoMonto.Location = new Point(36, 165);
            txb_nuevoMonto.Name = "txb_nuevoMonto";
            txb_nuevoMonto.Size = new Size(320, 27);
            txb_nuevoMonto.TabIndex = 2;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.SteelBlue;
            btn_modificar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_modificar.ForeColor = Color.White;
            btn_modificar.Location = new Point(36, 236);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(117, 41);
            btn_modificar.TabIndex = 3;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.SteelBlue;
            btn_cancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Location = new Point(239, 236);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(117, 41);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // FrmModificarMonto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(528, 305);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_modificar);
            Controls.Add(txb_nuevoMonto);
            Controls.Add(lb_ingresar);
            Controls.Add(lb_montoActual);
            Name = "FrmModificarMonto";
            Text = "Modificar monto";
            Load += FrmModificarMonto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_montoActual;
        private Label lb_ingresar;
        private TextBox txb_nuevoMonto;
        private Button btn_modificar;
        private Button btn_cancelar;
    }
}