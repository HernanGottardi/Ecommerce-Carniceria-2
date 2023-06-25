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
            SuspendLayout();
            // 
            // tb_correoElectronico
            // 
            tb_correoElectronico.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tb_correoElectronico.Location = new Point(31, 104);
            tb_correoElectronico.Name = "tb_correoElectronico";
            tb_correoElectronico.PlaceholderText = "aaaaa@gmail.com";
            tb_correoElectronico.Size = new Size(522, 32);
            tb_correoElectronico.TabIndex = 0;
            // 
            // tb_contraseña
            // 
            tb_contraseña.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tb_contraseña.Location = new Point(31, 221);
            tb_contraseña.Name = "tb_contraseña";
            tb_contraseña.PasswordChar = '*';
            tb_contraseña.PlaceholderText = "*******";
            tb_contraseña.Size = new Size(522, 32);
            tb_contraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 57);
            label1.Name = "label1";
            label1.Size = new Size(304, 32);
            label1.TabIndex = 2;
            label1.Text = "Ingresar correo electronico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 176);
            label2.Name = "label2";
            label2.Size = new Size(227, 32);
            label2.TabIndex = 3;
            label2.Text = "ingresar contraseña:";
            // 
            // btn_aceptar
            // 
            btn_aceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_aceptar.Location = new Point(31, 305);
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
            btn_cancelar.Location = new Point(395, 305);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(158, 34);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(599, 374);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_contraseña);
            Controls.Add(tb_correoElectronico);
            Name = "FrmRegistro";
            Text = "Registro";
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
    }
}