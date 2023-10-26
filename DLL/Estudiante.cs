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

        public Estudiante(int id, String nombre, String apellido, String fechanacimiento) {
            this.ID  = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechanacimiento;
        }

        public Estudiante(string nombre, string apellido, String fechanacimiento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento(fechanacimiento);
        }

        public int ID { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }


    }
}
