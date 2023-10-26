using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class EstudianteDAL
    {
        public bool GuardarEstudiante(Estudiante estudiante)
        {
            string query = $"INSERT INTO Estudiante(nombre, apellido, fechanacimiento) VALUES('{estudiante.Nombre}',{estudiante.Apellido}, '{estudiante.FechaNacimiento}')";
            int rows = DatabaseHelper.Instance.ExecuteNonQuery(query);
            if (rows == 0)
            {
                return false;
            }
            return true;
        }

        public List<Estudiante> ObtenerEstudiante()
        {
            string query = "SELECT * FROM estudiante";
            DataTable dt = DatabaseHelper.Instance.ExecuteQuery(query);
            List<Estudiante> estudiantes = new List<Estudiante>();
            foreach (DataRow row in dt.Rows)
            {
                Estudiante e = new Estudiante();
                e.ID = int.Parse(row["id"].ToString());
                e.Nombre = row["nombre"].ToString().Trim();
                e.Apellido = row["apellido"].ToString().Trim();
                //e.FechaNacimiento = row["fechanacimiento"].ToString().Trim();
                estudiantes.Add(e);
            }
            return estudiantes;
        }
    }
}