using proyectodeBaseDatos.Doctor;
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
    public partial class FrmLogin : Form
    {
        MetodosEmpleados user = new MetodosEmpleados();
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numempleado = int.Parse(textBoxNoEmpleado.Text);
            string passw = textBoxPassword.Text;

            int registro = user.ObtenerRegistro(numempleado, passw);
            string rol = user.Regresarol(registro);

            Empleado u = user.RegresaEmpleado(registro);


            switch (rol)
            {
                case ("Administrador"):

                    this.Hide();
                    using (var nuevo = new FrmAdmin(registro))
                    {
                        nuevo.ShowDialog();
                    }

                    this.Show();
                    textBoxNoEmpleado.Clear();
                    textBoxPassword.Clear();

                    break;
                case ("Auxiliar"):

                    this.Hide();
                    using (var nuevo = new FrmAsistente(registro))
                    {
                        nuevo.ShowDialog();
                    }
                    this.Show();
                    textBoxNoEmpleado.Clear();
                    textBoxPassword.Clear();
                    break;
                case ("Doctor"):
                    this.Hide();
                    using (var nuevo = new ForDoctor(registro))
                    {
                        nuevo.ShowDialog();
                    }
                    this.Show();
                    textBoxNoEmpleado.Clear();
                    textBoxPassword.Clear();
                    break;
                default:
                    MessageBox.Show("datos incorrectos ");

                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            this.Hide();
            using (var nuevo = new FrmRegistro())
            {
                nuevo.ShowDialog();
            }
            this.Show();

        }
    }
}
