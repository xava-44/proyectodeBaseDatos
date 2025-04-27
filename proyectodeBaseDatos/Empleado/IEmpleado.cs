using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectodeBaseDatos
{   
    internal interface IEmpleado
    {

        void Guardarempleado(Empleado empleado, string puesto );
        DataTable Listaempleados();
        Boolean EliminarEmpleado(Empleado empleado);
    




    }

}
