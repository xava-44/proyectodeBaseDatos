using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectodeBaseDatos
{
    internal class Medicamento
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public DateTime fechacaduci {  get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }

        public Medicamento(int id ,string nombre,DateTime fechacaduci,decimal precio, int cantidad, string descripcion)
        {
            this.nombre = nombre;
            this.id = id;
            this.fechacaduci = fechacaduci;
            this.precio = precio;
            this.cantidad = cantidad;   
            this.descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"id:{id},nombre:{nombre},fecha de caducidad:{fechacaduci},Precio:{precio},Descripcion:{descripcion}";
        }



    }
}
