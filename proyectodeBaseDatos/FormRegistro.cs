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
            string puesto=domainUpDown1.Text;
             
            if (puesto== "Administrador")
            {
                String nom=textBoxname.Text;
                String apel = textBoxApellido.Text;
                int  NoEmplea=int.Parse(textBoxIDempleado.Text);
                double suel= double.Parse(textBoxSueldo.Text);
                int  tel=int.Parse(textBoxTelefono.Text);

                    Empleado nuevo = new Empleado(NoEmplea,nom,suel,tel,apel,true);


                string inf = nuevo.ToString();

                MessageBox.Show("se registro corretamente el Administrador: " + inf);
                
               metodos.Guardarempleado(nuevo);

            }
            else if (puesto =="Doctor")
            {
                String nom = textBoxname.Text;
                String apel = textBoxApellido.Text;
                int NoEmplea = int.Parse(textBoxIDempleado.Text);
                double suel = double.Parse(textBoxSueldo.Text);
                int tel = int.Parse(textBoxTelefono.Text);

                Empleado nuevo = new Empleado(NoEmplea, nom, suel, tel, apel,"pediatra");

                string inf = nuevo.ToString();

                MessageBox.Show("se registro corretamente el Doctor: " + inf);
                metodos.Guardarempleado (nuevo);
                

            }
            else if (puesto == "Encargado de farmacia")
            {
                String nom = textBoxname.Text;
                String apel = textBoxApellido.Text;
                int NoEmplea = int.Parse(textBoxIDempleado.Text);
                double suel = double.Parse(textBoxSueldo.Text);
                int tel = int.Parse(textBoxTelefono.Text);

                Empleado nuevo = new Empleado(NoEmplea, nom, suel, tel, 23242, apel);

                string inf=nuevo.ToString();
             
                MessageBox.Show("se registro corretamente el asistente:  " +inf);
                metodos.Guardarempleado(nuevo);
            }


            Form1 form1 = new Form1();
            form1.ShowDialog();





        }
















        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegresa_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
