namespace formularios
{
    partial class FrmHeladera
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
            lb_vendedor = new Label();
            lb_Listar = new Label();
            menuStrip1 = new MenuStrip();
            agregarProductoToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            quitarToolStripMenuItem = new ToolStripMenuItem();
            configurarCortesToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem1 = new ToolStripMenuItem();
            modificarToolStripMenuItem1 = new ToolStripMenuItem();
            quitarToolStripMenuItem1 = new ToolStripMenuItem();
            facturacionToolStripMenuItem = new ToolStripMenuItem();
            serializarToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            lsb_productos = new ListBox();
            btn_detallarProducto = new Button();
            lsb_clientes = new ListBox();
            lb_clientes = new Label();
            nud_cantidadKilosVender = new NumericUpDown();
            lb_cantidadDeKilos = new Label();
            btn_vender = new Button();
            txb_detallarProducto = new TextBox();
            btn_detallarCliente = new Button();
            txb_detallarCliente = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_cantidadKilosVender).BeginInit();
            SuspendLayout();
            // 
            // lb_vendedor
            // 
            lb_vendedor.AutoSize = true;
            lb_vendedor.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lb_vendedor.ForeColor = Color.White;
            lb_vendedor.Location = new Point(12, 43);
            lb_vendedor.Name = "lb_vendedor";
            lb_vendedor.Size = new Size(270, 46);
            lb_vendedor.TabIndex = 0;
            lb_vendedor.Text = "Hola Vendedor!";
            // 
            // lb_Listar
            // 
            lb_Listar.AutoSize = true;
            lb_Listar.BackColor = Color.Black;
            lb_Listar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Listar.ForeColor = SystemColors.HighlightText;
            lb_Listar.Location = new Point(15, 104);
            lb_Listar.Name = "lb_Listar";
            lb_Listar.Size = new Size(235, 31);
            lb_Listar.TabIndex = 1;
            lb_Listar.Text = "Seleccionar producto:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(30, 30);
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarProductoToolStripMenuItem, configurarCortesToolStripMenuItem, facturacionToolStripMenuItem, serializarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MaximumSize = new Size(0, 200);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(875, 31);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarProductoToolStripMenuItem
            // 
            agregarProductoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarToolStripMenuItem, quitarToolStripMenuItem });
            agregarProductoToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            agregarProductoToolStripMenuItem.ForeColor = Color.White;
            agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            agregarProductoToolStripMenuItem.Size = new Size(180, 27);
            agregarProductoToolStripMenuItem.Text = "Configurar Producto";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(165, 28);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(165, 28);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // quitarToolStripMenuItem
            // 
            quitarToolStripMenuItem.Name = "quitarToolStripMenuItem";
            quitarToolStripMenuItem.Size = new Size(165, 28);
            quitarToolStripMenuItem.Text = "Quitar";
            quitarToolStripMenuItem.Click += quitarToolStripMenuItem_Click;
            // 
            // configurarCortesToolStripMenuItem
            // 
            configurarCortesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem1, modificarToolStripMenuItem1, quitarToolStripMenuItem1 });
            configurarCortesToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            configurarCortesToolStripMenuItem.ForeColor = Color.White;
            configurarCortesToolStripMenuItem.Name = "configurarCortesToolStripMenuItem";
            configurarCortesToolStripMenuItem.Size = new Size(159, 27);
            configurarCortesToolStripMenuItem.Text = "Configurar Cortes";
            // 
            // agregarToolStripMenuItem1
            // 
            agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            agregarToolStripMenuItem1.Size = new Size(165, 28);
            agregarToolStripMenuItem1.Text = "Agregar";
            agregarToolStripMenuItem1.Click += agregarToolStripMenuItem1_Click;
            // 
            // modificarToolStripMenuItem1
            // 
            modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            modificarToolStripMenuItem1.Size = new Size(165, 28);
            modificarToolStripMenuItem1.Text = "Modificar";
            modificarToolStripMenuItem1.Click += modificarToolStripMenuItem1_Click;
            // 
            // quitarToolStripMenuItem1
            // 
            quitarToolStripMenuItem1.Name = "quitarToolStripMenuItem1";
            quitarToolStripMenuItem1.Size = new Size(165, 28);
            quitarToolStripMenuItem1.Text = "Quitar";
            quitarToolStripMenuItem1.Click += quitarToolStripMenuItem1_Click;
            // 
            // facturacionToolStripMenuItem
            // 
            facturacionToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            facturacionToolStripMenuItem.ForeColor = Color.White;
            facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            facturacionToolStripMenuItem.Size = new Size(153, 27);
            facturacionToolStripMenuItem.Text = "Historial Facturas";
            facturacionToolStripMenuItem.Click += facturacionToolStripMenuItem_Click;
            // 
            // serializarToolStripMenuItem
            // 
            serializarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, productosToolStripMenuItem });
            serializarToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            serializarToolStripMenuItem.ForeColor = Color.White;
            serializarToolStripMenuItem.Name = "serializarToolStripMenuItem";
            serializarToolStripMenuItem.Size = new Size(92, 27);
            serializarToolStripMenuItem.Text = "Serializar";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(224, 28);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(224, 28);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // lsb_productos
            // 
            lsb_productos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lsb_productos.FormattingEnabled = true;
            lsb_productos.ItemHeight = 23;
            lsb_productos.Location = new Point(15, 145);
            lsb_productos.Name = "lsb_productos";
            lsb_productos.Size = new Size(363, 142);
            lsb_productos.TabIndex = 4;
            // 
            // btn_detallarProducto
            // 
            btn_detallarProducto.Location = new Point(15, 303);
            btn_detallarProducto.Name = "btn_detallarProducto";
            btn_detallarProducto.Size = new Size(179, 41);
            btn_detallarProducto.TabIndex = 5;
            btn_detallarProducto.Text = "Detallar producto.";
            btn_detallarProducto.UseVisualStyleBackColor = true;
            btn_detallarProducto.Click += btn_detallar_Click;
            // 
            // lsb_clientes
            // 
            lsb_clientes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lsb_clientes.FormattingEnabled = true;
            lsb_clientes.ItemHeight = 23;
            lsb_clientes.Location = new Point(497, 145);
            lsb_clientes.Name = "lsb_clientes";
            lsb_clientes.Size = new Size(363, 142);
            lsb_clientes.TabIndex = 6;
            // 
            // lb_clientes
            // 
            lb_clientes.AutoSize = true;
            lb_clientes.BackColor = Color.Black;
            lb_clientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_clientes.ForeColor = SystemColors.HighlightText;
            lb_clientes.Location = new Point(497, 104);
            lb_clientes.Name = "lb_clientes";
            lb_clientes.Size = new Size(215, 31);
            lb_clientes.TabIndex = 7;
            lb_clientes.Text = "Seleccionar cliente: ";
            // 
            // nud_cantidadKilosVender
            // 
            nud_cantidadKilosVender.Location = new Point(15, 502);
            nud_cantidadKilosVender.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nud_cantidadKilosVender.Name = "nud_cantidadKilosVender";
            nud_cantidadKilosVender.Size = new Size(379, 27);
            nud_cantidadKilosVender.TabIndex = 8;
            // 
            // lb_cantidadDeKilos
            // 
            lb_cantidadDeKilos.AutoSize = true;
            lb_cantidadDeKilos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_cantidadDeKilos.ForeColor = Color.White;
            lb_cantidadDeKilos.Location = new Point(13, 471);
            lb_cantidadDeKilos.Name = "lb_cantidadDeKilos";
            lb_cantidadDeKilos.Size = new Size(286, 28);
            lb_cantidadDeKilos.TabIndex = 9;
            lb_cantidadDeKilos.Text = "Fijar cantidad de kilos a vender:";
            // 
            // btn_vender
            // 
            btn_vender.BackColor = Color.Black;
            btn_vender.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_vender.ForeColor = Color.White;
            btn_vender.Location = new Point(497, 471);
            btn_vender.Name = "btn_vender";
            btn_vender.Size = new Size(366, 58);
            btn_vender.TabIndex = 10;
            btn_vender.Text = "Vender";
            btn_vender.UseVisualStyleBackColor = false;
            btn_vender.Click += btn_vender_Click;
            // 
            // txb_detallarProducto
            // 
            txb_detallarProducto.Location = new Point(15, 350);
            txb_detallarProducto.Multiline = true;
            txb_detallarProducto.Name = "txb_detallarProducto";
            txb_detallarProducto.ReadOnly = true;
            txb_detallarProducto.Size = new Size(363, 101);
            txb_detallarProducto.TabIndex = 11;
            txb_detallarProducto.Text = "Detalles....";
            // 
            // btn_detallarCliente
            // 
            btn_detallarCliente.Location = new Point(497, 303);
            btn_detallarCliente.Name = "btn_detallarCliente";
            btn_detallarCliente.Size = new Size(179, 41);
            btn_detallarCliente.TabIndex = 12;
            btn_detallarCliente.Text = "Detallar cliente.";
            btn_detallarCliente.UseVisualStyleBackColor = true;
            btn_detallarCliente.Click += btn_detallarCliente_Click;
            // 
            // txb_detallarCliente
            // 
            txb_detallarCliente.Location = new Point(497, 350);
            txb_detallarCliente.Multiline = true;
            txb_detallarCliente.Name = "txb_detallarCliente";
            txb_detallarCliente.ReadOnly = true;
            txb_detallarCliente.Size = new Size(366, 101);
            txb_detallarCliente.TabIndex = 13;
            txb_detallarCliente.Text = "Detalles....";
            // 
            // FrmHeladera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(875, 566);
            Controls.Add(txb_detallarCliente);
            Controls.Add(btn_detallarCliente);
            Controls.Add(txb_detallarProducto);
            Controls.Add(btn_vender);
            Controls.Add(lb_cantidadDeKilos);
            Controls.Add(nud_cantidadKilosVender);
            Controls.Add(lb_clientes);
            Controls.Add(lsb_clientes);
            Controls.Add(btn_detallarProducto);
            Controls.Add(lsb_productos);
            Controls.Add(lb_Listar);
            Controls.Add(lb_vendedor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmHeladera";
            Text = "Heladera";
            Load += FrmHeladera_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_cantidadKilosVender).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_vendedor;
        private DataGridView data_productos;
        private Label lb_Listar;
        private DataGridView data_clientes;
        private DataGridViewButtonColumn button_vender;
        private DataGridViewTextBoxColumn tx_nombre;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarProductoToolStripMenuItem;
        private ListBox lsb_productos;
        private Button btn_detallarProducto;
        private ListBox lsb_clientes;
        private Label lb_clientes;
        private NumericUpDown nud_cantidadKilosVender;
        private Label lb_cantidadDeKilos;
        private Button btn_vender;
        private TextBox txb_detallarProducto;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem quitarToolStripMenuItem;
        private ToolStripMenuItem configurarCortesToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem1;
        private ToolStripMenuItem modificarToolStripMenuItem1;
        private ToolStripMenuItem quitarToolStripMenuItem1;
        private ToolStripMenuItem facturacionToolStripMenuItem;
        private Button btn_detallarCliente;
        private TextBox txb_detallarCliente;
        private ToolStripMenuItem serializarToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
    }
}