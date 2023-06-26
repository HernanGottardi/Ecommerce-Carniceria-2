namespace formularios
{
    partial class FrmModificarMail
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
            button2 = new Button();
            lb_mailActual = new Label();
            txb_nuevoMail = new TextBox();
            lb_nuevoMail = new Label();
            SuspendLayout();
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.SteelBlue;
            btn_modificar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_modificar.ForeColor = Color.White;
            btn_modificar.Location = new Point(32, 234);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(109, 40);
            btn_modificar.TabIndex = 0;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(197, 234);
            button2.Name = "button2";
            button2.Size = new Size(109, 40);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lb_mailActual
            // 
            lb_mailActual.AutoSize = true;
            lb_mailActual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_mailActual.Location = new Point(32, 48);
            lb_mailActual.Name = "lb_mailActual";
            lb_mailActual.Size = new Size(261, 28);
            lb_mailActual.TabIndex = 3;
            lb_mailActual.Text = "Tu Correo Electronico actual:";
            // 
            // txb_nuevoMail
            // 
            txb_nuevoMail.Location = new Point(32, 164);
            txb_nuevoMail.Name = "txb_nuevoMail";
            txb_nuevoMail.PlaceholderText = "fulanito@gmail.com";
            txb_nuevoMail.Size = new Size(274, 27);
            txb_nuevoMail.TabIndex = 4;
            // 
            // lb_nuevoMail
            // 
            lb_nuevoMail.AutoSize = true;
            lb_nuevoMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nuevoMail.Location = new Point(32, 126);
            lb_nuevoMail.Name = "lb_nuevoMail";
            lb_nuevoMail.Size = new Size(274, 23);
            lb_nuevoMail.TabIndex = 5;
            lb_nuevoMail.Text = "Ingresar nuevo Correo Electronico:";
            // 
            // FrmModificarMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(623, 297);
            Controls.Add(lb_nuevoMail);
            Controls.Add(txb_nuevoMail);
            Controls.Add(lb_mailActual);
            Controls.Add(button2);
            Controls.Add(btn_modificar);
            Name = "FrmModificarMail";
            Text = "Modificar Correo Electronico";
            Load += FrmModificarMail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_modificar;
        private Button button2;
        private Label lb_mailActual;
        private TextBox txb_nuevoMail;
        private Label lb_nuevoMail;
    }
}