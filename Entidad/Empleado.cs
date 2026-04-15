using Entidad;

namespace Entidad
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string DNI { get; set; } 

        public string Correo { get; set; }

        public double Salario { get; set; }
        
        public DateTime FechaIngreso {  get; set; }

        public int IdArea { get; set; }

        public string NombreArea { get; set; }


        public string NombrCompleto => $"{Nombres} {Apellidos}";
    }
}

