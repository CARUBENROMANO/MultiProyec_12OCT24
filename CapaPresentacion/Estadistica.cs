using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Estadistica : Form
    {
        public Estadistica()
        {
            InitializeComponent();
        }

        private void Estadistica_Load(object sender, EventArgs e)
        {
            Dashboard();
        }
        private void Dashboard()
        {
            N_Dashboard neg = new N_Dashboard();
            E_Dashboard obj = new E_Dashboard();
            neg.Dashboard(obj);
            //RECUPERAMOS DATOS DE LA ENTIDAD PARA CARGAR LOS DATOS DEL DASHBOARD
            chartProdPreferidos.Series[0].Points.DataBindXY(obj.Producto1, obj.Cant1);
            chartProdxCategoria.Series[0].Points.DataBindXY(obj.Categoria1, obj.CantProd1);
            lblCantCateg.Text = obj.CantCategorias1;
            lblCantProd.Text = obj.CantProductos1;
            lblCantProve.Text = obj.CantProveedores1;
            lblTotalVentas.Text = obj.TotalVentas;
        }


    }
}
