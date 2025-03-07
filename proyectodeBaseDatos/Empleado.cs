using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectodeBaseDatos
{
    internal class Empleado
    {    
        private int id { get; } 
        private string name { get; set; }
        private string apellido { get; set; }
        private double sueldo {  get; set; }
        private int tel {  get; set; }
        private double bono { get; set; }
        private string especialidad { get; set; }
        private Boolean oficina {  get; set; }


        public Empleado() { }

        public Empleado(int id, string name, double sueldo, int tel, double bono, string apellido)
        {
            this.id = id;
            this.name = name;
            this.apellido = apellido;
            this.sueldo = sueldo;
            this.tel = tel;
            this.bono = bono;
            this.apellido = apellido;
        }

        public Empleado(int id, string name, double sueldo, int tel ,string apellido, string especialidad )
        {
            this.id = id;
            this.name = name;
            this.apellido=apellido;
            this.sueldo = sueldo;
            this.tel = tel;
            this.especialidad = especialidad;
        }

        public Empleado(int id, string name, double sueldo, int tel,string apellido, bool oficina)
        {
            this.id = id;
            this.apellido=apellido;
            this.name = name;
            this.sueldo = sueldo;
            this.tel = tel;
            this.oficina = oficina;
        }


        public override string ToString()
        {
            return $"Nombre:{name},Apellido:{apellido},ID:{id},Telefono:{tel},Sueldo:{sueldo}";
        }

        public override bool Equals(object obj)
        {
            return obj is Empleado empleado &&
                   id == empleado.id &&
                   name == empleado.name &&
                   sueldo == empleado.sueldo &&
                   tel == empleado.tel &&
                   bono == empleado.bono &&
                   especialidad == empleado.especialidad &&
                   oficina == empleado.oficina;
        }

        public override int GetHashCode()
        {
            int hashCode = -462980273;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + sueldo.GetHashCode();
            hashCode = hashCode * -1521134295 + tel.GetHashCode();
            hashCode = hashCode * -1521134295 + bono.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(especialidad);
            hashCode = hashCode * -1521134295 + oficina.GetHashCode();
            return hashCode;
        }
    }

    
}
