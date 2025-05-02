using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectodeBaseDatos
{
    public partial class FrmRegistro : Form
    {
        Empleado Empleado;
        IEmpleado metodos = new MetodosEmpleados();

        public FrmRegistro()
        {
            InitializeComponent();
            Empleado = new Empleado();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string puesto = domainUpDown1.Text;
            string nom = textBoxname.Text;
            string apel = textBoxApellido.Text;
            int NoEmplea = int.Parse(textBoxIDempleado.Text);
            decimal suel = decimal.Parse(textBoxSueldo.Text);
            double tel = double.Parse(textBoxTelefono.Text);
            string password = textBoxPassword.Text;

            string inf;
           Empleado = new Empleado(NoEmplea, nom, suel, tel, apel, password);
            inf = Empleado.ToString();
            metodos.Guardarempleado(Empleado, puesto);
            MessageBox.Show("se registro corretamente el Administrador: " + inf);

            


            //FrmLogin form1 = new FrmLogin();
            //form1.ShowDialog();
        }

        private void buttonRegresa_Click(object sender, EventArgs e)
        {


            FrmLogin form1 = new FrmLogin();
            form1.ShowDialog();
            //this.Close();
        }
    }
}
