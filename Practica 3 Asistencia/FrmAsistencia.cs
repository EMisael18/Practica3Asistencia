using System.Data;
using winMySQL.Clases;

namespace Practica_3_Asistencia
{
    public partial class FrmAsistencia : Form
    {
        Datos datos = new Datos();
        public FrmAsistencia()
        {
            InitializeComponent();
        }
        void cargarAsistenciaFecha()
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            DataSet ds = datos.ejecutar(
                $"SELECT e.num_control, e.nombre, e.ap_paterno, a.fecha, a.asistio " +
                $"FROM asistencia a " +
                $"INNER JOIN estudiantes e ON e.num_control = a.num_control " +
                $"WHERE a.fecha = '{fecha}'");

            if (ds != null && ds.Tables.Count > 0)
            {
                dgvAsistencia.DataSource = ds.Tables[0];
            }
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            cargarAsistenciaFecha();
        }


        private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtNumControl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            DataSet ds = datos.ejecutar(
                $"SELECT e.num_control, e.nombre, e.ap_paterno, a.fecha, a.asistio " +
                $"FROM asistencia a " +
                $"INNER JOIN estudiantes e ON e.num_control = a.num_control " +
                $"WHERE a.fecha = '{fecha}' " +
                $"AND e.num_control = '{txtNumControl.Text}'");

            dgvAsistencia.DataSource = ds.Tables[0];
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarEstudiantes();
        }
        void cargarEstudiantes()
        {
            DataSet ds = datos.ejecutar(
                $"SELECT e.num_control, e.nombre, e.ap_paterno, e.grupo, " +
                $"IFNULL(a.asistio,0) AS asistio " +
                $"FROM estudiantes e " +
                $"LEFT JOIN asistencia a ON e.num_control = a.num_control " +
                $"AND a.fecha = '{dtpFecha.Value:yyyy-MM-dd}' " +
                $"WHERE e.grupo = '{cmbGrupo.Text}'");

            dgvAsistencia.DataSource = ds.Tables[0];
        }

        private void FrmAsistencia_Load(object sender, EventArgs e)
        {
            cargarAsistenciaFecha();
            cmbGrupo.Items.Add("A");
            cmbGrupo.Items.Add("B");
            cmbGrupo.Items.Add("C");

            cmbGrupo.SelectedIndex = 0;

            cargarEstudiantes();
        }
    }
}
