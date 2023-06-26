namespace formularios
{
    partial class FrmModificarContraseña
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
            btn_modificar = new Button();
            txb_nuevaContraseña = new TextBox();
            label1 = new Label();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.SteelBlue;
            btn_modificar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_modificar.ForeColor = Color.White;
            btn_modificar.Location = new Point(44, 205);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(127, 37);
            btn_modificar.TabIndex = 0;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click_1;
            // 
            // txb_nuevaContraseña
            // 
            txb_nuevaContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nuevaContraseña.Location = new Point(44, 140);
            txb_nuevaContraseña.Name = "txb_nuevaContraseña";
            txb_nuevaContraseña.PasswordChar = '*';
            txb_nuevaContraseña.PlaceholderText = "******************";
            txb_nuevaContraseña.Size = new Size(401, 27);
            txb_nuevaContraseña.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 79);
            label1.Name = "label1";
            label1.Size = new Size(239, 25);
            label1.TabIndex = 3;
            label1.Text = "Ingresar nueva contraseña:";
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.SteelBlue;
            btn_cancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Location = new Point(318, 205);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(127, 37);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // FrmModificarContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(501, 264);
            Controls.Add(btn_cancelar);
            Controls.Add(label1);
            Controls.Add(txb_nuevaContraseña);
            Controls.Add(btn_modificar);
            Name = "FrmModificarContraseña";
            Text = "Modificar Contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_modificar;
        private TextBox txb_nuevaContraseña;
        private Label label1;
        private Button btn_cancelar;
    }
}