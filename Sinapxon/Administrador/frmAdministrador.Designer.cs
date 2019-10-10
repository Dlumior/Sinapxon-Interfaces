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
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnGestionarClassrooms = new System.Windows.Forms.Button();
            this.btnGestionarCursos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelSubGestionarUsr = new System.Windows.Forms.Panel();
            this.btnGestionarProfesor = new System.Windows.Forms.Button();
            this.btnGestionarAlumno = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelSubGestionarUsr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
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
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(0, 220);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(200, 45);
            this.btnGestionarUsuarios.TabIndex = 3;
            this.btnGestionarUsuarios.Text = "Gestionar usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // btnGestionarClassrooms
            // 
            this.btnGestionarClassrooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarClassrooms.Location = new System.Drawing.Point(0, 175);
            this.btnGestionarClassrooms.Name = "btnGestionarClassrooms";
            this.btnGestionarClassrooms.Size = new System.Drawing.Size(200, 45);
            this.btnGestionarClassrooms.TabIndex = 2;
            this.btnGestionarClassrooms.Text = "Gestionar Classrooms";
            this.btnGestionarClassrooms.UseVisualStyleBackColor = true;
            this.btnGestionarClassrooms.Click += new System.EventHandler(this.btnGestionarClassrooms_Click);
            // 
            // btnGestionarCursos
            // 
            this.btnGestionarCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarCursos.Location = new System.Drawing.Point(0, 130);
            this.btnGestionarCursos.Name = "btnGestionarCursos";
            this.btnGestionarCursos.Size = new System.Drawing.Size(200, 45);
            this.btnGestionarCursos.TabIndex = 1;
            this.btnGestionarCursos.Text = "Gestionar cursos";
            this.btnGestionarCursos.UseVisualStyleBackColor = true;
            this.btnGestionarCursos.Click += new System.EventHandler(this.btnGestionarCursos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            // btnGestionarProfesor
            // 
            this.btnGestionarProfesor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarProfesor.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarProfesor.Name = "btnGestionarProfesor";
            this.btnGestionarProfesor.Size = new System.Drawing.Size(200, 30);
            this.btnGestionarProfesor.TabIndex = 0;
            this.btnGestionarProfesor.Text = "Gestionar profesor";
            this.btnGestionarProfesor.UseVisualStyleBackColor = true;
            this.btnGestionarProfesor.Click += new System.EventHandler(this.btnGestionarProfesor_Click);
            // 
            // btnGestionarAlumno
            // 
            this.btnGestionarAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarAlumno.Location = new System.Drawing.Point(0, 30);
            this.btnGestionarAlumno.Name = "btnGestionarAlumno";
            this.btnGestionarAlumno.Size = new System.Drawing.Size(200, 30);
            this.btnGestionarAlumno.TabIndex = 1;
            this.btnGestionarAlumno.Text = "Gestionar alumno";
            this.btnGestionarAlumno.UseVisualStyleBackColor = true;
            this.btnGestionarAlumno.Click += new System.EventHandler(this.btnGestionarAlumno_Click);
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
    }
}