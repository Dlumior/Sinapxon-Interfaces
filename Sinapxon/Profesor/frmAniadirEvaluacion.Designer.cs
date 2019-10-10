namespace Sinapxon.Profesor
{
    partial class frmAniadirEvaluacion
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
            this.gbDatosEvaluacion = new System.Windows.Forms.GroupBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarEvaluacion = new System.Windows.Forms.Button();
            this.gbDatosEvaluacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añadir evaluación";
            // 
            // gbDatosEvaluacion
            // 
            this.gbDatosEvaluacion.Controls.Add(this.lblPorcentaje);
            this.gbDatosEvaluacion.Controls.Add(this.lblPeso);
            this.gbDatosEvaluacion.Controls.Add(this.txtPeso);
            this.gbDatosEvaluacion.Controls.Add(this.txtDescripcion);
            this.gbDatosEvaluacion.Controls.Add(this.textBox1);
            this.gbDatosEvaluacion.Controls.Add(this.lblDescripcion);
            this.gbDatosEvaluacion.Controls.Add(this.label2);
            this.gbDatosEvaluacion.Location = new System.Drawing.Point(18, 77);
            this.gbDatosEvaluacion.Name = "gbDatosEvaluacion";
            this.gbDatosEvaluacion.Size = new System.Drawing.Size(809, 469);
            this.gbDatosEvaluacion.TabIndex = 1;
            this.gbDatosEvaluacion.TabStop = false;
            this.gbDatosEvaluacion.Text = "Datos de la evaluación";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(709, 54);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(15, 13);
            this.lblPorcentaje.TabIndex = 6;
            this.lblPorcentaje.Text = "%";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(551, 34);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(554, 51);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(149, 20);
            this.txtPeso.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(27, 103);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(759, 335);
            this.txtDescripcion.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(499, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(24, 86);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de la evaluación";
            // 
            // btnGuardarEvaluacion
            // 
            this.btnGuardarEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEvaluacion.Location = new System.Drawing.Point(661, 588);
            this.btnGuardarEvaluacion.Name = "btnGuardarEvaluacion";
            this.btnGuardarEvaluacion.Size = new System.Drawing.Size(165, 23);
            this.btnGuardarEvaluacion.TabIndex = 2;
            this.btnGuardarEvaluacion.Text = "Guardar evaluación";
            this.btnGuardarEvaluacion.UseVisualStyleBackColor = true;
            // 
            // frmAniadirEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 642);
            this.Controls.Add(this.btnGuardarEvaluacion);
            this.Controls.Add(this.gbDatosEvaluacion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAniadirEvaluacion";
            this.Text = "frmAniadirEvaluacion";
            this.gbDatosEvaluacion.ResumeLayout(false);
            this.gbDatosEvaluacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosEvaluacion;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarEvaluacion;
    }
}