namespace CapaPresentacion.Modales
{
    partial class mdProveedor
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
            iconButton2btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobusqueda = new ComboBox();
            label6 = new Label();
            dataProveedor = new DataGridView();
            label10 = new Label();
            id = new DataGridViewTextBoxColumn();
            razonSocial = new DataGridViewTextBoxColumn();
            documento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataProveedor).BeginInit();
            SuspendLayout();
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
            iconButton2btnlimpiarbuscador.Location = new Point(625, 90);
            iconButton2btnlimpiarbuscador.Name = "iconButton2btnlimpiarbuscador";
            iconButton2btnlimpiarbuscador.Size = new Size(63, 26);
            iconButton2btnlimpiarbuscador.TabIndex = 77;
            iconButton2btnlimpiarbuscador.UseVisualStyleBackColor = false;
            iconButton2btnlimpiarbuscador.Click += iconButton2btnlimpiarbuscador_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(62, 96);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 76;
            label9.Text = "Buscar por";
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
            btnbuscar.Location = new Point(545, 90);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 26);
            btnbuscar.TabIndex = 75;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(365, 89);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(165, 27);
            txtbusqueda.TabIndex = 74;
            txtbusqueda.TextAlign = HorizontalAlignment.Right;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(170, 88);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(173, 28);
            cbobusqueda.TabIndex = 73;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(53, 20);
            label6.Name = "label6";
            label6.Size = new Size(641, 126);
            label6.TabIndex = 72;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataProveedor
            // 
            dataProveedor.AllowUserToAddRows = false;
            dataProveedor.AllowUserToDeleteRows = false;
            dataProveedor.AllowUserToOrderColumns = true;
            dataProveedor.AllowUserToResizeColumns = false;
            dataProveedor.AllowUserToResizeRows = false;
            dataProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProveedor.Columns.AddRange(new DataGridViewColumn[] { id, razonSocial, documento });
            dataProveedor.Location = new Point(53, 157);
            dataProveedor.MultiSelect = false;
            dataProveedor.Name = "dataProveedor";
            dataProveedor.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataProveedor.RowHeadersWidth = 51;
            dataProveedor.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            dataProveedor.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataProveedor.RowTemplate.Height = 29;
            dataProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProveedor.Size = new Size(641, 371);
            dataProveedor.TabIndex = 71;
            dataProveedor.CellDoubleClick += dataProveedor_CellDoubleClick;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(62, 20);
            label10.Name = "label10";
            label10.Size = new Size(221, 41);
            label10.TabIndex = 78;
            label10.Text = "Lista De Proveedor:";
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
            razonSocial.Width = 300;
            // 
            // documento
            // 
            documento.HeaderText = "Documento";
            documento.MinimumWidth = 6;
            documento.Name = "documento";
            documento.ReadOnly = true;
            documento.Width = 250;
            // 
            // mdProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 556);
            Controls.Add(label10);
            Controls.Add(iconButton2btnlimpiarbuscador);
            Controls.Add(label9);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label6);
            Controls.Add(dataProveedor);
            Name = "mdProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdProveedor";
            Load += mdProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton2btnlimpiarbuscador;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbobusqueda;
        private Label label6;
        private DataGridView dataProveedor;
        private Label label10;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn razonSocial;
        private DataGridViewTextBoxColumn documento;
    }
}