using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
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
    public partial class fmrDetalleVenta : Form
    {
        public fmrDetalleVenta()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().obtenerVenta(txtbusquedadocumento.Text);

            if (oVenta.idVenta != 0)
            {

                txtnumerodocumento.Text = oVenta.numeroDocumento;
                txtfecha.Text = oVenta.fechaRegistro;
                txttipodocumento.Text = oVenta.tipoDocumento;
                txtusuario.Text = oVenta.oUsuario.nombreUsuario;

                dgvdata.Rows.Clear();  // limpiamos todas los datos que tenemos en nuestra grilla

                foreach (DetalleVenta dv in oVenta.oDetalleVenta)
                {
                    dgvdata.Rows.Add(new object[] { dv.oProducto.nombreProducto, dv.precioVenta, dv.cantidad, dv.subTotal });
                }
                txtpagocon.Text = oVenta.montoPago.ToString("0.00");
                txtcambio.Text = oVenta.montoCambio.ToString("0.00");
                txttoltalpagar.Text = oVenta.montoTotal.ToString("0.00");

            }

            else
            {
                MessageBox.Show("NO SE REGISTRA VENTAS CON EL NUMERO INGRESADO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtbusquedadocumento.Text = "";

            dgvdata.Rows.Clear();
            txtpagocon.Text = "0.00";
            txtcambio.Text = "0.00";
            txttoltalpagar.Text = "0.00";
        }

        private void fmrDetalleVenta_Load(object sender, EventArgs e)
        {
            txtbusquedadocumento.Select();
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (txttipodocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_html = Properties.Resources.PlantillaVenta.ToString(); //esa plantilla lo paso a texto y lo pasamos a la variable texto:html
            Negocio odatos = new CN_Negocio().obtenerDatos();  //AQUI TRAEMOS LA INFORMACION

            Texto_html = Texto_html.Replace("@nombrenegocio", odatos.nombreNegocio.ToUpper());  ///remplaza un texto por otro el @ va ser el texto que esta ahora en el html
            Texto_html = Texto_html.Replace("@docnegocio", odatos.cuit);    ///es decir el 1ro es el texto antiguo y el 2do el texto nuevo
            Texto_html = Texto_html.Replace("@direcnegocio", odatos.Direccion);


            Texto_html = Texto_html.Replace("@tipodocumento", txttipodocumento.Text.ToUpper());  //reemplazamos por los datos de nuestras cajas de texto
            Texto_html = Texto_html.Replace("@numerodocumento", txtnumerodocumento.Text);

            //Texto_html = Texto_html.Replace("@docproveedor", txtcontactoprov.Text);
            //Texto_html = Texto_html.Replace("@nombreproveedor", txtrazonsocial.Text);
            Texto_html = Texto_html.Replace("@fecharegistro", txtfecha.Text);
            Texto_html = Texto_html.Replace("@usuarioregistro", txtusuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["producto"].Value.ToString() + "</td>";    ///aqui van los nombre de mi griwiu de mi dettal de compra
                filas += "<td>" + row.Cells["precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            Texto_html = Texto_html.Replace("@filas", filas);
            Texto_html = Texto_html.Replace("@montototal", txttoltalpagar.Text);    ///hasta aqui cambiammos todos los datos de mi html
            Texto_html = Texto_html.Replace("@pagocon", txtpagocon.Text);
            Texto_html = Texto_html.Replace("@cambio", txtcambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", txtnumerodocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)      //aqui validamos la ruta donde queremos guardar
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);     //// AGREGAR A MI USSING   Document

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);  //// AGREGAR A MI USSING   PdfWriter
                    pdfDoc.Open();  ///AQUI ABRIMOS NUESTRO PDF

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().obtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);  ///AQUI CRE la imagen y la guarda en un array
                        img.ScaleToFit(60, 60);    ///aqui definimos la escala y las dimensiones 
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;    /// aqui pongo que lo guarde sobre el texto 
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));   //le decimos en que posicion o sea a la izquierda en este caso
                        pdfDoc.Add(img);

                    }

                    using (StringReader sr = new StringReader(Texto_html))   //aqui pegamos todos los cambios a nuestro html
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);  // que tenga la capacidad de leer este html
                    }

                    pdfDoc.Close();
                    stream.Close();  // nuestro archivo de memeoria cierre
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }
    }
}
