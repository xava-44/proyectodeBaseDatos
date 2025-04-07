using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace proyectodeBaseDatos
{
    internal class Conexion
    {
        private string conexionstring = "Server=localhost;Database=BDMedical;Uid=root;Pwd=admin;";

        private MySqlConnection getConnection()
        {
            return new MySqlConnection(conexionstring);
        }

        // metodo que recibe el query y una coleccion con llave (string) ,valor (objet)
        public int ExecuteNonQuery(string query, Dictionary<string, object> parametros, Boolean agregar)
        {
            using (MySqlConnection conn = getConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // se itera la coleccion parametros
                foreach (var parametro in parametros)
                {
                    // al comando usa el metodo de parametros y este usa un metod para agregar con llave y valores
                    cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }
                if (agregar)
                {
                    cmd.ExecuteNonQuery();
                    int idEmpleado;
                    string obtenerid = "SELECT LAST_INSERT_ID()";
                    using (var comand = new MySqlCommand(obtenerid, conn))
                    {
                        idEmpleado = Convert.ToInt32(comand.ExecuteScalar());
                    }
                    return idEmpleado;
                }
                else
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int RegresaDatosEmpleado(string query, Dictionary<string, int> parametros)
        {
            using (MySqlConnection conn = getConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                foreach (var parametro in parametros)
                {
                    cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }
                object resultado = cmd.ExecuteScalar();

                // Verificar si el resultado es nulo
                if (resultado == DBNull.Value || resultado == null)
                {
                    return -1;
                }

                // Convertir el resultado a int
                int valorResultado = Convert.ToInt32(resultado);

                return valorResultado;
            }
        }
    }
    }
