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
    public class KardexDAL
    {
        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        public bool Insertar(Kardex kardex)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                DateTime recibirFecha = kardex.FechaEntradaSalida;
                string convertirFecha;
                convertirFecha = recibirFecha.ToString("MM/dd/yyyy");

                string insertar = $"Insert Into Kardex (Id, Id_Café, Nombre, Cantidad, Precio, Total, Tipo, Id_Cliente_Proveedor, Cliente_Proveedor, Fecha) Values ('{kardex.Id}', '{kardex.IdCafé}', '{kardex.Nombre}', {kardex.CantidadQuintales}, {kardex.PrecioQuintal}, {kardex.Total}, '{kardex.Tipo}', '{kardex.IdClienteProveedor}', '{kardex.ClienteProveedor}', CAST ('{convertirFecha}' As Date))";

                using (SqlCommand comando = new SqlCommand(insertar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos de entrada o salida, agregados exitosamente.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }

        public bool Modificar(Kardex kardex)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                DateTime recibirFecha = kardex.FechaEntradaSalida;
                string convertirFecha;
                convertirFecha = recibirFecha.ToString("MM/dd/yyyy");

                string modificar = $"Update\n\t Kardex Set Id = '{kardex.Id}',\nId_Café = '{kardex.IdCafé}',\nNombre = '{kardex.Nombre}',\nCantidad = {kardex.CantidadQuintales},\nPrecio = {kardex.PrecioQuintal},\nTotal = {kardex.Total},\nTipo= '{kardex.Tipo}',\nId_Cliente_Proveedor = '{kardex.IdClienteProveedor}',\nCliente_Proveedor = '{kardex.ClienteProveedor}',\nFecha = CAST('{convertirFecha}' As Date)\nWhere Id = '{kardex.Id}'";

                using (SqlCommand comando = new SqlCommand(modificar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos de la Entrada o Salida, modificados exitosamente.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }

        public bool Eliminar(Kardex kardex)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string eliminar = $"Delete From Kardex\nWhere Id = '{kardex.Id}'";

                using (SqlCommand comando = new SqlCommand(eliminar, conexion))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos de la Entradad o Salida, eliminados exitosamente.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }
    }
}
