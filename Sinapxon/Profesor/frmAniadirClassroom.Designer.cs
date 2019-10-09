namespace Sinapxon.Profesor
{
    partial class frmAniadirClassroom
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
            this.lblCursosDisponibles = new System.Windows.Forms.Label();
            this.dgvListaCursos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCursosDisponibles
            // 
            this.lblCursosDisponibles.AutoSize = true;
            this.lblCursosDisponibles.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursosDisponibles.Location = new System.Drawing.Point(12, 9);
            this.lblCursosDisponibles.Name = "lblCursosDisponibles";
            this.lblCursosDisponibles.Size = new System.Drawing.Size(219, 29);
            this.lblCursosDisponibles.TabIndex = 0;
            this.lblCursosDisponibles.Text = "Cursos disponibles";
            // 
            // dgvListaCursos
            // 
            this.dgvListaCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCursos.Location = new System.Drawing.Point(17, 86);
            this.dgvListaCursos.Name = "dgvListaCursos";
            this.dgvListaCursos.Size = new System.Drawing.Size(681, 323);
            this.dgvListaCursos.TabIndex = 1;
            // 
            // btnSeleccionarCurso
            // 
            this.btnSeleccionarCurso.Location = new System.Drawing.Point(569, 452);
            this.btnSeleccionarCurso.Name = "btnSeleccionarCurso";
            this.btnSeleccionarCurso.Size = new System.Drawing.Size(129, 23);
            this.btnSeleccionarCurso.TabIndex = 2;
            this.btnSeleccionarCurso.Text = "Seleccionar curso";
            this.btnSeleccionarCurso.UseVisualStyleBackColor = true;
            this.btnSeleccionarCurso.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmAniadirClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 520);
            this.Controls.Add(this.btnSeleccionarCurso);
            this.Controls.Add(this.dgvListaCursos);
            this.Controls.Add(this.lblCursosDisponibles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAniadirClassroom";
            this.Text = "frmAniadirClassroom";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCursosDisponibles;
        private System.Windows.Forms.DataGridView dgvListaCursos;
        private System.Windows.Forms.Button btnSeleccionarCurso;
    }
}