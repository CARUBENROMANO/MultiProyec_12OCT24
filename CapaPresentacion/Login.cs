using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar(); // AQUI VA A ESTA LA LISTA QUE TENGAMOS EN MI USUARIO DE BD


            Usuario oUsario = new CN_Usuario().Listar().Where(u => u.nombreUsuario == txtusuario.Text && u.claveUsuario ==
            txtclave.Text).FirstOrDefault();   // AQUI FLISTRAMOS - estos on expresiones landa el cual nos ayuda a tomar acciones respecto a nuestras listas

            if (oUsario != null)   /// si es diferente a nulo
            {
                Menu form = new Menu(oUsario);

                form.Show();  // MUESTRA MI MENU
                this.Hide(); //CON ESTO MI LOG ESTA OCULTO


                form.FormClosing += frm_closing; // cuando cierra tome el evento que sigue

            }

            else  // en caso de no encontrar
            {
                MessageBox.Show("NO SE ENCONTRO AL USUARIO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";  // al volver que mi usuario este vacio e igual que mi clave
            txtclave.Text = "";

            this.Show(); // llamo mi formulario que oculte anteriormente
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
