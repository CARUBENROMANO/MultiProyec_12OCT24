using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
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

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;
        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {


            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });  // true
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });  // false
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            textfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproveedor.Text = "0";
            txtidproducto.Text = "0";


        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();  // aqui le digo que se muestre mi modal

                if (result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal._Proveedor.idProveedor.ToString();
                    txtnombreproveedor.Text = modal._Proveedor.razonSocial;
                    txtdocproveedor.Text = modal._Proveedor.documento;

                }
                else
                {
                    txtdocproveedor.Select();
                }
            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();  // aqui le digo que se muestre mi modal

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.idProducto.ToString();  // el 1ro es mi texbox de mi modal y el 2do es mi entidad
                    txtcodproducto.Text = modal._Producto.codigo;
                    txtproducto.Text = modal._Producto.nombreProducto;
                    txtpreciocompra.Select();


                }
                else
                {
                    txtcodproducto.Select();
                }
            }
        }

        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.codigo == txtcodproducto.Text).FirstOrDefault();

                if (oProducto != null)
                {
                    txtcodproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.idProducto.ToString();
                    txtproducto.Text = oProducto.nombreProducto;
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    MessageBox.Show("EL CODIGO INGRESADO NO SE ENCUENTRA ASOCIADO A NINGUN PRODUCTO", "Mensaje", MessageBoxButtons.OK);

                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;  // para no repetir el producto


            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe selecionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorreto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Select();
                return;

            }


            if (!decimal.TryParse(txtprecioventa.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorreto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;

            }

            if (!producto_existe)  // si existe mi producto
            {
                dgvdata.Rows.Add(new object[] {

                    txtidproducto.Text,
                    txtproducto.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    txtcantidad.Value.ToString(),
                    (txtcantidad.Value * preciocompra).ToString("0.00")

                });
                calcularTotal();
                limpiarProducto();
                txtcodproducto.Select();
            }

        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "";
            txtcodproducto.Text = "";
            txtcodproducto.BackColor = Color.White;
            txtproducto.Text = "";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            txtcantidad.Text = "1";

        }


        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)  // conteo de todas mis filas
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["subtotal"].Value.ToString());  //recorre la columna del subtotal
                }
                txttotal.Text = total.ToString("0.00");  // ya que es decimal lo convertimos en string para ser f¿reflejado en el texbox

            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) // si el indice es menor a 0 no pinte nada
                return;

            if (e.ColumnIndex == 6) // de tal indice en este caso nro 6 empieza a pintar el boton
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.tachito3.Width;
                var h = Properties.Resources.tachito3.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;


                e.Graphics.DrawImage(Properties.Resources.tachito3, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex; //que fila voy a eliminar por medio del indice

                if (indice >= 0) //que se un indice valido o sea apartir de 0 (recordar que los vectores empiezan con 0)
                {
                    dgvdata.Rows.RemoveAt(indice); //elimino
                    calcularTotal(); //calculo los restante

                }

                if (dgvdata.Rows.Count == 0 || dgvdata.Columns.Count == 0)
                {
                    txttotal.Text = "0.00";

                }


            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))          //e.keychar es la tecla que estoy apretando
            {
                e.Handled = false;           /// hago que mi contralor no se active

            }

            else  /// que pasa si apreta otra tecla que no corresponder
            {
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")    // si no esta apretando nada y tambien hay un punto
                {
                    e.Handled = true;  // si es asi mi contralador se active

                }

                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")  // si esta borrando o escribiendo un punto
                    {
                        e.Handled = false;  //

                    }
                    else { e.Handled = true; }
                }
            }
        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))          //e.keychar es la tecla que estoy apretando
            {
                e.Handled = false;           /// hago que mi contralor no se active

            }

            else  /// que pasa si apreta otra tecla que no corresponder
            {
                if (txtprecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")    // si no esta apretando nada y tambien hay un punto
                {
                    e.Handled = true;  // si es asi mi contralador se active

                }

                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")  // si esta borrando o escribiendo un punto
                    {
                        e.Handled = false;  //

                    }
                    else { e.Handled = true; }
                }
            }
        }



        private void btnregistrar_Click_1(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtidproveedor.Text) == 0)   /// aqui hago validaciones
            {
                MessageBox.Show("Debe seleccionar un Proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)   /// aqui hago validaciones
            {
                MessageBox.Show("Debe Ingresar Un Producto en la Compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_Compra = new DataTable();     /// aqui hago el emcabezado de mis columana

            detalle_Compra.Columns.Add("idProducto", typeof(int));
            detalle_Compra.Columns.Add("precioCompra", typeof(decimal));
            detalle_Compra.Columns.Add("precioVenta", typeof(decimal));
            detalle_Compra.Columns.Add("cantidad", typeof(int));
            detalle_Compra.Columns.Add("montoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvdata.Rows)   /// aqui se rellena las columnas con los datos
            {
                detalle_Compra.Rows.Add(
                    new object[] {
                    Convert.ToUInt32(row.Cells["idProducto"].Value.ToString()),
                    row.Cells["precioCompra"].Value.ToString(),
                    row.Cells["precioVenta"].Value.ToString(),
                    row.Cells["cantidad"].Value.ToString(),
                    row.Cells["subtotal"].Value.ToString()
                    });
            }

            int idcorrelativo = new CN_Compra().obtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000}", idcorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { idUsuario = _Usuario.idUsuario },
                oProveedor = new Proveedor() { idProveedor = Convert.ToInt32(txtidproveedor.Text) },
                tipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                numeroDocumento = numerodocumento,
                montoTotal = Convert.ToDecimal(txttotal.Text),
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_Compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de Compra Generada: \n" + numerodocumento + "\n\n ¿Desea copiar al portapapeles?",
                    "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numerodocumento);

                    txtidproveedor.Text = "";
                    txtdocproveedor.Text = "";
                    txtnombreproveedor.Text = "";
                    dgvdata.Rows.Clear();
                    calcularTotal();
                }

                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
    }
}
