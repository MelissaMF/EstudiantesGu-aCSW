using DAL;
using BLL;

namespace UI
{
    public partial class Form1 : Form

    {
        private EstudianteBLL estudianteBLL;
        public Form1()
        {
            InitializeComponent();
            estudianteBLL = new EstudianteBLL();
            this.CargarEstudiantes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CargarEstudiantes()
        {
            this.dgvestudiante.Rows.Clear();
            List<Estudiante> estudiantes = estudianteBLL.ObtenerEstudiantes();
            foreach (Estudiante e in estudiantes)
            {
                int n = dgvestudiante.Rows.Add();
                dgvestudiante.Rows[n].Cells[0].Value = e.Rut;
                dgvestudiante.Rows[n].Cells[1].Value = e.Nombre;
                dgvestudiante.Rows[n].Cells[2].Value = e.Apellido;
                dgvestudiante.Rows[n].Cells[3].Value = e.FechaNacimiento.ToString("dd-MM-yyyy");

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rut = tbRut.Text;
            string nombre = tbnombre.Text;
            string apellido = tbApellido.Text;
            DateTime fechanacimiento = dtFechaNacimiento.Value.Date;

            Estudiante estudiante = new Estudiante(rut, nombre, apellido, fechanacimiento);
            try
            {
                this.estudianteBLL.AgregarEstudiante(estudiante);
                this.CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvestudiante.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar Estudiante",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DataGridViewRow filaSeleccionada = dgvestudiante.SelectedRows[0];
                    string rut = filaSeleccionada.Cells[0].Value.ToString();
                    this.estudianteBLL.EliminarEstudiante(rut);
                    this.CargarEstudiantes();
                    MessageBox.Show("El estudiante ha sido eliminado exitosamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbApellido.Clear();
            tbnombre.Clear();
            tbRut.Clear();
        }
    }
}
