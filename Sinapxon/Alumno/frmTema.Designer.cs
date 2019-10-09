namespace Sinapxon.Alumno
{
    partial class frmTema
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbDescripcion = new System.Windows.Forms.GroupBox();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnDescargarEvaluacion = new System.Windows.Forms.Button();
            this.btnSubirEvaluacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "APLICA - Tema 1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 456);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 144);
            this.dataGridView1.TabIndex = 1;
            // 
            // gbDescripcion
            // 
            this.gbDescripcion.Location = new System.Drawing.Point(17, 70);
            this.gbDescripcion.Name = "gbDescripcion";
            this.gbDescripcion.Size = new System.Drawing.Size(835, 100);
            this.gbDescripcion.TabIndex = 2;
            this.gbDescripcion.TabStop = false;
            this.gbDescripcion.Text = "Descripción";
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(17, 186);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(830, 243);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(830, 243);
            this.webBrowser2.TabIndex = 3;
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(675, 628);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(172, 23);
            this.btnDescargar.TabIndex = 4;
            this.btnDescargar.Text = "Descargar archivo seleccionado";
            this.btnDescargar.UseVisualStyleBackColor = true;
            // 
            // btnDescargarEvaluacion
            // 
            this.btnDescargarEvaluacion.Location = new System.Drawing.Point(12, 627);
            this.btnDescargarEvaluacion.Name = "btnDescargarEvaluacion";
            this.btnDescargarEvaluacion.Size = new System.Drawing.Size(142, 23);
            this.btnDescargarEvaluacion.TabIndex = 5;
            this.btnDescargarEvaluacion.Text = "Descargar evaluación";
            this.btnDescargarEvaluacion.UseVisualStyleBackColor = true;
            // 
            // btnSubirEvaluacion
            // 
            this.btnSubirEvaluacion.Location = new System.Drawing.Point(172, 627);
            this.btnSubirEvaluacion.Name = "btnSubirEvaluacion";
            this.btnSubirEvaluacion.Size = new System.Drawing.Size(134, 23);
            this.btnSubirEvaluacion.TabIndex = 6;
            this.btnSubirEvaluacion.Text = "Subir evaluación";
            this.btnSubirEvaluacion.UseVisualStyleBackColor = true;
            // 
            // frmTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.btnSubirEvaluacion);
            this.Controls.Add(this.btnDescargarEvaluacion);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.gbDescripcion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTema";
            this.Text = "frmTema";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbDescripcion;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Button btnDescargarEvaluacion;
        private System.Windows.Forms.Button btnSubirEvaluacion;
    }
}