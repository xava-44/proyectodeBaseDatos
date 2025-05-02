using proyectodeBaseDatos.Consultas;
using proyectodeBaseDatos.medicamentos;
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
        MetodoMedicamento objec = new MetodoMedicamento();
        public AgregarMedic()
        {
            InitializeComponent();
        }

        private void AgregarMedic_Load(object sender, EventArgs e)
        {
           
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string nom = textBoxnombre.Text;
                int num = int.Parse(textBoxNUM_medic.Text);
                decimal precio = decimal.Parse(textBoxPrecio.Text);
                int cantidad = int.Parse(textBoxCantidad.Text);
                string descripcion = textBoxDescrip.Text;
                DateTime time = dateTimeCaducidad.Value;
                Medicamento nuevo = new Medicamento(num, nom, time, precio, cantidad, descripcion);
                objec.GuadarMedicamento(nuevo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error "+ex);
            }
            
         

        }

        private void labelcaduci_Click(object sender, EventArgs e)
        {

        }
        //foreach (DataGridViewRow row in tablamedicamentos.Rows)
        //{
        //    if (row.IsNewRow) continue;
        //    string nombre = row.Cells["nombre"].Value?.ToString();
        //    DateTime fechacaduci = Convert.ToDateTime(row.Cells["fecha_caducidad"].Value);
        //    string descripcion = row.Cells["descripcion"].Value?.ToString();
        //    decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);
        //    int cantidad = Convert.ToInt32(row.Cells["existencia"].Value),
        //     id = Convert.ToInt32(row.Cells["num_medicamento"].Value);


        //    Medicamento medicamento = new Medicamento(id, nombre, fechacaduci, precio, cantidad, descripcion);
        //    objec.GuadarMedicamento(medicamento);



        //}
        // DataTable tabla = objec.ListaMedicamento();
        //  tablamedicamentos.DataSource

    }
}
