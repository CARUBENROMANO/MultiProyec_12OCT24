namespace CapaPresentacion
{
    partial class Login
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
            btningresar = new Button();
            btncancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtusuario = new TextBox();
            txtclave = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.RoyalBlue;
            btningresar.Cursor = Cursors.Hand;
            btningresar.Location = new Point(144, 374);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(115, 40);
            btningresar.TabIndex = 0;
            btningresar.Text = "INGRESAR";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Red;
            btncancelar.Cursor = Cursors.Hand;
            btncancelar.Location = new Point(319, 374);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(115, 40);
            btncancelar.TabIndex = 1;
            btncancelar.Text = "CERRAR";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 164);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 2;
            label1.Text = "ACCESO AL SISTEMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 299);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 235);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 4;
            label3.Text = "USUARIO";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(257, 228);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(154, 27);
            txtusuario.TabIndex = 5;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(257, 292);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(154, 27);
            txtclave.TabIndex = 6;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.ActiveCaption;
            iconPictureBox1.ForeColor = SystemColors.ActiveCaptionText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            iconPictureBox1.IconColor = SystemColors.ActiveCaptionText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 125;
            iconPictureBox1.Location = new Point(277, 26);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(125, 135);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(581, 450);
            Controls.Add(iconPictureBox1);
            Controls.Add(txtclave);
            Controls.Add(txtusuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btncancelar);
            Controls.Add(btningresar);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btningresar;
        private Button btncancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtusuario;
        private TextBox txtclave;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}