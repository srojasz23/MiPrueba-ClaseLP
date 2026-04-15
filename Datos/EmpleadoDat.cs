using Datos.Data.Sql;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class EmpleadoDat
    {
        private readonly SqlConnection _cn;

        public EmpleadoDat()
        {
            _cn = Conexion.Instancia.ObtenerConexion();
        
        }


        public List<Empleado> Listar()
        {
            var lista = new List<Empleado>();
            string sql = @"SELECT e.*, a.Nombre AS NombreArea
                            FROM Empleados e
                         INNER JOIN Areas a ON e.IdArea = a.IdArea";

        }

    }
}
