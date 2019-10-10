namespace Sinapxon.Profesor
{
    partial class frmEditarClassroom
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbTemas = new System.Windows.Forms.GroupBox();
            this.btnAniadirTema = new System.Windows.Forms.Button();
            this.btnEditarTema = new System.Windows.Forms.Button();
            this.dgvTemas = new System.Windows.Forms.DataGridView();
            this.gbEvaluaciones = new System.Windows.Forms.GroupBox();
            this.dgvEvaluaciones = new System.Windows.Forms.DataGridView();
            this.btnAniadirEvaluacion = new System.Windows.Forms.Button();
            this.btnEditarEvaluacion = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbTemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).BeginInit();
            this.gbEvaluaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar classroom";
            // 
            // gbTemas
            // 
            this.gbTemas.Controls.Add(this.btnAniadirTema);
            this.gbTemas.Controls.Add(this.btnEditarTema);
            this.gbTemas.Controls.Add(this.dgvTemas);
            this.gbTemas.Location = new System.Drawing.Point(18, 62);
            this.gbTemas.Name = "gbTemas";
            this.gbTemas.Size = new System.Drawing.Size(818, 227);
            this.gbTemas.TabIndex = 2;
            this.gbTemas.TabStop = false;
            this.gbTemas.Text = "Temas";
            // 
            // btnAniadirTema
            // 
            this.btnAniadirTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirTema.Location = new System.Drawing.Point(531, 192);
            this.btnAniadirTema.Name = "btnAniadirTema";
            this.btnAniadirTema.Size = new System.Drawing.Size(118, 23);
            this.btnAniadirTema.TabIndex = 2;
            this.btnAniadirTema.Text = "Añadir tema";
            this.btnAniadirTema.UseVisualStyleBackColor = true;
            this.btnAniadirTema.Click += new System.EventHandler(this.btnAniadirTema_Click);
            // 
            // btnEditarTema
            // 
            this.btnEditarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTema.Location = new System.Drawing.Point(665, 192);
            this.btnEditarTema.Name = "btnEditarTema";
            this.btnEditarTema.Size = new System.Drawing.Size(122, 23);
            this.btnEditarTema.TabIndex = 1;
            this.btnEditarTema.Text = "Editar tema";
            this.btnEditarTema.UseVisualStyleBackColor = true;
            // 
            // dgvTemas
            // 
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemas.Location = new System.Drawing.Point(18, 35);
            this.dgvTemas.Name = "dgvTemas";
            this.dgvTemas.Size = new System.Drawing.Size(769, 135);
            this.dgvTemas.TabIndex = 0;
            // 
            // gbEvaluaciones
            // 
            this.gbEvaluaciones.Controls.Add(this.dgvEvaluaciones);
            this.gbEvaluaciones.Controls.Add(this.btnAniadirEvaluacion);
            this.gbEvaluaciones.Controls.Add(this.btnEditarEvaluacion);
            this.gbEvaluaciones.Location = new System.Drawing.Point(18, 306);
            this.gbEvaluaciones.Name = "gbEvaluaciones";
            this.gbEvaluaciones.Size = new System.Drawing.Size(818, 268);
            this.gbEvaluaciones.TabIndex = 3;
            this.gbEvaluaciones.TabStop = false;
            this.gbEvaluaciones.Text = "Evaluaciones";
            // 
            // dgvEvaluaciones
            // 
            this.dgvEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluaciones.Location = new System.Drawing.Point(18, 43);
            this.dgvEvaluaciones.Name = "dgvEvaluaciones";
            this.dgvEvaluaciones.Size = new System.Drawing.Size(769, 175);
            this.dgvEvaluaciones.TabIndex = 2;
            // 
            // btnAniadirEvaluacion
            // 
            this.btnAniadirEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirEvaluacion.Location = new System.Drawing.Point(489, 239);
            this.btnAniadirEvaluacion.Name = "btnAniadirEvaluacion";
            this.btnAniadirEvaluacion.Size = new System.Drawing.Size(149, 23);
            this.btnAniadirEvaluacion.TabIndex = 1;
            this.btnAniadirEvaluacion.Text = "Añadir evaluacion";
            this.btnAniadirEvaluacion.UseVisualStyleBackColor = true;
            this.btnAniadirEvaluacion.Click += new System.EventHandler(this.btnAniadirEvaluacion_Click);
            // 
            // btnEditarEvaluacion
            // 
            this.btnEditarEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEvaluacion.Location = new System.Drawing.Point(644, 239);
            this.btnEditarEvaluacion.Name = "btnEditarEvaluacion";
            this.btnEditarEvaluacion.Size = new System.Drawing.Size(143, 23);
            this.btnEditarEvaluacion.TabIndex = 0;
            this.btnEditarEvaluacion.Text = "Editar evaluación";
            this.btnEditarEvaluacion.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(719, 607);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmEditarClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 642);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbEvaluaciones);
            this.Controls.Add(this.gbTemas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEditarClassroom";
            this.Text = "frmEditarClassroom";
            this.gbTemas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).EndInit();
            this.gbEvaluaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTemas;
        private System.Windows.Forms.GroupBox gbEvaluaciones;
        private System.Windows.Forms.DataGridView dgvTemas;
        private System.Windows.Forms.Button btnAniadirTema;
        private System.Windows.Forms.Button btnEditarTema;
        private System.Windows.Forms.DataGridView dgvEvaluaciones;
        private System.Windows.Forms.Button btnAniadirEvaluacion;
        private System.Windows.Forms.Button btnEditarEvaluacion;
        private System.Windows.Forms.Button btnGuardar;
    }
}