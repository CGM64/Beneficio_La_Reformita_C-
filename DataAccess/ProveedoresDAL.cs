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
    public class ProveedoresDAL
    {
        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        public bool Insertar(Proveedores proveedores)
        {
            using(SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                //string insertar = $"Insert Into Proveedores (Id, DPI, Nombre, NIT, Celular, CantidadQuintales, Precio, Total, FechaIngreso) Values ('{proveedores.Id}', {proveedores.DPI}, '{proveedores.Nombre}', '{proveedores.NIT}', {proveedores.Celular}, {proveedores.CantidadQuintales}, {proveedores.PrecioQuintal}, {proveedores.Total}, {proveedores.FechaIngreso})";
                string insertar = $"Insert Into Proveedores (Id, DPI, Nombre, NIT, Celular) Values ('{proveedores.Id}', {proveedores.DPI}, '{proveedores.Nombre}', '{proveedores.NIT}', {proveedores.Celular})";

                using (SqlCommand comando = new SqlCommand(insertar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos del proveedror, agregados exitosamente.", "La reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }

        public bool Modificar(Proveedores proveedores)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string modificar = $"Update\n\t Proveedores Set Id = '{proveedores.Id}',\nDPI = '{proveedores.DPI}',\nNombre = '{proveedores.Nombre}',\nNIT = '{proveedores.NIT}',\nCelular = '{proveedores.Celular}'\nWhere Id = '{proveedores.Id}'";

                using (SqlCommand comando = new SqlCommand(modificar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos del proveedor, modificados exitosamente.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }

        public bool Eliminar(Proveedores proveedores)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string eliminar = $"Delete From Proveedores\nWhere Id = '{proveedores.Id}'";

                using (SqlCommand comando = new SqlCommand(eliminar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos del proveedor, eliminados exitosamente.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }
    }
}
