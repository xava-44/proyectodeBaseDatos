using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectodeBaseDatos.Admin
{
    public partial class EliminarEmpleado : UserControl
    {
        MetodosEmpleados metodo=new MetodosEmpleados();
        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void buttEmliminar_Click(object sender, EventArgs e)
        {  
            int num =int.Parse(textBoxEliminar.Text);
            Boolean eliminado=metodo.EliminarEmpleado(num);
            if (eliminado) {
                MessageBox.Show("se elimino correctamente ");
            }
            else
            {
                MessageBox.Show("ocurrio un error al eliminar el empleado con el id: "+num);
            }
            textBoxEliminar.Clear();
        }
    }
}
