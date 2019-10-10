namespace Sinapxon.Alumno
{
    partial class frmExplorarCursos
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
            this.lblExplorarCursos = new System.Windows.Forms.Label();
            this.txtBuscarCurso = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvListaCursos = new System.Windows.Forms.DataGridView();
            this.btnVerCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExplorarCursos
            // 
            this.lblExplorarCursos.AutoSize = true;
            this.lblExplorarCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplorarCursos.Location = new System.Drawing.Point(12, 9);
            this.lblExplorarCursos.Name = "lblExplorarCursos";
            this.lblExplorarCursos.Size = new System.Drawing.Size(200, 29);
            this.lblExplorarCursos.TabIndex = 0;
            this.lblExplorarCursos.Text = "Explorar Cursos";
            // 
            // txtBuscarCurso
            // 
            this.txtBuscarCurso.Location = new System.Drawing.Point(17, 72);
            this.txtBuscarCurso.Name = "txtBuscarCurso";
            this.txtBuscarCurso.Size = new System.Drawing.Size(685, 20);
            this.txtBuscarCurso.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(729, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvListaCursos
            // 
            this.dgvListaCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCursos.Location = new System.Drawing.Point(17, 150);
            this.dgvListaCursos.Name = "dgvListaCursos";
            this.dgvListaCursos.Size = new System.Drawing.Size(787, 435);
            this.dgvListaCursos.TabIndex = 3;
            // 
            // btnVerCurso
            // 
            this.btnVerCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCurso.Location = new System.Drawing.Point(694, 622);
            this.btnVerCurso.Name = "btnVerCurso";
            this.btnVerCurso.Size = new System.Drawing.Size(110, 23);
            this.btnVerCurso.TabIndex = 4;
            this.btnVerCurso.Text = "Ver curso";
            this.btnVerCurso.UseVisualStyleBackColor = true;
            this.btnVerCurso.Click += new System.EventHandler(this.BtnVerCurso_Click);
            // 
            // frmExplorarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.btnVerCurso);
            this.Controls.Add(this.dgvListaCursos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarCurso);
            this.Controls.Add(this.lblExplorarCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExplorarCursos";
            this.Text = "frmExplorarCursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExplorarCursos;
        private System.Windows.Forms.TextBox txtBuscarCurso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvListaCursos;
        private System.Windows.Forms.Button btnVerCurso;
    }
}