namespace CapaPresentacion
{
    partial class fmrReportesCompras
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
            label9 = new Label();
            label6 = new Label();
            txtfechainicio = new DateTimePicker();
            cboproveedor = new ComboBox();
            label3 = new Label();
            label14 = new Label();
            txtfechafin = new DateTimePicker();
            label1 = new Label();
            btnbuscarroveedor = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            dgvdata = new DataGridView();
            fechaRegistro = new DataGridViewTextBoxColumn();
            tipoDocumento = new DataGridViewTextBoxColumn();
            numeroDocumento = new DataGridViewTextBoxColumn();
            montoTotal = new DataGridViewTextBoxColumn();
            usuarioRegistro = new DataGridViewTextBoxColumn();
            documentoProveedor = new DataGridViewTextBoxColumn();
            razonSocial = new DataGridViewTextBoxColumn();
            codigoProducto = new DataGridViewTextBoxColumn();
            nombreproducto = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btnexportar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobusqueda = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(58, 24);
            label9.Name = "label9";
            label9.Size = new Size(250, 35);
            label9.TabIndex = 34;
            label9.Text = "REPORTE COMPRAS";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(46, 12);
            label6.Name = "label6";
            label6.Size = new Size(1174, 124);
            label6.TabIndex = 33;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtfechainicio
            // 
            txtfechainicio.CustomFormat = "dd/MM/yyyy";
            txtfechainicio.Format = DateTimePickerFormat.Short;
            txtfechainicio.Location = new Point(178, 77);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new Size(125, 27);
            txtfechainicio.TabIndex = 35;
            // 
            // cboproveedor
            // 
            cboproveedor.FormattingEnabled = true;
            cboproveedor.Location = new Point(736, 71);
            cboproveedor.Name = "cboproveedor";
            cboproveedor.Size = new Size(188, 28);
            cboproveedor.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 77);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 39;
            label3.Text = "Fecha Inicio : ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(324, 80);
            label14.Name = "label14";
            label14.Size = new Size(114, 23);
            label14.TabIndex = 40;
            label14.Text = "Fecha de Fin: ";
            // 
            // txtfechafin
            // 
            txtfechafin.CustomFormat = "dd/MM/yyyy";
            txtfechafin.Format = DateTimePickerFormat.Short;
            txtfechafin.Location = new Point(444, 76);
            txtfechafin.Name = "txtfechafin";
            txtfechafin.Size = new Size(125, 27);
            txtfechafin.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(628, 76);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 43;
            label1.Text = "Proveedor : ";
            // 
            // btnbuscarroveedor
            // 
            btnbuscarroveedor.BackColor = Color.PowderBlue;
            btnbuscarroveedor.Cursor = Cursors.Hand;
            btnbuscarroveedor.FlatAppearance.BorderColor = Color.Black;
            btnbuscarroveedor.FlatStyle = FlatStyle.Flat;
            btnbuscarroveedor.ForeColor = Color.White;
            btnbuscarroveedor.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            btnbuscarroveedor.IconColor = Color.Black;
            btnbuscarroveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarroveedor.IconSize = 25;
            btnbuscarroveedor.Location = new Point(933, 72);
            btnbuscarroveedor.Name = "btnbuscarroveedor";
            btnbuscarroveedor.Size = new Size(69, 26);
            btnbuscarroveedor.TabIndex = 44;
            btnbuscarroveedor.UseVisualStyleBackColor = false;
            btnbuscarroveedor.Click += btnbuscarroveedor_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 150);
            label2.Name = "label2";
            label2.Size = new Size(1174, 503);
            label2.TabIndex = 45;
            label2.TextAlign = ContentAlignment.MiddleLeft;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { fechaRegistro, tipoDocumento, numeroDocumento, montoTotal, usuarioRegistro, documentoProveedor, razonSocial, codigoProducto, nombreproducto, categoria, precioCompra, precioVenta, cantidad, subtotal });
            dgvdata.Location = new Point(58, 213);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 29;
            dgvdata.Size = new Size(1147, 413);
            dgvdata.TabIndex = 89;
            // 
            // fechaRegistro
            // 
            fechaRegistro.HeaderText = "Fecha Registro";
            fechaRegistro.MinimumWidth = 6;
            fechaRegistro.Name = "fechaRegistro";
            fechaRegistro.ReadOnly = true;
            fechaRegistro.Width = 125;
            // 
            // tipoDocumento
            // 
            tipoDocumento.HeaderText = "Tipo Documento";
            tipoDocumento.MinimumWidth = 6;
            tipoDocumento.Name = "tipoDocumento";
            tipoDocumento.ReadOnly = true;
            tipoDocumento.Width = 125;
            // 
            // numeroDocumento
            // 
            numeroDocumento.HeaderText = "numeroDocumento";
            numeroDocumento.MinimumWidth = 6;
            numeroDocumento.Name = "numeroDocumento";
            numeroDocumento.ReadOnly = true;
            numeroDocumento.Width = 125;
            // 
            // montoTotal
            // 
            montoTotal.HeaderText = "Monto Total";
            montoTotal.MinimumWidth = 6;
            montoTotal.Name = "montoTotal";
            montoTotal.ReadOnly = true;
            montoTotal.Width = 125;
            // 
            // usuarioRegistro
            // 
            usuarioRegistro.HeaderText = "Usuario Registro";
            usuarioRegistro.MinimumWidth = 6;
            usuarioRegistro.Name = "usuarioRegistro";
            usuarioRegistro.ReadOnly = true;
            usuarioRegistro.Width = 125;
            // 
            // documentoProveedor
            // 
            documentoProveedor.HeaderText = "Documento Proveedor";
            documentoProveedor.MinimumWidth = 6;
            documentoProveedor.Name = "documentoProveedor";
            documentoProveedor.ReadOnly = true;
            documentoProveedor.Width = 125;
            // 
            // razonSocial
            // 
            razonSocial.HeaderText = "Razon Social";
            razonSocial.MinimumWidth = 6;
            razonSocial.Name = "razonSocial";
            razonSocial.ReadOnly = true;
            razonSocial.Width = 125;
            // 
            // codigoProducto
            // 
            codigoProducto.HeaderText = "Codigo Producto";
            codigoProducto.MinimumWidth = 6;
            codigoProducto.Name = "codigoProducto";
            codigoProducto.ReadOnly = true;
            codigoProducto.Width = 125;
            // 
            // nombreproducto
            // 
            nombreproducto.HeaderText = "Producto";
            nombreproducto.MinimumWidth = 6;
            nombreproducto.Name = "nombreproducto";
            nombreproducto.ReadOnly = true;
            nombreproducto.Width = 280;
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.MinimumWidth = 6;
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 125;
            // 
            // precioCompra
            // 
            precioCompra.HeaderText = "Precio Compra";
            precioCompra.MinimumWidth = 6;
            precioCompra.Name = "precioCompra";
            precioCompra.ReadOnly = true;
            precioCompra.Width = 125;
            // 
            // precioVenta
            // 
            precioVenta.HeaderText = "Precio Venta";
            precioVenta.MinimumWidth = 6;
            precioVenta.Name = "precioVenta";
            precioVenta.ReadOnly = true;
            precioVenta.Width = 180;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(556, 163);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 95;
            label4.Text = "Buscar por";
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
            btnlimpiarbuscador.Location = new Point(1142, 162);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(63, 26);
            btnlimpiarbuscador.TabIndex = 94;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // btnexportar
            // 
            btnexportar.BackColor = Color.Chartreuse;
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
            btnexportar.Location = new Point(58, 163);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(161, 29);
            btnexportar.TabIndex = 93;
            btnexportar.Text = "DESCARGAR EXCEL";
            btnexportar.UseVisualStyleBackColor = false;
            btnexportar.Click += btnexportar_Click;
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
            btnbuscar.Location = new Point(1061, 161);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 26);
            btnbuscar.TabIndex = 92;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(872, 161);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(165, 27);
            txtbusqueda.TabIndex = 91;
            txtbusqueda.TextAlign = HorizontalAlignment.Right;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(677, 159);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(173, 28);
            cbobusqueda.TabIndex = 90;
            // 
            // fmrReportesCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 676);
            Controls.Add(label4);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btnexportar);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(dgvdata);
            Controls.Add(label2);
            Controls.Add(btnbuscarroveedor);
            Controls.Add(label1);
            Controls.Add(txtfechafin);
            Controls.Add(cboproveedor);
            Controls.Add(label3);
            Controls.Add(label14);
            Controls.Add(txtfechainicio);
            Controls.Add(label9);
            Controls.Add(label6);
            Name = "fmrReportesCompras";
            Text = "fmrReportesCompra";
            Load += fmrReportesCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label6;
        private DateTimePicker txtfechainicio;
        private ComboBox cboproveedor;
        private Label label3;
        private Label label14;
        private DateTimePicker txtfechafin;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnbuscarroveedor;
        private Label label2;
        private DataGridView dgvdata;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnexportar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbobusqueda;
        private DataGridViewTextBoxColumn fechaRegistro;
        private DataGridViewTextBoxColumn tipoDocumento;
        private DataGridViewTextBoxColumn numeroDocumento;
        private DataGridViewTextBoxColumn montoTotal;
        private DataGridViewTextBoxColumn usuarioRegistro;
        private DataGridViewTextBoxColumn documentoProveedor;
        private DataGridViewTextBoxColumn razonSocial;
        private DataGridViewTextBoxColumn codigoProducto;
        private DataGridViewTextBoxColumn nombreproducto;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn precioCompra;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subtotal;
    }
}