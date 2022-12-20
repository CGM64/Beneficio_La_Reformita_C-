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
    public class ExistenciasDAL
    {
        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        public bool Insertar(Existencias existencias)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string insertar = $"Insert Into Existencias(Id, Nombre, Precio, Existencia, Total_Quetzales) Values('{existencias.IdCafé}', '{existencias.Nombre}', {existencias.PrecioQuintal}, {existencias.Existencia}, {existencias.Total_Quetzales})";

                using (SqlCommand comando = new SqlCommand(insertar, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }

        public bool ModificarCafé(Existencias existencias)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string modificar = $"Update\n\t Existencias Set Id = '{existencias.IdCafé}',\nNombre = '{existencias.Nombre}',\nPrecio = {existencias.PrecioQuintal}\nExistencia = {existencias.Existencia}\nTotal_Quetzales = {existencias.Total_Quetzales}\nWhere Id = '{existencias.IdCafé}'";

                using (SqlCommand comando = new SqlCommand(modificar, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();
                }
            }

            return true;
        }

        public bool Modificar(Existencias existencias)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string modificar = $"Update\n\t Existencias Set Id = '{existencias.IdCafé}',\nExistencia = {existencias.Existencia}\nWhere Id = '{existencias.IdCafé}'";

                using (SqlCommand comando = new SqlCommand(modificar, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();
                }
            }

            return true;
        }

        public bool Eliminar(Existencias existencias)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string eliminar = $"Delete From Existencias\nWhere Id = '{existencias.IdCafé}'";

                using (SqlCommand comando = new SqlCommand(eliminar, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }
    }
}
