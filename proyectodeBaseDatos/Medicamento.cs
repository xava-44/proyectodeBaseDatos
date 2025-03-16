using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectodeBaseDatos
{
    internal class Medicamento
    {
        private string nombre { get; set; }
        private int id { get; set; }
        private double fechacaduci {  get; set; }

        public Medicamento(string nombre, int id, double fechacaduci)
        {
            this.nombre = nombre;
            this.id = id;
            this.fechacaduci = fechacaduci;
        }

        public override string ToString()
        {
            return $"id:{id},nombre:{nombre},fecha de caducidad:{fechacaduci}";
        }
    }
}
