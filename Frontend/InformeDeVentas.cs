using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Frontend
{
    public partial class InformeDeVentas : Form
    {
        public InformeDeVentas()
        {
            InitializeComponent();
        }

        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        private void InformeDeVentas_Load(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select * From Reporte_de_Ventas";

                using (SqlDataAdapter adaptador = new SqlDataAdapter(lista, conexion))
                {
                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    listaInformeDeVentas.DataSource = tabla;

                    conexion.Close();
                }
            }
        }

        private void botonCerrarFormulario_Click(object sender, EventArgs e)
        {
            DialogResult preguntaParaSalir;

            preguntaParaSalir = MessageBox.Show("¿Desea cerrar este formulario?", "La Reformita", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (preguntaParaSalir == DialogResult.OK)
            {
                Form abrirAcceso = new MenúPrincipal();
                abrirAcceso.Show();

                this.Hide();
            }
        }
    }
}
