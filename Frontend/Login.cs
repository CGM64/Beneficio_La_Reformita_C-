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
using System.Configuration;
using System.Data.SqlClient;

namespace Frontend
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;
        string id;
        int contador;

        public bool Validar(Usuarios usuarios)
        {
            //El ciclo se cierra hasta que el contador llegue a la quinta vuelta (tope)
            //El usuario tendrá como máximo, 5 intentos, para iniciar sesión
            do
            {
                using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
                {
                    conexion.Open();

                    string validar = $"Select Usuario, Contraseña From Usuarios Where Usuario = '{usuarios.Usuario}' and Contraseña = '{usuarios.Contraseña}'";

                    using (SqlCommand comando = new SqlCommand(validar, conexion))
                    {
                        comando.ExecuteNonQuery();

                        //Comprueba o valida, si C# encontró los valores dentro de la tabla
                        SqlDataReader encontrarValores = comando.ExecuteReader();

                        if (encontrarValores.Read())
                        {
                            MessageBox.Show("Bienvenido " + usuarios.Usuario + ".");

                            Form abrirMenu = new MenúPrincipal();
                            abrirMenu.Show();

                            //Cierra el formulario
                            this.Hide();
                        }
                        else if (!encontrarValores.Read() && contador <= 4)
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos. \n\t Intento " + (contador + 1) + " de 5.", "La Reformita");

                            contador++;
                        }
                    }
                }

                if (contador > 4)
                {
                    //Si del el intento No. 6 en adelante, hasta llegar al 9no., el usuario intenta ingresar y escribe erroneamente los datos, se le aparecerá el siguiente mensaje
                    if (contador >= 6 && contador <= 9)
                    {
                        MessageBox.Show("Ha alcanzado el límite de intentos.", "La Reformita");
                    } 

                    contador++;
                }

                //Si el usuario hace un décimo intento
                if (contador == 11)
                {
                    contador++;

                    //Cierra el formulario y al mismo tiempo, finaliza la compilación
                    //this.Dispose();
                    Application.Exit();
                }
            } while (contador == 5);

            return true;
        }

        private bool validarCamposVacíos()
        {
            bool validar = true;

            if (usuario.Text == "" && contrasena.Text == "")
            {
                validar = false;

                errorProvider1.SetError(usuario, "Ingrese el Usuario");
                errorProvider1.SetError(contrasena, "Ingrese la Contraseña");
            } else if(usuario.Text == "" && contrasena.Text != "")
            {
                validar = false;

                errorProvider1.SetError(usuario, "Ingrese el Usuario");
                errorProvider1.SetError(contrasena, "");
            } else if(contrasena.Text == "" && usuario.Text != "")
            {
                validar = false;

                errorProvider1.SetError(usuario, "");
                errorProvider1.SetError(contrasena, "Ingrese la Contraseña");
            }

            return validar;
        }

        private void borrarMensajeDeError()
        {
            if (usuario.Text != "" && contrasena.Text != "")
            {
                errorProvider1.SetError(usuario, "");
                errorProvider1.SetError(contrasena, "");
            }
        }

        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            if(usuario.Text == "" || contrasena.Text == "")
            {
                validarCamposVacíos();
            } else if(usuario.Text != "" && contrasena.Text != "")
            {
                borrarMensajeDeError();

                Validar(
                    new Usuarios(
                        id,
                        usuario.Text,
                        contrasena.Text
                    )
                );
            }
        }

        //Doble clic al formulario
        private void Login_Load(object sender, EventArgs e)
        {
            //Agrega datos al vector del combo box
            listaUsuarios();
        }

        private void listaUsuarios()
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Id, Usuario From Usuarios";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        id = encontrarValores["Id"].ToString();
                        usuario.Items.Add(encontrarValores["Usuario"].ToString());
                    }
                }
            }
        }

        private void botonLoginSalir_Click(object sender, EventArgs e)
        {
            DialogResult preguntaParaSalir;

            preguntaParaSalir = MessageBox.Show("¿Desea salir del programa?", "La Reformita", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(preguntaParaSalir == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void botonContrasena_Click(object sender, EventArgs e)
        {
            Form abrirAcceso = new AccesoManipulaciónUsuarios();
            abrirAcceso.Show();

            this.Hide();
        }
    }
}
