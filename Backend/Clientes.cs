using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Clientes:Persona
    {
        public string Id
        {
            get;
            set;
        }

        public Clientes(string idRecibir, string dpiRecibir, string nombreRecibir, string nitRecibir, long celularRecibir) : base(dpiRecibir, nombreRecibir, nitRecibir, celularRecibir)
        {
            Id = idRecibir;
        }
    }
}
