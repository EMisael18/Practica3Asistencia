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
        
        bool editar = false;
        string numControlOriginal = "";
        Datos datos = new Datos();
        public FrmAgregar()
        {
            InitializeComponent();
        }
        public FrmAgregar(string nc, string nombre, string paterno, string materno, string grupo)
        {
            InitializeComponent();

            txtNumControl.Text = nc;
            txtNombre.Text = nombre;
            txtPaterno.Text = paterno;
            txtMaterno.Text = materno;
            cmbGrupo.Text = grupo;


            editar = true;
            numControlOriginal = nc;
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
            if (editar == false)
            {
                // INSERTAR NUEVO
                bool f = datos.ejecutarcomando(
                    $"INSERT INTO estudiantes (num_control,nombre,ap_paterno,ap_materno,grupo) " +
                    $"VALUES ('{txtNumControl.Text}','{txtNombre.Text}','{txtPaterno.Text}','{txtMaterno.Text}','{cmbGrupo.Text}')");

                if (f)
                {
                    MessageBox.Show("Alumno agregado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }
            }
            else
            {
                // 🔴 VALIDAR QUE NO EXISTA OTRO IGUAL
                DataSet ds = datos.ejecutar(
                    $"SELECT * FROM estudiantes WHERE num_control='{txtNumControl.Text}'");

                if (ds.Tables[0].Rows.Count > 0 && txtNumControl.Text != numControlOriginal)
                {
                    MessageBox.Show("Ese número de control ya existe");
                    return;
                }

                // 🔥 ACTUALIZAR ESTUDIANTE (incluye num_control)
                bool f1 = datos.ejecutarcomando(
                    $"UPDATE estudiantes SET " +
                    $"num_control='{txtNumControl.Text}', " +
                    $"nombre='{txtNombre.Text}', " +
                    $"ap_paterno='{txtPaterno.Text}', " +
                    $"ap_materno='{txtMaterno.Text}', " +
                    $"grupo='{cmbGrupo.Text}' " +
                    $"WHERE num_control='{numControlOriginal}'");

                

                if (f1)
                {
                    MessageBox.Show("Alumno actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }
        }
}
