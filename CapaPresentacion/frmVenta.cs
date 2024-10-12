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
    public partial class frmVenta : Form
    {
        private Usuario _Usuario;
        public frmVenta(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });  // true
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });  // false
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";

            txtpagocon.Text = "";
            txtcambio.Text = "";
            txttoltalpagar.Text = "0";
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
                    txtprecioventa.Text = modal._Producto.precioventa.ToString("0.00");
                    txtstock.Text = modal._Producto.stock.ToString();

                    txtcantidad.Select();


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
                    txtprecioventa.Text = oProducto.precioventa.ToString("0.00");
                    txtstock.Text = oProducto.stock.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtcodproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtprecioventa.Text = "";
                    txtstock.Text = "";
                    txtcantidad.Value = 1;
                    MessageBox.Show("EL CODIGO INGRESADO NO SE ENCUENTRA ASOCIADO A NINGUN PRODUCTO", "Mensaje", MessageBoxButtons.OK);
                }
            }
        }

        private void btnregistra_Click(object sender, EventArgs e)  // para agregar Producto
        {
            decimal precioventa = 0;

            bool producto_existe = false;  // para no repetir el producto


            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe selecionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorreto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;

            }


            if (Convert.ToUInt32(txtstock.Text) < Convert.ToUInt32(txtcantidad.Value.ToString()))
            {
                MessageBox.Show("La Cantidad NO pueder ser mayor al Stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;

            }


            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["idProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }



            if (!producto_existe)  // si existe mi producto
            {

                bool respuesta = new CN_Venta().restarStock(
                    Convert.ToInt32(txtidproducto.Text),
                    Convert.ToInt32(txtcantidad.Value.ToString())
                    );

                if (respuesta)
                {


                    dgvdata.Rows.Add(new object[] {

                    txtidproducto.Text,
                    txtproducto.Text,
                    precioventa.ToString("0.00"),
                    txtcantidad.Value.ToString(),
                    (txtcantidad.Value * precioventa).ToString("0.00")

                });
                    calcularTotal();
                    limpiarProducto();
                    txtcodproducto.Select();
                }
            }
        }


        private void calcularcambio()  ///solo se va a usar cuando se de enter 
        {
            if (txttoltalpagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen Productos en la Venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txttoltalpagar.Text);

            if (txtpagocon.Text.Trim() == "")
            {
                txtpagocon.Text = "0";
            }

            if (decimal.TryParse(txtpagocon.Text.Trim(), out pagacon))    ///el tryparse nos dice que texto lo vamos a cambiar a decimal
            {
                if (pagacon < total)   //// si es menor al total que no realice nada
                {
                    txtcambio.Text = "0.00";
                    MessageBox.Show("MONTO INGRESADO DEBE SER MAYOR AL MONTO A PAGAR", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00");

                }



            }

        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtproducto.Text = "";
            txtprecioventa.Text = "";
            txtstock.Text = "";
            txtcantidad.Value = 1;

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
                txttoltalpagar.Text = total.ToString("0.00");  // ya que es decimal lo convertimos en string para ser f¿reflejado en el texbox

            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) // si el indice es menor a 0 no pinte nada
                return;

            if (e.ColumnIndex == 5) // de tal indice en este caso nro 6 empieza a pintar el boton
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
                    bool respuesta = new CN_Venta().sumarStock(
                    Convert.ToInt32(dgvdata.Rows[indice].Cells["idproducto"].Value.ToString()),
                    Convert.ToInt32(dgvdata.Rows[indice].Cells["cantidad"].Value.ToString()));


                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(indice); //elimino
                        calcularTotal(); //calculo los restante
                    }



                    ////aqui agregue

                    if (dgvdata.Rows.Count == 0 || dgvdata.Columns.Count == 0)
                    {
                        txtcambio.Text = "0.00";
                        txttoltalpagar.Text = "0.00";
                        txtpagocon.Text = "0.00";
                    }



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

        private void txtpagocon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))          //e.keychar es la tecla que estoy apretando
            {
                e.Handled = false;           /// hago que mi contralor no se active

            }

            else  /// que pasa si apreta otra tecla que no corresponder
            {
                if (txtpagocon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")    // si no esta apretando nada y tambien hay un punto
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

        private void txtpagocon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)    // si precio enter entonces que actue / utilice el metodo calcular cambio
            {
                calcularcambio();

            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe Ingresar Un Producto en la Venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_Venta = new DataTable();

            detalle_Venta.Columns.Add("idProducto", typeof(int));
            detalle_Venta.Columns.Add("precioVenta", typeof(decimal));
            detalle_Venta.Columns.Add("cantidad", typeof(int));
            detalle_Venta.Columns.Add("subTotal", typeof(decimal));


            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_Venta.Rows.Add(
                    new object[] {
                    row.Cells["idProducto"].Value.ToString(),

                    row.Cells["precio"].Value.ToString(),
                    row.Cells["cantidad"].Value.ToString(),
                    row.Cells["subtotal"].Value.ToString()
                    });
            }

            int idcorrelativo = new CN_Venta().obtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000}", idcorrelativo);
            calcularcambio();

            Venta oVenta = new Venta()
            {
                oUsuario = new Usuario() { idUsuario = _Usuario.idUsuario },

                tipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                numeroDocumento = numerodocumento,
                montoPago = Convert.ToDecimal(txtpagocon.Text),
                montoCambio = Convert.ToDecimal(txtcambio.Text),
                montoTotal = Convert.ToDecimal(txttoltalpagar.Text),
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_Venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de Venta Generada: \n" + numerodocumento + "\n\n ¿Desea copiar al portapapeles?",
                    "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numerodocumento);

                    dgvdata.Rows.Clear();
                    calcularTotal();
                    txtpagocon.Text = "";
                    txtcambio.Text = "";
                }

                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
