namespace CapaPresentacion
{
    partial class fmrDetalleCompra
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
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            txtfecha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txttipodocumento = new TextBox();
            txtusuario = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            txtnumerodocumento = new TextBox();
            txtnombreproveedor = new TextBox();
            txtdocproveedor = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dgvdata = new DataGridView();
            producto = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            txttotal = new TextBox();
            label13 = new Label();
            btnexportar = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(214, 21);
            label6.Name = "label6";
            label6.Size = new Size(852, 653);
            label6.TabIndex = 33;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(233, 31);
            label1.Name = "label1";
            label1.Size = new Size(231, 35);
            label1.TabIndex = 35;
            label1.Text = "DETALLE COMPRA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(461, 66);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 82;
            label2.Text = "Numero Documento :";
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
            btnlimpiarbuscador.Location = new Point(975, 67);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(63, 26);
            btnlimpiarbuscador.TabIndex = 81;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
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
            btnbuscar.Location = new Point(890, 67);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 26);
            btnbuscar.TabIndex = 80;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(658, 66);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(193, 27);
            txtbusqueda.TabIndex = 79;
            txtbusqueda.TextAlign = HorizontalAlignment.Right;
            // 
            // txtfecha
            // 
            txtfecha.BackColor = Color.WhiteSmoke;
            txtfecha.Location = new Point(13, 58);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(146, 27);
            txtfecha.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 35;
            label3.Text = "Fecha : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(249, 23);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 36;
            label4.Text = "Tipo Documento : ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txttipodocumento);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(250, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(801, 94);
            groupBox1.TabIndex = 83;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Compra:";
            // 
            // txttipodocumento
            // 
            txttipodocumento.BackColor = Color.WhiteSmoke;
            txttipodocumento.Location = new Point(249, 59);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.Size = new Size(175, 27);
            txttipodocumento.TabIndex = 41;
            // 
            // txtusuario
            // 
            txtusuario.BackColor = Color.WhiteSmoke;
            txtusuario.Location = new Point(565, 59);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(175, 27);
            txtusuario.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(565, 23);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 39;
            label5.Text = "Usuario : ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtnumerodocumento);
            groupBox2.Controls.Add(txtnombreproveedor);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(250, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(801, 106);
            groupBox2.TabIndex = 84;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Proveedor:";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(723, 22);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(61, 27);
            txtnumerodocumento.TabIndex = 40;
            txtnumerodocumento.Visible = false;
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.BackColor = Color.WhiteSmoke;
            txtnombreproveedor.Location = new Point(364, 58);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.Size = new Size(279, 27);
            txtnombreproveedor.TabIndex = 38;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.BackColor = Color.WhiteSmoke;
            txtdocproveedor.Location = new Point(13, 58);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.Size = new Size(225, 27);
            txtdocproveedor.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(364, 23);
            label7.Name = "label7";
            label7.Size = new Size(120, 23);
            label7.TabIndex = 36;
            label7.Text = "Razon Social : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 23);
            label8.Name = "label8";
            label8.Size = new Size(182, 23);
            label8.TabIndex = 35;
            label8.Text = "Numero Documento : ";
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { producto, precioCompra, cantidad, subtotal });
            dgvdata.Location = new Point(233, 311);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 29;
            dgvdata.Size = new Size(818, 306);
            dgvdata.TabIndex = 85;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.ReadOnly = true;
            producto.Width = 270;
            // 
            // precioCompra
            // 
            precioCompra.HeaderText = "Precio Producto";
            precioCompra.MinimumWidth = 6;
            precioCompra.Name = "precioCompra";
            precioCompra.ReadOnly = true;
            precioCompra.Width = 200;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 150;
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Sub Total";
            subtotal.MinimumWidth = 6;
            subtotal.Name = "subtotal";
            subtotal.ReadOnly = true;
            subtotal.Width = 170;
            // 
            // txttotal
            // 
            txttotal.BackColor = Color.WhiteSmoke;
            txttotal.Location = new Point(369, 633);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(119, 27);
            txttotal.TabIndex = 87;
            txttotal.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(233, 633);
            label13.Name = "label13";
            label13.Size = new Size(111, 23);
            label13.TabIndex = 86;
            label13.Text = "Monto Total :";
            // 
            // btnexportar
            // 
            btnexportar.BackColor = Color.PowderBlue;
            btnexportar.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnexportar.IconColor = Color.Black;
            btnexportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexportar.IconSize = 26;
            btnexportar.ImageAlign = ContentAlignment.TopLeft;
            btnexportar.Location = new Point(877, 631);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(174, 38);
            btnexportar.TabIndex = 88;
            btnexportar.Text = "Descargar en PDF";
            btnexportar.TextAlign = ContentAlignment.TopCenter;
            btnexportar.UseVisualStyleBackColor = false;
            btnexportar.Click += btnexportar_Click;
            // 
            // fmrDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 685);
            Controls.Add(btnexportar);
            Controls.Add(txttotal);
            Controls.Add(label13);
            Controls.Add(dgvdata);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(label1);
            Controls.Add(label6);
            Name = "fmrDetalleCompra";
            Text = "fmrDetalleCompra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private TextBox txtfecha;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtusuario;
        private Label label5;
        private TextBox txttipodocumento;
        private GroupBox groupBox2;
        private TextBox txtnumerodocumento;
        private TextBox txtnombreproveedor;
        private TextBox txtdocproveedor;
        private Label label7;
        private Label label8;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precioCompra;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subtotal;
        private TextBox txttotal;
        private Label label13;
        private FontAwesome.Sharp.IconButton btnexportar;
    }
}