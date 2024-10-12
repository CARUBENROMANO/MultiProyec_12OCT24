namespace CapaPresentacion
{
    partial class fmrDetalleVenta
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
            btnexportar = new FontAwesome.Sharp.IconButton();
            txttoltalpagar = new TextBox();
            label13 = new Label();
            dgvdata = new DataGridView();
            groupBox1 = new GroupBox();
            txtnumerodocumento = new TextBox();
            txttipodocumento = new TextBox();
            txtusuario = new TextBox();
            label5 = new Label();
            txtfecha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusquedadocumento = new TextBox();
            label1 = new Label();
            label6 = new Label();
            txtcambio = new TextBox();
            label7 = new Label();
            txtpagocon = new TextBox();
            label8 = new Label();
            producto = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnexportar
            // 
            btnexportar.BackColor = Color.PowderBlue;
            btnexportar.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnexportar.IconColor = Color.Black;
            btnexportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexportar.IconSize = 26;
            btnexportar.ImageAlign = ContentAlignment.TopLeft;
            btnexportar.Location = new Point(907, 600);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(163, 38);
            btnexportar.TabIndex = 99;
            btnexportar.Text = "Descargar en PDF";
            btnexportar.TextAlign = ContentAlignment.TopCenter;
            btnexportar.UseVisualStyleBackColor = false;
            btnexportar.Click += btnexportar_Click;
            // 
            // txttoltalpagar
            // 
            txttoltalpagar.BackColor = Color.WhiteSmoke;
            txttoltalpagar.Location = new Point(335, 604);
            txttoltalpagar.Name = "txttoltalpagar";
            txttoltalpagar.Size = new Size(97, 27);
            txttoltalpagar.TabIndex = 98;
            txttoltalpagar.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(227, 605);
            label13.Name = "label13";
            label13.Size = new Size(111, 23);
            label13.TabIndex = 97;
            label13.Text = "Monto Total :";
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { producto, precio, cantidad, subtotal });
            dgvdata.Location = new Point(225, 228);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 29;
            dgvdata.Size = new Size(845, 355);
            dgvdata.TabIndex = 96;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtnumerodocumento);
            groupBox1.Controls.Add(txttipodocumento);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(227, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(820, 94);
            groupBox1.TabIndex = 95;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Venta:";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(750, 22);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(45, 27);
            txtnumerodocumento.TabIndex = 104;
            txtnumerodocumento.Visible = false;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(438, 77);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 94;
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
            btnlimpiarbuscador.Location = new Point(952, 78);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(63, 26);
            btnlimpiarbuscador.TabIndex = 93;
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
            btnbuscar.Location = new Point(867, 78);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 26);
            btnbuscar.TabIndex = 92;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusquedadocumento
            // 
            txtbusquedadocumento.Location = new Point(635, 77);
            txtbusquedadocumento.Name = "txtbusquedadocumento";
            txtbusquedadocumento.Size = new Size(193, 27);
            txtbusquedadocumento.TabIndex = 91;
            txtbusquedadocumento.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(210, 42);
            label1.Name = "label1";
            label1.Size = new Size(204, 35);
            label1.TabIndex = 90;
            label1.Text = "DETALLE VENTA";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(191, 32);
            label6.Name = "label6";
            label6.Size = new Size(911, 636);
            label6.TabIndex = 89;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtcambio
            // 
            txtcambio.BackColor = Color.WhiteSmoke;
            txtcambio.Location = new Point(746, 605);
            txtcambio.Name = "txtcambio";
            txtcambio.Size = new Size(128, 27);
            txtcambio.TabIndex = 101;
            txtcambio.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(662, 608);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 100;
            label7.Text = "Cambio :";
            // 
            // txtpagocon
            // 
            txtpagocon.BackColor = Color.WhiteSmoke;
            txtpagocon.Location = new Point(540, 604);
            txtpagocon.Name = "txtpagocon";
            txtpagocon.Size = new Size(111, 27);
            txtpagocon.TabIndex = 103;
            txtpagocon.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(449, 605);
            label8.Name = "label8";
            label8.Size = new Size(85, 23);
            label8.TabIndex = 102;
            label8.Text = "Pago con:";
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.ReadOnly = true;
            producto.Width = 270;
            // 
            // precio
            // 
            precio.HeaderText = "Precio Producto";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 200;
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
            // fmrDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 677);
            Controls.Add(txtpagocon);
            Controls.Add(label8);
            Controls.Add(txtcambio);
            Controls.Add(label7);
            Controls.Add(btnexportar);
            Controls.Add(txttoltalpagar);
            Controls.Add(label13);
            Controls.Add(dgvdata);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusquedadocumento);
            Controls.Add(label1);
            Controls.Add(label6);
            Name = "fmrDetalleVenta";
            Text = "fmrDetalleVenta";
            Load += fmrDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnexportar;
        private TextBox txttoltalpagar;
        private Label label13;
        private DataGridView dgvdata;
        private GroupBox groupBox1;
        private TextBox txttipodocumento;
        private TextBox txtusuario;
        private Label label5;
        private TextBox txtfecha;
        private Label label3;
        private Label label4;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusquedadocumento;
        private Label label1;
        private Label label6;
        private TextBox txtcambio;
        private Label label7;
        private TextBox txtpagocon;
        private Label label8;
        private DataGridViewTextBoxColumn nombreProducto;
        private TextBox txtnumerodocumento;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subtotal;
    }
}