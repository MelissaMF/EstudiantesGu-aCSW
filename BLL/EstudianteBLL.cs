using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class EstudianteBLL
    {
        private EstudianteDAL estudianteDAL;

        public EstudianteBLL()
        {
            estudianteDAL = new EstudianteDAL();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            if (string.IsNullOrEmpty(estudiante.Rut))
            {
                throw new Exception("Rut no puede estar vacío");
            }
            if (string.IsNullOrEmpty(estudiante.Nombre))
            {
                throw new Exception("Nombre no puede estar vacío");
            }
            if (string.IsNullOrEmpty(estudiante.Apellido))
            {
                throw new Exception("Rut no puede estar vacío");
            }

            Estudiante existeEstudiante = ObtenerEstudiantes().Where(f =>f.Rut.Equals(estudiante.Rut)).FirstOrDefault();

            if(existeEstudiante != null )
            {
                throw new Exception("El estudiante ya fue ingresado");
            }
            if (!estudianteDAL.GuardarEstudiante(estudiante))
            {
                throw new Exception("No se ha guardado al estudiante");
            }
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            return estudianteDAL.ObtenerEstudiante();
        }

        public void EliminarEstudiante(String Rut)
        {
            
        }

    }
}
