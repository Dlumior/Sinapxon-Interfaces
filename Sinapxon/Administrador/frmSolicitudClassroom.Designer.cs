namespace Sinapxon.Administrador
{
    partial class frmSolicitudClassroom
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
            this.gbDatosProfesor = new System.Windows.Forms.GroupBox();
            this.gbDatosClassroom = new System.Windows.Forms.GroupBox();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnDenegar = new System.Windows.Forms.Button();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescripcionClassroom = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreProfesor = new System.Windows.Forms.TextBox();
            this.txtGradoInstruccion = new System.Windows.Forms.TextBox();
            this.txtAreaInteres = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gbDatosProfesor.SuspendLayout();
            this.gbDatosClassroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos de la solicitud";
            // 
            // gbDatosProfesor
            // 
            this.gbDatosProfesor.Controls.Add(this.txtAreaInteres);
            this.gbDatosProfesor.Controls.Add(this.txtGradoInstruccion);
            this.gbDatosProfesor.Controls.Add(this.txtNombreProfesor);
            this.gbDatosProfesor.Controls.Add(this.label3);
            this.gbDatosProfesor.Controls.Add(this.label2);
            this.gbDatosProfesor.Controls.Add(this.lblNombreProfesor);
            this.gbDatosProfesor.Location = new System.Drawing.Point(18, 79);
            this.gbDatosProfesor.Name = "gbDatosProfesor";
            this.gbDatosProfesor.Size = new System.Drawing.Size(752, 176);
            this.gbDatosProfesor.TabIndex = 1;
            this.gbDatosProfesor.TabStop = false;
            this.gbDatosProfesor.Text = "Datos del profesor";
            // 
            // gbDatosClassroom
            // 
            this.gbDatosClassroom.Controls.Add(this.comboBox2);
            this.gbDatosClassroom.Controls.Add(this.lblIdioma);
            this.gbDatosClassroom.Controls.Add(this.comboBox1);
            this.gbDatosClassroom.Controls.Add(this.txtDescripcion);
            this.gbDatosClassroom.Controls.Add(this.lblPeriodo);
            this.gbDatosClassroom.Controls.Add(this.lblDescripcionClassroom);
            this.gbDatosClassroom.Location = new System.Drawing.Point(18, 275);
            this.gbDatosClassroom.Name = "gbDatosClassroom";
            this.gbDatosClassroom.Size = new System.Drawing.Size(752, 263);
            this.gbDatosClassroom.TabIndex = 2;
            this.gbDatosClassroom.TabStop = false;
            this.gbDatosClassroom.Text = "Datos del classroom";
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(695, 557);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 23);
            this.btnAprobar.TabIndex = 3;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            // 
            // btnDenegar
            // 
            this.btnDenegar.Location = new System.Drawing.Point(590, 557);
            this.btnDenegar.Name = "btnDenegar";
            this.btnDenegar.Size = new System.Drawing.Size(75, 23);
            this.btnDenegar.TabIndex = 4;
            this.btnDenegar.Text = "Denegar";
            this.btnDenegar.UseVisualStyleBackColor = true;
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.Location = new System.Drawing.Point(32, 29);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProfesor.TabIndex = 0;
            this.lblNombreProfesor.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grado de instrucción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Área de interés";
            // 
            // lblDescripcionClassroom
            // 
            this.lblDescripcionClassroom.AutoSize = true;
            this.lblDescripcionClassroom.Location = new System.Drawing.Point(32, 63);
            this.lblDescripcionClassroom.Name = "lblDescripcionClassroom";
            this.lblDescripcionClassroom.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionClassroom.TabIndex = 1;
            this.lblDescripcionClassroom.Text = "Descripción";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(31, 225);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(43, 13);
            this.lblPeriodo.TabIndex = 2;
            this.lblPeriodo.Text = "Periodo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(35, 79);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(660, 133);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.Enabled = false;
            this.txtNombreProfesor.Location = new System.Drawing.Point(35, 45);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.ReadOnly = true;
            this.txtNombreProfesor.Size = new System.Drawing.Size(658, 20);
            this.txtNombreProfesor.TabIndex = 8;
            // 
            // txtGradoInstruccion
            // 
            this.txtGradoInstruccion.Enabled = false;
            this.txtGradoInstruccion.Location = new System.Drawing.Point(35, 94);
            this.txtGradoInstruccion.Name = "txtGradoInstruccion";
            this.txtGradoInstruccion.ReadOnly = true;
            this.txtGradoInstruccion.Size = new System.Drawing.Size(658, 20);
            this.txtGradoInstruccion.TabIndex = 9;
            // 
            // txtAreaInteres
            // 
            this.txtAreaInteres.Enabled = false;
            this.txtAreaInteres.Location = new System.Drawing.Point(35, 150);
            this.txtAreaInteres.Name = "txtAreaInteres";
            this.txtAreaInteres.ReadOnly = true;
            this.txtAreaInteres.Size = new System.Drawing.Size(658, 20);
            this.txtAreaInteres.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(613, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(35, 31);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 8;
            this.lblIdioma.Text = "Idioma";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(80, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(328, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // frmSolicitudClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.btnDenegar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.gbDatosClassroom);
            this.Controls.Add(this.gbDatosProfesor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSolicitudClassroom";
            this.Text = "frmSolicitudClassroom";
            this.gbDatosProfesor.ResumeLayout(false);
            this.gbDatosProfesor.PerformLayout();
            this.gbDatosClassroom.ResumeLayout(false);
            this.gbDatosClassroom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosProfesor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.GroupBox gbDatosClassroom;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnDenegar;
        private System.Windows.Forms.Label lblDescripcionClassroom;
        private System.Windows.Forms.TextBox txtAreaInteres;
        private System.Windows.Forms.TextBox txtGradoInstruccion;
        private System.Windows.Forms.TextBox txtNombreProfesor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblIdioma;
    }
}