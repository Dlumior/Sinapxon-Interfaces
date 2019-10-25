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
            this.panelContenedorCursos = new System.Windows.Forms.Panel();
            this.panelBucador = new System.Windows.Forms.Panel();
            this.pbContenedorBuscador = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCursos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelIdioma = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelContenedorCursos.SuspendLayout();
            this.panelBucador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContenedorBuscador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelIdioma.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatosClassroom
            // 
            this.lblDatosClassroom.AutoSize = true;
            this.lblDatosClassroom.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosClassroom.Location = new System.Drawing.Point(12, 9);
            this.lblDatosClassroom.Name = "lblDatosClassroom";
            this.lblDatosClassroom.Size = new System.Drawing.Size(235, 29);
            this.lblDatosClassroom.TabIndex = 0;
            this.lblDatosClassroom.Text = "Datos del classroom";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(25, 16);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(126, 25);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(28, 17);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(87, 25);
            this.lblPeriodo.TabIndex = 3;
            this.lblPeriodo.Text = "Periodo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(30, 75);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(384, 179);
            this.txtDescripcion.TabIndex = 6;
            // 
            // btnEnviarSolicitud
            // 
            this.btnEnviarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnEnviarSolicitud.FlatAppearance.BorderSize = 0;
            this.btnEnviarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarSolicitud.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnEnviarSolicitud.Location = new System.Drawing.Point(742, 18);
            this.btnEnviarSolicitud.Name = "btnEnviarSolicitud";
            this.btnEnviarSolicitud.Size = new System.Drawing.Size(197, 42);
            this.btnEnviarSolicitud.TabIndex = 9;
            this.btnEnviarSolicitud.Text = "Enviar solicitud";
            this.btnEnviarSolicitud.UseVisualStyleBackColor = false;
            this.btnEnviarSolicitud.Click += new System.EventHandler(this.BtnEnviarSolicitud_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(384, 27);
            this.comboBox1.TabIndex = 10;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.Color.White;
            this.lblIdioma.Location = new System.Drawing.Point(28, 16);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(77, 25);
            this.lblIdioma.TabIndex = 15;
            this.lblIdioma.Text = "Idioma";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(30, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(384, 27);
            this.comboBox2.TabIndex = 16;
            // 
            // panelContenedorCursos
            // 
            this.panelContenedorCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelContenedorCursos.Controls.Add(this.dataGridView1);
            this.panelContenedorCursos.Controls.Add(this.panelBucador);
            this.panelContenedorCursos.Location = new System.Drawing.Point(17, 74);
            this.panelContenedorCursos.Name = "panelContenedorCursos";
            this.panelContenedorCursos.Size = new System.Drawing.Size(458, 585);
            this.panelContenedorCursos.TabIndex = 17;
            // 
            // panelBucador
            // 
            this.panelBucador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelBucador.Controls.Add(this.lblCursos);
            this.panelBucador.Controls.Add(this.btnBuscar);
            this.panelBucador.Controls.Add(this.textBox1);
            this.panelBucador.Controls.Add(this.pbBuscar);
            this.panelBucador.Controls.Add(this.pbContenedorBuscador);
            this.panelBucador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBucador.Location = new System.Drawing.Point(0, 0);
            this.panelBucador.Name = "panelBucador";
            this.panelBucador.Size = new System.Drawing.Size(458, 131);
            this.panelBucador.TabIndex = 0;
            // 
            // pbContenedorBuscador
            // 
            this.pbContenedorBuscador.Image = global::Sinapxon.Properties.Resources.Barra_G4;
            this.pbContenedorBuscador.Location = new System.Drawing.Point(4, 59);
            this.pbContenedorBuscador.Name = "pbContenedorBuscador";
            this.pbContenedorBuscador.Size = new System.Drawing.Size(359, 50);
            this.pbContenedorBuscador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContenedorBuscador.TabIndex = 0;
            this.pbContenedorBuscador.TabStop = false;
            // 
            // pbBuscar
            // 
            this.pbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbBuscar.Image = global::Sinapxon.Properties.Resources.round_search;
            this.pbBuscar.Location = new System.Drawing.Point(22, 66);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(36, 36);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBuscar.TabIndex = 1;
            this.pbBuscar.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(64, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(369, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 45);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 410);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursos.ForeColor = System.Drawing.Color.White;
            this.lblCursos.Location = new System.Drawing.Point(17, 16);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(80, 25);
            this.lblCursos.TabIndex = 4;
            this.lblCursos.Text = "Cursos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.panelIdioma);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Location = new System.Drawing.Point(492, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 131);
            this.panel1.TabIndex = 18;
            // 
            // panelIdioma
            // 
            this.panelIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelIdioma.Controls.Add(this.lblIdioma);
            this.panelIdioma.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIdioma.Location = new System.Drawing.Point(0, 0);
            this.panelIdioma.Name = "panelIdioma";
            this.panelIdioma.Size = new System.Drawing.Size(447, 58);
            this.panelIdioma.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(492, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 129);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panel3.Controls.Add(this.lblPeriodo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 58);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.txtDescripcion);
            this.panel4.Location = new System.Drawing.Point(492, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(447, 274);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panel5.Controls.Add(this.lblDescripcion);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(447, 58);
            this.panel5.TabIndex = 0;
            // 
            // frmDatosClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedorCursos);
            this.Controls.Add(this.btnEnviarSolicitud);
            this.Controls.Add(this.lblDatosClassroom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatosClassroom";
            this.Text = "frmDatosClassroom";
            this.panelContenedorCursos.ResumeLayout(false);
            this.panelBucador.ResumeLayout(false);
            this.panelBucador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContenedorBuscador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelIdioma.ResumeLayout(false);
            this.panelIdioma.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Panel panelContenedorCursos;
        private System.Windows.Forms.Panel panelBucador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.PictureBox pbContenedorBuscador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelIdioma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}