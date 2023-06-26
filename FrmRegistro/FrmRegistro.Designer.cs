namespace formularios
{
    partial class FrmRegistro
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
            tb_correoElectronico = new TextBox();
            tb_contraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            groupBox1 = new GroupBox();
            rb_vendedor = new RadioButton();
            rb_Cliente = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_correoElectronico
            // 
            tb_correoElectronico.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tb_correoElectronico.Location = new Point(31, 169);
            tb_correoElectronico.Name = "tb_correoElectronico";
            tb_correoElectronico.PlaceholderText = "aaaaa@gmail.com";
            tb_correoElectronico.Size = new Size(522, 32);
            tb_correoElectronico.TabIndex = 0;
            // 
            // tb_contraseña
            // 
            tb_contraseña.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tb_contraseña.Location = new Point(31, 264);
            tb_contraseña.Name = "tb_contraseña";
            tb_contraseña.PasswordChar = '*';
            tb_contraseña.PlaceholderText = "*******";
            tb_contraseña.Size = new Size(522, 32);
            tb_contraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 124);
            label1.Name = "label1";
            label1.Size = new Size(250, 28);
            label1.TabIndex = 2;
            label1.Text = "Ingresar correo electronico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 223);
            label2.Name = "label2";
            label2.Size = new Size(186, 28);
            label2.TabIndex = 3;
            label2.Text = "ingresar contraseña:";
            // 
            // btn_aceptar
            // 
            btn_aceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_aceptar.Location = new Point(31, 318);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(158, 34);
            btn_aceptar.TabIndex = 4;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(395, 318);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(158, 34);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Maroon;
            groupBox1.Controls.Add(rb_vendedor);
            groupBox1.Controls.Add(rb_Cliente);
            groupBox1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(31, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 83);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo De Usuario: ";
            // 
            // rb_vendedor
            // 
            rb_vendedor.AutoSize = true;
            rb_vendedor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rb_vendedor.ForeColor = Color.White;
            rb_vendedor.Location = new Point(364, 38);
            rb_vendedor.Name = "rb_vendedor";
            rb_vendedor.Size = new Size(105, 27);
            rb_vendedor.TabIndex = 1;
            rb_vendedor.TabStop = true;
            rb_vendedor.Text = "Vendedor";
            rb_vendedor.UseVisualStyleBackColor = true;
            // 
            // rb_Cliente
            // 
            rb_Cliente.AutoSize = true;
            rb_Cliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rb_Cliente.ForeColor = Color.White;
            rb_Cliente.Location = new Point(45, 38);
            rb_Cliente.Name = "rb_Cliente";
            rb_Cliente.Size = new Size(84, 27);
            rb_Cliente.TabIndex = 0;
            rb_Cliente.TabStop = true;
            rb_Cliente.Text = "Cliente";
            rb_Cliente.UseVisualStyleBackColor = true;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(599, 374);
            Controls.Add(groupBox1);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_contraseña);
            Controls.Add(tb_correoElectronico);
            Name = "FrmRegistro";
            Text = "Registro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_correoElectronico;
        private TextBox tb_contraseña;
        private Label label1;
        private Label label2;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private GroupBox groupBox1;
        private RadioButton rb_vendedor;
        private RadioButton rb_Cliente;
    }
}