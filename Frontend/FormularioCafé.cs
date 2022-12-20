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
    public partial class FormularioCafé : Form
    {
        CaféDAL café;
        ExistenciasDAL existencias;

        public FormularioCafé()
        {
            InitializeComponent();

            café = new CaféDAL();
            existencias = new ExistenciasDAL();
        }

        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        private bool validarCamposVacíos()
        {
            bool validar = true;

            if (idCafé.Text == "" && nombreCafé.Text == "" && precioCafé.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idCafé, "Ingrese el Id");
                errorProvider1.SetError(nombreCafé, "Ingrese el Nombre");
                errorProvider1.SetError(precioCafé, "Ingrese el Precio");
            }
            else if (idCafé.Text == "" && nombreCafé.Text != "" && precioCafé.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idCafé, "Ingrese el Id");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(precioCafé, "");
            }
            else if (nombreCafé.Text == "" && idCafé.Text != "" && precioCafé.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "Ingrese el Nombre");
                errorProvider1.SetError(precioCafé, "");
            } else if(precioCafé.Text == "" && idCafé.Text != "" && precioCafé.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(precioCafé, "Ingrese el Precio");
            } else if(nombreCafé.Text == "" && precioCafé.Text == "" && idCafé.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "Ingrese el Nombre");
                errorProvider1.SetError(precioCafé, "Ingrese el Precio");
            } else if(idCafé.Text == "" && precioCafé.Text == "" && nombreCafé.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idCafé, "Ingrese el Id");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(precioCafé, "Ingrese el Precio");
            } else if(idCafé.Text == "" && nombreCafé.Text == "" && precioCafé.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idCafé, "Ingrese el Id");
                errorProvider1.SetError(nombreCafé, "Ingrese el Nombre");
                errorProvider1.SetError(precioCafé, "");
            }
            //
            if (idCafé.Text != "" && nombreCafé.Text != "" && precioCafé.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(precioCafé, "Ingrese el Precio");
            }
            if (precioCafé.Text != "" && idCafé.Text != "" && nombreCafé.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "Ingrese el Nombre");
                errorProvider1.SetError(precioCafé, "");
            }
            if (nombreCafé.Text != "" && precioCafé.Text != "" && idCafé.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idCafé, "Ingrese el Id");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(precioCafé, "");
            }

            return validar;
        }

        private void borrarMensajeDeError()
        {
            if (idCafé.Text != "" && nombreCafé.Text != "" && precioCafé.Text != "")
            {
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(precioCafé, "");
            }
        }

        private void botonAgregarCafé_Click(object sender, EventArgs e)
        {
            if(idCafé.Text == "" || nombreCafé.Text == "" || precioCafé.Text == "")
            {
                validarCamposVacíos();
            } else if(idCafé.Text != "" && nombreCafé.Text != "" && precioCafé.Text != "")
            {
                borrarMensajeDeError();

                café.Insertar(
                    new Café(
                        idCafé.Text,
                        nombreCafé.Text,
                        decimal.Parse(precioCafé.Text)
                    )
                );

                existencias.Insertar(
                    new Existencias(
                        0,
                        0,
                        idCafé.Text,
                        nombreCafé.Text,
                        decimal.Parse(precioCafé.Text)
                    )
                );

                listaCafé();
            }
        }

        private void listaIdCafé_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Id, Nombre, Precio From Café Where Id = '{listaIdCafé.Text}'";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        idCafé.Text = encontrarValores["Id"].ToString();
                        nombreCafé.Text = encontrarValores["Nombre"].ToString();
                        precioCafé.Text = encontrarValores["Precio"].ToString();
                    }
                }
            }
        }

        private void listaCafé()
        {
            listaIdCafé.Items.Clear();

            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Id From Café";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        listaIdCafé.Items.Add(encontrarValores["Id"].ToString());
                    }

                    conexion.Close();
                }
            }
        }

        private void botonModificarCafé_Click(object sender, EventArgs e)
        {
            DialogResult preguntaModificar;

            preguntaModificar = MessageBox.Show("¿Desea modificar los datos de este café?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (preguntaModificar == DialogResult.Yes)
            {
                if (idCafé.Text == "" || nombreCafé.Text == "" || precioCafé.Text == "")
                {
                    validarCamposVacíos();
                }
                else if (idCafé.Text != "" && nombreCafé.Text != "" && precioCafé.Text != "")
                {
                    borrarMensajeDeError();

                    café.Modificar(
                        new Café(
                            idCafé.Text,
                            nombreCafé.Text,
                            decimal.Parse(precioCafé.Text)
                        )
                    );

                    existencias.ModificarCafé(
                        new Existencias(
                            0,
                            0,
                            idCafé.Text,
                            nombreCafé.Text,
                            decimal.Parse(precioCafé.Text)
                        )
                    );

                    listaCafé();
                }
            }
        }

        private void FormularioCafé_Load(object sender, EventArgs e)
        {
            listaCafé();
        }

        private void botonEliminarCafé_Click(object sender, EventArgs e)
        {
            DialogResult preguntaEliminar;

            preguntaEliminar = MessageBox.Show("¿Desea eliminar los datos de este café?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (preguntaEliminar == DialogResult.Yes)
            {
                if (listaIdCafé.Text == "" && idCafé.Text == "")
                {
                    errorProvider1.SetError(idCafé, "Ingrese el Id");
                }
                else if (listaIdCafé.Text != "" && idCafé.Text != "")
                {
                    errorProvider1.SetError(idCafé, "");

                    café.Eliminar(
                        new Café(
                            idCafé.Text,
                            nombreCafé.Text,
                            decimal.Parse(precioCafé.Text)
                        )
                    );

                    existencias.Eliminar(
                        new Existencias(
                            0,
                            0,
                            idCafé.Text,
                            nombreCafé.Text,
                            decimal.Parse(precioCafé.Text)
                        )
                    );

                    listaCafé();
                }
            }
        }

        private void botonCaféCerrarFormulario_Click(object sender, EventArgs e)
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

        private void botonCaféLimpiarCampos_Click(object sender, EventArgs e)
        {
            DialogResult preguntaLimpiarCampos;

            preguntaLimpiarCampos = MessageBox.Show("¿Desea limpiar todos los campos?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (preguntaLimpiarCampos == DialogResult.Yes)
            {
                idCafé.Clear();
                nombreCafé.Clear();
                precioCafé.Clear();

                MessageBox.Show("Campos limpios.", "La Reformita");
            }
        }
    }
}
