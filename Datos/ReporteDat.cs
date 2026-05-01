using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data.Sql;
using Entidad;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class ReporteDat
    {
        public List<ReporteEmpleado> PorArea()
        {
            var lista = new List<ReporteEmpleado>();

            using var cn = Conexion.Instancia.ObtenerConexion();

            var cmd = new SqlCommand("SELECT * FROM vw_ReporteEmpleadosPorArea", cn);

            cn.Open();

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new ReporteEmpleado
                {
                    Areas = dr["Area"].ToString(),
                    TotalEmpleados = Convert.ToInt32(dr["TotalEmpleados"]),
                    SalarioPromedio = Convert.ToDouble(dr["SalarioPromedio"]),
                    SalarioMaximo = Convert.ToDouble(dr["SalarioMaximo"]),
                    SalarioMinimo = Convert.ToDouble(dr["SalarioMinimo"])
                });
            }

            return lista;
        }


        public List<ReporteContrato> Contratos(string estado = null)
        {

            var lista = new List<ReporteContrato>();
            using var cn = Conexion.Instancia.ObtenerConexion();
            string sql = "SELECT * FROM vw_ReporteContratos";
            if (!string.IsNullOrEmpty(estado))
            {
                sql += " WHERE EstadoContrato = @Estado";
            }

            var cmd = new SqlCommand(sql, cn);
            if (!string.IsNullOrEmpty(estado))
            {
                cmd.Parameters.AddWithValue("@Estado", estado);
            }

            cn.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new ReporteContrato
                {
                    IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]),
                    NombreCompleto = dr["NombreCompleto"].ToString(),
                    DNI = dr["DNI"].ToString(),
                    Area = dr["Area"].ToString(),
                    TipoContrato = dr["TipoContrato"].ToString(),
                    FechaInicio = Convert.ToDateTime(dr["FechaInicio"]),
                    FechaFin = dr["FechaFin"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["FechaFin"]),
                    EstadoContrato = dr["EstadoContrato"].ToString(),
                    MesesEnEmpresa = Convert.ToInt32(dr["MesesEnEmpresa"])
                });
            }
            return lista;
        }



        public List<ReporteContrato> Alertas()
        {
            var lista = new List<ReporteContrato>();
            using var cn = Conexion.Instancia.ObtenerConexion();

            var cmd = new SqlCommand("SELECT * FROM vw_AlertasContratos", cn);


            cn.Open();


            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new ReporteContrato
                {

                    NombreCompleto = dr["NombreCompleto"].ToString()!,
                    Area = dr["Area"].ToString()!,
                    EstadoContrato = dr["EstadoContrato"].ToString()!,

                });
            }
            return lista;

        }


        public void Log(string nombre, string usuario)
        {
            using var cn = Conexion.Instancia.ObtenerConexion();
            var cmd = new SqlCommand("INSERT INTO ReportesGenerados (NombreReporte, Usuario) VALUES (@n, @u)", cn);

            cmd.Parameters.Add(new SqlParameter("@n", nombre));
            cmd.Parameters.Add(new SqlParameter("@u", usuario));

            cn.Open();
            cmd.ExecuteNonQuery();
        }

    }
}
