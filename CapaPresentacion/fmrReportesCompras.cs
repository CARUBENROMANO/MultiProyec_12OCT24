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
    public partial class fmrReportesCompras : Form
    {
        public fmrReportesCompras()
        {
            InitializeComponent();
        }

        private void fmrReportesCompras_Load(object sender, EventArgs e)
        {
            List<Proveedor> lista = new CN_Proveedor().Listar();
            cboproveedor.Items.Add(new OpcionCombo() { Valor = 0, Texto = "TODOS" });
            foreach (Proveedor item in lista)
            {
                cboproveedor.Items.Add(new OpcionCombo() { Valor = item.idProveedor, Texto = item.razonSocial });
            }
            cboproveedor.DisplayMember = "Texto";
            cboproveedor.ValueMember = "Valor";
            cboproveedor.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;


        }

        private void btnbuscarroveedor_Click(object sender, EventArgs e)   ///buscar todos
        {
            int idproveedor = Convert.ToInt32(((OpcionCombo)cboproveedor.SelectedItem).Valor.ToString());  /// selecciona el proveedor del desplegable  

            List<ReporteCompras> lista = new List<ReporteCompras>();

            lista = new CN_Reporte().Compra(
                txtfechainicio.Value.ToString(),
                txtfechafin.Value.ToString(),
                idproveedor
                );

            dgvdata.Rows.Clear();


            foreach (ReporteCompras rc in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    rc.fechaRegistro,
                    rc.tipoDocumento,
                    rc.numeroDocumento,
                    rc.montoTotal,
                    rc.usuarioRegistro,
                    rc.documentoProveedor,
                    rc.razonSocial,
                    rc.codigoProducto,
                    rc.nombreProducto,
                    rc.categoria,
                    rc.precioCompra,
                    rc.precioVenta,
                    rc.cantidad,
                    rc.subtotal

                });




            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columns in dgvdata.Columns)  /// aqui hacemos referencia a la cabezera 
                {

                    dt.Columns.Add(columns.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible)  /// si la fila es visible

                        dt.Rows.Add(new object[]     // agregar fila a mi table  tiene que se lo mismo de mi griview
                        {
                           row.Cells[0].Value.ToString(),
                           row.Cells[1].Value.ToString(),
                           row.Cells[2].Value.ToString(),
                           row.Cells[3].Value.ToString(),
                           row.Cells[4].Value.ToString(),
                           row.Cells[5].Value.ToString(),
                           row.Cells[6].Value.ToString(),
                           row.Cells[7].Value.ToString(),
                           row.Cells[8].Value.ToString(),
                           row.Cells[9].Value.ToString(),
                           row.Cells[10].Value.ToString(),
                           row.Cells[11].Value.ToString(),
                           row.Cells[12].Value.ToString(),
                           row.Cells[13].Value.ToString(),

                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();  // aqui vamos a guardar el archivo
                savefile.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMMyyyy_hhmmtt"));
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
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
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
