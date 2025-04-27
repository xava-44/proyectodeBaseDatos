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
        MetodosEmpleados user=new MetodosEmpleados();
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numempleado = int.Parse(textBoxNoEmpleado.Text);
            string passw = textBoxPassword.Text;
            
            int  registro = user.ObtenerRegistro(numempleado, passw);
            string rol= user.Regresarol(registro);

            Empleado u = user.RegresaEmpleado(registro);
            

            switch (rol)
            {
                case ("Administrador"):
                   FrmAdmin frmAdmin = new FrmAdmin(registro);
                   frmAdmin.MdiParent = this;
                    frmAdmin.Show();
                
                    break;
                case ("Auxiliar"):
                    FrmAsistente formMenuAsistente = new FrmAsistente(registro);
                    formMenuAsistente.MdiParent = this;
                    formMenuAsistente.Show();

                    break;
                case ("Doctor"):
                    ForDoctor forDoctor = new ForDoctor(registro);
                    forDoctor.MdiParent = this;
                    forDoctor.Show();
                    break;
                default:
                    MessageBox.Show("datos incorrectos ");
                    break;
            }
        }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                FrmRegistro registro = new FrmRegistro();
                registro.MdiParent = this;
                registro.Show();
                //this.Close();

            }
        }
}
