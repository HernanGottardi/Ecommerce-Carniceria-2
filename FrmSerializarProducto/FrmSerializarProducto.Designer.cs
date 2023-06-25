namespace formularios
{
    partial class FrmSerializarProducto
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
            groupBox1 = new GroupBox();
            rb_deserializar = new RadioButton();
            rb_serializar = new RadioButton();
            groupBox2 = new GroupBox();
            rb_xml = new RadioButton();
            rb_json = new RadioButton();
            btn_cancelar = new Button();
            rtb_deserializado = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.Black;
            btn_aceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_aceptar.ForeColor = Color.White;
            btn_aceptar.Location = new Point(26, 371);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(137, 38);
            btn_aceptar.TabIndex = 2;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_deserializar);
            groupBox1.Controls.Add(rb_serializar);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(26, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 143);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modo";
            // 
            // rb_deserializar
            // 
            rb_deserializar.AutoSize = true;
            rb_deserializar.Location = new Point(19, 84);
            rb_deserializar.Name = "rb_deserializar";
            rb_deserializar.Size = new Size(118, 27);
            rb_deserializar.TabIndex = 1;
            rb_deserializar.TabStop = true;
            rb_deserializar.Text = "Deserializar";
            rb_deserializar.UseVisualStyleBackColor = true;
            // 
            // rb_serializar
            // 
            rb_serializar.AutoSize = true;
            rb_serializar.Location = new Point(19, 39);
            rb_serializar.Name = "rb_serializar";
            rb_serializar.Size = new Size(99, 27);
            rb_serializar.TabIndex = 0;
            rb_serializar.TabStop = true;
            rb_serializar.Text = "Serializar";
            rb_serializar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rb_xml);
            groupBox2.Controls.Add(rb_json);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(26, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 143);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo";
            // 
            // rb_xml
            // 
            rb_xml.AutoSize = true;
            rb_xml.Location = new Point(19, 95);
            rb_xml.Name = "rb_xml";
            rb_xml.Size = new Size(64, 27);
            rb_xml.TabIndex = 3;
            rb_xml.TabStop = true;
            rb_xml.Text = "XML";
            rb_xml.UseVisualStyleBackColor = true;
            // 
            // rb_json
            // 
            rb_json.AutoSize = true;
            rb_json.Location = new Point(19, 48);
            rb_json.Name = "rb_json";
            rb_json.Size = new Size(72, 27);
            rb_json.TabIndex = 2;
            rb_json.TabStop = true;
            rb_json.Text = "JSON";
            rb_json.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Black;
            btn_cancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Location = new Point(306, 371);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(137, 38);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // rtb_deserializado
            // 
            rtb_deserializado.Location = new Point(483, 28);
            rtb_deserializado.Name = "rtb_deserializado";
            rtb_deserializado.Size = new Size(185, 381);
            rtb_deserializado.TabIndex = 5;
            rtb_deserializado.Text = "";
            // 
            // FrmSerializarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(696, 432);
            Controls.Add(rtb_deserializado);
            Controls.Add(btn_cancelar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_aceptar);
            Name = "FrmSerializarProducto";
            Text = "Serializar Producto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_aceptar;
        private GroupBox groupBox1;
        private RadioButton rb_deserializar;
        private RadioButton rb_serializar;
        private GroupBox groupBox2;
        private RadioButton rb_xml;
        private RadioButton rb_json;
        private Button btn_cancelar;
        private RichTextBox rtb_deserializado;
    }
}