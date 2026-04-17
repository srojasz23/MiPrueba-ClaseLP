using Datos.Data.Sql;

using Entidad;

using Microsoft.Data.SqlClient;

using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



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



            using (var cn = Conexion.Instancia.ObtenerConexion())

            {

                string sql = @"SELECT e.*, a.Nombre AS NombreArea 

            FROM Empleados e 

            INNER JOIN Areas a ON e.IdArea = a.IdArea";



                using (var cmd = new SqlCommand(sql, cn))

                {

                    cn.Open();

                    var reader = cmd.ExecuteReader();



                    while (reader.Read())

                    {

                        lista.Add(new Empleado

                        {

                            IdEmpleado = (int)reader["IdEmpleado"],

                            Nombres = reader["Nombres"].ToString(),

                            Apellidos = reader["Apellidos"].ToString(),

                            DNI = reader["DNI"].ToString(),

                            Correo = reader["Correo"].ToString(),

                            Salario = Convert.ToDouble(reader["Salario"]),

                            FechaIngreso = (DateTime)reader["FechaIngreso"],

                            IdArea = (int)reader["IdArea"],

                            NombreArea = reader["NombreArea"].ToString()

                        });

                    }

                }

            }



            return lista;

        }



        public bool Insertar(Empleado emp)

        {

            string sql = @"INSERT INTO Empleados 

              (Nombres, Apellidos, DNI, Correo, Salario, FechaIngreso, IdArea)

              VALUES 

              (@Nombres, @Apellidos, @DNI, @Correo, @Salario, @FechaIngreso, @IdArea)";



            using (var cmd = new SqlCommand(sql, _cn))

            {

                cmd.Parameters.AddWithValue("@Nombres", emp.Nombres);

                cmd.Parameters.AddWithValue("@Apellidos", emp.Apellidos);

                cmd.Parameters.AddWithValue("@DNI", emp.DNI);

                cmd.Parameters.AddWithValue("@Correo", emp.Correo);

                cmd.Parameters.AddWithValue("@Salario", emp.Salario);

                cmd.Parameters.AddWithValue("@FechaIngreso", emp.FechaIngreso);

                cmd.Parameters.AddWithValue("@IdArea", emp.IdArea);



                _cn.Open();

                int filas = cmd.ExecuteNonQuery();

                _cn.Close();

                return filas > 0;

            }

        }



        public bool Actualizar(Empleado emp)

        {

            string sql = @"UPDATE Empleados SET

              Nombres=@Nombres, Apellidos=@Apellidos, DNI=@DNI,

              Correo=@Correo, Salario=@Salario, 

              FechaIngreso=@FechaIngreso, IdArea=@IdArea

              WHERE IdEmpleado=@IdEmpleado";



            using (var cmd = new SqlCommand(sql, _cn))

            {

                cmd.Parameters.AddWithValue("@IdEmpleado", emp.IdEmpleado);

                cmd.Parameters.AddWithValue("@Nombres", emp.Nombres);

                cmd.Parameters.AddWithValue("@Apellidos", emp.Apellidos);

                cmd.Parameters.AddWithValue("@DNI", emp.DNI);

                cmd.Parameters.AddWithValue("@Correo", emp.Correo);

                cmd.Parameters.AddWithValue("@Salario", emp.Salario);

                cmd.Parameters.AddWithValue("@FechaIngreso", emp.FechaIngreso);

                cmd.Parameters.AddWithValue("@IdArea", emp.IdArea);



                _cn.Open();

                int filas = cmd.ExecuteNonQuery();

                _cn.Close();

                return filas > 0;

            }

        }



        public bool Eliminar(int idEmpleado)

        {

            string sql = "DELETE FROM Empleados WHERE IdEmpleado = @Id";



            using (var cmd = new SqlCommand(sql, _cn))

            {

                cmd.Parameters.AddWithValue("@Id", idEmpleado);

                _cn.Open();

                int filas = cmd.ExecuteNonQuery();

                _cn.Close();

                return filas > 0;

            }

        }



    }

}