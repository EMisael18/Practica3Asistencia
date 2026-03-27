namespace Practica_3_Asistencia
{
    partial class FrmAsistencia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dtpFecha = new DateTimePicker();
            dgvAsistencia = new DataGridView();
            cmsEliminar = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            txtNumControl = new TextBox();
            btnBuscar = new Button();
            cmbGrupo = new ComboBox();
            GRUPO = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            cmsEliminar.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(209, 56);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(300, 31);
            dtpFecha.TabIndex = 0;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.ContextMenuStrip = cmsEliminar;
            dgvAsistencia.Location = new Point(12, 288);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.RowHeadersWidth = 62;
            dgvAsistencia.Size = new Size(1042, 225);
            dgvAsistencia.TabIndex = 1;
            dgvAsistencia.CellContentClick += dgvAsistencia_CellContentClick;
            dgvAsistencia.CellValueChanged += dgvAsistencia_CellValueChanged;
            dgvAsistencia.CurrentCellDirtyStateChanged += dgvAsistencia_CurrentCellDirtyStateChanged;
            // 
            // cmsEliminar
            // 
            cmsEliminar.ImageScalingSize = new Size(24, 24);
            cmsEliminar.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            cmsEliminar.Name = "cmsEliminar";
            cmsEliminar.Size = new Size(147, 36);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(146, 32);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 25);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 2;
            label1.Text = "FECHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(510, 108);
            label2.Name = "label2";
            label2.Size = new Size(141, 28);
            label2.TabIndex = 3;
            label2.Text = "Num Control";
            // 
            // txtNumControl
            // 
            txtNumControl.Location = new Point(407, 152);
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(300, 31);
            txtNumControl.TabIndex = 4;
            txtNumControl.TextChanged += txtNumControl_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(750, 149);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(709, 54);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(182, 33);
            cmbGrupo.TabIndex = 6;
            cmbGrupo.SelectedIndexChanged += cmbGrupo_SelectedIndexChanged;
            // 
            // GRUPO
            // 
            GRUPO.AutoSize = true;
            GRUPO.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GRUPO.Location = new Point(762, 25);
            GRUPO.Name = "GRUPO";
            GRUPO.Size = new Size(84, 28);
            GRUPO.TabIndex = 7;
            GRUPO.Text = "GRUPO";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(455, 219);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(242, 34);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "GUARDAR CAMBIOS";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmAsistencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 543);
            Controls.Add(btnGuardar);
            Controls.Add(GRUPO);
            Controls.Add(cmbGrupo);
            Controls.Add(btnBuscar);
            Controls.Add(txtNumControl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAsistencia);
            Controls.Add(dtpFecha);
            Name = "FrmAsistencia";
            Text = "Asistencia";
            Load += FrmAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            cmsEliminar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private DataGridView dgvAsistencia;
        private Label label1;
        private Label label2;
        private TextBox txtNumControl;
        private Button btnBuscar;
        private ComboBox cmbGrupo;
        private Label GRUPO;
        private ContextMenuStrip cmsEliminar;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Button btnGuardar;
    }
}
