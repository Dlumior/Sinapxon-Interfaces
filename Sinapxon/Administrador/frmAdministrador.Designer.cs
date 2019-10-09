﻿namespace Sinapxon.Administrador
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
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnGestionarCursos = new System.Windows.Forms.Button();
            this.btnGestionarClassrooms = new System.Windows.Forms.Button();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
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
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(200, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(864, 681);
            this.panelContenido.TabIndex = 1;
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
            // btnGestionarCursos
            // 
            this.btnGestionarCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarCursos.Location = new System.Drawing.Point(0, 130);
            this.btnGestionarCursos.Name = "btnGestionarCursos";
            this.btnGestionarCursos.Size = new System.Drawing.Size(200, 45);
            this.btnGestionarCursos.TabIndex = 1;
            this.btnGestionarCursos.Text = "Gestionar cursos";
            this.btnGestionarCursos.UseVisualStyleBackColor = true;
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
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmAdministrador";
            this.Text = "frmAdministrador";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Button btnGestionarClassrooms;
        private System.Windows.Forms.Button btnGestionarCursos;
    }
}