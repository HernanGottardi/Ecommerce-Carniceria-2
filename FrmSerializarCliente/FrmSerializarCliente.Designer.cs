namespace formularios
{
    partial class FrmSerializarCliente
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
            groupBox1 = new GroupBox();
            rb_deserializar = new RadioButton();
            rb_serializar = new RadioButton();
            groupBox2 = new GroupBox();
            rb_json = new RadioButton();
            rb_xml = new RadioButton();
            btn_aceptar = new Button();
            rtb_deserializado = new RichTextBox();
            btn_cancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_deserializar);
            groupBox1.Controls.Add(rb_serializar);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(23, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modo";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // rb_deserializar
            // 
            rb_deserializar.AutoSize = true;
            rb_deserializar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rb_deserializar.Location = new Point(19, 85);
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
            rb_serializar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rb_serializar.Location = new Point(19, 45);
            rb_serializar.Name = "rb_serializar";
            rb_serializar.Size = new Size(99, 27);
            rb_serializar.TabIndex = 0;
            rb_serializar.TabStop = true;
            rb_serializar.Text = "Serializar";
            rb_serializar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rb_json);
            groupBox2.Controls.Add(rb_xml);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(23, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(468, 141);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo";
            // 
            // rb_json
            // 
            rb_json.AutoSize = true;
            rb_json.Location = new Point(19, 43);
            rb_json.Name = "rb_json";
            rb_json.Size = new Size(72, 27);
            rb_json.TabIndex = 2;
            rb_json.TabStop = true;
            rb_json.Text = "JSON";
            rb_json.UseVisualStyleBackColor = true;
            // 
            // rb_xml
            // 
            rb_xml.AutoSize = true;
            rb_xml.Location = new Point(19, 85);
            rb_xml.Name = "rb_xml";
            rb_xml.Size = new Size(64, 27);
            rb_xml.TabIndex = 3;
            rb_xml.TabStop = true;
            rb_xml.Text = "XML";
            rb_xml.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.Black;
            btn_aceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_aceptar.ForeColor = Color.White;
            btn_aceptar.Location = new Point(23, 345);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(124, 42);
            btn_aceptar.TabIndex = 1;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // rtb_deserializado
            // 
            rtb_deserializado.Location = new Point(517, 29);
            rtb_deserializado.Name = "rtb_deserializado";
            rtb_deserializado.Size = new Size(188, 358);
            rtb_deserializado.TabIndex = 3;
            rtb_deserializado.Text = "";
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Black;
            btn_cancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Location = new Point(367, 345);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(124, 42);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // FrmSerializarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(732, 412);
            Controls.Add(btn_cancelar);
            Controls.Add(rtb_deserializado);
            Controls.Add(btn_aceptar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSerializarCliente";
            Text = "Serializar Clientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_aceptar;
        private RichTextBox rtb_deserializado;
        private RadioButton rb_deserializar;
        private RadioButton rb_serializar;
        private RadioButton rb_json;
        private RadioButton rb_xml;
        private Button btn_cancelar;
    }
}