using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ReporteBLL
    {

        public readonly ReporteDat _dat = new ReporteDat();
        // reporte por area 

        public List<ReporteEmpleado> PorArea()
        {
            return _dat.PorArea();
        }

        //reporte contratos activos
        public List<ReporteContrato> Activos()
        {
            return _dat.Contratos("Activo");
        }


        // reporte vencidos
        public List<ReporteContrato> Vencidos()
        {
            return _dat.Contratos("Vencido");
        }

        // reporte de todos los contratos
        public List<ReporteContrato> Todos()
        {
            return _dat.Contratos();
        }

        //ALERTAS (POR VENCER Y VENCIDOS)
        public List<ReporteContrato> Alertas()
        {
            return _dat.Alertas();
        }

        // auditoria
        public void RegistrarLog(string nombre, string usuario)
        {
            _dat.Log(nombre, usuario);
        }

    }
}
