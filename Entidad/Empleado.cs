using Entidad;

namespace Entidad
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombres { get; set; } = string.Empty;

        public string Apellidos { get; set; } = string.Empty;

        public string DNI { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;

        public double Salario { get; set; }
        
        public DateTime FechaIngreso {  get; set; }

        public int IdArea { get; set; }

        public string NombreArea { get; set; } = string.Empty;


        public string NombrCompleto => $"{Nombres} {Apellidos}";
    }
}

