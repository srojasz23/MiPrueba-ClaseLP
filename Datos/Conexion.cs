using Microsoft.Data.SqlClient;
using System.Data.SqlClient;


namespace Datos.Data.Sql
{
    public class Conexion
    {

        // Patron Singleton
        private static Conexion _instancia; // aca se esta aplicando Singleton 
        private static readonly object _lock     = new object();

        private readonly string connectionString =
            //"Server=localhost;Database=SistemaEmpleados;Integrated Security=True;TrustServerCertificate=True;";
            "Server=localhost;Database=SistemaEmpleados;User Id=sa;Password=12345;TrustServerCertificate=True;";

        //aca vamos agregar un constructor privado para que nadie pueda hacer nueva conexion 

        private Conexion() { }              
        
        public static Conexion Instancia
        {
            get {
                lock (_lock)
                {
                    if (_instancia == null)
                        _instancia = new Conexion();
                    return _instancia;
                }
            
            }

        }


        public SqlConnection ObtenerConexion()
        { 
            return new SqlConnection(connectionString);
        
        }
    }
}
