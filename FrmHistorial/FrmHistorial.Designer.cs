namespace formularios
{
    partial class FrmHistorial
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgv_facturaciones = new DataGridView();
            lb_tituloHistorial = new Label();
            lb_totalGanado = new Label();
            btn_archivoTexto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_facturaciones).BeginInit();
            SuspendLayout();
            // 
            // dgv_facturaciones
            // 
            dgv_facturaciones.BackgroundColor = Color.Maroon;
            dgv_facturaciones.BorderStyle = BorderStyle.None;
            dgv_facturaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_facturaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_facturaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_facturaciones.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_facturaciones.GridColor = Color.Maroon;
            dgv_facturaciones.Location = new Point(12, 113);
            dgv_facturaciones.Name = "dgv_facturaciones";
            dgv_facturaciones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_facturaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_facturaciones.RowHeadersVisible = false;
            dgv_facturaciones.RowHeadersWidth = 51;
            dgv_facturaciones.RowTemplate.Height = 29;
            dgv_facturaciones.Size = new Size(970, 270);
            dgv_facturaciones.TabIndex = 0;
            // 
            // lb_tituloHistorial
            // 
            lb_tituloHistorial.AutoSize = true;
            lb_tituloHistorial.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tituloHistorial.Location = new Point(12, 47);
            lb_tituloHistorial.Name = "lb_tituloHistorial";
            lb_tituloHistorial.Size = new Size(501, 46);
            lb_tituloHistorial.TabIndex = 1;
            lb_tituloHistorial.Text = "HISTORIAL DE FACTURACIONES.";
            // 
            // lb_totalGanado
            // 
            lb_totalGanado.AutoSize = true;
            lb_totalGanado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_totalGanado.Location = new Point(12, 404);
            lb_totalGanado.Name = "lb_totalGanado";
            lb_totalGanado.Size = new Size(165, 28);
            lb_totalGanado.TabIndex = 2;
            lb_totalGanado.Text = "Total Recaudado: ";
            // 
            // btn_archivoTexto
            // 
            btn_archivoTexto.BackColor = Color.White;
            btn_archivoTexto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_archivoTexto.ForeColor = Color.Black;
            btn_archivoTexto.Location = new Point(12, 461);
            btn_archivoTexto.Name = "btn_archivoTexto";
            btn_archivoTexto.Size = new Size(240, 39);
            btn_archivoTexto.TabIndex = 3;
            btn_archivoTexto.Text = "Cargar Facturas en Archivo...";
            btn_archivoTexto.UseVisualStyleBackColor = false;
            btn_archivoTexto.Click += btn_archivoTexto_Click;
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(994, 541);
            Controls.Add(btn_archivoTexto);
            Controls.Add(lb_totalGanado);
            Controls.Add(lb_tituloHistorial);
            Controls.Add(dgv_facturaciones);
            ForeColor = Color.White;
            Name = "FrmHistorial";
            Text = "Historial Facturaciones";
            Load += FrmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_facturaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_facturaciones;
        private Label lb_tituloHistorial;
        private Label lb_totalGanado;
        private Button btn_archivoTexto;
    }
}