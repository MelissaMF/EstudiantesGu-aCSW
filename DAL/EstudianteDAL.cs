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
            string fechanac = estudiante.FechaNacimiento.ToString("yyyy-MM-dd");
            string query = $"INSERT INTO Estudiantes(rut, nombre, apellido, fechanacimiento) VALUES('{estudiante.Rut}','{estudiante.Nombre}','{estudiante.Apellido}', '{fechanac}')";
            int rows = DatabaseHelper.Instance.ExecuteNonQuery(query);
            if (rows == 0)
            {
                return false;
            }
            return true;
        }

        public List<Estudiante> ObtenerEstudiante()
        {
            string query = "SELECT * FROM Estudiantes";
            DataTable dt = DatabaseHelper.Instance.ExecuteQuery(query);
            List<Estudiante> estudiantes = new List<Estudiante>();
            foreach (DataRow row in dt.Rows)
            {
                Estudiante e = new Estudiante();
                e.Rut = row["rut"].ToString();
                e.Nombre = row["nombre"].ToString().Trim();
                e.Apellido = row["apellido"].ToString().Trim();
                e.FechaNacimiento = DateTime.Parse(row["fechanacimiento"].ToString());
                estudiantes.Add(e);
            }
            return estudiantes;
        }

        public bool EliminarEstudiante(string rut)
        {
            string query = $"DELETE FROM Estudiantes WHERE rut = '{rut}'";
            int rows = DatabaseHelper.Instance.ExecuteNonQuery(query);
            if (rows == 0)
            {
                return false;
            }
            return true;

        }

    }
}