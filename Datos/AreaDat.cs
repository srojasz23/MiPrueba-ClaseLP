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

    public class AreaDat

    {



        public List<Area> Listar()

        {

            var lista = new List<Area>();



            using (var cn = Conexion.Instancia.ObtenerConexion())

            {

                string sql = "SELECT * FROM Areas";



                using (var cmd = new SqlCommand(sql, cn))

                {

                    cn.Open();

                    var dr = cmd.ExecuteReader();



                    while (dr.Read())

                    {

                        lista.Add(new Area

                        {

                            IdArea = (int)dr["IdArea"],

                            Nombre = dr["Nombre"].ToString()

                        });

                    }

                }

            }



            return lista;

        }

    }

}