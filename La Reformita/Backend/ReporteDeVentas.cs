using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ReporteDeVentas:Café
    {
        public string Id
        {
            get;
            set;
        }

        public float CantidadQuintales
        {
            get;
            set;
        }


        public decimal Total
        {
            get;
            set;
        }

        public string IdCliente
        {
            get;
            set;
        }

        public string Cliente
        {
            get;
            set;
        }

        public DateTime FechaVenta
        {
            get;
            set;
        }

        public ReporteDeVentas(string idRecibir, float cantidadQuintalesRecibir, decimal totalRecibir, string idClienteProveedorRecibir, string clienteProveedorRecibir, DateTime fechaRecibir, string idCaféRecibir, string nombreRecibir, decimal precioQuintalRecibir) : base(idCaféRecibir, nombreRecibir, precioQuintalRecibir)
        {
            Id = idRecibir;
            CantidadQuintales = cantidadQuintalesRecibir;
            Total = totalRecibir;
            IdCliente = idClienteProveedorRecibir;
            Cliente = clienteProveedorRecibir;
            FechaVenta = fechaRecibir;
        }
    }
}
