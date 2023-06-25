namespace formularios
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            btn_ingresar = new Button();
            btn_registrarse = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.Maroon;
            btn_ingresar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ingresar.ForeColor = Color.White;
            btn_ingresar.Location = new Point(60, 172);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(164, 52);
            btn_ingresar.TabIndex = 0;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_registrarse
            // 
            btn_registrarse.BackColor = Color.Maroon;
            btn_registrarse.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_registrarse.ForeColor = Color.White;
            btn_registrarse.Location = new Point(427, 172);
            btn_registrarse.Name = "btn_registrarse";
            btn_registrarse.Size = new Size(164, 52);
            btn_registrarse.TabIndex = 1;
            btn_registrarse.Text = "Registrarse";
            btn_registrarse.UseVisualStyleBackColor = false;
            btn_registrarse.Click += btn_registrarse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 54);
            label1.Name = "label1";
            label1.Size = new Size(577, 35);
            label1.TabIndex = 2;
            label1.Text = "¡Bienvenido/a a nuestra carnicería digital!";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(639, 320);
            Controls.Add(label1);
            Controls.Add(btn_registrarse);
            Controls.Add(btn_ingresar);
            Name = "FrmMenuPrincipal";
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ingresar;
        private Button btn_registrarse;
        private Label label1;
    }
}