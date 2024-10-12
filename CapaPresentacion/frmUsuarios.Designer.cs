namespace CapaPresentacion
{
    partial class frmUsuarios
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtnombre = new TextBox();
            txtclave = new TextBox();
            label4 = new Label();
            txtdocumento = new TextBox();
            btnguardar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            nombreUsuario = new DataGridViewTextBoxColumn();
            ClaveUsuario = new DataGridViewTextBoxColumn();
            documento = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            domicilio = new DataGridViewTextBoxColumn();
            idRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            label6 = new Label();
            txtid = new TextBox();
            cboRol = new ComboBox();
            label7 = new Label();
            label9 = new Label();
            cbobusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            iconButton2btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtindice = new TextBox();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtcorreo = new TextBox();
            txttelefono = new TextBox();
            txtdomicilio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(323, 656);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(35, 74);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(35, 136);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(35, 97);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(235, 27);
            txtnombre.TabIndex = 4;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(33, 159);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(235, 27);
            txtclave.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(33, 199);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Documento";
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(35, 222);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(235, 27);
            txtdocumento.TabIndex = 7;
            txtdocumento.TextChanged += txtconfirmaclave_TextChanged;
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
            btnguardar.Location = new Point(37, 508);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(233, 29);
            btnguardar.TabIndex = 8;
            btnguardar.Text = "GUARDAR";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.LimeGreen;
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatAppearance.BorderColor = Color.Black;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnlimpiar.IconColor = Color.Black;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.Location = new Point(35, 543);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(233, 29);
            btnlimpiar.TabIndex = 9;
            btnlimpiar.Text = "LIMPIAR";
            btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(37, 9);
            label5.Name = "label5";
            label5.Size = new Size(196, 32);
            label5.TabIndex = 11;
            label5.Text = "Carga de Usuario";
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
            iconButton1.Location = new Point(37, 578);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(233, 29);
            iconButton1.TabIndex = 12;
            iconButton1.Text = "ELIMINAR";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, id, nombreUsuario, ClaveUsuario, documento, correo, telefono, domicilio, idRol, Rol });
            dgvdata.Location = new Point(356, 166);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 29;
            dgvdata.Size = new Size(876, 441);
            dgvdata.TabIndex = 13;
            dgvdata.CellContentClick += dgvdata_CellContentClick_1;
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
            id.HeaderText = "idUsuario";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 70;
            // 
            // nombreUsuario
            // 
            nombreUsuario.HeaderText = "Nombre Usuario";
            nombreUsuario.MinimumWidth = 6;
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.ReadOnly = true;
            nombreUsuario.Width = 150;
            // 
            // ClaveUsuario
            // 
            ClaveUsuario.HeaderText = "Clave Usuario";
            ClaveUsuario.MinimumWidth = 6;
            ClaveUsuario.Name = "ClaveUsuario";
            ClaveUsuario.ReadOnly = true;
            ClaveUsuario.Visible = false;
            ClaveUsuario.Width = 140;
            // 
            // documento
            // 
            documento.HeaderText = "Documento";
            documento.MinimumWidth = 6;
            documento.Name = "documento";
            documento.ReadOnly = true;
            documento.Width = 125;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            correo.ReadOnly = true;
            correo.Width = 200;
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 150;
            // 
            // domicilio
            // 
            domicilio.HeaderText = "Domicilio";
            domicilio.MinimumWidth = 6;
            domicilio.Name = "domicilio";
            domicilio.ReadOnly = true;
            domicilio.Width = 230;
            // 
            // idRol
            // 
            idRol.HeaderText = "idRol";
            idRol.MinimumWidth = 6;
            idRol.Name = "idRol";
            idRol.ReadOnly = true;
            idRol.Visible = false;
            idRol.Width = 125;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 130;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(356, 61);
            label6.Name = "label6";
            label6.Size = new Size(876, 76);
            label6.TabIndex = 14;
            label6.Text = "Lista de Usuarios";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtid
            // 
            txtid.Location = new Point(219, 44);
            txtid.Name = "txtid";
            txtid.Size = new Size(53, 27);
            txtid.TabIndex = 15;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(35, 454);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(233, 28);
            cboRol.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(37, 431);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 29;
            label7.Text = "Rol";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(662, 92);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 31;
            label9.Text = "Buscar por";
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(747, 89);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(167, 28);
            cbobusqueda.TabIndex = 32;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(944, 89);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(139, 27);
            txtbusqueda.TabIndex = 33;
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
            btnbuscar.Location = new Point(1112, 91);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(40, 26);
            btnbuscar.TabIndex = 34;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
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
            iconButton2btnlimpiarbuscador.Location = new Point(1181, 92);
            iconButton2btnlimpiarbuscador.Name = "iconButton2btnlimpiarbuscador";
            iconButton2btnlimpiarbuscador.Size = new Size(40, 26);
            iconButton2btnlimpiarbuscador.TabIndex = 35;
            iconButton2btnlimpiarbuscador.UseVisualStyleBackColor = false;
            iconButton2btnlimpiarbuscador.Click += iconButton2btnlimpiarbuscador_Click;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(39, 44);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(53, 27);
            txtindice.TabIndex = 36;
            txtindice.Text = "0";
            txtindice.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(39, 379);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 37;
            label8.Text = "Domiclio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(35, 318);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 38;
            label10.Text = "Telefono";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(31, 262);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 39;
            label11.Text = "Correo";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(35, 285);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(235, 27);
            txtcorreo.TabIndex = 40;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(37, 339);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(235, 27);
            txttelefono.TabIndex = 41;
            // 
            // txtdomicilio
            // 
            txtdomicilio.Location = new Point(39, 402);
            txtdomicilio.Name = "txtdomicilio";
            txtdomicilio.Size = new Size(235, 27);
            txtdomicilio.TabIndex = 42;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 656);
            Controls.Add(txtdomicilio);
            Controls.Add(txttelefono);
            Controls.Add(txtcorreo);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(txtindice);
            Controls.Add(iconButton2btnlimpiarbuscador);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(cboRol);
            Controls.Add(txtid);
            Controls.Add(label6);
            Controls.Add(dgvdata);
            Controls.Add(iconButton1);
            Controls.Add(label5);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(txtdocumento);
            Controls.Add(label4);
            Controls.Add(txtclave);
            Controls.Add(txtnombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnombre;
        private TextBox txtclave;
        private Label label4;
        private TextBox txtdocumento;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView dgvdata;
        private Label label6;
        private TextBox txtid;
        private ComboBox cboRol;
        private Label label7;
        private Label label9;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton iconButton2btnlimpiarbuscador;
        private TextBox txtindice;
        private Label label8;
        private Label label10;
        private Label label11;
        private TextBox txtcorreo;
        private TextBox txttelefono;
        private TextBox txtdomicilio;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombreUsuario;
        private DataGridViewTextBoxColumn ClaveUsuario;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn domicilio;
        private DataGridViewTextBoxColumn idRol;
        private DataGridViewTextBoxColumn Rol;
    }
}