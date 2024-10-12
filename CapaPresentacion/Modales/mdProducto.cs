using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdProducto : Form
    {
        public Producto _Producto { get; set; } // aqui decimos que es una propiedad de producto
        public mdProducto()
        {
            InitializeComponent();
        }

        private void mdProducto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dataProducto.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;


            // mostrar los productos

            List<Producto> listaProducto = new CN_Producto().Listar();  ///aqui lista los productos

            foreach (Producto item in listaProducto)
            {
                dataProducto.Rows.Add(new object[] {
                    item.idProducto,
                    item.codigo,
                    item.nombreProducto,
                    item.marca,
                    item.oCategoria.nombreCategoria,
                    item.stock,
                    item.precioCompra,
                    item.precioventa
                });

            }
        }

        private void dataProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;                // aqui validamos que la celda sea valida
            int iColum = e.ColumnIndex;      // aqui dice el indice de la columna

            if (iRow >= 0 && iColum > 0)  // aqui validadamos que  sea una fila y columna de datagriviud
            {
                _Producto = new Producto()
                {
                    idProducto = Convert.ToInt32(dataProducto.Rows[iRow].Cells["id"].Value.ToString()),
                    codigo = dataProducto.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    nombreProducto = dataProducto.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    marca = dataProducto.Rows[iRow].Cells["Marca"].Value.ToString(),
                    stock = Convert.ToInt32(dataProducto.Rows[iRow].Cells["Stock"].Value.ToString()),
                    precioCompra = Convert.ToDecimal(dataProducto.Rows[iRow].Cells["PrecioCompra"].Value.ToString()),
                    precioventa = Convert.ToDecimal(dataProducto.Rows[iRow].Cells["PrecioVenta"].Value.ToString()),

                };

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dataProducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataProducto.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;

                }


            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dataProducto.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
