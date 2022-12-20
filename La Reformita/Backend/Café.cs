using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Café
    {
        public string IdCafé { 
            get; 
            set; 
        }

        public string Nombre { 
            get; 
            set; 
        }

        public decimal PrecioQuintal { 
            get; 
            set; 
        }

        public Café(string idRecibir, string nombreRecibir, decimal precioQuintalRecibir)
        {
            IdCafé = idRecibir;
            Nombre = nombreRecibir;
            PrecioQuintal = precioQuintalRecibir;
        }
    }
}
