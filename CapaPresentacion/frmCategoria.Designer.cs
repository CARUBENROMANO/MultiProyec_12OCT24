namespace CapaPresentacion
{
    partial class frmCategoria
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label5 = new Label();
            btneditar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            txtnombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataCategoria = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            label6 = new Label();
            txtid = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            cboestado = new ComboBox();
            label4 = new Label();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobusqueda = new ComboBox();
            label9 = new Label();
            txtindice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataCategoria).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(53, 9);
            label5.Name = "label5";
            label5.Size = new Size(218, 32);
            label5.TabIndex = 33;
            label5.Text = "Carga de Categoria";
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.LimeGreen;
            btneditar.Cursor = Cursors.Hand;
            btneditar.FlatAppearance.BorderColor = Color.Black;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.ForeColor = Color.White;
            btneditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btneditar.IconColor = Color.Black;
            btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneditar.Location = new Point(55, 328);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(233, 29);
            btneditar.TabIndex = 31;
            btneditar.Text = "LIMPIAR";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
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
            btnguardar.Location = new Point(53, 267);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(233, 29);
            btnguardar.TabIndex = 30;
            btnguardar.Text = "AGREGAR";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(55, 134);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(235, 27);
            txtnombre.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(55, 164);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 25;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(53, 98);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 24;
            label2.Text = "Nombre de Categoria";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 547);
            label1.TabIndex = 23;
            // 
            // dataCategoria
            // 
            dataCategoria.AllowUserToAddRows = false;
            dataCategoria.AllowUserToDeleteRows = false;
            dataCategoria.AllowUserToResizeColumns = false;
            dataCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCategoria.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, id, nombre, estado, EstadoValor });
            dataCategoria.Location = new Point(381, 108);
            dataCategoria.MultiSelect = false;
            dataCategoria.Name = "dataCategoria";
            dataCategoria.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataCategoria.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataCategoria.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataCategoria.RowTemplate.Height = 29;
            dataCategoria.Size = new Size(457, 260);
            dataCategoria.TabIndex = 34;
            dataCategoria.CellContentClick += dataCategoria_CellContentClick;
            dataCategoria.CellPainting += dataCategoria_CellPainting;
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
            id.Width = 70;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre Categoria";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 220;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 125;
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
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(381, 29);
            label6.Name = "label6";
            label6.Size = new Size(840, 70);
            label6.TabIndex = 35;
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtid
            // 
            txtid.Location = new Point(233, 52);
            txtid.Name = "txtid";
            txtid.Size = new Size(57, 27);
            txtid.TabIndex = 36;
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
            iconButton1.Location = new Point(55, 394);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(233, 29);
            iconButton1.TabIndex = 37;
            iconButton1.Text = "ELIMINAR";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(55, 200);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(112, 28);
            cboestado.TabIndex = 38;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(381, 43);
            label4.Name = "label4";
            label4.Size = new Size(255, 36);
            label4.TabIndex = 39;
            label4.Text = "Lista de Categoria";
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
            btnlimpiarbuscador.Location = new Point(1158, 49);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(63, 26);
            btnlimpiarbuscador.TabIndex = 44;
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
            btnbuscar.Location = new Point(1089, 49);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 26);
            btnbuscar.TabIndex = 43;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(949, 49);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(134, 27);
            txtbusqueda.TabIndex = 42;
            txtbusqueda.TextAlign = HorizontalAlignment.Right;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(760, 51);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(173, 28);
            cbobusqueda.TabIndex = 41;
            cbobusqueda.SelectedIndexChanged += cbobusqueda_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(665, 55);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 40;
            label9.Text = "Buscar por";
            // 
            // txtindice
            // 
            txtindice.Location = new Point(150, 51);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(57, 27);
            txtindice.TabIndex = 45;
            txtindice.Text = "0";
            txtindice.Visible = false;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 547);
            Controls.Add(txtindice);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(cboestado);
            Controls.Add(iconButton1);
            Controls.Add(txtid);
            Controls.Add(label6);
            Controls.Add(dataCategoria);
            Controls.Add(label5);
            Controls.Add(btneditar);
            Controls.Add(btnguardar);
            Controls.Add(txtnombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dataCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private TextBox txtnombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataCategoria;
        private Label label6;
        private TextBox txtid;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ComboBox cboestado;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbobusqueda;
        private Label label9;
        private TextBox txtindice;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn EstadoValor;
    }
}