using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Existencias:Café
    {
        public float Existencia
        {
            get;
            set;
        }

        public decimal Total_Quetzales
        {
            get;
            set;
        }

        public Existencias(float recibirExistencia, decimal recibirTotalQuetzales, string idRecibir, string nombreRecibir, decimal precioQuintalRecibir) : base(idRecibir, nombreRecibir, precioQuintalRecibir)
        {
            Existencia = recibirExistencia;
            Total_Quetzales = recibirTotalQuetzales;
        }
    }
}
