namespace CapaPresentacion
{
    partial class frmNegocio
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
            label5 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            txtDireNegocio = new TextBox();
            txtDire = new Label();
            txtcuitNegocio = new TextBox();
            txtNegocio = new TextBox();
            txtCuit = new Label();
            txtNombreNegocio = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            picLogo = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 21);
            label5.Name = "label5";
            label5.Size = new Size(226, 32);
            label5.TabIndex = 13;
            label5.Text = "Detalle del Negocio";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(653, 450);
            label1.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(iconButton2);
            groupBox1.Controls.Add(txtDireNegocio);
            groupBox1.Controls.Add(txtDire);
            groupBox1.Controls.Add(txtcuitNegocio);
            groupBox1.Controls.Add(txtNegocio);
            groupBox1.Controls.Add(txtCuit);
            groupBox1.Controls.Add(txtNombreNegocio);
            groupBox1.Controls.Add(iconButton1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(picLogo);
            groupBox1.Location = new Point(24, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 323);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.DeepSkyBlue;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.UpDown;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(221, 222);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(167, 35);
            iconButton2.TabIndex = 14;
            iconButton2.Text = "Guardar Cambios";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // txtDireNegocio
            // 
            txtDireNegocio.Location = new Point(221, 178);
            txtDireNegocio.Name = "txtDireNegocio";
            txtDireNegocio.Size = new Size(289, 27);
            txtDireNegocio.TabIndex = 13;
            // 
            // txtDire
            // 
            txtDire.AutoSize = true;
            txtDire.BackColor = Color.White;
            txtDire.Location = new Point(219, 155);
            txtDire.Name = "txtDire";
            txtDire.Size = new Size(83, 20);
            txtDire.TabIndex = 12;
            txtDire.Text = "Direccion : ";
            // 
            // txtcuitNegocio
            // 
            txtcuitNegocio.Location = new Point(219, 115);
            txtcuitNegocio.Name = "txtcuitNegocio";
            txtcuitNegocio.Size = new Size(291, 27);
            txtcuitNegocio.TabIndex = 11;
            // 
            // txtNegocio
            // 
            txtNegocio.Location = new Point(221, 53);
            txtNegocio.Name = "txtNegocio";
            txtNegocio.Size = new Size(289, 27);
            txtNegocio.TabIndex = 10;
            // 
            // txtCuit
            // 
            txtCuit.AutoSize = true;
            txtCuit.BackColor = Color.White;
            txtCuit.Location = new Point(219, 92);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(42, 20);
            txtCuit.TabIndex = 9;
            txtCuit.Text = "Cuit :";
            // 
            // txtNombreNegocio
            // 
            txtNombreNegocio.AutoSize = true;
            txtNombreNegocio.BackColor = Color.White;
            txtNombreNegocio.Location = new Point(219, 30);
            txtNombreNegocio.Name = "txtNombreNegocio";
            txtNombreNegocio.Size = new Size(157, 20);
            txtNombreNegocio.TabIndex = 8;
            txtNombreNegocio.Text = "Nombre del Negocio :";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.DeepSkyBlue;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Upload;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(58, 222);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(104, 35);
            iconButton1.TabIndex = 3;
            iconButton1.Text = " Subir";
            iconButton1.TextAlign = ContentAlignment.TopCenter;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 22);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Logo";
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(18, 53);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(177, 152);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "frmNegocio";
            Text = "frmNegocio";
            Load += frmNegocio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private GroupBox groupBox1;
        private PictureBox picLogo;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox txtDireNegocio;
        private Label txtDire;
        private TextBox txtcuitNegocio;
        private TextBox txtNegocio;
        private Label txtCuit;
        private Label txtNombreNegocio;
    }
}