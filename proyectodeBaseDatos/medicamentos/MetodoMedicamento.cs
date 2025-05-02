using proyectodeBaseDatos.Consultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace proyectodeBaseDatos.medicamentos 
{
    internal class MetodoMedicamento : Imedicamentos

    {
        Conexion conne=new Conexion();
        public bool EliminarMedicamento(int id_medicamento)
        {
            
            string eliminarmedic = "DELETE FROM medicamentos WHERE num_medicamento= @num_medicamento";
            var parametros = new Dictionary<string, object>
            {
                {"@num_medicamento",id_medicamento }

            };
            int ID = conne.ExecuteNonQuery(eliminarmedic, parametros);

            if (ID <= 0)
            {

                throw new Exception("ocurrio un error al eliminar medicamento");
                
            }
            
            
            return true;
            
        }

        public void GuadarMedicamento(Medicamento medicamneto)
        {
            try
            {

                string sentencia_empleado = "INSERT INTO medicamentos (nombre,fecha_caducidad,descripcion,precio,existencia,num_medicamento) " +
                    "VALUES (@nombre,@fecha,@descripcion,@precio,@existen,@num_medic)";

                var parametros = new Dictionary<string, object>
            {
                    {"@nombre",medicamneto.nombre},
                    {"@fecha",medicamneto.fechacaduci},
                    {"@descripcion",medicamneto.descripcion },
                    {"@precio",medicamneto.precio},
                    {"@existen",medicamneto.cantidad},
                    {"@num_medic",medicamneto.id },

             };

                int ID = conne.ExecuteNonQuery(sentencia_empleado, parametros);

                if (ID <= 0)
                {

                    throw new Exception("ocurrio un error al agregar medicamento");
                }

            }
            catch (Exception ex)
            {
             MessageBox.Show("ocurrio un error " + ex.Message);

            }
        }

        public DataTable ListaMedicamento()
        {

            string coman = "SELECT * FROM medicamentos";

            var tabla = conne.RegresaDataTable(coman, null);
           
            if (tabla.Columns.Contains("id"))
                tabla.Columns.Remove("id");
            return tabla;
            
        }

        public Medicamento ModificarMedicamento(Medicamento medicamento)
        {    
            throw new NotImplementedException();
        }
    }
}
