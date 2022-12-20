using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Backend;
using System.Windows.Forms;

namespace DataAccess
{
    public class UsuariosDAL
    {
        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        public bool Insertar(Usuarios usuarios)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string insertar = $"Insert Into Usuarios (Id, Usuario, Contraseña) Values ('{usuarios.Id}', '{usuarios.Usuario}', '{usuarios.Contraseña}')";

                using (SqlCommand comando = new SqlCommand(insertar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos del usuario, agregados exitosamente.", "La reformita");
                }
            }

            return true;
        }

        public bool Modificar(Usuarios usuarios)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string modificar = $"Update Usuarios\n\t Set Usuario = '{usuarios.Usuario}',\nContraseña = '{usuarios.Contraseña}'\nWhere Id = '{usuarios.Id}'";

                using (SqlCommand comando = new SqlCommand(modificar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos del usuario, modificados exitosamente.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }

        public bool Eliminar(Usuarios usuarios)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string eliminar = $"Delete From Usuarios\nWhere Id = '{usuarios.Id}' and Usuario = '{usuarios.Usuario}' and Contraseña = '{usuarios.Contraseña}'";

                using (SqlCommand comando = new SqlCommand(eliminar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos del usuario, eliminados exitosamente.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }
    }
}
