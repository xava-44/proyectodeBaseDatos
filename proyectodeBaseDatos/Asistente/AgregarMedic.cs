using proyectodeBaseDatos.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectodeBaseDatos.Asistente
{
    public partial class AgregarMedic : UserControl
    {
        MetodosEmpleados obje=new MetodosEmpleados();
        public AgregarMedic()
        {
            InitializeComponent();
        }

        private void AgregarMedic_Load(object sender, EventArgs e)
        {
            DataTable tabla = obje.Listaempleados();// tu método
            tablamedicamentos.DataSource = tabla;

        }

        //private void Mostrarelementos()
        //{
        //    Medicamentos.Items.Clear();
        //    foreach (int item in ListaMedic)
        //    {
        //        Medicamentos.Items.Add(item);
        //    }

        //}
    }
}
