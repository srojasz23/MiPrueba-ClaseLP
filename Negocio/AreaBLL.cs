using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Negocio.BLL

{

    public class AreaBLL

    {

        private readonly AreaDat _dat = new AreaDat();

        public List<Area> ObtenerAreas()

        {

            return _dat.Listar();

        }

    }

}