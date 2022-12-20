using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess
{
    public class CaféDAL
    {
        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        public bool Insertar(Café café)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string insertar = $"Insert Into Café (Id, Nombre, Precio) Values ('{café.IdCafé}', '{café.Nombre}', {café.PrecioQuintal})";

                using (SqlCommand comando = new SqlCommand(insertar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos del café, agregados exitosamente.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }

        public bool Modificar(Café café)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string modificar = $"Update\n\t Café Set Id = '{café.IdCafé}',\nNombre = '{café.Nombre}',\nPrecio = {café.PrecioQuintal}\nWhere Id = '{café.IdCafé}'";

                using (SqlCommand comando = new SqlCommand(modificar, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    MessageBox.Show("Datos del café, modificados exitosamente.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }

        public bool Eliminar(Café café)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string eliminar = $"Delete From Café\nWhere Id = '{café.IdCafé}'";

                using (SqlCommand comando = new SqlCommand(eliminar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos del café, eliminados exitosamente.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }
    }
}
