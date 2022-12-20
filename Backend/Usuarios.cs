using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Usuarios
    {
        public string Id
        {
            get;
            set;
        }

        public string Usuario { 
            get; 
            set; 
        }

        public string Contraseña
        {
            get;
            set;
        }

        public Usuarios(string idRecibir, string usuarioRecibir, string contrasenaRecibir)
        {
            Id = idRecibir;
            Usuario = usuarioRecibir;
            Contraseña = contrasenaRecibir;
        }
    }
}
