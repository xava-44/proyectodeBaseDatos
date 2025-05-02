using proyectodeBaseDatos.Admin;
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
using ZstdSharp.Unsafe;

namespace proyectodeBaseDatos
{
    public partial class FrmAdmin: Form
    {    

        MetodosEmpleados metodo=new MetodosEmpleados();
        Empleado empleado;
        private int num_empleado;
        public FrmAdmin(int num_empleado)
        {
            InitializeComponent();
            this.num_empleado = num_empleado;
        }

        private void btnConsultarMedicamento_Click(object sender, EventArgs e)
        {

        }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdmin.Controls.Clear();
            EliminarEmpleado delete= new EliminarEmpleado();
            delete.Dock = DockStyle.Fill;
            panelAdmin.Controls.Add(delete);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_shown(object sender, EventArgs e)
        {
            empleado= metodo.RegresaEmpleado(num_empleado);

            labelbienvenida.Text = "Bienvenido " + empleado.Name + " " + empleado.Apellido;
        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdmin.Controls.Clear();
            UserListaEmpleados listaEmpleados = new UserListaEmpleados();
            listaEmpleados.Dock = DockStyle.Fill;
            panelAdmin.Controls.Add(listaEmpleados);
        }
    }
}
