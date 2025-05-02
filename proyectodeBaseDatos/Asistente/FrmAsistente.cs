using proyectodeBaseDatos.Asistente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectodeBaseDatos
{
    public partial class FrmAsistente : Form
    {

        private int num_empleado;
        Empleado Empleado;
        MetodosEmpleados metodos = new MetodosEmpleados();
     

        public FrmAsistente(int num_empleado)
        {
            InitializeComponent();
            labelbienvenida.Text = "";
            this.num_empleado = num_empleado;

        }

        private void label_shown(object sender, EventArgs e)
        {
           
            Empleado=metodos.RegresaEmpleado(num_empleado);
            labelbienvenida.Text = "Bienvenido "+Empleado.Name+" "+Empleado.Apellido;
        }

        private void FrmAsistente_Load(object sender, EventArgs e)
        {

        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            listamedicamentos agregar = new listamedicamentos();
            agregar.Dock = DockStyle.Fill;
            panel1.Controls.Add(agregar);

        }

        private void agregarMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AgregarMedic agregar = new AgregarMedic();
            agregar.Dock = DockStyle.Fill;
            panel1.Controls.Add(agregar);
        }

        private void modificarMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlModificar agregar = new UserControlModificar();
            agregar.Dock = DockStyle.Fill;
            panel1.Controls.Add(agregar);
        }

        private void eliminarMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlEliminar eliminar = new UserControlEliminar();
            eliminar.Dock = DockStyle.Fill; ;
            panel1.Controls.Add(eliminar);
        }
    }
}
