namespace formularios
{
    partial class FrmQuitarCorte
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
            btn_aceptar = new Button();
            btn_Cancelar = new Button();
            lsb_listaDeCortes = new ListBox();
            lb_tituloQuitarCorte = new Label();
            SuspendLayout();
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.Black;
            btn_aceptar.Location = new Point(100, 316);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(146, 44);
            btn_aceptar.TabIndex = 0;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Black;
            btn_Cancelar.Location = new Point(412, 316);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(146, 44);
            btn_Cancelar.TabIndex = 1;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // lsb_listaDeCortes
            // 
            lsb_listaDeCortes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsb_listaDeCortes.FormattingEnabled = true;
            lsb_listaDeCortes.ItemHeight = 28;
            lsb_listaDeCortes.Location = new Point(100, 136);
            lsb_listaDeCortes.Name = "lsb_listaDeCortes";
            lsb_listaDeCortes.Size = new Size(458, 144);
            lsb_listaDeCortes.TabIndex = 2;
            // 
            // lb_tituloQuitarCorte
            // 
            lb_tituloQuitarCorte.AutoSize = true;
            lb_tituloQuitarCorte.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tituloQuitarCorte.Location = new Point(100, 52);
            lb_tituloQuitarCorte.Name = "lb_tituloQuitarCorte";
            lb_tituloQuitarCorte.Size = new Size(363, 37);
            lb_tituloQuitarCorte.TabIndex = 3;
            lb_tituloQuitarCorte.Text = "Elegir corte de carne a quitar:";
            // 
            // FrmQuitarCorte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(668, 390);
            Controls.Add(lb_tituloQuitarCorte);
            Controls.Add(lsb_listaDeCortes);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_aceptar);
            ForeColor = Color.White;
            Name = "FrmQuitarCorte";
            Text = "Quitar Corte";
            Load += FrmQuitarCorte_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_aceptar;
        private Button btn_Cancelar;
        private ListBox lsb_listaDeCortes;
        private Label lb_tituloQuitarCorte;
    }
}