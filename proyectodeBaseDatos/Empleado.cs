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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public double Sueldo { get; set; }
        public double Tel { get; set; }
        public double Bono { get; set; }
        public string Especialidad { get; set; }
        public bool Oficina { get; set; }
        private string Password { get; set; }

        public Empleado() { }

        public Empleado(int id, string name, double sueldo, double tel, double bono, string apellido, string password)
        {
            Id = id;
            Name = name;
            Apellido = apellido;
            Sueldo = sueldo;
            Tel = tel;
            Bono = bono;
            Password = password;
        }

        public Empleado(int id, string name, double sueldo, double tel, string apellido, string password, string especialidad)
        {
            Id = id;
            Name = name;
            Apellido = apellido;
            Sueldo = sueldo;
            Tel = tel;
            Especialidad = especialidad;
            Password = password;
        }

        public Empleado(int id, string name, double sueldo, double tel, string apellido, string password, bool oficina)
        {
            Id = id;
            Name = name;
            Apellido = apellido;
            Sueldo = sueldo;
            Tel = tel;
            Oficina = oficina;
            Password = password;
        }

        public string GetPassword()
        {
            return Password;
        }

        public override string ToString()
        {
            return $"Nombre:{Name},Apellido:{Apellido},ID:{Id},Telefono:{Tel},Sueldo:{Sueldo}";
        }

        public override bool Equals(object obj)
        {
            return obj is Empleado empleado &&
                   Id == empleado.Id &&
                   Name == empleado.Name &&
                   Sueldo == empleado.Sueldo &&
                   Tel == empleado.Tel &&
                   Bono == empleado.Bono &&
                   Especialidad == empleado.Especialidad &&
                   Oficina == empleado.Oficina;
        }

        public override int GetHashCode()
        {
            int hashCode = -462980273;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Sueldo.GetHashCode();
            hashCode = hashCode * -1521134295 + Tel.GetHashCode();
            hashCode = hashCode * -1521134295 + Bono.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Especialidad);
            hashCode = hashCode * -1521134295 + Oficina.GetHashCode();
            return hashCode;
        }
    }


}
