namespace Sinapxon.Alumno
{
    partial class frmExplorarClassroom
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.gbDescripcion = new System.Windows.Forms.GroupBox();
            this.lblClassroom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbInfroProfesor = new System.Windows.Forms.GroupBox();
            this.gbPeriodo = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(12, 9);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(324, 29);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Técnicas de programación";
            // 
            // gbDescripcion
            // 
            this.gbDescripcion.Location = new System.Drawing.Point(17, 97);
            this.gbDescripcion.Name = "gbDescripcion";
            this.gbDescripcion.Size = new System.Drawing.Size(769, 100);
            this.gbDescripcion.TabIndex = 1;
            this.gbDescripcion.TabStop = false;
            this.gbDescripcion.Text = "Descripción";
            // 
            // lblClassroom
            // 
            this.lblClassroom.AutoSize = true;
            this.lblClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassroom.Location = new System.Drawing.Point(12, 53);
            this.lblClassroom.Name = "lblClassroom";
            this.lblClassroom.Size = new System.Drawing.Size(143, 25);
            this.lblClassroom.TabIndex = 2;
            this.lblClassroom.Text = "Classroom 1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(601, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ingresar al classroom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // gbInfroProfesor
            // 
            this.gbInfroProfesor.Location = new System.Drawing.Point(17, 236);
            this.gbInfroProfesor.Name = "gbInfroProfesor";
            this.gbInfroProfesor.Size = new System.Drawing.Size(769, 265);
            this.gbInfroProfesor.TabIndex = 4;
            this.gbInfroProfesor.TabStop = false;
            this.gbInfroProfesor.Text = "Infromación del profesor";
            // 
            // gbPeriodo
            // 
            this.gbPeriodo.Location = new System.Drawing.Point(17, 530);
            this.gbPeriodo.Name = "gbPeriodo";
            this.gbPeriodo.Size = new System.Drawing.Size(769, 100);
            this.gbPeriodo.TabIndex = 5;
            this.gbPeriodo.TabStop = false;
            this.gbPeriodo.Text = "Periodo";
            // 
            // frmExplorarClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.gbPeriodo);
            this.Controls.Add(this.gbInfroProfesor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblClassroom);
            this.Controls.Add(this.gbDescripcion);
            this.Controls.Add(this.lblCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmExplorarClassroom";
            this.Text = "frmExplorarClassroom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.GroupBox gbDescripcion;
        private System.Windows.Forms.Label lblClassroom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbInfroProfesor;
        private System.Windows.Forms.GroupBox gbPeriodo;
    }
}