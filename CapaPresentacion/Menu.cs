using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.Windows.Controls;

namespace CapaPresentacion
{
    public partial class Menu : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Menu(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menutitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void AbrirFormulario(IconMenuItem menu, Form formulario)  // este metodo recibe el munu que se ha cliqueado
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;  // el menu que no esta marcado que quede con su color original
            }

            menu.BackColor = Color.SteelBlue;  // menu que se va a mostrar que sea de color diferente
            MenuActivo = menu;  // el que chequemos va a ser mostrado

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();   // esto es cerrar y poder abrir otro formulario
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;  // estos 4 le damos estilo
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.DodgerBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();  // aqui lo mostramos


        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());  // decimos que selecionamos el menu y que lo muestre
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menustock, new frmCategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menustock, new frmProducto());
        }

        private void menuventas_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermisos = new CN_Permiso().Listar(usuarioActual.idUsuario);

            foreach (IconMenuItem iconMenu in menuStrip1.Items)
            {
                bool busqueda = listaPermisos.Any(m => m.nombreMenu == iconMenu.Name);  // m es cada elemento de mi menu 

                if (busqueda == false)
                {
                    iconMenu.Visible = false;  // si no lo encuentra lo oculta
                }

            }



            lbusuario.Text = usuarioActual.nombreUsuario;
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVenta(usuarioActual));
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new fmrDetalleVenta());
        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras(usuarioActual));
        }

        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new fmrDetalleCompra());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((IconMenuItem)sender, new fmrReportesCompras());  //aqui debo hacer cambio
        }

        private void menutitulo_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void submenunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menustock, new frmNegocio());
        }

        private void submenureportescompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new fmrReportesCompras());
        }

        private void submenureportesventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new fmrReportesVentas());
        }

        private void menuacerca_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuestadistica, new Estadistica());
        }
    }
}
