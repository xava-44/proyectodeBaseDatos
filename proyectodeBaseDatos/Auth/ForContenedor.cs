using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectodeBaseDatos.Auth
{
    public partial class ForContenedor : Form
    {
        public ForContenedor()
        {
            InitializeComponent();
            this.Load += ForContenedor_Load;
        }

        private void ForContenedor_Load(object sender, EventArgs e)
        {
           // this.Opacity = 0;
           // this.ShowInTaskbar = false;

            // Lanza el formulario principal de trabajo
            var formInicio = new FrmLogin();
            formInicio.MdiParent = this;
            formInicio.FormClosed += (s, args) =>
            {
                // Cuando cierre el formulario principal, cierra la app
                this.Close();
            };

            formInicio.Show();




        }
    }
}
