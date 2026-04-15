using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } 
        public string PasswordHash { get; set; }

       public string Rol {  get; set; }

    }
}
