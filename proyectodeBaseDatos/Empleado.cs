using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectodeBaseDatos
{
    internal class Empleado
    {
        public int id;
        public string name;
        public string apellido;
        public double sueldo;
        public double tel;
        public double bono;
        public string especialidad;
        public Boolean oficina;
        private String password;


        public Empleado() { }

        public Empleado(int id, string name, double sueldo, double tel, double bono, string apellido, String password)
        {
            this.id = id;
            this.name = name;
            this.apellido = apellido;
            this.sueldo = sueldo;
            this.tel = tel;
            this.bono = bono;
            this.apellido = apellido;
            this.password = password;
        }

        public Empleado(int id, string name, double sueldo, double tel, string apellido, String password, string especialidad)
        {
            this.id = id;
            this.name = name;
            this.apellido = apellido;
            this.sueldo = sueldo;
            this.tel = tel;
            this.especialidad = especialidad;
            this.password = password;

        }

        public Empleado(int id, string name, double sueldo, double tel, string apellido, String password, bool oficina)
        {
            this.id = id;
            this.apellido = apellido;
            this.name = name;
            this.sueldo = sueldo;
            this.tel = tel;
            this.oficina = oficina;
            this.password = password;
        }
        public String getpassword()
        {
            return this.password;
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
