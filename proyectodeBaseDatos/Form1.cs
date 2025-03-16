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
    public partial class Form1 : Form
    {     
        MetodosEmpleados user=new MetodosEmpleados();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numempleado= int.Parse(textBoxNoEmpleado.Text);
            string passw=textBoxPassword.Text;
            
            Boolean registro=user.ObtenerRegistro(numempleado, passw);

            if (registro)
            {
                FormMenuAsistente formMenuAsistente = new FormMenuAsistente();
                formMenuAsistente.MdiParent = this;
                formMenuAsistente.Show();


            }else
            {
                MessageBox.Show("datos incorrectos ");

            }
           





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistro registro = new FormRegistro();
            registro.MdiParent = this;
            registro.Show();
            //this.Close();

        }
    }
}
