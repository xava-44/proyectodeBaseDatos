using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace proyectodeBaseDatos
{
    internal class MetodosEmpleados : IEmpleado
    {

        Conexion conne = new Conexion();

        public bool EliminarEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public void Guardarempleado(Empleado empleado)
        {
            try
            {
                string sentencia_empleado = "INSERT INTO empleado (nombre,apellido,sueldo,telefono) VALUES (@nombre,@apellido,@sueldo,@telefono)";

                var parametros = new Dictionary<string, object>
            {
                {"@nombre",empleado.name },
                {"@apellido",empleado.apellido},
                {"@sueldo",empleado.sueldo},
                {"@telefono",empleado.tel }

            };

                int ID = conne.ExecuteNonQuery(sentencia_empleado, parametros, true);

                if (ID <= 0)
                {

                    throw new Exception("ocurrio un error al agregar empleado");
                }


                string sentenciausuario = "INSERT INTO usuario(numempleado,password,idempleado)VALUES(@numempleado,@password,@idempleado)";

                int has = FuncionHashPolinomial(empleado.getpassword());

                var paramer = new Dictionary<string, object>
            {
                {"@numempleado",empleado.id},
                {"@password",has },
                {"@idempleado",ID }

            };

                int filas = conne.ExecuteNonQuery(sentenciausuario, paramer, false);

                if (filas <= 0)
                {

                    throw new Exception("ocurrio un error al agregar empleado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error " + ex.Message);

            }
        }

        public List<Empleado> Listaempleados()
        {
            throw new NotImplementedException();
        }

        public Boolean ObtenerRegistro(int NumEmpleado, string Password)
        {
            string query = "SELECT numempleado FROM usuario WHERE numempleado=@numempleado";
            var paramer = new Dictionary<string, int>
            {
                {"@numempleado",NumEmpleado}

              };

            int registroempleado = conne.RegresaDatosEmpleado(query, paramer);

            int convertirpassword = FuncionHashPolinomial(Password);

            string sentencia = "SELECT password FROM usuario WHERE password=@password";
            paramer.Add("@password", convertirpassword);

            int registro_password = conne.RegresaDatosEmpleado(sentencia, paramer);

            if (registroempleado == NumEmpleado && registro_password == convertirpassword)
            {
                return true;

            }
            else
            {


                return false;
            }

        }



        static int FuncionHashPolinomial(string clave)
        {
            const int basePolinomial = 31; // Base comúnmente usada para funciones hash
            int hash = 0;

            for (int i = 0; i < clave.Length; i++)
            {
                // Convertir carácter a su valor ASCII y multiplicar por la potencia de la base
                hash = (hash * basePolinomial + clave[i]);
            }
            MessageBox.Show("digo has" + hash);
            // Asegurarse de que el resultado sea positivo
            return Math.Abs(hash);
        }


    }
}
