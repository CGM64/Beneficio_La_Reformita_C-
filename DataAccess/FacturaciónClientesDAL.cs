using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class FacturaciónClientesDAL
    {
        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;

        public bool Insertar(FacturaciónClientes facturacionClientes)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                DateTime recibirFecha = facturacionClientes.FechaVenta;
                string convertirFecha;
                convertirFecha = recibirFecha.ToString("MM/dd/yyyy");

                string insertar = $"Insert Into Facturación_Clientes (Id, DPI, Nombre, NIT, Celular, Nombre_Café, Cantidad, Precio, Total, Fecha) Values ('{facturacionClientes.Id}', '{facturacionClientes.DPI}', '{facturacionClientes.Nombre}', '{facturacionClientes.NIT}', {facturacionClientes.Celular}, '{facturacionClientes.NombreCafé}', {facturacionClientes.Cantidad}, {facturacionClientes.Precio}, {facturacionClientes.Total}, CAST ('{convertirFecha}' As Date))";

                using (SqlCommand comando = new SqlCommand(insertar, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }

        public bool Modificar(FacturaciónClientes facturacionClientes)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                DateTime recibirFecha = facturacionClientes.FechaVenta;
                string convertirFecha;
                convertirFecha = recibirFecha.ToString("MM/dd/yyyy");

                string modificar = $"Update\n\t Facturación_Clientes Set Id = '{facturacionClientes.Id}',\nNombre_Café = '{facturacionClientes.NombreCafé}',\nCantidad = {facturacionClientes.Cantidad},\nPrecio = {facturacionClientes.Precio},\nTotal = {facturacionClientes.Total},\nFecha = CAST('{convertirFecha}' As Date)\nWhere Id = '{facturacionClientes.Id}'";

                using (SqlCommand comando = new SqlCommand(modificar, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }

        public bool Eliminar(FacturaciónClientes facturacionClientes)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string eliminar = $"Delete From Facturación_Clientes\nWhere Id = '{facturacionClientes.Id}'";

                using (SqlCommand comando = new SqlCommand(eliminar, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }
    }
}
