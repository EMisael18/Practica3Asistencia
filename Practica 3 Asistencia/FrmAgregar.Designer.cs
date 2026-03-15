namespace Practica_3_Asistencia
{
    partial class FrmAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtPaterno = new TextBox();
            txtNumControl = new TextBox();
            txtMaterno = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbGrupo = new ComboBox();
            label5 = new Label();
            Agregar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(47, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 31);
            txtNombre.TabIndex = 0;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(47, 160);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(255, 31);
            txtPaterno.TabIndex = 1;
            // 
            // txtNumControl
            // 
            txtNumControl.Location = new Point(496, 72);
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(248, 31);
            txtNumControl.TabIndex = 2;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(496, 160);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(248, 31);
            txtMaterno.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 35);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(558, 35);
            label2.Name = "label2";
            label2.Size = new Size(141, 28);
            label2.TabIndex = 5;
            label2.Text = "Num Control";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(111, 121);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 6;
            label3.Text = "Ap Paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(558, 121);
            label4.Name = "label4";
            label4.Size = new Size(131, 28);
            label4.TabIndex = 7;
            label4.Text = "Ap Materno";
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(297, 245);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(182, 33);
            cmbGrupo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(350, 202);
            label5.Name = "label5";
            label5.Size = new Size(75, 28);
            label5.TabIndex = 9;
            label5.Text = "Grupo";
            // 
            // Agregar
            // 
            Agregar.Location = new Point(324, 309);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(112, 34);
            Agregar.TabIndex = 10;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click;
            // 
            // FrmAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Agregar);
            Controls.Add(label5);
            Controls.Add(cmbGrupo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaterno);
            Controls.Add(txtNumControl);
            Controls.Add(txtPaterno);
            Controls.Add(txtNombre);
            Name = "FrmAgregar";
            Text = "Agregar Alumno";
            Load += FrmAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtPaterno;
        private TextBox txtNumControl;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtMaterno;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbGrupo;
        private Label label5;
        private Button Agregar;
    }
}