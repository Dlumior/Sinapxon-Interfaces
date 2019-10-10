namespace Sinapxon.Alumno
{
    partial class frmMiClassroom
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
            this.btnTemas = new System.Windows.Forms.Button();
            this.btnEvaluaciones = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTemas
            // 
            this.btnTemas.BackColor = System.Drawing.Color.BlueViolet;
            this.btnTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTemas.Location = new System.Drawing.Point(141, 195);
            this.btnTemas.Name = "btnTemas";
            this.btnTemas.Size = new System.Drawing.Size(229, 206);
            this.btnTemas.TabIndex = 0;
            this.btnTemas.Text = "TEMAS";
            this.btnTemas.UseVisualStyleBackColor = false;
            this.btnTemas.Click += new System.EventHandler(this.BtnTemas_Click);
            // 
            // btnEvaluaciones
            // 
            this.btnEvaluaciones.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEvaluaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEvaluaciones.Location = new System.Drawing.Point(465, 195);
            this.btnEvaluaciones.Name = "btnEvaluaciones";
            this.btnEvaluaciones.Size = new System.Drawing.Size(229, 206);
            this.btnEvaluaciones.TabIndex = 1;
            this.btnEvaluaciones.Text = "EVALUACIONES";
            this.btnEvaluaciones.UseVisualStyleBackColor = false;
            this.btnEvaluaciones.Click += new System.EventHandler(this.BtnEvaluaciones_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(326, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Lenguaje de programación";
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(12, 12);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 23);
            this.btnX.TabIndex = 3;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // frmMiClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEvaluaciones);
            this.Controls.Add(this.btnTemas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMiClassroom";
            this.Text = "frmMiClassroom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemas;
        private System.Windows.Forms.Button btnEvaluaciones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnX;
    }
}