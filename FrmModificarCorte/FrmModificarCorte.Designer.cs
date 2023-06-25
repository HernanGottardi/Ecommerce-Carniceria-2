namespace formularios
{
    partial class FrmModificarCorte
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
            lsb_listaDeCortes = new ListBox();
            btn_modificar = new Button();
            btn_cancelar = new Button();
            txb_nuevoNombre = new TextBox();
            lb_tituloModificar = new Label();
            lb_nuevaModificacion = new Label();
            SuspendLayout();
            // 
            // lsb_listaDeCortes
            // 
            lsb_listaDeCortes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsb_listaDeCortes.FormattingEnabled = true;
            lsb_listaDeCortes.ItemHeight = 28;
            lsb_listaDeCortes.Location = new Point(168, 95);
            lsb_listaDeCortes.Name = "lsb_listaDeCortes";
            lsb_listaDeCortes.Size = new Size(410, 144);
            lsb_listaDeCortes.TabIndex = 0;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.Black;
            btn_modificar.Location = new Point(168, 348);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(130, 56);
            btn_modificar.TabIndex = 1;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Black;
            btn_cancelar.Location = new Point(448, 348);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(130, 56);
            btn_cancelar.TabIndex = 2;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // txb_nuevoNombre
            // 
            txb_nuevoNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nuevoNombre.Location = new Point(168, 303);
            txb_nuevoNombre.Name = "txb_nuevoNombre";
            txb_nuevoNombre.Size = new Size(410, 30);
            txb_nuevoNombre.TabIndex = 3;
            // 
            // lb_tituloModificar
            // 
            lb_tituloModificar.AutoSize = true;
            lb_tituloModificar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tituloModificar.Location = new Point(168, 38);
            lb_tituloModificar.Name = "lb_tituloModificar";
            lb_tituloModificar.Size = new Size(410, 37);
            lb_tituloModificar.TabIndex = 4;
            lb_tituloModificar.Text = "Elegir Corte de carne a modificar:";
            // 
            // lb_nuevaModificacion
            // 
            lb_nuevaModificacion.AutoSize = true;
            lb_nuevaModificacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nuevaModificacion.Location = new Point(168, 272);
            lb_nuevaModificacion.Name = "lb_nuevaModificacion";
            lb_nuevaModificacion.Size = new Size(219, 28);
            lb_nuevaModificacion.TabIndex = 5;
            lb_nuevaModificacion.Text = "Ingresar nuevo nombre:";
            lb_nuevaModificacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(762, 450);
            Controls.Add(lb_nuevaModificacion);
            Controls.Add(lb_tituloModificar);
            Controls.Add(txb_nuevoNombre);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_modificar);
            Controls.Add(lsb_listaDeCortes);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Modificar Corte";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsb_listaDeCortes;
        private Button btn_modificar;
        private Button btn_cancelar;
        private TextBox txb_nuevoNombre;
        private Label lb_tituloModificar;
        private Label lb_nuevaModificacion;
    }
}