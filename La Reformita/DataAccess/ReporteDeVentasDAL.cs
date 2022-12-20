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
    public class ReporteDeVentasDAL
    {
        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        public bool Insertar(ReporteDeVentas reporteDeVentas)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                DateTime recibirFecha = reporteDeVentas.FechaVenta;
                string convertirFecha;
                convertirFecha = recibirFecha.ToString("MM/dd/yyyy");

                string insertar = $"Insert Into Reporte_de_Ventas (Id, Id_Café, Nombre, Cantidad, Precio, Total, Id_Cliente, Cliente, Fecha) Values ('{reporteDeVentas.Id}', '{reporteDeVentas.IdCafé}', '{reporteDeVentas.Nombre}', {reporteDeVentas.CantidadQuintales}, {reporteDeVentas.PrecioQuintal}, {reporteDeVentas.Total}, '{reporteDeVentas.IdCliente}', '{reporteDeVentas.Cliente}', CAST ('{convertirFecha}' As Date))";

                using (SqlCommand comando = new SqlCommand(insertar, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }

        public bool Modificar(ReporteDeVentas reporteDeVentas)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                DateTime recibirFecha = reporteDeVentas.FechaVenta;
                string convertirFecha;
                convertirFecha = recibirFecha.ToString("MM/dd/yyyy");

                string modificar = $"Update\n\t Reporte_de_Ventas Set Id = '{reporteDeVentas.Id}',\nId_Café = '{reporteDeVentas.IdCafé}',\nNombre = '{reporteDeVentas.Nombre}',\nCantidad = {reporteDeVentas.CantidadQuintales},\nPrecio = {reporteDeVentas.PrecioQuintal},\nTotal = {reporteDeVentas.Total},\nId_Cliente = '{reporteDeVentas.IdCliente}',\nCliente = '{reporteDeVentas.Cliente}',\nFecha = CAST('{convertirFecha}' As Date)\nWhere Id = '{reporteDeVentas.Id}'";

                using (SqlCommand comando = new SqlCommand(modificar, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }

        public bool Eliminar(ReporteDeVentas reporteDeVentas)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string eliminar = $"Delete From Reporte_de_Ventas\nWhere Id = '{reporteDeVentas.Id}'";

                using (SqlCommand comando = new SqlCommand(eliminar, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }
    }
}
