using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Kardex:Café
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



        public string Tipo
        {
            get;
            set;
        }

        public string IdClienteProveedor
        {
            get;
            set;
        }

        public string ClienteProveedor
        {
            get;
            set;
        }

        public DateTime FechaEntradaSalida
        {
            get;
            set;
        }


        public Kardex(string idRecibir, float cantidadQuintalesRecibir,  decimal totalRecibir, string tipoRecibir, string idClienteProveedorRecibir, string clienteProveedorRecibir, DateTime fechaRecibir, string idCaféRecibir, string nombreRecibir, decimal precioQuintalRecibir): base(idCaféRecibir, nombreRecibir, precioQuintalRecibir)
        {
            Id = idRecibir;
            CantidadQuintales = cantidadQuintalesRecibir;
            Total = totalRecibir;
            Tipo = tipoRecibir;
            IdClienteProveedor = idClienteProveedorRecibir;
            ClienteProveedor = clienteProveedorRecibir;
            FechaEntradaSalida = fechaRecibir;
        }
    }
}
