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

namespace proyectodeBaseDatos.Admin
{
    public partial class UserListaEmpleados : UserControl
    { 
        MetodosEmpleados metodo= new MetodosEmpleados();
        
        public UserListaEmpleados()
        {
            InitializeComponent();
        }

        private void UserListaEmpleados_Load(object sender, EventArgs e)
        {
            DataTable tabla = metodo.Listaempleados();
            dataGridViewLista.DataSource = tabla;
        }
    }
}
