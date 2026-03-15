using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winMySQL.Clases;

namespace Practica_3_Asistencia
{
    public partial class FrmAgregar : Form
    {
        Datos datos = new Datos();
        public FrmAgregar()
        {
            InitializeComponent();
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            cmbGrupo.Items.Add("A");
            cmbGrupo.Items.Add("B");
            cmbGrupo.Items.Add("C");

            cmbGrupo.SelectedIndex = 0;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            bool resultado = datos.ejecutarcomando(
               $"INSERT INTO estudiantes (num_control,nombre,ap_paterno,ap_materno,grupo) " +
               $"VALUES ('{txtNumControl.Text}','{txtNombre.Text}','{txtPaterno.Text}','{txtMaterno.Text}','{cmbGrupo.Text}')");

            if (resultado)
            {
                MessageBox.Show("Estudiante agregado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar estudiante");
            }
        }
    }
}
