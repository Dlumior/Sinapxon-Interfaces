namespace Sinapxon.Profesor
{
    partial class frmDatosClassroom
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
            this.lblDatosClassroom = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnEnviarSolicitud = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDatosClassroom
            // 
            this.lblDatosClassroom.AutoSize = true;
            this.lblDatosClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosClassroom.Location = new System.Drawing.Point(12, 9);
            this.lblDatosClassroom.Name = "lblDatosClassroom";
            this.lblDatosClassroom.Size = new System.Drawing.Size(251, 29);
            this.lblDatosClassroom.TabIndex = 0;
            this.lblDatosClassroom.Text = "Datos del classroom";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(37, 122);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(37, 523);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(43, 13);
            this.lblPeriodo.TabIndex = 3;
            this.lblPeriodo.Text = "Periodo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(40, 138);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(772, 357);
            this.txtDescripcion.TabIndex = 6;
            // 
            // btnEnviarSolicitud
            // 
            this.btnEnviarSolicitud.Location = new System.Drawing.Point(692, 539);
            this.btnEnviarSolicitud.Name = "btnEnviarSolicitud";
            this.btnEnviarSolicitud.Size = new System.Drawing.Size(120, 23);
            this.btnEnviarSolicitud.TabIndex = 9;
            this.btnEnviarSolicitud.Text = "Enviar solicitud";
            this.btnEnviarSolicitud.UseVisualStyleBackColor = true;
            this.btnEnviarSolicitud.Click += new System.EventHandler(this.BtnEnviarSolicitud_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 539);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(37, 69);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 15;
            this.lblIdioma.Text = "Idioma";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(40, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(286, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // frmDatosClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 642);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnEnviarSolicitud);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblDatosClassroom);
            this.Name = "frmDatosClassroom";
            this.Text = "frmDatosClassroom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosClassroom;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnEnviarSolicitud;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}