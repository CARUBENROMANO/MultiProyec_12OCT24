namespace CapaPresentacion
{
    partial class frmProveedores
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
            txtindice = new TextBox();
            txtid = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            btn = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            txttelefono = new TextBox();
            txtcorreo = new TextBox();
            txtrazonsocial = new TextBox();
            label1 = new Label();
            dataProveedor = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            razonSocial = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            documento = new DataGridViewTextBoxColumn();
            label10 = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobusqueda = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            iconButton2btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            label7 = new Label();
            txtdocumento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataProveedor).BeginInit();
            SuspendLayout();
            // 
            // txtindice
            // 
            txtindice.Location = new Point(115, 44);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(57, 27);
            txtindice.TabIndex = 58;
            txtindice.Text = "0";
            txtindice.Visible = false;
            // 
            // txtid
            // 
            txtid.Location = new Point(183, 44);
            txtid.Name = "txtid";
            txtid.Size = new Size(57, 27);
            txtid.TabIndex = 57;
            txtid.Text = "0";
            txtid.Visible = false;
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
            iconButton1.Location = new Point(12, 481);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(241, 29);
            iconButton1.TabIndex = 56;
            iconButton1.Text = "ELIMINAR";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 9);
            label5.Name = "label5";
            label5.Size = new Size(225, 32);
            label5.TabIndex = 53;
            label5.Text = "Carga de Proveedor";
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
            btn.Location = new Point(12, 426);
            btn.Name = "btn";
            btn.Size = new Size(241, 29);
            btn.TabIndex = 52;
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
            btnguardar.Location = new Point(12, 374);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(241, 29);
            btnguardar.TabIndex = 51;
            btnguardar.Text = "GUARDAR";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(18, 233);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(235, 27);
            txttelefono.TabIndex = 50;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(18, 164);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(235, 27);
            txtcorreo.TabIndex = 49;
            // 
            // txtrazonsocial
            // 
            txtrazonsocial.Location = new Point(18, 100);
            txtrazonsocial.Name = "txtrazonsocial";
            txtrazonsocial.Size = new Size(235, 27);
            txtrazonsocial.TabIndex = 48;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(282, 582);
            label1.TabIndex = 47;
            // 
            // dataProveedor
            // 
            dataProveedor.AllowUserToAddRows = false;
            dataProveedor.AllowUserToDeleteRows = false;
            dataProveedor.AllowUserToOrderColumns = true;
            dataProveedor.AllowUserToResizeColumns = false;
            dataProveedor.AllowUserToResizeRows = false;
            dataProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProveedor.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, id, razonSocial, correo, Telefono, documento });
            dataProveedor.Location = new Point(288, 116);
            dataProveedor.MultiSelect = false;
            dataProveedor.Name = "dataProveedor";
            dataProveedor.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataProveedor.RowHeadersWidth = 51;
            dataProveedor.RowTemplate.Height = 29;
            dataProveedor.Size = new Size(977, 410);
            dataProveedor.TabIndex = 59;
            dataProveedor.CellContentClick += dataProveedor_CellContentClick;
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
            // razonSocial
            // 
            razonSocial.HeaderText = "Razon Social";
            razonSocial.MinimumWidth = 6;
            razonSocial.Name = "razonSocial";
            razonSocial.ReadOnly = true;
            razonSocial.Width = 250;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            correo.ReadOnly = true;
            correo.Width = 250;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 200;
            // 
            // documento
            // 
            documento.HeaderText = "Documento";
            documento.MinimumWidth = 6;
            documento.Name = "documento";
            documento.ReadOnly = true;
            documento.Width = 250;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(300, 10);
            label10.Name = "label10";
            label10.Size = new Size(221, 41);
            label10.TabIndex = 64;
            label10.Text = "Lista De Proveedor:";
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
            btnbuscar.Location = new Point(1126, 15);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 26);
            btnbuscar.TabIndex = 63;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(936, 15);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(165, 27);
            txtbusqueda.TabIndex = 62;
            txtbusqueda.TextAlign = HorizontalAlignment.Right;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(743, 15);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(173, 28);
            cbobusqueda.TabIndex = 61;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(288, 9);
            label6.Name = "label6";
            label6.Size = new Size(977, 70);
            label6.TabIndex = 60;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(18, 77);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 65;
            label3.Text = "Razon Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(18, 210);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 66;
            label2.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(18, 141);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 67;
            label4.Text = "Correo";
            // 
            // iconButton2btnlimpiarbuscador
            // 
            iconButton2btnlimpiarbuscador.BackColor = Color.PowderBlue;
            iconButton2btnlimpiarbuscador.Cursor = Cursors.Hand;
            iconButton2btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            iconButton2btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            iconButton2btnlimpiarbuscador.ForeColor = Color.White;
            iconButton2btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton2btnlimpiarbuscador.IconColor = Color.Black;
            iconButton2btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2btnlimpiarbuscador.IconSize = 25;
            iconButton2btnlimpiarbuscador.Location = new Point(1195, 15);
            iconButton2btnlimpiarbuscador.Name = "iconButton2btnlimpiarbuscador";
            iconButton2btnlimpiarbuscador.Size = new Size(63, 26);
            iconButton2btnlimpiarbuscador.TabIndex = 70;
            iconButton2btnlimpiarbuscador.UseVisualStyleBackColor = false;
            iconButton2btnlimpiarbuscador.Click += iconButton2btnlimpiarbuscador_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(627, 18);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 69;
            label9.Text = "Buscar por";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(18, 289);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 71;
            label7.Text = "Documento";
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(18, 322);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(235, 27);
            txtdocumento.TabIndex = 72;
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 582);
            Controls.Add(txtdocumento);
            Controls.Add(label7);
            Controls.Add(iconButton2btnlimpiarbuscador);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label6);
            Controls.Add(dataProveedor);
            Controls.Add(txtindice);
            Controls.Add(txtid);
            Controls.Add(iconButton1);
            Controls.Add(label5);
            Controls.Add(btn);
            Controls.Add(btnguardar);
            Controls.Add(txttelefono);
            Controls.Add(txtcorreo);
            Controls.Add(txtrazonsocial);
            Controls.Add(label1);
            Name = "frmProveedores";
            Text = "frmProveedores";
            Load += frmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtindice;
        private TextBox txtid;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label5;
        private FontAwesome.Sharp.IconButton btn;
        private FontAwesome.Sharp.IconButton btnguardar;
        private TextBox txttelefono;
        private TextBox txtcorreo;
        private TextBox txtrazonsocial;
        private Label label1;
        private DataGridView dataProveedor;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbobusqueda;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton2btnlimpiarbuscador;
        private Label label9;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn razonSocial;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn documento;
        private Label label7;
        private TextBox txtdocumento;
    }
}