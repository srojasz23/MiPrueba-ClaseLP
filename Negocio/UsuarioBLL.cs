using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio.BLL
{
    public class UsuarioBLL
    {
        private readonly UsuarioDat _dat = new UsuarioDat();

        public Usuario Login(string user, string pass)
        {
            var usuario = _dat.Login(user, pass);

            if (usuario == null) 
                throw new Exception("Usuario o contraseña incorrectos.");

            return usuario;


        }

    }
}
