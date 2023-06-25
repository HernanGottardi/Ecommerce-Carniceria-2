namespace formularios
{
    partial class FrmQuitarProducto
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
            lsb_listaProductos = new ListBox();
            lb_quitar = new Label();
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            txb_detallar = new TextBox();
            btn_detallar = new Button();
            SuspendLayout();
            // 
            // lsb_listaProductos
            // 
            lsb_listaProductos.FormattingEnabled = true;
            lsb_listaProductos.ItemHeight = 20;
            lsb_listaProductos.Location = new Point(30, 83);
            lsb_listaProductos.Name = "lsb_listaProductos";
            lsb_listaProductos.Size = new Size(479, 224);
            lsb_listaProductos.TabIndex = 0;
            // 
            // lb_quitar
            // 
            lb_quitar.AutoSize = true;
            lb_quitar.Font = new Font("Lucida Sans Unicode", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_quitar.ForeColor = Color.White;
            lb_quitar.Location = new Point(30, 33);
            lb_quitar.Name = "lb_quitar";
            lb_quitar.Size = new Size(418, 34);
            lb_quitar.TabIndex = 1;
            lb_quitar.Text = "Seleccionar producto a quitar:";
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Black;
            btn_cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Location = new Point(337, 349);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(172, 45);
            btn_cancelar.TabIndex = 2;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.Black;
            btn_aceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_aceptar.ForeColor = Color.White;
            btn_aceptar.Location = new Point(30, 349);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(172, 45);
            btn_aceptar.TabIndex = 3;
            btn_aceptar.Text = "Quitar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // txb_detallar
            // 
            txb_detallar.Location = new Point(547, 83);
            txb_detallar.Multiline = true;
            txb_detallar.Name = "txb_detallar";
            txb_detallar.ReadOnly = true;
            txb_detallar.Size = new Size(230, 311);
            txb_detallar.TabIndex = 4;
            // 
            // btn_detallar
            // 
            btn_detallar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_detallar.Location = new Point(603, 44);
            btn_detallar.Name = "btn_detallar";
            btn_detallar.Size = new Size(121, 33);
            btn_detallar.TabIndex = 5;
            btn_detallar.Text = "Detallar";
            btn_detallar.UseVisualStyleBackColor = true;
            btn_detallar.Click += btn_detallar_Click;
            // 
            // FrmQuitarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_detallar);
            Controls.Add(txb_detallar);
            Controls.Add(btn_aceptar);
            Controls.Add(btn_cancelar);
            Controls.Add(lb_quitar);
            Controls.Add(lsb_listaProductos);
            ForeColor = Color.Black;
            Name = "FrmQuitarProducto";
            Text = "Quitar Producto";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsb_listaProductos;
        private Label lb_quitar;
        private Button btn_cancelar;
        private Button btn_aceptar;
        private TextBox txb_detallar;
        private Button btn_detallar;
    }
}