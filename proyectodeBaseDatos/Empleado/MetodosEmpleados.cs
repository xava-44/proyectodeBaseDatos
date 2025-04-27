using System;
using System.Collections.Generic;
using System.Data;
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

        public void Guardarempleado(Empleado empleado, string puesto)
        {
            try
            {
                string puestoID = "SELECT id FROM roles WHERE nombre=@nombre ";

                var paramer = new Dictionary<string, object>
            {
                {"@nombre",puesto}

            };

                int idpuesto = conne.VerificaUsuario(puestoID, paramer);

                int has = FuncionHashPolinomial(empleado.GetPassword());


                string sentencia_empleado = "INSERT INTO usuario (nombre,apellido,telefono,sueldo,id_rol,num_empleado,password) " +
                    "VALUES (@nombre,@apellido,@telefono,@sueldo,@rol,@num_empl,@pass)";

                var parametros = new Dictionary<string, object>
            {
                    {"@nombre",empleado.Name },
                    {"@apellido",empleado.Apellido},
                    {"@telefono",empleado.Tel },
                    {"@sueldo",empleado.Sueldo},
                    {"@rol",idpuesto},
                    {"@num_empl",empleado.Id },
                    {"@pass",has }
             };

                int ID = conne.ExecuteNonQuery(sentencia_empleado, parametros);

                if (ID <= 0)
                {

                    throw new Exception("ocurrio un error al agregar empleado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error " + ex.Message);

            }
        }

        public DataTable Listaempleados()
        {
            string coman = "SELECT * FROM usuario";

            var tabla = conne.RegresaDataTable(coman,null);

            return tabla;
        }

        public int ObtenerRegistro(int NumEmpleado, string Password)
        {
            int registro;
            int convertirpassword = FuncionHashPolinomial(Password);

            string queryVerifica = @"
             SELECT u.num_empleado
             FROM usuario u
             WHERE u.num_empleado = @numempleado AND u.password = @password";

            var parametrosVerifica = new Dictionary<string, object>
             {
                { "@numempleado", NumEmpleado },
                { "@password", convertirpassword }
             };
            registro = conne.VerificaUsuario(queryVerifica, parametrosVerifica);

            if (registro == NumEmpleado)
            {
                return registro;
            }
            else {

                return -1;

            }

        }


        public string Regresarol(int NumEmpleado)
        {
            string rol = "";
            string sentencia = @"SELECT r.nombre FROM usuario u 
                JOIN roles r ON u.id_rol = r.id WHERE u.num_empleado = @num_empleado";
            var parametr = new Dictionary<string, object>
                {
                    {"@num_empleado",NumEmpleado }

                };
            rol=conne.RegresaDatos(sentencia, parametr);
            return rol;

        }

        public string Regresadatos(int No_empleado, string sentencia)
        {
            String dato_usuario = "";

            switch (sentencia)
            {
                case ("rol"):
                    sentencia = @"SELECT r.nombre FROM usuario u 
                JOIN roles r ON u.id_rol = r.id WHERE u.num_empleado = @num_empleado";
                    break;
                case ("nombre"):
                    sentencia = "SELECT u.nombre FROM usuario u WHERE u.num_empleado = @num_empleado";

                    break;
                case ("apellido"):
                    sentencia = "SELECT u.apellido FROM usuario u WHERE u.num_empleado = @num_empleado";
                    break;
                default:

                    MessageBox.Show("el valor del usuario a buscar es incorrecto");
                    return "";
            }

            var parametr = new Dictionary<string, object>
                {
                    {"@num_empleado",No_empleado }

                };

            return dato_usuario = conne.RegresaDatos(sentencia, parametr);

        }

        public Empleado RegresaEmpleado(int No_empleado)
        {
            string sentencia = @"SELECT nombre, apellido,telefono,sueldo,id_rol,
                        num_empleado,password
                         FROM usuario 
                         WHERE num_empleado = @num_empleado";

            var parametros = new Dictionary<string, object>
            {
              {"@num_empleado", No_empleado}
            };

            var dt = conne.RegresaDataTable(sentencia, parametros); 

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Usuario no encontrado");
                return null;
            }

            var fila = dt.Rows[0];

            string Nombre = fila["nombre"].ToString(),Apellido = fila["apellido"].ToString();

            double Telefono = double.Parse(fila["telefono"].ToString()); 
            decimal Sueldo = Convert.ToDecimal(fila["sueldo"]);
            int IdRol = Convert.ToInt32(fila["id_rol"]),NumEmpleado = Convert.ToInt32(fila["num_empleado"]);
            string Password = fila["password"].ToString();
           
            Empleado Empleado = new Empleado(NumEmpleado,Nombre,Sueldo,Telefono,Apellido,Password);
            return Empleado;
            
           
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

            // Asegurarse de que el resultado sea positivo
            return Math.Abs(hash);
        }


    }
}
