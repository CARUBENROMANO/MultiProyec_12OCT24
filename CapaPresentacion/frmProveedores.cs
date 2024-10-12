using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Recursos;
using ClosedXML.Excel;
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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn columna in dataProveedor.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
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
                dataProveedor.Rows.Add(new object[] {"",
                    item.idProveedor,
                    item.razonSocial,
                    item.correo,
                    item.telefono,
                    item.documento

                });

            }



        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Proveedor obj = new Proveedor()
            {
                idProveedor = Convert.ToInt32(txtid.Text),
                razonSocial = txtrazonsocial.Text,
                correo = txtcorreo.Text,
                telefono = txttelefono.Text,
                documento = txtdocumento.Text,


            };

            if (obj.idProveedor == 0)  // si es igual a 0 lo que hace es registrar
            {
                int idgenerado = new CN_Proveedor().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {

                    dataProveedor.Rows.Add(new object[] {"",
                    idgenerado,
                    txtrazonsocial.Text,
                    txtcorreo.Text,
                    txttelefono.Text,
                    txtdocumento.Text,

                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

            else
            {
                bool resultado = new CN_Proveedor().editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dataProveedor.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["razonSocial"].Value = txtrazonsocial.Text;
                    row.Cells["correo"].Value = txtcorreo.Text;
                    row.Cells["telefono"].Value = txttelefono.Text;
                    row.Cells["documento"].Value = txtdocumento.Text;


                    Limpiar();

                }
                else { MessageBox.Show(mensaje); }

            }
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtrazonsocial.Text = "";
            txtcorreo.Text = "";
            txttelefono.Text = "";
            txtdocumento.Text = "";

            txtrazonsocial.Select();
        }

        private void dataProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataProveedor.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)   // el indice de la columna seleccionada es valida 
                {

                    txtindice.Text = indice.ToString();
                    txtid.Text = dataProveedor.Rows[indice].Cells["id"].Value.ToString();

                    txtrazonsocial.Text = dataProveedor.Rows[indice].Cells["razonSocial"].Value.ToString();
                    txtcorreo.Text = dataProveedor.Rows[indice].Cells["correo"].Value.ToString();
                    txttelefono.Text = dataProveedor.Rows[indice].Cells["telefono"].Value.ToString();
                    txtdocumento.Text = dataProveedor.Rows[indice].Cells["documento"].Value.ToString();




                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e) // eliminar
        {

            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea Eliminar el Proveedor", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Proveedor obj = new Proveedor()
                    {
                        idProveedor = Convert.ToInt32(txtid.Text)
                    };

                    bool repuesta = new CN_Proveedor().Eliminar(obj, out mensaje);

                    if (repuesta)
                    {
                        dataProveedor.Rows.RemoveAt(Convert.ToInt32(txtindice.Text)); // si elimino correctamente procede  a eliminar de mi DataGridview
                        Limpiar();  // una vez que se elimine se limpian las caja de texto
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  // y sino que nos aparezca un mensaje
                    }


                }

            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dataProveedor.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataProveedor.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
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

        private void btn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
