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
    public partial class mdProveedor : Form

    {
        public Proveedor _Proveedor { get; set; } // aqui decimos que es una propiedad de proveedor
        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn columna in dataProveedor.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;


            // mostrar los proveedore

            List<Proveedor> lista = new CN_Proveedor().Listar();  ///aqui lista los proveedores

            foreach (Proveedor item in lista)
            {
                dataProveedor.Rows.Add(new object[] {
                    item.idProveedor,
                    item.razonSocial,

                    item.documento

                });


            }
        }

        private void dataProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;                // aqui validamos que la celda sea valida
            int iColum = e.ColumnIndex;      // aqui dice el indice de la columna

            if (iRow >= 0 && iColum > 0)  // aqui validadamos que  sea una fila y columna de datagriviud
            {
                _Proveedor = new Proveedor()
                {
                    idProveedor = Convert.ToInt32(dataProveedor.Rows[iRow].Cells["id"].Value.ToString()),
                    razonSocial = dataProveedor.Rows[iRow].Cells["razonSocial"].Value.ToString(),
                    documento = dataProveedor.Rows[iRow].Cells["documento"].Value.ToString()

                };

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string Filtro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dataProveedor.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataProveedor.Rows)
                {
                    if (row.Cells[Filtro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;

                }


            }
        }

        private void iconButton2btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dataProveedor.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
