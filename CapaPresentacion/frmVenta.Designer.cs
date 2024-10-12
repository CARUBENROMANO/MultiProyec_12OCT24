namespace CapaPresentacion
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnregistrar = new FontAwesome.Sharp.IconButton();
            txttoltalpagar = new TextBox();
            btnagregarproducto = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            label9 = new Label();
            txtcantidad = new NumericUpDown();
            txtstock = new TextBox();
            txtprecioventa = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            txtproducto = new TextBox();
            txtcodproducto = new TextBox();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            txtidproducto = new TextBox();
            cbotipodocumento = new ComboBox();
            txtfecha = new TextBox();
            label3 = new Label();
            label14 = new Label();
            groupBox1 = new GroupBox();
            label13 = new Label();
            label6 = new Label();
            txtcambio = new TextBox();
            label1 = new Label();
            txtpagocon = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor = Color.PowderBlue;
            btnregistrar.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnregistrar.IconColor = Color.Black;
            btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregistrar.IconSize = 40;
            btnregistrar.ImageAlign = ContentAlignment.TopLeft;
            btnregistrar.Location = new Point(994, 605);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(132, 39);
            btnregistrar.TabIndex = 92;
            btnregistrar.Text = "REGISTRAR";
            btnregistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregistrar.UseVisualStyleBackColor = false;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // txttoltalpagar
            // 
            txttoltalpagar.BackColor = Color.WhiteSmoke;
            txttoltalpagar.Location = new Point(997, 426);
            txttoltalpagar.Name = "txttoltalpagar";
            txttoltalpagar.Size = new Size(119, 27);
            txttoltalpagar.TabIndex = 91;
            txttoltalpagar.Text = "0";
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.BackColor = Color.PowderBlue;
            btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnagregarproducto.IconColor = Color.Black;
            btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregarproducto.Location = new Point(994, 259);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(132, 80);
            btnagregarproducto.TabIndex = 89;
            btnagregarproducto.Text = "AGREGAR";
            btnagregarproducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnagregarproducto.UseVisualStyleBackColor = false;
            btnagregarproducto.Click += btnregistra_Click;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { idProducto, producto, precio, cantidad, subtotal, btneliminar });
            dgvdata.Location = new Point(116, 259);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 29;
            dgvdata.Size = new Size(872, 385);
            dgvdata.TabIndex = 88;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "idProducto";
            idProducto.MinimumWidth = 6;
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.Visible = false;
            idProducto.Width = 70;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.ReadOnly = true;
            producto.Width = 280;
            // 
            // precio
            // 
            precio.HeaderText = "Precio Producto";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 180;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 170;
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Sub Total";
            subtotal.MinimumWidth = 6;
            subtotal.Name = "subtotal";
            subtotal.ReadOnly = true;
            subtotal.Width = 150;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.MinimumWidth = 6;
            btneliminar.Name = "btneliminar";
            btneliminar.ReadOnly = true;
            btneliminar.Width = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(116, 9);
            label9.Name = "label9";
            label9.Size = new Size(219, 35);
            label9.TabIndex = 86;
            label9.Text = "REGISTAR VENTA";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(837, 61);
            txtcantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtcantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(112, 27);
            txtcantidad.TabIndex = 47;
            txtcantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtstock
            // 
            txtstock.BackColor = Color.WhiteSmoke;
            txtstock.Location = new Point(670, 59);
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(141, 27);
            txtstock.TabIndex = 46;
            // 
            // txtprecioventa
            // 
            txtprecioventa.BackColor = Color.WhiteSmoke;
            txtprecioventa.Location = new Point(516, 59);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(137, 27);
            txtprecioventa.TabIndex = 45;
            txtprecioventa.KeyPress += txtprecioventa_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(516, 23);
            label12.Name = "label12";
            label12.Size = new Size(71, 23);
            label12.TabIndex = 44;
            label12.Text = "Precio : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(670, 23);
            label11.Name = "label11";
            label11.Size = new Size(64, 23);
            label11.TabIndex = 43;
            label11.Text = "Stock : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(833, 23);
            label10.Name = "label10";
            label10.Size = new Size(93, 23);
            label10.TabIndex = 42;
            label10.Text = "Cantidad : ";
            // 
            // btnbuscarproducto
            // 
            btnbuscarproducto.BackColor = Color.PowderBlue;
            btnbuscarproducto.Cursor = Cursors.Hand;
            btnbuscarproducto.FlatAppearance.BorderColor = Color.Black;
            btnbuscarproducto.FlatStyle = FlatStyle.Flat;
            btnbuscarproducto.ForeColor = Color.White;
            btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            btnbuscarproducto.IconColor = Color.Black;
            btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproducto.IconSize = 25;
            btnbuscarproducto.Location = new Point(212, 60);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new Size(53, 26);
            btnbuscarproducto.TabIndex = 41;
            btnbuscarproducto.UseVisualStyleBackColor = false;
            btnbuscarproducto.Click += btnbuscarproducto_Click;
            // 
            // txtproducto
            // 
            txtproducto.BackColor = Color.WhiteSmoke;
            txtproducto.Location = new Point(271, 58);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(223, 27);
            txtproducto.TabIndex = 38;
            // 
            // txtcodproducto
            // 
            txtcodproducto.BackColor = Color.WhiteSmoke;
            txtcodproducto.Location = new Point(13, 58);
            txtcodproducto.Name = "txtcodproducto";
            txtcodproducto.Size = new Size(181, 27);
            txtcodproducto.TabIndex = 37;
            txtcodproducto.KeyDown += txtcodproducto_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 23);
            label7.Name = "label7";
            label7.Size = new Size(130, 23);
            label7.TabIndex = 35;
            label7.Text = "Cod Producto : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(271, 23);
            label8.Name = "label8";
            label8.Size = new Size(94, 23);
            label8.TabIndex = 36;
            label8.Text = "Producto : ";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(txtcantidad);
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(txtstock);
            groupBox3.Controls.Add(txtprecioventa);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnbuscarproducto);
            groupBox3.Controls.Add(txtproducto);
            groupBox3.Controls.Add(txtcodproducto);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(116, 144);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1010, 109);
            groupBox3.TabIndex = 87;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion de Producto:";
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(149, 23);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(45, 27);
            txtidproducto.TabIndex = 41;
            txtidproducto.Visible = false;
            // 
            // cbotipodocumento
            // 
            cbotipodocumento.FormattingEnabled = true;
            cbotipodocumento.Location = new Point(284, 49);
            cbotipodocumento.Name = "cbotipodocumento";
            cbotipodocumento.Size = new Size(188, 28);
            cbotipodocumento.TabIndex = 38;
            // 
            // txtfecha
            // 
            txtfecha.BackColor = Color.WhiteSmoke;
            txtfecha.Location = new Point(13, 49);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(158, 27);
            txtfecha.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 23);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 35;
            label3.Text = "Fecha : ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(284, 23);
            label14.Name = "label14";
            label14.Size = new Size(152, 23);
            label14.TabIndex = 36;
            label14.Text = "Tipo Documento : ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label14);
            groupBox1.Location = new Point(116, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 91);
            groupBox1.TabIndex = 93;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Venta:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(994, 400);
            label13.Name = "label13";
            label13.Size = new Size(122, 23);
            label13.TabIndex = 90;
            label13.Text = "Total a Pagar : ";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(107, 9);
            label6.Name = "label6";
            label6.Size = new Size(1035, 660);
            label6.TabIndex = 85;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtcambio
            // 
            txtcambio.BackColor = Color.WhiteSmoke;
            txtcambio.Location = new Point(997, 558);
            txtcambio.Name = "txtcambio";
            txtcambio.Size = new Size(119, 27);
            txtcambio.TabIndex = 95;
            txtcambio.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(994, 532);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 94;
            label1.Text = "Cambio : ";
            // 
            // txtpagocon
            // 
            txtpagocon.BackColor = Color.WhiteSmoke;
            txtpagocon.Location = new Point(997, 492);
            txtpagocon.Name = "txtpagocon";
            txtpagocon.Size = new Size(119, 27);
            txtpagocon.TabIndex = 97;
            txtpagocon.Text = "0";
            txtpagocon.KeyDown += txtpagocon_KeyDown;
            txtpagocon.KeyPress += txtpagocon_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(994, 466);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 96;
            label2.Text = "Pagar con: ";
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 678);
            Controls.Add(txtpagocon);
            Controls.Add(label2);
            Controls.Add(txtcambio);
            Controls.Add(label1);
            Controls.Add(btnregistrar);
            Controls.Add(txttoltalpagar);
            Controls.Add(btnagregarproducto);
            Controls.Add(dgvdata);
            Controls.Add(label9);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label13);
            Controls.Add(label6);
            Name = "frmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registrar Venta";
            Load += frmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnregistrar;
        private TextBox txttoltalpagar;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private DataGridView dgvdata;
        private Label label9;
        private NumericUpDown txtcantidad;
        private TextBox txtstock;
        private TextBox txtprecioventa;
        private Label label12;
        private Label label11;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private TextBox txtproducto;
        private TextBox txtcodproducto;
        private Label label7;
        private Label label8;
        private GroupBox groupBox3;
        private TextBox txtidproducto;
        private ComboBox cbotipodocumento;
        private TextBox txtfecha;
        private Label label3;
        private Label label14;
        private GroupBox groupBox1;
        private Label label13;
        private Label label6;
        private TextBox txtcambio;
        private Label label1;
        private TextBox txtpagocon;
        private Label label2;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewButtonColumn btneliminar;
    }
}