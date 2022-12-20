using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Proveedores:Persona
    {
        public string Id { 
            get; 
            set; 
        }

        public Proveedores(string idRecibir, string dpiRecibir, string nombreRecibir, string nitRecibir, long celularRecibir): base(dpiRecibir, nombreRecibir, nitRecibir, celularRecibir)
        {
            Id = idRecibir;
        }
    }
}
