using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Recursos;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void txtconfirmaclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            List<Rol> listarol = new CN_Rol().Listar();

            foreach (Rol itemi in listarol)
            {
                cboRol.Items.Add(new OpcionCombo() { Valor = itemi.idRol, Texto = itemi.descripcion });
            }

            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;


            //// Mostrar todos los usuario
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dgvdata.Rows.Add(new object[] {
                    "",
                    item.idUsuario,
                    item.nombreUsuario,
                    item.claveUsuario,
                    item.documento,
                    item.correo,
                    item.telefono,
                    item.domicilio,
                    item.oRol.idRol,
                    item.oRol.descripcion

                });



            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            Usuario obj = new Usuario()
            {
                idUsuario = Convert.ToInt32(txtid.Text),
                nombreUsuario = txtnombre.Text,
                claveUsuario = txtclave.Text,
                documento = txtdocumento.Text,
                correo = txtcorreo.Text,
                telefono = txttelefono.Text,
                domicilio = txtdomicilio.Text,


                oRol = new Rol() { idRol = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).Valor) },

            };

            if (obj.idUsuario == 0) /// aqui me dice que es un usuario es nuevo
            {
                int idUsuariogenerado = new CN_Usuario().Registrar(obj, out mensaje);

                if (idUsuariogenerado != 0)
                {

                    dgvdata.Rows.Add(new object[] {"",idUsuariogenerado,txtnombre.Text,txtclave.Text,txtdocumento.Text,txtcorreo.Text,
                        txttelefono.Text,txtdomicilio.Text,
                    ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),

                    });

                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

            else
            {
                bool resultado = new CN_Usuario().editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["nombreUsuario"].Value = txtnombre.Text;
                    row.Cells["ClaveUsuario"].Value = txtclave.Text;

                    row.Cells["documento"].Value = txtdocumento.Text;
                    row.Cells["correo"].Value = txtcorreo.Text;
                    row.Cells["telefono"].Value = txttelefono.Text;
                    row.Cells["domicilio"].Value = txtdomicilio.Text;


                    row.Cells["idRol"].Value = ((OpcionCombo)cboRol.SelectedItem).Valor.ToString();
                    row.Cells["idRol"].Value = ((OpcionCombo)cboRol.SelectedItem).Texto.ToString();


                    limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }




        }

        private void limpiar()
        {
            txtindice.Text = "0";
            txtid.Text = "0";
            txtnombre.Text = "";
            txtclave.Text = "";
            txtdocumento.Text = "";
            txtdomicilio.Text = "";
            txtcorreo.Text = "";
            txttelefono.Text = "";

            txtnombre.Select();


        }

        //private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void dgvdata_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["id"].Value.ToString(); // que pinte mi 1er fila , corresponde al o inica con el "0" lo que va en corchete es el nombre de mi columna
                    txtnombre.Text = dgvdata.Rows[indice].Cells["nombreUsuario"].Value.ToString();
                    txtclave.Text = dgvdata.Rows[indice].Cells["ClaveUsuario"].Value.ToString();
                    txtdocumento.Text = dgvdata.Rows[indice].Cells["documento"].Value.ToString();

                    txtcorreo.Text = dgvdata.Rows[indice].Cells["correo"].Value.ToString();
                    txttelefono.Text = dgvdata.Rows[indice].Cells["telefono"].Value.ToString();
                    txtdomicilio.Text = dgvdata.Rows[indice].Cells["domicilio"].Value.ToString();

                    foreach (OpcionCombo oc in cboRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["idRol"].Value))
                        {
                            int indice_combo = cboRol.Items.IndexOf(oc);
                            cboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                }

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)  /// ELIMINAR
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea Eliminar el usuario seleccionado", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario obj = new Usuario()
                    {
                        idUsuario = Convert.ToInt32(txtid.Text)
                    };

                    bool repuesta = new CN_Usuario().Eliminar(obj, out mensaje);

                    if (repuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text)); // si elimino correctamente procede  a eliminar de mi DataGridview

                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  // y sino que nos aparezca un mensaje
                    }
                    limpiar();
                }

            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string Filtro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
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
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
