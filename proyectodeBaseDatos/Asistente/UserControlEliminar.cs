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
    public partial class UserControlEliminar : UserControl
    {   
        MetodoMedicamento metodo=new MetodoMedicamento();
        public UserControlEliminar()
        {
            InitializeComponent();
        }

        private void UserControlEliminar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBoxEliminar.Text);
            Boolean eliminado = metodo.EliminarMedicamento(num);
            if (eliminado)
            {
                MessageBox.Show("se elimino correctamente");

            }
            else
            {
                MessageBox.Show("ocurrio un error al eliminar el medicamento");
            }

        }
    }
}
