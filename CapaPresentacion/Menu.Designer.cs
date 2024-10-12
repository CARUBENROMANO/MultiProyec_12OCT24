namespace CapaPresentacion
{
    partial class Menu
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
            menutitulo = new MenuStrip();
            sISTEMADEVENTASToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuusuario = new FontAwesome.Sharp.IconMenuItem();
            menustock = new FontAwesome.Sharp.IconMenuItem();
            submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            submenunegocio = new ToolStripMenuItem();
            menuventas = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            menucompras = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarcompra = new FontAwesome.Sharp.IconMenuItem();
            submenuverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            submenureportescompras = new ToolStripMenuItem();
            submenureportesventas = new ToolStripMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            menuestadistica = new FontAwesome.Sharp.IconMenuItem();
            contenedor = new Panel();
            lbusuario = new Label();
            label2 = new Label();
            menutitulo.SuspendLayout();
            menuStrip1.SuspendLayout();
            contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // menutitulo
            // 
            menutitulo.AutoSize = false;
            menutitulo.BackColor = Color.DodgerBlue;
            menutitulo.ImageScalingSize = new Size(20, 20);
            menutitulo.Items.AddRange(new ToolStripItem[] { sISTEMADEVENTASToolStripMenuItem });
            menutitulo.Location = new Point(0, 0);
            menutitulo.Name = "menutitulo";
            menutitulo.RightToLeft = RightToLeft.No;
            menutitulo.Size = new Size(1249, 68);
            menutitulo.TabIndex = 0;
            menutitulo.Text = "menuStrip1";
            menutitulo.ItemClicked += menutitulo_ItemClicked_1;
            // 
            // sISTEMADEVENTASToolStripMenuItem
            // 
            sISTEMADEVENTASToolStripMenuItem.Name = "sISTEMADEVENTASToolStripMenuItem";
            sISTEMADEVENTASToolStripMenuItem.Size = new Size(162, 64);
            sISTEMADEVENTASToolStripMenuItem.Text = "SISTEMA DE VENTAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 353);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuusuario, menustock, menuventas, menucompras, menuproveedores, menureportes, iconMenuItem1, menuestadistica });
            menuStrip1.Location = new Point(0, 68);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(1249, 68);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuusuario
            // 
            menuusuario.AutoSize = false;
            menuusuario.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            menuusuario.IconColor = Color.Black;
            menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuusuario.ImageScaling = ToolStripItemImageScaling.None;
            menuusuario.Name = "menuusuario";
            menuusuario.Size = new Size(152, 64);
            menuusuario.Text = "Usuarios";
            menuusuario.TextImageRelation = TextImageRelation.TextAboveImage;
            menuusuario.Click += menuusuario_Click;
            // 
            // menustock
            // 
            menustock.AutoSize = false;
            menustock.DropDownItems.AddRange(new ToolStripItem[] { submenucategoria, submenuproducto, submenunegocio });
            menustock.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            menustock.IconColor = Color.Black;
            menustock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menustock.ImageScaling = ToolStripItemImageScaling.None;
            menustock.Name = "menustock";
            menustock.Size = new Size(152, 64);
            menustock.Text = "Stock";
            menustock.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // submenucategoria
            // 
            submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            submenucategoria.IconColor = Color.Black;
            submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenucategoria.Name = "submenucategoria";
            submenucategoria.Size = new Size(157, 26);
            submenucategoria.Text = "Categoria";
            submenucategoria.Click += submenucategoria_Click;
            // 
            // submenuproducto
            // 
            submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuproducto.IconColor = Color.Black;
            submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuproducto.Name = "submenuproducto";
            submenuproducto.Size = new Size(157, 26);
            submenuproducto.Text = "Producto";
            submenuproducto.Click += submenuproducto_Click;
            // 
            // submenunegocio
            // 
            submenunegocio.Name = "submenunegocio";
            submenunegocio.Size = new Size(157, 26);
            submenunegocio.Text = "Logo";
            submenunegocio.Click += submenunegocio_Click;
            // 
            // menuventas
            // 
            menuventas.AutoSize = false;
            menuventas.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrarventa, submenuverdetalleventa });
            menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuventas.IconColor = Color.Black;
            menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuventas.ImageScaling = ToolStripItemImageScaling.None;
            menuventas.Name = "menuventas";
            menuventas.Size = new Size(152, 64);
            menuventas.Text = "Ventas";
            menuventas.TextImageRelation = TextImageRelation.TextAboveImage;
            menuventas.Click += menuventas_Click;
            // 
            // submenuregistrarventa
            // 
            submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuregistrarventa.IconColor = Color.Black;
            submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuregistrarventa.Name = "submenuregistrarventa";
            submenuregistrarventa.Size = new Size(192, 26);
            submenuregistrarventa.Text = "Registrar Venta";
            submenuregistrarventa.Click += submenuregistrarventa_Click;
            // 
            // submenuverdetalleventa
            // 
            submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuverdetalleventa.IconColor = Color.Black;
            submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuverdetalleventa.Name = "submenuverdetalleventa";
            submenuverdetalleventa.Size = new Size(192, 26);
            submenuverdetalleventa.Text = "Ver Detalle";
            submenuverdetalleventa.Click += submenuverdetalleventa_Click;
            // 
            // menucompras
            // 
            menucompras.AutoSize = false;
            menucompras.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrarcompra, submenuverdetallecompra });
            menucompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            menucompras.IconColor = Color.Black;
            menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menucompras.ImageScaling = ToolStripItemImageScaling.None;
            menucompras.Name = "menucompras";
            menucompras.Size = new Size(152, 64);
            menucompras.Text = "Compras";
            menucompras.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // submenuregistrarcompra
            // 
            submenuregistrarcompra.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuregistrarcompra.IconColor = Color.Black;
            submenuregistrarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuregistrarcompra.Name = "submenuregistrarcompra";
            submenuregistrarcompra.Size = new Size(208, 26);
            submenuregistrarcompra.Text = "Registrar Compra";
            submenuregistrarcompra.Click += submenuregistrarcompra_Click;
            // 
            // submenuverdetallecompra
            // 
            submenuverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuverdetallecompra.IconColor = Color.Black;
            submenuverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuverdetallecompra.Name = "submenuverdetallecompra";
            submenuverdetallecompra.Size = new Size(208, 26);
            submenuverdetallecompra.Text = "Ver Detalle";
            submenuverdetallecompra.Click += submenuverdetallecompra_Click;
            // 
            // menuproveedores
            // 
            menuproveedores.AutoSize = false;
            menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            menuproveedores.IconColor = Color.Black;
            menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuproveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuproveedores.Name = "menuproveedores";
            menuproveedores.Size = new Size(152, 64);
            menuproveedores.Text = "Proveedores";
            menuproveedores.TextImageRelation = TextImageRelation.TextAboveImage;
            menuproveedores.Click += menuproveedores_Click;
            // 
            // menureportes
            // 
            menureportes.AutoSize = false;
            menureportes.DropDownItems.AddRange(new ToolStripItem[] { submenureportescompras, submenureportesventas });
            menureportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menureportes.IconColor = Color.Black;
            menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menureportes.ImageScaling = ToolStripItemImageScaling.None;
            menureportes.Name = "menureportes";
            menureportes.Size = new Size(152, 64);
            menureportes.Text = "Reportes";
            menureportes.TextImageRelation = TextImageRelation.TextAboveImage;
            menureportes.Click += menureportes_Click;
            // 
            // submenureportescompras
            // 
            submenureportescompras.Name = "submenureportescompras";
            submenureportescompras.Size = new Size(208, 26);
            submenureportescompras.Text = "Reporte Compras";
            submenureportescompras.Click += submenureportescompras_Click;
            // 
            // submenureportesventas
            // 
            submenureportesventas.Name = "submenureportesventas";
            submenureportesventas.Size = new Size(208, 26);
            submenureportesventas.Text = "Reporte Ventas";
            submenureportesventas.Click += submenureportesventas_Click;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.AutoSize = false;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(152, 64);
            iconMenuItem1.Text = "Acerca de";
            iconMenuItem1.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // menuestadistica
            // 
            menuestadistica.AutoSize = false;
            menuestadistica.IconChar = FontAwesome.Sharp.IconChar.Deezer;
            menuestadistica.IconColor = Color.Black;
            menuestadistica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuestadistica.ImageScaling = ToolStripItemImageScaling.None;
            menuestadistica.Name = "menuestadistica";
            menuestadistica.Size = new Size(152, 64);
            menuestadistica.Text = "Estadistica";
            menuestadistica.TextImageRelation = TextImageRelation.TextAboveImage;
            menuestadistica.Click += menuacerca_Click;
            // 
            // contenedor
            // 
            contenedor.BackColor = SystemColors.ControlLight;
            contenedor.Controls.Add(lbusuario);
            contenedor.Controls.Add(label2);
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 136);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1249, 803);
            contenedor.TabIndex = 3;
            // 
            // lbusuario
            // 
            lbusuario.AutoSize = true;
            lbusuario.BackColor = SystemColors.Control;
            lbusuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbusuario.ForeColor = SystemColors.ActiveCaptionText;
            lbusuario.Location = new Point(121, 748);
            lbusuario.Name = "lbusuario";
            lbusuario.Size = new Size(91, 25);
            lbusuario.TabIndex = 1;
            lbusuario.Text = "Usuario : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(24, 748);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 0;
            label2.Text = "Usuario : ";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 939);
            Controls.Add(contenedor);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(menutitulo);
            MainMenuStrip = menutitulo;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            menutitulo.ResumeLayout(false);
            menutitulo.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contenedor.ResumeLayout(false);
            contenedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menutitulo;
        private Label label1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuestadistica;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private Panel contenedor;
        private ToolStripMenuItem sISTEMADEVENTASToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menustock;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarcompra;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallecompra;
        private Label label2;
        private Label lbusuario;
        private ToolStripMenuItem submenunegocio;
        private ToolStripMenuItem submenureportescompras;
        private ToolStripMenuItem submenureportesventas;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}