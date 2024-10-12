using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Recursos;
using ClosedXML.Excel;

namespace CapaPresentacion
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });  // true
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });  // false
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            List<Categoria> listacategoria = new CN_Categoria().Listar();  // aqui lista todas las categorias que habiamos creado

            foreach (Categoria item in listacategoria)
            {
                cbocategoria.Items.Add(new OpcionCombo() { Valor = item.idCategoria, Texto = item.nombreCategoria });
            }
            cbocategoria.DisplayMember = "Texto";
            cbocategoria.ValueMember = "Valor";
            cbocategoria.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dataProducto.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
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
                dataProducto.Rows.Add(new object[] {"",
                    item.idProducto,
                    item.codigo,
                    item.nombreProducto,
                    item.marca,
                    item.oCategoria.idCategoria,
                    item.oCategoria.nombreCategoria,
                    item.stock,
                    item.precioCompra,
                    item.precioventa,
                    item.estadoProducto == true ? 1 : 0,
                    item.estadoProducto == true ? "Activo" : "No Activo"
                });

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Producto obj = new Producto()
            {
                idProducto = Convert.ToInt32(txtid.Text),
                codigo = txtcodigo.Text,
                nombreProducto = txtnombre.Text,
                marca = txtmarca.Text,
                oCategoria = new Categoria() { idCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor) },
                estadoProducto = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false,

            };

            if (obj.idProducto == 0)  // si es igual a 0 lo que hace es registrar
            {
                int idgenerado = new CN_Producto().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {

                    dataProducto.Rows.Add(new object[] {"",
                    idgenerado,
                    txtcodigo.Text,
                    txtnombre.Text,
                    txtmarca.Text,
                    ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbocategoria.SelectedItem).Texto.ToString(),
                    "0",   // stock
                    "0,00", // precio de compra
                    "0,00",  // precio de venta
                    ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cboestado.SelectedItem).Texto.ToString(),
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
                bool resultado = new CN_Producto().editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dataProducto.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["Codigo"].Value = txtcodigo.Text;
                    row.Cells["Nombre"].Value = txtnombre.Text;
                    row.Cells["Marca"].Value = txtmarca.Text;
                    row.Cells["idCategoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();


                    Limpiar();

                }
                else { MessageBox.Show(mensaje); }

            }
        }


        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtmarca.Text = "";
            cbocategoria.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;

            txtcodigo.Select();
        }

        private void dataProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataProducto.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)   // el indice de la columna seleccionada es valida 
                {

                    txtindice.Text = indice.ToString();
                    txtid.Text = dataProducto.Rows[indice].Cells["id"].Value.ToString();

                    txtcodigo.Text = dataProducto.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtnombre.Text = dataProducto.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtmarca.Text = dataProducto.Rows[indice].Cells["Marca"].Value.ToString();


                    //foreach (OpcionCombo oc in cbocategoria.Items)    ///  pintamos lo valores
                    //{
                    //    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataProducto.Rows[indice].Cells["idCategoria"].Value))
                    //    {
                    //        int indice_combo = cbocategoria.Items.IndexOf(oc);
                    //        cbocategoria.SelectedIndex = indice_combo;
                    //        break;
                    //    }

                    //}

                    //foreach (OpcionCombo oc in cboestado.Items)    ///  pintamos lo valores
                    //{
                    //    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataProducto.Rows[indice].Cells["EstadoValor"].Value))
                    //    {
                    //        int indice_combo = cboestado.Items.IndexOf(oc);
                    //        cboestado.SelectedIndex = indice_combo;
                    //        break;
                    //    }

                    //}


                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)   /// eliminar
        {

            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea Eliminar el Producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        idProducto = Convert.ToInt32(txtid.Text)
                    };

                    bool repuesta = new CN_Producto().Eliminar(obj, out mensaje);

                    if (repuesta)
                    {
                        dataProducto.Rows.RemoveAt(Convert.ToInt32(txtindice.Text)); // si elimino correctamente procede  a eliminar de mi DataGridview
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

        private void iconButton2btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dataProducto.Rows)
            {
                row.Visible = true;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dataProducto.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columns in dataProducto.Columns)  /// aqui hacemos referencia a la cabezera 
                {
                    if (columns.HeaderText != "" && columns.Visible)   /// que NOO SEA VACIO y que QUE ES LA COLUMNA VISIBLE
                        dt.Columns.Add(columns.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dataProducto.Rows)
                {
                    if (row.Visible)  /// si la fila es visible
                    //{
                        dt.Rows.Add(new object[]     // agregar fila a mi table  tiene que se lo mismo de mi griview
                        {
                           row.Cells[2].Value.ToString(),
                           row.Cells[3].Value.ToString(),
                           row.Cells[4].Value.ToString(),
                           row.Cells[5].Value.ToString(),
                           row.Cells[6].Value.ToString(),
                           row.Cells[7].Value.ToString(),
                           row.Cells[8].Value.ToString(),
                           row.Cells[9].Value.ToString(),
                           row.Cells[11].Value.ToString(),

                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();  // aqui vamos a guardar el archivo
                savefile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel files | *xlsx";  // filtra a la hora de guardar visualizan los xls guardados de esa extension

                if (savefile.ShowDialog() == DialogResult.OK)  /// aceptamos la ruta                  
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();  /// agrego mi libreria de nut 
                        var hoja = wb.Worksheets.Add(dt, "Informe");      /// agrego una hoja
                        hoja.ColumnsUsed().AdjustToContents();     /// que se ajuste al contenido segun posea
                        wb.SaveAs(savefile.FileName);        /// que proceda a guaradar con la ruta defenida
                                                             /// si esta todo ok nos brinde un mensaje
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch
                    {
                        MessageBox.Show("Error al generar el Reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }



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


