namespace CapaPresentacion
{
    partial class Estadistica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadistica));
            label6 = new Label();
            chartProdxCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartProdPreferidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblTotalVentas = new Label();
            label1 = new Label();
            label2 = new Label();
            lblCantProd = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            lblCantCateg = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            lblCantProve = new Label();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)chartProdxCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartProdPreferidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(1237, 675);
            label6.TabIndex = 16;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chartProdxCategoria
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MajorGrid.LineColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartProdxCategoria.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartProdxCategoria.Legends.Add(legend1);
            chartProdxCategoria.Location = new Point(40, 259);
            chartProdxCategoria.Name = "chartProdxCategoria";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            chartProdxCategoria.Series.Add(series1);
            chartProdxCategoria.Size = new Size(565, 369);
            chartProdxCategoria.TabIndex = 17;
            chartProdxCategoria.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Cantidad de Productos por categoria";
            chartProdxCategoria.Titles.Add(title1);
            // 
            // chartProdPreferidos
            // 
            chartArea2.Name = "ChartArea1";
            chartProdPreferidos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartProdPreferidos.Legends.Add(legend2);
            chartProdPreferidos.Location = new Point(652, 248);
            chartProdPreferidos.Name = "chartProdPreferidos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartProdPreferidos.Series.Add(series2);
            chartProdPreferidos.Size = new Size(561, 421);
            chartProdPreferidos.TabIndex = 18;
            chartProdPreferidos.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Productos Mas Vendidos";
            chartProdPreferidos.Titles.Add(title2);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(49, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 108);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.BackColor = SystemColors.Window;
            lblTotalVentas.Location = new Point(188, 121);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(50, 20);
            lblTotalVentas.TabIndex = 21;
            lblTotalVentas.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(159, 80);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 22;
            label1.Text = "TOTAL DE VENTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(448, 82);
            label2.Name = "label2";
            label2.Size = new Size(149, 19);
            label2.TabIndex = 24;
            label2.Text = "CANT DE PRODUCTOS";
            // 
            // lblCantProd
            // 
            lblCantProd.AutoSize = true;
            lblCantProd.BackColor = SystemColors.Window;
            lblCantProd.Location = new Point(466, 121);
            lblCantProd.Name = "lblCantProd";
            lblCantProd.Size = new Size(50, 20);
            lblCantProd.TabIndex = 25;
            lblCantProd.Text = "label1";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(339, 36);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(105, 82);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.Window;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(330, 63);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(275, 108);
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(753, 80);
            label4.Name = "label4";
            label4.Size = new Size(142, 19);
            label4.TabIndex = 30;
            label4.Text = "CANT DE CATEGORIA";
            // 
            // lblCantCateg
            // 
            lblCantCateg.AutoSize = true;
            lblCantCateg.BackColor = SystemColors.Window;
            lblCantCateg.Location = new Point(782, 121);
            lblCantCateg.Name = "lblCantCateg";
            lblCantCateg.Size = new Size(50, 20);
            lblCantCateg.TabIndex = 29;
            lblCantCateg.Text = "label1";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(652, 32);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(95, 82);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.Window;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(643, 63);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(258, 108);
            pictureBox6.TabIndex = 27;
            pictureBox6.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Window;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1071, 82);
            label7.Name = "label7";
            label7.Size = new Size(148, 19);
            label7.TabIndex = 34;
            label7.Text = "CANT DE PROVEEDOR";
            // 
            // lblCantProve
            // 
            lblCantProve.AutoSize = true;
            lblCantProve.BackColor = SystemColors.Window;
            lblCantProve.Location = new Point(1118, 121);
            lblCantProve.Name = "lblCantProve";
            lblCantProve.Size = new Size(50, 20);
            lblCantProve.TabIndex = 33;
            lblCantProve.Text = "label1";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(957, 36);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(108, 82);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 32;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = SystemColors.Window;
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.Location = new Point(947, 63);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(278, 108);
            pictureBox8.TabIndex = 31;
            pictureBox8.TabStop = false;
            // 
            // Estadistica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 693);
            Controls.Add(label7);
            Controls.Add(lblCantProve);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(label4);
            Controls.Add(lblCantCateg);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(label2);
            Controls.Add(lblCantProd);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(lblTotalVentas);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(chartProdPreferidos);
            Controls.Add(chartProdxCategoria);
            Controls.Add(label6);
            Name = "Estadistica";
            Text = "Estadistica";
            Load += Estadistica_Load;
            ((System.ComponentModel.ISupportInitialize)chartProdxCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartProdPreferidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdxCategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdPreferidos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblTotalVentas;
        private Label label1;
        private Label label2;
        private Label lblCantProd;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label4;
        private Label lblCantCateg;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label7;
        private Label lblCantProve;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
    }
}