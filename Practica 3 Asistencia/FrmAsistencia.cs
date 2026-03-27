using System.Data;
using winMySQL.Clases;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
                $"SELECT e.num_control, e.nombre, e.ap_paterno, e.ap_materno, e.grupo, " +
                $"IFNULL(a.asistio,0) AS asistio " +
                $"FROM estudiantes e " +
                $"LEFT JOIN asistencia a ON e.num_control = a.num_control " +
                $"AND a.fecha = '{fecha}' " +
                $"WHERE e.grupo = '{cmbGrupo.Text}'");

            dgvAsistencia.DataSource = ds.Tables[0];

            if (dgvAsistencia.Columns.Contains("asistio"))
            {
                int index = dgvAsistencia.Columns["asistio"].Index;
                dgvAsistencia.Columns.Remove("asistio");

                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.Name = "asistio";
                chk.HeaderText = "asistio";
                chk.DataPropertyName = "asistio";

                dgvAsistencia.Columns.Insert(index, chk);
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
            string nc = txtNumControl.Text.Trim();

            DataSet ds = datos.ejecutar(
                $"SELECT e.num_control, e.nombre, e.ap_paterno, e.ap_materno, e.grupo, " +
                $"IFNULL(a.asistio,0) AS asistio " +
                $"FROM estudiantes e " +
                $"LEFT JOIN asistencia a ON e.num_control = a.num_control " +
                $"AND a.fecha = '{fecha}' " +
                $"WHERE e.num_control = '{nc}'");

            if (ds != null && ds.Tables.Count > 0)
            {
                dgvAsistencia.DataSource = ds.Tables[0];
                dgvAsistencia.Columns["asistio"].CellTemplate = new DataGridViewCheckBoxCell();
            }
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarEstudiantes();
        }
        void cargarEstudiantes()
        {
            DataSet ds = datos.ejecutar(
                $"SELECT e.num_control, e.nombre, e.ap_paterno, e.ap_materno, e.grupo, " +
                $"IFNULL(a.asistio,0) AS asistio " +
                $"FROM estudiantes e " +
                $"LEFT JOIN asistencia a ON e.num_control = a.num_control " +
                $"AND a.fecha = '{dtpFecha.Value:yyyy-MM-dd}' " +
                $"WHERE e.grupo = '{cmbGrupo.Text}'");

            dgvAsistencia.DataSource = ds.Tables[0];
            if (dgvAsistencia.Columns.Contains("asistio"))
            {
                int index = dgvAsistencia.Columns["asistio"].Index;
                dgvAsistencia.Columns.Remove("asistio");

                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.Name = "asistio";
                chk.HeaderText = "asistio";
                chk.DataPropertyName = "asistio";

                dgvAsistencia.Columns.Insert(index, chk);
            }
        }

        private void FrmAsistencia_Load(object sender, EventArgs e)
        {
            cmbGrupo.Items.Add("A");
            cmbGrupo.Items.Add("B");
            cmbGrupo.Items.Add("C");

            cmbGrupo.SelectedIndex = 0;

            cargarEstudiantes();
            dgvAsistencia.CellDoubleClick += dgvAsistencia_CellDoubleClick;

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nc = dgvAsistencia.CurrentRow.Cells["num_control"].Value.ToString();

            if (MessageBox.Show(
                "Deseas eliminar el alumno: " + nc,
                "Sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarcomando(
                    $"DELETE FROM estudiantes WHERE num_control='{nc}'");

                if (f == true)
                {
                    MessageBox.Show("Alumno eliminado con éxito", "Sistema");
                    cargarEstudiantes();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el alumno", "Sistema");
                }
            }
        }

        private void dgvAsistencia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void dgvAsistencia_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAsistencia.IsCurrentCellDirty)
            {
                dgvAsistencia.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgvAsistencia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            FrmAgregar frm = new FrmAgregar(
                dgvAsistencia.Rows[e.RowIndex].Cells["num_control"].Value.ToString(),
                dgvAsistencia.Rows[e.RowIndex].Cells["nombre"].Value.ToString(),
                dgvAsistencia.Rows[e.RowIndex].Cells["ap_paterno"].Value.ToString(),
                dgvAsistencia.Rows[e.RowIndex].Cells["ap_materno"].Value.ToString(),
                dgvAsistencia.Rows[e.RowIndex].Cells["grupo"].Value.ToString()
            );

            frm.ShowDialog();

            cargarEstudiantes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            for (int i = 0; i < dgvAsistencia.Rows.Count; i++)
            {
              
                if (dgvAsistencia.Rows[i].Cells["num_control"].Value == null)
                {
                    continue;
                }

                string nc = dgvAsistencia.Rows[i].Cells["num_control"].Value.ToString();

                bool asistio = false;
                int valor;

                object v = dgvAsistencia.Rows[i].Cells["asistio"].Value;

                if (v != null && v != DBNull.Value)
                {
                    asistio = Convert.ToBoolean(v);
                }

                if (asistio == true)
                {
                    valor = 1;
                }
                else
                {
                    valor = 0;
                }

                DataSet ds = datos.ejecutar(
                    $"SELECT * FROM asistencia WHERE num_control='{nc}' AND fecha='{fecha}'");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    datos.ejecutarcomando(
                        $"UPDATE asistencia SET asistio={valor} WHERE num_control='{nc}' AND fecha='{fecha}'");
                }
                else
                {
                    datos.ejecutarcomando(
                        $"INSERT INTO asistencia (num_control,fecha,asistio) VALUES ('{nc}','{fecha}',{valor})");
                }
            }

            MessageBox.Show("Asistencia guardada correctamente");
        }

            
        
    }
}

