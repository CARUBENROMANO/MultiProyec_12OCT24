namespace CapaPresentacion
{
    partial class frmProducto
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label5 = new Label();
            btn = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            txtmarca = new TextBox();
            label4 = new Label();
            txtnombre = new TextBox();
            txtcodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataProducto = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            idCategoria = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbocategoria = new ComboBox();
            cboestado = new ComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            cbobusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            txtid = new TextBox();
            txtindice = new TextBox();
            btnexportar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataProducto).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(212, 32);
            label5.TabIndex = 22;
            label5.Text = "Carga de Producto";
            // 
            // btn
            // 
            btn.BackColor = Color.LimeGreen;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.IconChar = FontAwesome.Sharp.IconChar.None;
            btn.IconColor = Color.Black;
            btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn.Location = new Point(22, 445);
            btn.Name = "btn";
            btn.Size = new Size(233, 29);
            btn.TabIndex = 20;
            btn.Text = "LIMPIAR";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.DodgerBlue;
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderColor = Color.Black;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.ForeColor = Color.White;
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnguardar.IconColor = Color.Black;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.IconSize = 25;
            btnguardar.ImageAlign = ContentAlignment.TopLeft;
            btnguardar.Location = new Point(22, 410);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(233, 29);
            btnguardar.TabIndex = 19;
            btnguardar.Text = "GUARDAR";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(24, 224);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(235, 27);
            txtmarca.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(24, 201);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 17;
            label4.Text = "Marca";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(24, 161);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(235, 27);
            txtnombre.TabIndex = 16;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(24, 95);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(235, 27);
            txtcodigo.TabIndex = 15;
            txtcodigo.TextChanged += txtnombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 13;
            label2.Text = "Codigo";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(282, 657);
            label1.TabIndex = 12;
            // 
            // dataProducto
            // 
            dataProducto.AllowUserToAddRows = false;
            dataProducto.AllowUserToDeleteRows = false;
            dataProducto.AllowUserToOrderColumns = true;
            dataProducto.AllowUserToResizeColumns = false;
            dataProducto.AllowUserToResizeRows = false;
            dataProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProducto.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, id, Codigo, Nombre, Marca, idCategoria, Categoria, Stock, PrecioCompra, PrecioVenta, EstadoValor, Estado });
            dataProducto.Location = new Point(302, 120);
            dataProducto.MultiSelect = false;
            dataProducto.Name = "dataProducto";
            dataProducto.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataProducto.RowHeadersWidth = 51;
            dataProducto.RowTemplate.Height = 29;
            dataProducto.Size = new Size(1024, 371);
            dataProducto.TabIndex = 23;
            dataProducto.CellContentClick += dataProducto_CellContentClick;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.MinimumWidth = 6;
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 30;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 35;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 120;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 190;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 180;
            // 
            // idCategoria
            // 
            idCategoria.HeaderText = "idCategoria";
            idCategoria.MinimumWidth = 6;
            idCategoria.Name = "idCategoria";
            idCategoria.ReadOnly = true;
            idCategoria.Width = 90;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 180;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 70;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 80;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 80;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.MinimumWidth = 6;
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            EstadoValor.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 60;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(302, 43);
            label6.Name = "label6";
            label6.Size = new Size(1024, 70);
            label6.TabIndex = 24;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(24, 271);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 25;
            label7.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(24, 338);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 26;
            label8.Text = "Estado";
            // 
            // cbocategoria
            // 
            cbocategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbocategoria.FormattingEnabled = true;
            cbocategoria.Location = new Point(24, 294);
            cbocategoria.Name = "cbocategoria";
            cbocategoria.Size = new Size(112, 28);
            cbocategoria.TabIndex = 27;
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(24, 361);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(112, 28);
            cboestado.TabIndex = 28;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Red;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(22, 480);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(233, 29);
            iconButton1.TabIndex = 29;
            iconButton1.Text = "ELIMINAR";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(745, 49);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(173, 28);
            cbobusqueda.TabIndex = 31;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(938, 49);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(165, 27);
            txtbusqueda.TabIndex = 32;
            txtbusqueda.TextAlign = HorizontalAlignment.Right;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.PowderBlue;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatAppearance.BorderColor = Color.Black;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.White;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 25;
            btnbuscar.Location = new Point(1128, 49);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 26);
            btnbuscar.TabIndex = 33;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(302, 44);
            label10.Name = "label10";
            label10.Size = new Size(221, 41);
            label10.TabIndex = 35;
            label10.Text = "Lista De Productos";
            // 
            // txtid
            // 
            txtid.Location = new Point(202, 50);
            txtid.Name = "txtid";
            txtid.Size = new Size(57, 27);
            txtid.TabIndex = 37;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(116, 50);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(57, 27);
            txtindice.TabIndex = 46;
            txtindice.Text = "0";
            txtindice.Visible = false;
            // 
            // btnexportar
            // 
            btnexportar.BackColor = Color.Ivory;
            btnexportar.Cursor = Cursors.Hand;
            btnexportar.FlatAppearance.BorderColor = Color.Black;
            btnexportar.FlatStyle = FlatStyle.Flat;
            btnexportar.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnexportar.ForeColor = Color.Black;
            btnexportar.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnexportar.IconColor = Color.Black;
            btnexportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexportar.IconSize = 17;
            btnexportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnexportar.Location = new Point(302, 84);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(161, 29);
            btnexportar.TabIndex = 47;
            btnexportar.Text = "DESCARGAR EXCEL";
            btnexportar.UseVisualStyleBackColor = false;
            btnexportar.Click += btnexportar_Click;
            // 
            // btnlimpiarbuscador
            // 
            btnlimpiarbuscador.BackColor = Color.PowderBlue;
            btnlimpiarbuscador.Cursor = Cursors.Hand;
            btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador.ForeColor = Color.White;
            btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador.IconColor = Color.Black;
            btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador.IconSize = 25;
            btnlimpiarbuscador.Location = new Point(1207, 51);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(63, 26);
            btnlimpiarbuscador.TabIndex = 48;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(623, 55);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 77;
            label9.Text = "Buscar por";
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1341, 657);
            Controls.Add(label9);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btnexportar);
            Controls.Add(txtindice);
            Controls.Add(txtid);
            Controls.Add(label10);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(iconButton1);
            Controls.Add(cboestado);
            Controls.Add(cbocategoria);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataProducto);
            Controls.Add(label5);
            Controls.Add(btn);
            Controls.Add(btnguardar);
            Controls.Add(txtmarca);
            Controls.Add(label4);
            Controls.Add(txtnombre);
            Controls.Add(txtcodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProducto";
            Text = "frmProducto";
            Load += frmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private FontAwesome.Sharp.IconButton btn;
        private FontAwesome.Sharp.IconButton btnguardar;
        private TextBox txtmarca;
        private Label label4;
        private TextBox txtnombre;
        private TextBox txtcodigo;
        private Label label2;
        private Label label1;
        private DataGridView dataProducto;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbocategoria;
        private ComboBox cboestado;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private Label label10;
        private TextBox txtid;
        private TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnexportar;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn idCategoria;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private Label label9;
    }
}