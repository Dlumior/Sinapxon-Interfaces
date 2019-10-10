namespace Sinapxon.Administrador
{
    partial class frmAdministrador
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubGestionarUsr = new System.Windows.Forms.Panel();
            this.btnGestionarAlumno = new System.Windows.Forms.Button();
            this.btnGestionarProfesor = new System.Windows.Forms.Button();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnGestionarClassrooms = new System.Windows.Forms.Button();
            this.btnGestionarCursos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelSubGestionarUsr.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.panelMenu.Controls.Add(this.panelSubGestionarUsr);
            this.panelMenu.Controls.Add(this.btnGestionarUsuarios);
            this.panelMenu.Controls.Add(this.btnGestionarClassrooms);
            this.panelMenu.Controls.Add(this.btnGestionarCursos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSubGestionarUsr
            // 
            this.panelSubGestionarUsr.Controls.Add(this.btnGestionarAlumno);
            this.panelSubGestionarUsr.Controls.Add(this.btnGestionarProfesor);
            this.panelSubGestionarUsr.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubGestionarUsr.Location = new System.Drawing.Point(0, 265);
            this.panelSubGestionarUsr.Name = "panelSubGestionarUsr";
            this.panelSubGestionarUsr.Size = new System.Drawing.Size(200, 70);
            this.panelSubGestionarUsr.TabIndex = 4;
            // 
            // btnGestionarAlumno
            // 
            this.btnGestionarAlumno.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnGestionarAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarAlumno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarAlumno.Location = new System.Drawing.Point(0, 30);
            this.btnGestionarAlumno.Name = "btnGestionarAlumno";
            this.btnGestionarAlumno.Size = new System.Drawing.Size(200, 37);
            this.btnGestionarAlumno.TabIndex = 1;
            this.btnGestionarAlumno.Text = "Gestionar alumno";
            this.btnGestionarAlumno.UseVisualStyleBackColor = false;
            this.btnGestionarAlumno.Click += new System.EventHandler(this.btnGestionarAlumno_Click);
            // 
            // btnGestionarProfesor
            // 
            this.btnGestionarProfesor.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnGestionarProfesor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarProfesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarProfesor.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarProfesor.Name = "btnGestionarProfesor";
            this.btnGestionarProfesor.Size = new System.Drawing.Size(200, 30);
            this.btnGestionarProfesor.TabIndex = 0;
            this.btnGestionarProfesor.Text = "Gestionar profesor";
            this.btnGestionarProfesor.UseVisualStyleBackColor = false;
            this.btnGestionarProfesor.Click += new System.EventHandler(this.btnGestionarProfesor_Click);
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnGestionarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(0, 220);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(200, 45);
            this.btnGestionarUsuarios.TabIndex = 3;
            this.btnGestionarUsuarios.Text = "Gestionar usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // btnGestionarClassrooms
            // 
            this.btnGestionarClassrooms.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnGestionarClassrooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarClassrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarClassrooms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarClassrooms.Location = new System.Drawing.Point(0, 175);
            this.btnGestionarClassrooms.Name = "btnGestionarClassrooms";
            this.btnGestionarClassrooms.Size = new System.Drawing.Size(200, 45);
            this.btnGestionarClassrooms.TabIndex = 2;
            this.btnGestionarClassrooms.Text = "Gestionar Classrooms";
            this.btnGestionarClassrooms.UseVisualStyleBackColor = false;
            this.btnGestionarClassrooms.Click += new System.EventHandler(this.btnGestionarClassrooms_Click);
            // 
            // btnGestionarCursos
            // 
            this.btnGestionarCursos.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnGestionarCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarCursos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarCursos.Location = new System.Drawing.Point(0, 130);
            this.btnGestionarCursos.Name = "btnGestionarCursos";
            this.btnGestionarCursos.Size = new System.Drawing.Size(200, 45);
            this.btnGestionarCursos.TabIndex = 1;
            this.btnGestionarCursos.Text = "Gestionar cursos";
            this.btnGestionarCursos.UseVisualStyleBackColor = false;
            this.btnGestionarCursos.Click += new System.EventHandler(this.btnGestionarCursos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.SlateBlue;
            this.panelLogo.Controls.Add(this.pctLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 130);
            this.panelLogo.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(864, 681);
            this.panelContenedor.TabIndex = 1;
            // 
            // pctLogo
            // 
            this.pctLogo.Location = new System.Drawing.Point(4, 4);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(193, 126);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmAdministrador";
            this.Text = "frmAdministrador";
            this.panelMenu.ResumeLayout(false);
            this.panelSubGestionarUsr.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Button btnGestionarClassrooms;
        private System.Windows.Forms.Button btnGestionarCursos;
        private System.Windows.Forms.Panel panelSubGestionarUsr;
        private System.Windows.Forms.Button btnGestionarAlumno;
        private System.Windows.Forms.Button btnGestionarProfesor;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}