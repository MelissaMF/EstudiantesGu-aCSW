using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Estudiante
    {
        public Estudiante() { }

        public Estudiante(int id, string rut, string nombre, String apellido, DateTime fechanacimiento)
        {
            this.ID = id;
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechanacimiento;
        }

        public Estudiante(string rut, string nombre, string apellido, DateTime fechanacimiento)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = (fechanacimiento);
        }

        public int ID { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }


    }
}
