using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class FacturaciónClientes:Persona
    {
        public string Id
        {
            get;
            set;
        }

        public string NombreCafé
        {
            get;
            set;
        }

        public float Cantidad
        {
            get;
            set;
        }

        public decimal Precio
        {
            get;
            set;
        }

        public decimal Total
        {
            get;
            set;
        }

        public DateTime FechaVenta
        {
            get;
            set;
        }

        public FacturaciónClientes(string idRecibir, string nombreCafeRecibir, float cantidadRecibir, decimal precioRecibir, decimal totalRecibir, DateTime fechaRecibir, string dpiRecibir, string nombreRecibir, string nitRecibir, long celularRecibir) : base(dpiRecibir, nombreRecibir, nitRecibir, celularRecibir)
        {
            Id = idRecibir;
            NombreCafé = nombreCafeRecibir;
            Cantidad = cantidadRecibir;
            Precio = precioRecibir;
            Total = totalRecibir;
            FechaVenta = fechaRecibir;
        }
    }
}
