

using Datos;
using Entidad;

namespace Negocio
{
    public class EmpleadoBLL
    {
        private readonly EmpleadoDat _dal = new EmpleadoDat();

        public List<Empleado> ObtenerTodos() => _dal.Listar();

        public bool Registrar(Empleado emp)
        {
            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(emp.Nombres))
                throw new System.Exception("El nombre es obligatorio.");
            if (emp.DNI.Length != 8)
                throw new System.Exception("El DNI debe tener 8 dígitos.");
            if (emp.Salario <= 0)
                throw new System.Exception("El salario debe ser mayor a 0.");

            return _dal.Insertar(emp);
        }

        public bool Modificar(Empleado emp) => _dal.Actualizar(emp);

        public bool Eliminar(int id) => _dal.Eliminar(id);

        // para registrar el contrato del empleado 
        public bool RegistrarConContrato(Empleado emp, DateTime inicio, DateTime? fin, string tipo, string rol)
        {
            
            
            if(rol !="Admin")
                throw new System.Exception("Solo Administradores pueden registra contrato");

            return _dal.InsertarConContrato(emp, inicio, fin, tipo);

            /* Solo registrar al empleado con contrato, sin validacion de rol.
            if (string.IsNullOrWhiteSpace(tipo))
                throw new Exception("Tipo de contrato Obligatorio");

            return _dal.InsertarConContrato(emp, inicio, fin, tipo);
            */


        }





    }
}

