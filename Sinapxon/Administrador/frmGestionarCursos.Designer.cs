namespace Sinapxon.Administrador
{
    partial class frmGestionarCursos
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
            this.lblGestionarCurso = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gbBuscarCurso = new System.Windows.Forms.GroupBox();
            this.btnAniadirCurso = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnEditarCurso = new System.Windows.Forms.Button();
            this.gbBuscarCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionarCurso
            // 
            this.lblGestionarCurso.AutoSize = true;
            this.lblGestionarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionarCurso.Location = new System.Drawing.Point(12, 9);
            this.lblGestionarCurso.Name = "lblGestionarCurso";
            this.lblGestionarCurso.Size = new System.Drawing.Size(210, 29);
            this.lblGestionarCurso.TabIndex = 0;
            this.lblGestionarCurso.Text = "Gestionar cursos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(17, 33);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(545, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // gbBuscarCurso
            // 
            this.gbBuscarCurso.Controls.Add(this.btnAniadirCurso);
            this.gbBuscarCurso.Controls.Add(this.btnBuscar);
            this.gbBuscarCurso.Controls.Add(this.txtBuscar);
            this.gbBuscarCurso.Location = new System.Drawing.Point(22, 67);
            this.gbBuscarCurso.Name = "gbBuscarCurso";
            this.gbBuscarCurso.Size = new System.Drawing.Size(815, 79);
            this.gbBuscarCurso.TabIndex = 2;
            this.gbBuscarCurso.TabStop = false;
            this.gbBuscarCurso.Text = "Buscar cursos";
            // 
            // btnAniadirCurso
            // 
            this.btnAniadirCurso.Location = new System.Drawing.Point(680, 33);
            this.btnAniadirCurso.Name = "btnAniadirCurso";
            this.btnAniadirCurso.Size = new System.Drawing.Size(112, 23);
            this.btnAniadirCurso.TabIndex = 3;
            this.btnAniadirCurso.Text = "Añadir curso";
            this.btnAniadirCurso.UseVisualStyleBackColor = true;
            this.btnAniadirCurso.Click += new System.EventHandler(this.btnAniadirCurso_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(568, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(39, 198);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(775, 351);
            this.dgvCursos.TabIndex = 3;
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.Location = new System.Drawing.Point(739, 585);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCurso.TabIndex = 4;
            this.btnEditarCurso.Text = "Editar curso";
            this.btnEditarCurso.UseVisualStyleBackColor = true;
            this.btnEditarCurso.Click += new System.EventHandler(this.btnEditarCurso_Click);
            // 
            // frmGestionarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.btnEditarCurso);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.gbBuscarCurso);
            this.Controls.Add(this.lblGestionarCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarCursos";
            this.Text = "frmGestionarCursos";
            this.gbBuscarCurso.ResumeLayout(false);
            this.gbBuscarCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionarCurso;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox gbBuscarCurso;
        private System.Windows.Forms.Button btnAniadirCurso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnEditarCurso;
    }
}