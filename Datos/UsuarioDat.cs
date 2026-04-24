using Datos.Data.Sql;
using Entidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDat
    {
        public Usuario Login(string user, string pass)
        {
            using (var cn = Conexion.Instancia.ObtenerConexion())
            {
                string sql = "SELECT * FROM Usuario WHERE Usuario=@u and PasswordHash=@p";

                using (var cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@u", user); 
                    cmd.Parameters.AddWithValue("@p", pass); 

                    cn.Open();
                    var dr = cmd.ExecuteReader();

                    if (dr.Read()) 
                    {
                        return new Usuario
                        {
                            IdUsuario = (int)dr["IdUsuario"],
                            NombreUsuario = dr["Usuario"].ToString(),
                            Rol = dr["Rol"].ToString()
                        };
                    }
                }

            }

            return null;
        }

    }
}
