using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectodeBaseDatos
{   
    internal interface IEmpleado
    {

        void Guardarempleado(Empleado empleado);
        List<Empleado> Listaempleados();
        Boolean EliminarEmpleado(Empleado empleado);
    




    }

}
