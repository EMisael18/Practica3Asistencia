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
            dtpFecha = new DateTimePicker();
            dgvAsistencia = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNumControl = new TextBox();
            btnBuscar = new Button();
            cmbGrupo = new ComboBox();
            GRUPO = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(62, 65);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(300, 31);
            dtpFecha.TabIndex = 0;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Location = new Point(12, 240);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.RowHeadersWidth = 62;
            dgvAsistencia.Size = new Size(855, 225);
            dgvAsistencia.TabIndex = 1;
            dgvAsistencia.CellContentClick += dgvAsistencia_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 34);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 2;
            label1.Text = "FECHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(363, 117);
            label2.Name = "label2";
            label2.Size = new Size(141, 28);
            label2.TabIndex = 3;
            label2.Text = "Num Control";
            // 
            // txtNumControl
            // 
            txtNumControl.Location = new Point(260, 161);
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(300, 31);
            txtNumControl.TabIndex = 4;
            txtNumControl.TextChanged += txtNumControl_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(608, 158);
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
            cmbGrupo.Location = new Point(562, 63);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(182, 33);
            cmbGrupo.TabIndex = 6;
            cmbGrupo.SelectedIndexChanged += cmbGrupo_SelectedIndexChanged;
            // 
            // GRUPO
            // 
            GRUPO.AutoSize = true;
            GRUPO.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GRUPO.Location = new Point(615, 34);
            GRUPO.Name = "GRUPO";
            GRUPO.Size = new Size(84, 28);
            GRUPO.TabIndex = 7;
            GRUPO.Text = "GRUPO";
            // 
            // FrmAsistencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 477);
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
    }
}
