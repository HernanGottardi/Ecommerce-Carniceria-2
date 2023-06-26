namespace formularios
{
    partial class FrmVenta
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
            lb_saludo = new Label();
            tx_saldo = new TextBox();
            lb_pedirMonto = new Label();
            bt_enviarMonto = new Button();
            SuspendLayout();
            // 
            // lb_saludo
            // 
            lb_saludo.AutoSize = true;
            lb_saludo.BackColor = Color.Transparent;
            lb_saludo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lb_saludo.ForeColor = Color.Black;
            lb_saludo.Location = new Point(62, 60);
            lb_saludo.Name = "lb_saludo";
            lb_saludo.Size = new Size(212, 46);
            lb_saludo.TabIndex = 0;
            lb_saludo.Text = "Hola Cliente!";
            lb_saludo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tx_saldo
            // 
            tx_saldo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tx_saldo.Location = new Point(62, 274);
            tx_saldo.Name = "tx_saldo";
            tx_saldo.PlaceholderText = "Ejemplo: 3000";
            tx_saldo.Size = new Size(323, 34);
            tx_saldo.TabIndex = 1;
            // 
            // lb_pedirMonto
            // 
            lb_pedirMonto.AutoSize = true;
            lb_pedirMonto.BackColor = Color.Transparent;
            lb_pedirMonto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lb_pedirMonto.ForeColor = Color.Black;
            lb_pedirMonto.Location = new Point(62, 200);
            lb_pedirMonto.Name = "lb_pedirMonto";
            lb_pedirMonto.Size = new Size(308, 35);
            lb_pedirMonto.TabIndex = 2;
            lb_pedirMonto.Text = "Ingresar saldo disponible: ";
            // 
            // bt_enviarMonto
            // 
            bt_enviarMonto.BackColor = Color.SteelBlue;
            bt_enviarMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_enviarMonto.ForeColor = Color.White;
            bt_enviarMonto.Location = new Point(62, 339);
            bt_enviarMonto.Name = "bt_enviarMonto";
            bt_enviarMonto.Size = new Size(323, 38);
            bt_enviarMonto.TabIndex = 3;
            bt_enviarMonto.Text = "Enviar";
            bt_enviarMonto.UseVisualStyleBackColor = false;
            bt_enviarMonto.Click += bt_enviarMonto_Click;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(674, 404);
            Controls.Add(bt_enviarMonto);
            Controls.Add(lb_pedirMonto);
            Controls.Add(tx_saldo);
            Controls.Add(lb_saludo);
            Name = "FrmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta";
            Load += FrmVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_saludo;
        private Label lb_pedirMonto;
        public TextBox tx_saldo;
        public Button bt_enviarMonto;
    }
}