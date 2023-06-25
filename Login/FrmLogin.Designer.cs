namespace formularios
{
    partial class FrmLogin
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
            txb_mail = new TextBox();
            txb_contraseña = new TextBox();
            label1 = new Label();
            btn_Cliente = new Button();
            label3 = new Label();
            btn_Vendedor = new Button();
            btn_ingresoManual = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txb_mail
            // 
            txb_mail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_mail.Location = new Point(130, 145);
            txb_mail.Name = "txb_mail";
            txb_mail.PlaceholderText = "Ejemplo: hernan@gmail.com";
            txb_mail.Size = new Size(531, 34);
            txb_mail.TabIndex = 0;
            // 
            // txb_contraseña
            // 
            txb_contraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_contraseña.Location = new Point(130, 302);
            txb_contraseña.Name = "txb_contraseña";
            txb_contraseña.PasswordChar = '*';
            txb_contraseña.PlaceholderText = "********";
            txb_contraseña.Size = new Size(531, 34);
            txb_contraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(207, 72);
            label1.Name = "label1";
            label1.Size = new Size(298, 46);
            label1.TabIndex = 2;
            label1.Text = "Correo Electronico";
            // 
            // btn_Cliente
            // 
            btn_Cliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cliente.Location = new Point(386, 380);
            btn_Cliente.Name = "btn_Cliente";
            btn_Cliente.Size = new Size(134, 47);
            btn_Cliente.TabIndex = 4;
            btn_Cliente.Text = "Cliente";
            btn_Cliente.UseVisualStyleBackColor = true;
            btn_Cliente.Click += btn_Cliente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(207, 234);
            label3.Name = "label3";
            label3.Size = new Size(189, 46);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // btn_Vendedor
            // 
            btn_Vendedor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Vendedor.Location = new Point(527, 380);
            btn_Vendedor.Name = "btn_Vendedor";
            btn_Vendedor.Size = new Size(134, 47);
            btn_Vendedor.TabIndex = 6;
            btn_Vendedor.Text = "Vendedor";
            btn_Vendedor.UseVisualStyleBackColor = true;
            btn_Vendedor.Click += btn_Vendedor_Click;
            // 
            // btn_ingresoManual
            // 
            btn_ingresoManual.BackColor = Color.DarkSlateBlue;
            btn_ingresoManual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ingresoManual.ForeColor = Color.White;
            btn_ingresoManual.Location = new Point(130, 380);
            btn_ingresoManual.Name = "btn_ingresoManual";
            btn_ingresoManual.Size = new Size(144, 47);
            btn_ingresoManual.TabIndex = 7;
            btn_ingresoManual.Text = "Ingresar";
            btn_ingresoManual.UseVisualStyleBackColor = false;
            btn_ingresoManual.Click += btn_ingresoManual_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = global::FrmLogin.Properties.Resources.usuario_png;
            pictureBox1.Location = new Point(130, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 56);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = global::FrmLogin.Properties.Resources.contraseña_png;
            pictureBox2.Location = new Point(130, 234);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = global::FrmLogin.Properties.Resources.FondoLogin;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_ingresoManual);
            Controls.Add(btn_Vendedor);
            Controls.Add(label3);
            Controls.Add(btn_Cliente);
            Controls.Add(label1);
            Controls.Add(txb_contraseña);
            Controls.Add(txb_mail);
            Name = "FrmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_mail;
        private TextBox txb_contraseña;
        private Label label1;
        private Button btn_Cliente;
        private Label label3;
        private Button btn_Vendedor;
        private Button btn_ingresoManual;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}