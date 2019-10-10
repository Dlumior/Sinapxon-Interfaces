namespace Sinapxon.Alumno
{
    partial class frmAlumno
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
            this.btnExplorar = new System.Windows.Forms.Button();
            this.btnMisClassrooms = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pctLogoSinapxon = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoSinapxon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.panelMenu.Controls.Add(this.btnExplorar);
            this.panelMenu.Controls.Add(this.btnMisClassrooms);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExplorar
            // 
            this.btnExplorar.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnExplorar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExplorar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplorar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplorar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExplorar.Location = new System.Drawing.Point(0, 175);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(200, 45);
            this.btnExplorar.TabIndex = 3;
            this.btnExplorar.Text = "Explorar cursos";
            this.btnExplorar.UseVisualStyleBackColor = false;
            this.btnExplorar.Click += new System.EventHandler(this.BtnExplorar_Click);
            // 
            // btnMisClassrooms
            // 
            this.btnMisClassrooms.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnMisClassrooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMisClassrooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisClassrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisClassrooms.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMisClassrooms.Location = new System.Drawing.Point(0, 130);
            this.btnMisClassrooms.Name = "btnMisClassrooms";
            this.btnMisClassrooms.Size = new System.Drawing.Size(200, 45);
            this.btnMisClassrooms.TabIndex = 2;
            this.btnMisClassrooms.Text = "Mis classrooms";
            this.btnMisClassrooms.UseVisualStyleBackColor = false;
            this.btnMisClassrooms.Click += new System.EventHandler(this.BtnMisClassrooms_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.SlateBlue;
            this.panelLogo.Controls.Add(this.pctLogoSinapxon);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 130);
            this.panelLogo.TabIndex = 1;
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
            // pctLogoSinapxon
            // 
            this.pctLogoSinapxon.Location = new System.Drawing.Point(3, 3);
            this.pctLogoSinapxon.Name = "pctLogoSinapxon";
            this.pctLogoSinapxon.Size = new System.Drawing.Size(194, 121);
            this.pctLogoSinapxon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogoSinapxon.TabIndex = 0;
            this.pctLogoSinapxon.TabStop = false;
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoSinapxon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.Button btnMisClassrooms;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pctLogoSinapxon;
    }
}