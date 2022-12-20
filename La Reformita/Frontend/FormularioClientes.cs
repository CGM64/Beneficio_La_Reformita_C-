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
    public partial class FormularioClientes : Form
    {
        ClientesDAL clientes;

        public FormularioClientes()
        {
            InitializeComponent();

            clientes = new ClientesDAL();
        }

        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        private void botonCerrarFormularioClientes_Click(object sender, EventArgs e)
        {
            DialogResult preguntaParaSalir;

            preguntaParaSalir = MessageBox.Show("¿Desea cerrar el formulario?", "La Reformita", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if(preguntaParaSalir == DialogResult.OK)
            {
                Form cerrarFormulario = new MenúPrincipal();
                cerrarFormulario.Show();

                this.Dispose();
            }
        }

        private bool validarCamposVacíos()
        {
            bool validar = true;

            if (idClientes.Text == "" && dpiClientes.Text == "" && nombreClientes.Text == "" && nitClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "Ingrese el DPI");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (idClientes.Text == "" && dpiClientes.Text != "" && nombreClientes.Text != "" && nitClientes.Text != "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (dpiClientes.Text == "" && idClientes.Text != "" && nombreClientes.Text != "" && nitClientes.Text != "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (nombreClientes.Text == "" && idClientes.Text != "" && dpiClientes.Text != "" && nitClientes.Text != "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (nitClientes.Text == "" && idClientes.Text != "" && dpiClientes.Text != "" && nombreClientes.Text != "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (celularClientes.Text == "" && idClientes.Text != "" && dpiClientes.Text != "" && nombreClientes.Text != "" && nitClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            //
            else if (idClientes.Text != "" && dpiClientes.Text == "" && nombreClientes.Text == "" && nitClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (dpiClientes.Text != "" && idClientes.Text == "" && nombreClientes.Text == "" && nitClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (nombreClientes.Text != "" && idClientes.Text == "" && dpiClientes.Text == "" && nitClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (nitClientes.Text != "" && idClientes.Text == "" && dpiClientes.Text == "" && nombreClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (celularClientes.Text != "" && idClientes.Text == "" && dpiClientes.Text == "" && nombreClientes.Text == "" && nitClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "");
            }
            //
            else if (idClientes.Text == "" && dpiClientes.Text == "" && nombreClientes.Text != "" && nitClientes.Text != "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (nombreClientes.Text == "" && idClientes.Text == "" && dpiClientes.Text != "" && nitClientes.Text != "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (nitClientes.Text == "" && idClientes.Text == "" && dpiClientes.Text != "" && nombreClientes.Text != "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (celularClientes.Text == "" && idClientes.Text == "" && dpiClientes.Text != "" && nombreClientes.Text != "" && nitClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            //
            else if (idClientes.Text != "" && dpiClientes.Text != "" && nombreClientes.Text == "" && nitClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (nombreClientes.Text != "" && idClientes.Text != "" && dpiClientes.Text == "" && nitClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (nitClientes.Text != "" && idClientes.Text != "" && dpiClientes.Text == "" && nombreClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (celularClientes.Text != "" && idClientes.Text != "" && dpiClientes.Text == "" && nombreClientes.Text == "" && nitClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            //
            else if (dpiClientes.Text == "" && nombreClientes.Text == "" && idClientes.Text != "" && nitClientes.Text != "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (nitClientes.Text == "" && dpiClientes.Text == "" && idClientes.Text != "" && nombreClientes.Text != "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (celularClientes.Text == "" && dpiClientes.Text == "" && idClientes.Text != "" && nombreClientes.Text != "" && nitClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if(nitClientes.Text == "" && nombreClientes.Text == "" && idClientes.Text != "" && dpiClientes.Text != "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (celularClientes.Text == "" && nombreClientes.Text == "" && idClientes.Text != "" && dpiClientes.Text != "" && nitClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (celularClientes.Text == "" && nitClientes.Text == "" && idClientes.Text != "" && dpiClientes.Text != "" && nombreClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            //
            else if (dpiClientes.Text != "" && nombreClientes.Text != "" && idClientes.Text == "" && nitClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (nitClientes.Text != "" && dpiClientes.Text != "" && idClientes.Text == "" && nombreClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (celularClientes.Text != "" && dpiClientes.Text != "" && idClientes.Text == "" && nombreClientes.Text == "" && nitClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (nitClientes.Text != "" && nombreClientes.Text != "" && idClientes.Text == "" && dpiClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (celularClientes.Text != "" && nombreClientes.Text != "" && idClientes.Text == "" && dpiClientes.Text == "" && nitClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (celularClientes.Text != "" && nitClientes.Text != "" && idClientes.Text == "" && dpiClientes.Text == "" && nombreClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "");
            }
            //
            else if (idClientes.Text == "" && dpiClientes.Text == "" && nombreClientes.Text == "" && nitClientes.Text != "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (idClientes.Text == "" && dpiClientes.Text == "" && nitClientes.Text == "" && nombreClientes.Text != "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (idClientes.Text == "" && dpiClientes.Text == "" && celularClientes.Text == "" && nombreClientes.Text != "" && nitClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            //
            else if (idClientes.Text != "" && dpiClientes.Text != "" && nombreClientes.Text != "" && nitClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (idClientes.Text != "" && dpiClientes.Text != "" && nitClientes.Text != "" && nombreClientes.Text == "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (idClientes.Text != "" && dpiClientes.Text != "" && celularClientes.Text != "" && nombreClientes.Text == "" && nitClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "");
            }
            //
            else if (idClientes.Text == "" && dpiClientes.Text == "" && nombreClientes.Text == "" && nitClientes.Text == "" && celularClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "");
            }
            else if (idClientes.Text == "" && dpiClientes.Text == "" && nombreClientes.Text == "" && celularClientes.Text == "" && nitClientes.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "Ingrese el Id");
                errorProvider1.SetError(dpiClientes, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreClientes, "Ingrese el Nombre");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            //
            else if (idClientes.Text != "" && dpiClientes.Text != "" && nombreClientes.Text != "" && nitClientes.Text != "" && celularClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "Ingrese el No. de Celular");
            }
            else if (idClientes.Text != "" && dpiClientes.Text != "" && nombreClientes.Text != "" && celularClientes.Text != "" && nitClientes.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "Ingrese el NIT");
                errorProvider1.SetError(celularClientes, "");
            }

            return validar;
        }

        private void borrarMensajeDeError()
        {
            if (idClientes.Text != "" && dpiClientes.Text != "" && nombreClientes.Text != "" && nitClientes.Text != "" && celularClientes.Text != "")
            {
                errorProvider1.SetError(idClientes, "");
                errorProvider1.SetError(dpiClientes, "");
                errorProvider1.SetError(nombreClientes, "");
                errorProvider1.SetError(nitClientes, "");
                errorProvider1.SetError(celularClientes, "");
            }
        }

        private void botonAgregarClientes_Click(object sender, EventArgs e)
        {
            if(idClientes.Text == "" || dpiClientes.Text == "" || nombreClientes.Text == "" || nitClientes.Text == "" || celularClientes.Text == "")
            {
                validarCamposVacíos();
            } else if(idClientes.Text != "" && dpiClientes.Text != "" && nombreClientes.Text != "" && nitClientes.Text != "" && celularClientes.Text != "")
            {
                borrarMensajeDeError();

                clientes.Insertar(
                    new Clientes(
                        idClientes.Text,
                        dpiClientes.Text,
                        nombreClientes.Text,
                        nitClientes.Text,
                        long.Parse(celularClientes.Text)
                    )
                );

                listaClientes();
            }
        }

        private void botonModificarClientes_Click(object sender, EventArgs e)
        {
            DialogResult preguntaModificar;

            preguntaModificar = MessageBox.Show("¿Desea modificar los datos de este cliente?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(preguntaModificar == DialogResult.Yes)
            {
                if (listaIdClientes.Text == ""|| idClientes.Text == "" || dpiClientes.Text == "" || nombreClientes.Text == "" || nitClientes.Text == "" || celularClientes.Text == "")
                {
                    validarCamposVacíos();
                }
                else if (listaIdClientes.Text != "" && idClientes.Text != "" && dpiClientes.Text != "" && nombreClientes.Text != "" && nitClientes.Text != "" && celularClientes.Text != "")
                {
                    borrarMensajeDeError();

                    clientes.Modificar(
                        new Clientes(
                            idClientes.Text,
                            dpiClientes.Text,
                            nombreClientes.Text,
                            nitClientes.Text,
                            long.Parse(celularClientes.Text)
                        )
                    );

                    listaClientes();
                }
            }
        }

        private void botonClientesEliminar_Click(object sender, EventArgs e)
        {
            DialogResult preguntaEliminar;

            preguntaEliminar = MessageBox.Show("¿Desea eliminar los datos de este cliente?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (preguntaEliminar == DialogResult.Yes)
            {
                if (idClientes.Text == "" && idClientes.Text == "")
                {
                    errorProvider1.SetError(idClientes, "Ingrese el Id");
                }
                else if (listaIdClientes.Text != "" && idClientes.Text != "")
                {
                    errorProvider1.SetError(idClientes, "");

                    clientes.Eliminar(
                        new Clientes(
                            idClientes.Text,
                            dpiClientes.Text,
                            nombreClientes.Text,
                            nitClientes.Text,
                            long.Parse(celularClientes.Text)
                        )
                    );

                    listaClientes();
                }
            }
        }

        private void botonLimpiarCamposClientes_Click(object sender, EventArgs e)
        {
            DialogResult preguntaLimpiarCampos;

            preguntaLimpiarCampos = MessageBox.Show("¿Desea limpiar todos los campos?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(preguntaLimpiarCampos == DialogResult.Yes)
            {
                idClientes.Clear();
                dpiClientes.Clear();
                nombreClientes.Clear();
                nitClientes.Clear();
                celularClientes.Clear();

                MessageBox.Show("Campos limpios.", "La Reformita");
            }
        }

        //Muestra los datos de la base de datos en el combo box
        private void listaClientes()
        {
            listaIdClientes.Items.Clear();

            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Id From Clientes";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        listaIdClientes.Items.Add(encontrarValores["Id"].ToString());
                    }
                }
            }
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            listaClientes();
        }

        //Muestra los datos que pertenecen al cliente seleccionado
        private void listaIdClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select * From Clientes Where Id = '{listaIdClientes.Text}'";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        idClientes.Text = encontrarValores["Id"].ToString();
                        dpiClientes.Text = encontrarValores["DPI"].ToString();
                        nombreClientes.Text = encontrarValores["Nombre"].ToString();
                        nitClientes.Text = encontrarValores["NIT"].ToString();
                        celularClientes.Text = encontrarValores["Celular"].ToString();

                    }
                }
            }
        }
    }
}
