using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ReporteEmpleado
    {
                public string Areas { get; set; } = string.Empty;
                public int TotalEmpleados { get; set; }
                public Double SalarioPromedio { get; set; }
                public Double SalarioMaximo { get; set; }
                public Double SalarMinimo { get; set; }



    }

    public class ReporteContrato
    {
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public string DNI { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string TipoContrato { get; set; } = string.Empty;
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        public string EstadoContrato { get; set; } = string.Empty;

        public int MesesEnEmpresa { get; set; }

    }



}
