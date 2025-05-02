using proyectodeBaseDatos.medicamentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectodeBaseDatos.Asistente
{
    public partial class listamedicamentos : UserControl
    {
        MetodoMedicamento objec = new MetodoMedicamento();
        public listamedicamentos()
        {
            InitializeComponent();
        }

        private void listamedicamentos_Load(object sender, EventArgs e)
        {
            DataTable tabla = objec.ListaMedicamento();
            dataGridView_medic.DataSource =tabla;
        }
    }
}

