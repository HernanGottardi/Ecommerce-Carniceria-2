namespace formularios
{
    partial class FrmElegirCliente
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
            lb_nombreProducto = new Label();
            label2 = new Label();
            nud_cantidadKilosVender = new NumericUpDown();
            lsb_clientes = new ListBox();
            btn_Confirmar = new Button();
            btn_cancelar = new Button();
            lb_cantidadDeKilos = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_cantidadKilosVender).BeginInit();
            SuspendLayout();
            // 
            // lb_nombreProducto
            // 
            lb_nombreProducto.AutoSize = true;
            lb_nombreProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nombreProducto.Location = new Point(156, 29);
            lb_nombreProducto.Name = "lb_nombreProducto";
            lb_nombreProducto.Size = new Size(274, 35);
            lb_nombreProducto.TabIndex = 0;
            lb_nombreProducto.Text = "Seleccionaste vender X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 1;
            label2.Text = "Lista de Clientes:";
            // 
            // nud_cantidadKilosVender
            // 
            nud_cantidadKilosVender.Location = new Point(12, 375);
            nud_cantidadKilosVender.Name = "nud_cantidadKilosVender";
            nud_cantidadKilosVender.Size = new Size(324, 27);
            nud_cantidadKilosVender.TabIndex = 3;
            // 
            // lsb_clientes
            // 
            lsb_clientes.FormattingEnabled = true;
            lsb_clientes.ItemHeight = 20;
            lsb_clientes.Location = new Point(12, 148);
            lsb_clientes.Name = "lsb_clientes";
            lsb_clientes.Size = new Size(324, 164);
            lsb_clientes.TabIndex = 5;
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.Location = new Point(390, 148);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(135, 89);
            btn_Confirmar.TabIndex = 6;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = true;
            btn_Confirmar.Click += btn_Confirmar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(390, 313);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(135, 89);
            btn_cancelar.TabIndex = 7;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // lb_cantidadDeKilos
            // 
            lb_cantidadDeKilos.AutoSize = true;
            lb_cantidadDeKilos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_cantidadDeKilos.Location = new Point(12, 331);
            lb_cantidadDeKilos.Name = "lb_cantidadDeKilos";
            lb_cantidadDeKilos.Size = new Size(286, 28);
            lb_cantidadDeKilos.TabIndex = 8;
            lb_cantidadDeKilos.Text = "Fijar cantidad de kilos a vender:";
            // 
            // FrmElegirCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 450);
            Controls.Add(lb_cantidadDeKilos);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_Confirmar);
            Controls.Add(lsb_clientes);
            Controls.Add(nud_cantidadKilosVender);
            Controls.Add(label2);
            Controls.Add(lb_nombreProducto);
            Name = "FrmElegirCliente";
            Text = "Form1";
            Load += FrmElegirCliente_Load;
            ((System.ComponentModel.ISupportInitialize)nud_cantidadKilosVender).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_nombreProducto;
        private Label label2;
        private DataGridView dataGridView1;
        private NumericUpDown nud_cantidadKilosVender;
        private NumericUpDown numericUpDown2;
        private ListBox lsb_clientes;
        private Button btn_Confirmar;
        private Button btn_cancelar;
        private Label lb_cantidadDeKilos;
    }
}