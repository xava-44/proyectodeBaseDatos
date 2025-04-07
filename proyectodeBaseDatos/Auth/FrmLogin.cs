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

            Boolean registro = user.ObtenerRegistro(numempleado, passw);

            if (registro)
            {
                FrmAsistente formMenuAsistente = new FrmAsistente();
                formMenuAsistente.MdiParent = this;
                formMenuAsistente.Show();


            }
            else
            {
                MessageBox.Show("datos incorrectos ");
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
