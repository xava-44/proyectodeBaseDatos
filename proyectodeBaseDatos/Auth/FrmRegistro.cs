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
            double suel = double.Parse(textBoxSueldo.Text);
            double tel = double.Parse(textBoxTelefono.Text);
            string password = textBoxPassword.Text;

            Empleado nuevo;
            string inf;

            switch (puesto)
            {
                case "Administrador":
                    nuevo = new Empleado(NoEmplea, nom, suel, tel, apel, password, true);
                    inf = nuevo.ToString();
                    metodos.Guardarempleado(nuevo);
                    MessageBox.Show("se registro corretamente el Administrador: " + inf);
                    break;
                case "Doctor":
                    nuevo = new Empleado(NoEmplea, nom, suel, tel, apel, password, "pediatra");
                    inf = nuevo.ToString();
                    MessageBox.Show("se registro corretamente el Doctor: " + inf);
                    metodos.Guardarempleado(nuevo);
                    break;
                case "Encargado de farmacia":
                    nuevo = new Empleado(NoEmplea, nom, suel, tel, 23242, apel, password);
                    inf = nuevo.ToString();
                    MessageBox.Show("se registro corretamente el asistente:  " + inf);
                    metodos.Guardarempleado(nuevo);
                    break;
                default:
                    MessageBox.Show("Puesto no reconocido.");
                    return;
            }

            FrmLogin form1 = new FrmLogin();
            form1.ShowDialog();
        }

        private void buttonRegresa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
