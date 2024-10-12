using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using iTextSharp.text;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Document = iTextSharp.text.Document;

namespace CapaPresentacion
{
    public partial class fmrDetalleCompra : Form
    {
        public fmrDetalleCompra()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().obtenerCompra(txtbusqueda.Text);

            if (oCompra.idCompra != 0)
            {

                txtnumerodocumento.Text = oCompra.numeroDocumento;
                txtfecha.Text = oCompra.fechaRegistro;
                txttipodocumento.Text = oCompra.tipoDocumento;
                txtusuario.Text = oCompra.oUsuario.nombreUsuario;
                txtdocproveedor.Text = oCompra.oProveedor.documento;
                txtnombreproveedor.Text = oCompra.oProveedor.razonSocial;

                dgvdata.Rows.Clear();  // limpiamos todas los datos que tenemos en nuestra grilla

                foreach (DetalleCompra dc in oCompra.oDetalleCompra)
                {
                    dgvdata.Rows.Add(new object[] { dc.oProducto.nombreProducto, dc.precioCostoProducto, dc.cantDetCompra, dc.montoTotal });
                }

                txttotal.Text = oCompra.montoTotal.ToString("0.00");

            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";

            dgvdata.Rows.Clear();
            txttotal.Text = "0.00";
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (txttipodocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_html = Properties.Resources.PlantillaCompra.ToString(); //esa plantilla lo paso a texto y lo pasamos a la variable texto:html
            Negocio odatos = new CN_Negocio().obtenerDatos();  //AQUI TRAEMOS LA INFORMACION

            Texto_html = Texto_html.Replace("@nombrenegocio", odatos.nombreNegocio.ToUpper());  ///remplaza un texto por otro el @ va ser el texto que esta ahora en el html
            Texto_html = Texto_html.Replace("@docnegocio", odatos.cuit);    ///es decir el 1ro es el texto antiguo y el 2do el texto nuevo
            Texto_html = Texto_html.Replace("@direcnegocio", odatos.Direccion);


            Texto_html = Texto_html.Replace("@tipodocumento", txttipodocumento.Text.ToUpper());  //reemplazamos por los datos de nuestras cajas de texto
            Texto_html = Texto_html.Replace("@numerodocumento", txtnumerodocumento.Text);

            Texto_html = Texto_html.Replace("@docproveedor", txtdocproveedor.Text);
            Texto_html = Texto_html.Replace("@nombreproveedor", txtnombreproveedor.Text);
            Texto_html = Texto_html.Replace("@fecharegistro", txtfecha.Text);
            Texto_html = Texto_html.Replace("@usuarioregistro", txtusuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["producto"].Value.ToString() + "</td>";    ///aqui van los nombre de mi griwiu de mi dettal de compra
                filas += "<td>" + row.Cells["precioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            Texto_html = Texto_html.Replace("@filas", filas);
            Texto_html = Texto_html.Replace("@montototal", txttotal.Text);    ///hasta aqui cambiammos todos los datos de mi html


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", txtnumerodocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)      //aqui validamos la ruta donde queremos guardar
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);     //// AGREGAR A MI USSING   Document


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
