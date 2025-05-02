using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectodeBaseDatos.medicamentos
{
    internal interface Imedicamentos
    {

        void GuadarMedicamento(Medicamento medicamneto);
        DataTable ListaMedicamento();
        Boolean EliminarMedicamento(int id_medicamento);    
        Medicamento ModificarMedicamento(Medicamento medicamento);
    }
}
