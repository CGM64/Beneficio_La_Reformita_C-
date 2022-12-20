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
    public class ClientesDAL
    {
        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        public bool Insertar(Clientes clientes)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string insertar = $"Insert Into Clientes (Id, DPI, Nombre, NIT, Celular) Values ('{clientes.Id}', {clientes.DPI}, '{clientes.Nombre}', '{clientes.NIT}', {clientes.Celular})";

                using (SqlCommand comando = new SqlCommand(insertar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos del cliente, agregados exitosamente.", "La reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }

        public bool Modificar(Clientes clientes)
        {
            using(SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string modificar = $"Update\n\t Clientes Set Id = '{clientes.Id}',\nDPI = '{clientes.DPI}',\nNombre = '{clientes.Nombre}',\nNIT = '{clientes.NIT}',\nCelular = '{clientes.Celular}'\nWhere Id = '{clientes.Id}'";

                using(SqlCommand comando = new SqlCommand(modificar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos del cliente, modificados exitosamente.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }

        public bool Eliminar(Clientes clientes)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string eliminar = $"Delete From Clientes\nWhere Id = '{clientes.Id}'";

                using (SqlCommand comando = new SqlCommand(eliminar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos del cliente, eliminados exitosamente.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }
    }
}
