using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Persona
    {
        public string DPI { 
            get; 
            set; 
        }

        public string Nombre { 
            get; 
            set; 
        }

        public string NIT { 
            get; 
            set; 
        }

        public long Celular
        {
            get;
            set;
        }

        public Persona(string dpiRecibir, string nombreRecibir, string nitRecibir, long celularRecibir)
        {
            DPI = dpiRecibir;
            Nombre = nombreRecibir;
            NIT = nitRecibir;
            Celular = celularRecibir;
        }
    }
}
