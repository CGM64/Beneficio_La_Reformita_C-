using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using DataAccess;
using System.Configuration;
using System.Data.SqlClient;

namespace Frontend
{
    public partial class FormularioUsuarios : Form
    {
        UsuariosDAL usuarios;

        public FormularioUsuarios()
        {
            InitializeComponent();

            usuarios = new UsuariosDAL();
        }

        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        private void botonAgregarUsuario_Click(object sender, EventArgs e)
        {
            if(idUsuarios.Text == "" || usuario.Text == "" || contrasna.Text == "")
            {
                MessageBox.Show("No puede dejar campos vacíos.", "La Reformita");
            } else if(idUsuarios.Text != "" && usuario.Text != "" && contrasna.Text != "")
            {
                usuarios.Insertar(
                    new Usuarios(
                        idUsuarios.Text,
                        usuario.Text,
                        contrasna.Text)
                );

                listaUsuarios();
            }
        }

        private void botonModificarUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nota: Para modificar los datos de un usuario, debe coincidir el Id, con el Id almacenado en la base de datos.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult preguntaParaSalir;

            preguntaParaSalir = MessageBox.Show("¿Desea modificar los datos de este usuario?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (preguntaParaSalir == DialogResult.Yes)
            {
                if (idUsuarios.Text == "" || usuario.Text == "" || contrasna.Text == "")
                {
                    MessageBox.Show("No puede dejar campos vacíos.", "La Reformita");
                }
                else if (idUsuarios.Text != ""  && usuario.Text != "" || contrasna.Text != "")
                {
                    usuarios.Modificar(
                        new Usuarios(
                            idUsuarios.Text,
                            usuario.Text,
                            contrasna.Text)
                    );

                    listaUsuarios();
                }
            }
        }

        private void botonEliminarUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nota: Para eliminar los datos de un usuario, deben coincidir el Id, Usuario y Contraseña, con los datos almacenados en la base de datos.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult preguntaParaSalir;

            preguntaParaSalir = MessageBox.Show("¿Desea eliminar este usuario?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (preguntaParaSalir == DialogResult.Yes)
            {
                if (idUsuarios.Text == "" || usuario.Text == "" || contrasna.Text == "")
                {
                    MessageBox.Show("No puede dejar campos vacíos.", "La Reformita");
                }
                else if (idUsuarios.Text != "" && usuario.Text != "" || contrasna.Text != "")
                {
                    usuarios.Eliminar(
                        new Usuarios(
                            idUsuarios.Text,
                            usuario.Text,
                            contrasna.Text)
                    );

                    listaUsuarios();
                }
            }
        }

        private void botonCerrarForuolario_Click(object sender, EventArgs e)
        {
            DialogResult preguntaParaSalir;

            preguntaParaSalir = MessageBox.Show("¿Desea cerrar el formulario?", "La Reformita", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (preguntaParaSalir == DialogResult.OK)
            {
                Form abrirLogin = new Login();
                abrirLogin.Show();

                this.Dispose();
            }
        }

        private void listaUsuarios()
        {
            usuariosLista.Items.Clear();

            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Usuario From Usuarios";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        usuariosLista.Items.Add(encontrarValores["Usuario"].ToString());
                    }
                }
            }
        }

        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {
            listaUsuarios();
        }

        private void usuariosLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Id, Usuario From Usuarios Where Usuario = '{usuariosLista.Text}'";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        idUsuarios.Text = encontrarValores["Id"].ToString();
                        usuario.Text = encontrarValores["Usuario"].ToString();
                    }
                }
            }
        }

        private void botonLimpiarCampos_Click(object sender, EventArgs e)
        {
            DialogResult preguntaLimpiarCampos;

            preguntaLimpiarCampos = MessageBox.Show("¿Desea limpiar todos los campos?", "La Reformita", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (preguntaLimpiarCampos == DialogResult.OK)
            {
                idUsuarios.Clear();
                usuario.Clear();
                contrasna.Clear();
                
                MessageBox.Show("Campos limpios.", "La Reformita");
            }
        }
    }
}
