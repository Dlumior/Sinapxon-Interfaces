namespace Sinapxon.Alumno
{
    partial class frmEvaluacion
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
            this.dgvEntregables = new System.Windows.Forms.DataGridView();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregables)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "APLICA - Evaluación 1";
            // 
            // dgvEntregables
            // 
            this.dgvEntregables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregables.Location = new System.Drawing.Point(26, 117);
            this.dgvEntregables.Name = "dgvEntregables";
            this.dgvEntregables.Size = new System.Drawing.Size(826, 452);
            this.dgvEntregables.TabIndex = 1;
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.Location = new System.Drawing.Point(680, 613);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(172, 23);
            this.btnSubirArchivo.TabIndex = 2;
            this.btnSubirArchivo.Text = "Subir archivo al entregable";
            this.btnSubirArchivo.UseVisualStyleBackColor = true;
            // 
            // frmEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.btnSubirArchivo);
            this.Controls.Add(this.dgvEntregables);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEvaluacion";
            this.Text = "frmEvaluacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEntregables;
        private System.Windows.Forms.Button btnSubirArchivo;
    }
}