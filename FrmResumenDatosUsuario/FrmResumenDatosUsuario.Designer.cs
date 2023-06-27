namespace formularios
{
    partial class FrmResumenDatosUsuario
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
            btn_eliminar = new Button();
            btn_cerrar = new Button();
            label1 = new Label();
            lb_mail = new Label();
            lb_contraseña = new Label();
            lb_monto = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.SteelBlue;
            btn_eliminar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(44, 333);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(153, 42);
            btn_eliminar.TabIndex = 0;
            btn_eliminar.Text = "Eliminar usuario";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = Color.SteelBlue;
            btn_cerrar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cerrar.ForeColor = Color.White;
            btn_cerrar.Location = new Point(401, 333);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(153, 42);
            btn_cerrar.TabIndex = 1;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(123, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 35);
            label1.TabIndex = 2;
            label1.Text = "Tus datos personales:";
            // 
            // lb_mail
            // 
            lb_mail.AutoSize = true;
            lb_mail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_mail.ForeColor = Color.White;
            lb_mail.Location = new Point(30, 82);
            lb_mail.Name = "lb_mail";
            lb_mail.Size = new Size(155, 23);
            lb_mail.TabIndex = 3;
            lb_mail.Text = "Correo Electronico:";
            // 
            // lb_contraseña
            // 
            lb_contraseña.AutoSize = true;
            lb_contraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_contraseña.ForeColor = Color.White;
            lb_contraseña.Location = new Point(30, 147);
            lb_contraseña.Name = "lb_contraseña";
            lb_contraseña.Size = new Size(101, 23);
            lb_contraseña.TabIndex = 4;
            lb_contraseña.Text = "Contraseña:";
            // 
            // lb_monto
            // 
            lb_monto.AutoSize = true;
            lb_monto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_monto.ForeColor = Color.White;
            lb_monto.Location = new Point(30, 211);
            lb_monto.Name = "lb_monto";
            lb_monto.Size = new Size(65, 23);
            lb_monto.TabIndex = 5;
            lb_monto.Text = "Monto:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 0, 64);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lb_contraseña);
            groupBox1.Controls.Add(lb_monto);
            groupBox1.Controls.Add(lb_mail);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(44, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 277);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // FrmResumenDatosUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(606, 390);
            Controls.Add(groupBox1);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_eliminar);
            Name = "FrmResumenDatosUsuario";
            Text = "Datos Usuario";
            Load += FrmResumenDatosUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_eliminar;
        private Button btn_cerrar;
        private Label label1;
        private Label lb_mail;
        private Label lb_contraseña;
        private Label lb_monto;
        private GroupBox groupBox1;
    }
}