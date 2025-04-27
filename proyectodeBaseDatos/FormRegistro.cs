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
    public partial class FormRegistro : Form

    {
        Empleado Empleado;
        IEmpleado metodos = new MetodosEmpleados();
        public FormRegistro()
        {
            InitializeComponent();
            Empleado = new Empleado();


        }




        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string puesto = domainUpDown1.Text;

            String nom = textBoxname.Text;
            String apel = textBoxApellido.Text;
            int NoEmplea = int.Parse(textBoxIDempleado.Text);
            double suel = double.Parse(textBoxSueldo.Text);
            double tel = double.Parse(textBoxTelefono.Text);
            String password = textBoxPassword.Text;

            if (puesto == "Administrador")
            {
                Empleado nuevo = new Empleado(NoEmplea, nom, suel, tel, apel, password, true);
                string inf = nuevo.ToString();


                metodos.Guardarempleado(nuevo);
                MessageBox.Show("se registro corretamente el Administrador: " + inf);


            }
            else if (puesto == "Doctor")
            {

                Empleado nuevo = new Empleado(NoEmplea, nom, suel, tel, apel, password, "pediatra");

                string inf = nuevo.ToString();

                MessageBox.Show("se registro corretamente el Doctor: " + inf);
                metodos.Guardarempleado(nuevo);



            }
            else if (puesto == "Encargado de farmacia")
            {
                Empleado nuevo = new Empleado(NoEmplea, nom, suel, tel, 23242, apel, password);

                string inf = nuevo.ToString();

                MessageBox.Show("se registro corretamente el asistente:  " + inf);
                metodos.Guardarempleado(nuevo);
            }


            Form1 form1 = new Form1();
            form1.Show();





        }
















        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegresa_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
