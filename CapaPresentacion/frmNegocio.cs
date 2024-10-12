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
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace CapaPresentacion
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }


        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();  /// nos permite guardar la imagen en memeria
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }



        private void frmNegocio_Load(object sender, EventArgs e)
        {

            bool obtenido = true;
            byte[] byteimage = new CN_Negocio().obtenerLogo(out obtenido);

            if (obtenido)
            {
                picLogo.Image = ByteToImage(byteimage);

                Negocio datos = new CN_Negocio().obtenerDatos();

                txtNegocio.Text = datos.nombreNegocio;
                txtcuitNegocio.Text = datos.cuit;
                txtDireNegocio.Text = datos.Direccion;
            }


        }

        private void iconButton1_Click(object sender, EventArgs e) // subir imagen
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "File|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CN_Negocio().actualizarLogo(byteimage, out mensaje);


                if (respuesta)

                    picLogo.Image = ByteToImage(byteimage);

                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void iconButton2_Click(object sender, EventArgs e) // guardar cambios
        {
            string mensaje = string.Empty;  // el mesnaje comienza vacio

            Negocio obj = new Negocio()   /// creo un objeto de la clase negocio
            {
                nombreNegocio = txtNegocio.Text,
                cuit = txtcuitNegocio.Text,
                Direccion = txtDireNegocio.Text

        };

            bool respuesta = new CN_Negocio ().guardaDatos(obj, out mensaje);

            if (respuesta)
                MessageBox.Show("Los Cambios fueron Guardados", "Mnesaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("NO SE pudieron guardar los Cambios Solicitados", "Mnesaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
