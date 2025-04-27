using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectodeBaseDatos.Doctor
{
    public partial class ForDoctor : Form
    {
        private int num_empleado;
        public ForDoctor(int num_empleado)
        {
            InitializeComponent();
            this.num_empleado = num_empleado;
        }
    }
}
