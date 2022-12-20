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
    public partial class FormularioProveedores : Form
    {
        ProveedoresDAL proveedores;
        public FormularioProveedores()
        {
            InitializeComponent();

            proveedores = new ProveedoresDAL();
        }

        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        private bool validarCamposVacios()
        {
            bool validar = true;

            if (idProveedores.Text == "" && dpiProveedores.Text == "" && nombreProveedores.Text == "" && nitProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "Ingrese el DPI");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (idProveedores.Text == "" && dpiProveedores.Text != "" && nombreProveedores.Text != "" && nitProveedores.Text != "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (dpiProveedores.Text == "" && idProveedores.Text != "" && nombreProveedores.Text != "" && nitProveedores.Text != "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (nombreProveedores.Text == "" && idProveedores.Text != "" && dpiProveedores.Text != "" && nitProveedores.Text != "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (nitProveedores.Text == "" && idProveedores.Text != "" && dpiProveedores.Text != "" && nombreProveedores.Text != "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (celularProveedores.Text == "" && idProveedores.Text != "" && dpiProveedores.Text != "" && nombreProveedores.Text != "" && nitProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            //
            else if (idProveedores.Text != "" && dpiProveedores.Text == "" && nombreProveedores.Text == "" && nitProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (dpiProveedores.Text != "" && idProveedores.Text == "" && nombreProveedores.Text == "" && nitProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (nombreProveedores.Text != "" && idProveedores.Text == "" && dpiProveedores.Text == "" && nitProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (nitProveedores.Text != "" && idProveedores.Text == "" && dpiProveedores.Text == "" && nombreProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (celularProveedores.Text != "" && idProveedores.Text == "" && dpiProveedores.Text == "" && nombreProveedores.Text == "" && nitProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "");
            }
            //
            else if (idProveedores.Text == "" && dpiProveedores.Text == "" && nombreProveedores.Text != "" && nitProveedores.Text != "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (nombreProveedores.Text == "" && idProveedores.Text == "" && dpiProveedores.Text != "" && nitProveedores.Text != "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (nitProveedores.Text == "" && idProveedores.Text == "" && dpiProveedores.Text != "" && nombreProveedores.Text != "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (celularProveedores.Text == "" && idProveedores.Text == "" && dpiProveedores.Text != "" && nombreProveedores.Text != "" && nitProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            //
            else if (idProveedores.Text != "" && dpiProveedores.Text != "" && nombreProveedores.Text == "" && nitProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (nombreProveedores.Text != "" && idProveedores.Text != "" && dpiProveedores.Text == "" && nitProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (nitProveedores.Text != "" && idProveedores.Text != "" && dpiProveedores.Text == "" && nombreProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (celularProveedores.Text != "" && idProveedores.Text != "" && dpiProveedores.Text == "" && nombreProveedores.Text == "" && nitProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            //
            else if (dpiProveedores.Text == "" && nombreProveedores.Text == "" && idProveedores.Text != "" && nitProveedores.Text != "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (nitProveedores.Text == "" && dpiProveedores.Text == "" && idProveedores.Text != "" && nombreProveedores.Text != "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (celularProveedores.Text == "" && dpiProveedores.Text == "" && idProveedores.Text != "" && nombreProveedores.Text != "" && nitProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (nitProveedores.Text == "" && nombreProveedores.Text == "" && idProveedores.Text != "" && dpiProveedores.Text != "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (celularProveedores.Text == "" && nombreProveedores.Text == "" && idProveedores.Text != "" && dpiProveedores.Text != "" && nitProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (celularProveedores.Text == "" && nitProveedores.Text == "" && idProveedores.Text != "" && dpiProveedores.Text != "" && nombreProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            //
            else if (dpiProveedores.Text != "" && nombreProveedores.Text != "" && idProveedores.Text == "" && nitProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (nitProveedores.Text != "" && dpiProveedores.Text != "" && idProveedores.Text == "" && nombreProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (celularProveedores.Text != "" && dpiProveedores.Text != "" && idProveedores.Text == "" && nombreProveedores.Text == "" && nitProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (nitProveedores.Text != "" && nombreProveedores.Text != "" && idProveedores.Text == "" && dpiProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (celularProveedores.Text != "" && nombreProveedores.Text != "" && idProveedores.Text == "" && dpiProveedores.Text == "" && nitProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (celularProveedores.Text != "" && nitProveedores.Text != "" && idProveedores.Text == "" && dpiProveedores.Text == "" && nombreProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "");
            }
            //
            else if (idProveedores.Text == "" && dpiProveedores.Text == "" && nombreProveedores.Text == "" && nitProveedores.Text != "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (idProveedores.Text == "" && dpiProveedores.Text == "" && nitProveedores.Text == "" && nombreProveedores.Text != "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (idProveedores.Text == "" && dpiProveedores.Text == "" && celularProveedores.Text == "" && nombreProveedores.Text != "" && nitProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            //
            else if (idProveedores.Text != "" && dpiProveedores.Text != "" && nombreProveedores.Text != "" && nitProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (idProveedores.Text != "" && dpiProveedores.Text != "" && nitProveedores.Text != "" && nombreProveedores.Text == "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (idProveedores.Text != "" && dpiProveedores.Text != "" && celularProveedores.Text != "" && nombreProveedores.Text == "" && nitProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "");
            }
            //
            else if (idProveedores.Text == "" && dpiProveedores.Text == "" && nombreProveedores.Text == "" && nitProveedores.Text == "" && celularProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "");
            }
            else if (idProveedores.Text == "" && dpiProveedores.Text == "" && nombreProveedores.Text == "" && celularProveedores.Text == "" && nitProveedores.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "Ingrese el Id");
                errorProvider1.SetError(dpiProveedores, "Ingrese el No. de DPI");
                errorProvider1.SetError(nombreProveedores, "Ingrese el Nombre");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            //
            else if (idProveedores.Text != "" && dpiProveedores.Text != "" && nombreProveedores.Text != "" && nitProveedores.Text != "" && celularProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "Ingrese el No. de Celular");
            }
            else if (idProveedores.Text != "" && dpiProveedores.Text != "" && nombreProveedores.Text != "" && celularProveedores.Text != "" && nitProveedores.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "Ingrese el NIT");
                errorProvider1.SetError(celularProveedores, "");
            }

            return validar;
        }

        private void borrarMensajeDeError()
        {
            if (idProveedores.Text != "" && dpiProveedores.Text != "" && nombreProveedores.Text != "" && nitProveedores.Text != "" && celularProveedores.Text != "")
            {
                errorProvider1.SetError(idProveedores, "");
                errorProvider1.SetError(dpiProveedores, "");
                errorProvider1.SetError(nombreProveedores, "");
                errorProvider1.SetError(nitProveedores, "");
                errorProvider1.SetError(celularProveedores, "");
            }
        }

        private void botonAgregarProveedores_Click(object sender, EventArgs e)
        {
            if(idProveedores.Text == "" || dpiProveedores.Text == "" || nombreProveedores.Text == "" || nitProveedores.Text == "" || celularProveedores.Text == "")
            {
                validarCamposVacios();
            } else if (idProveedores.Text != "" && dpiProveedores.Text != "" && nombreProveedores.Text != "" && nitProveedores.Text != "" && celularProveedores.Text != "")
            {
                borrarMensajeDeError();

                proveedores.Insertar(
                    new Proveedores(
                        idProveedores.Text,
                        dpiProveedores.Text,
                        nombreProveedores.Text,
                        nitProveedores.Text,
                        long.Parse(celularProveedores.Text)
                    )
                );

                listaProveedores();
            }
        }

        private void listaProveedores()
        {
            listaIdProveedores.Items.Clear();

            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Id From Proveedores";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        listaIdProveedores.Items.Add(encontrarValores["Id"].ToString());
                    }
                }
            }
        }

        private void FormularioProveedores_Load(object sender, EventArgs e)
        {
            listaProveedores();
        }

        private void listaIdProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select * From Proveedores Where Id = '{listaIdProveedores.Text}'";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        idProveedores.Text = encontrarValores["Id"].ToString();
                        dpiProveedores.Text = encontrarValores["DPI"].ToString();
                        nombreProveedores.Text = encontrarValores["Nombre"].ToString();
                        nitProveedores.Text = encontrarValores["NIT"].ToString();
                        celularProveedores.Text = encontrarValores["Celular"].ToString();

                    }
                }
            }
        }

        private void botonProveedoresModificar_Click(object sender, EventArgs e)
        {
            DialogResult preguntaModificar;

            preguntaModificar = MessageBox.Show("¿Desea modificar los datos de este proveedor?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (preguntaModificar == DialogResult.Yes)
            {
                if (listaIdProveedores.Text == "" || idProveedores.Text == "" || dpiProveedores.Text == "" || nombreProveedores.Text == "" || nitProveedores.Text == "" || celularProveedores.Text == "")
                {
                    validarCamposVacios();
                }
                else if (listaIdProveedores.Text != "" && idProveedores.Text != "" && dpiProveedores.Text != "" && nombreProveedores.Text != "" && nitProveedores.Text != "" && celularProveedores.Text != "")
                {
                    borrarMensajeDeError();

                    proveedores.Modificar(
                        new Proveedores(
                            idProveedores.Text,
                            dpiProveedores.Text,
                            nombreProveedores.Text,
                            nitProveedores.Text,
                            long.Parse(celularProveedores.Text)
                        )
                    );

                    listaProveedores();
                }
            }
        }

        private void botonProveedoresEliminar_Click(object sender, EventArgs e)
        {
            DialogResult preguntaEliminar;

            preguntaEliminar = MessageBox.Show("¿Desea eliminar los datos de este proveedor?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (preguntaEliminar == DialogResult.Yes)
            {
                if (listaIdProveedores.Text == "" && idProveedores.Text == "")
                {
                    errorProvider1.SetError(idProveedores, "Ingrese el Id");
                }
                else if (listaIdProveedores.Text != "" && idProveedores.Text != "")
                {
                    errorProvider1.SetError(idProveedores, "");

                    proveedores.Eliminar(
                        new Proveedores(
                            idProveedores.Text,
                            dpiProveedores.Text,
                            nombreProveedores.Text,
                            nitProveedores.Text,
                            long.Parse(celularProveedores.Text)
                        )
                    );

                    listaProveedores();
                }
            }
        }

        private void botonProveedoresCerrarFormulario_Click(object sender, EventArgs e)
        {
            DialogResult preguntaCerrarFormulario;

            preguntaCerrarFormulario = MessageBox.Show("¿Desea cerrar el formulario?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (preguntaCerrarFormulario == DialogResult.Yes)
            {
                Form cerrarFormulario = new MenúPrincipal();
                cerrarFormulario.Show();

                this.Dispose();
            }
        }

        private void botonProveedoresLimpiarCampos_Click(object sender, EventArgs e)
        {
            DialogResult preguntaLimpiarCampos;

            preguntaLimpiarCampos = MessageBox.Show("¿Desea limpiar todos los campos?", "La Reformita", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (preguntaLimpiarCampos == DialogResult.OK)
            {
                idProveedores.Clear();
                dpiProveedores.Clear();
                nombreProveedores.Clear();
                nitProveedores.Clear();
                celularProveedores.Clear();

                MessageBox.Show("Campos limpios.", "La Reformita");
            }
        }
    }
}
