namespace Sinapxon.Profesor
{
    partial class frmGestionarMisClassrooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarMisClassrooms));
            this.btnSolicitarClassroom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnVerClassroom = new System.Windows.Forms.Button();
            this.btnAniadirEvaluacion = new System.Windows.Forms.Button();
            this.btnAniadirTema = new System.Windows.Forms.Button();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.pbBlueBox = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSolicitarClassroom
            // 
            this.btnSolicitarClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSolicitarClassroom.FlatAppearance.BorderSize = 0;
            this.btnSolicitarClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitarClassroom.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarClassroom.Location = new System.Drawing.Point(766, 66);
            this.btnSolicitarClassroom.Name = "btnSolicitarClassroom";
            this.btnSolicitarClassroom.Size = new System.Drawing.Size(132, 58);
            this.btnSolicitarClassroom.TabIndex = 1;
            this.btnSolicitarClassroom.Text = "Solicitar classroom";
            this.btnSolicitarClassroom.UseVisualStyleBackColor = false;
            this.btnSolicitarClassroom.Click += new System.EventHandler(this.BtnAniadirClassroom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mis classrooms";
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelContenedor.Controls.Add(this.btnVerClassroom);
            this.panelContenedor.Controls.Add(this.btnAniadirEvaluacion);
            this.panelContenedor.Controls.Add(this.btnAniadirTema);
            this.panelContenedor.Controls.Add(this.lblNombreCurso);
            this.panelContenedor.Controls.Add(this.lblCodigoCurso);
            this.panelContenedor.Controls.Add(this.pbBlueBox);
            this.panelContenedor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenedor.Location = new System.Drawing.Point(33, 152);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(882, 517);
            this.panelContenedor.TabIndex = 10;
            // 
            // btnVerClassroom
            // 
            this.btnVerClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerClassroom.FlatAppearance.BorderSize = 0;
            this.btnVerClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClassroom.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClassroom.Image = global::Sinapxon.Properties.Resources.baseline_edit_black_18dp;
            this.btnVerClassroom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerClassroom.Location = new System.Drawing.Point(633, 80);
            this.btnVerClassroom.Name = "btnVerClassroom";
            this.btnVerClassroom.Size = new System.Drawing.Size(181, 44);
            this.btnVerClassroom.TabIndex = 9;
            this.btnVerClassroom.Text = "Ver classroom";
            this.btnVerClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerClassroom.UseVisualStyleBackColor = false;
            this.btnVerClassroom.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAniadirEvaluacion
            // 
            this.btnAniadirEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAniadirEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnAniadirEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirEvaluacion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirEvaluacion.Image = global::Sinapxon.Properties.Resources.baseline_add_box_black_18dp;
            this.btnAniadirEvaluacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAniadirEvaluacion.Location = new System.Drawing.Point(96, 109);
            this.btnAniadirEvaluacion.Name = "btnAniadirEvaluacion";
            this.btnAniadirEvaluacion.Size = new System.Drawing.Size(189, 44);
            this.btnAniadirEvaluacion.TabIndex = 7;
            this.btnAniadirEvaluacion.Text = "Añadir evaluación";
            this.btnAniadirEvaluacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAniadirEvaluacion.UseVisualStyleBackColor = false;
            this.btnAniadirEvaluacion.Click += new System.EventHandler(this.btnAniadirEvaluacion_Click);
            // 
            // btnAniadirTema
            // 
            this.btnAniadirTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAniadirTema.FlatAppearance.BorderSize = 0;
            this.btnAniadirTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirTema.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirTema.Image = global::Sinapxon.Properties.Resources.baseline_add_box_black_18dp;
            this.btnAniadirTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAniadirTema.Location = new System.Drawing.Point(316, 109);
            this.btnAniadirTema.Name = "btnAniadirTema";
            this.btnAniadirTema.Size = new System.Drawing.Size(160, 44);
            this.btnAniadirTema.TabIndex = 6;
            this.btnAniadirTema.Text = "Añadir Tema";
            this.btnAniadirTema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAniadirTema.UseVisualStyleBackColor = false;
            this.btnAniadirTema.Click += new System.EventHandler(this.btnAniadirTema_Click);
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblNombreCurso.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.ForeColor = System.Drawing.Color.White;
            this.lblNombreCurso.Location = new System.Drawing.Point(181, 54);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(181, 25);
            this.lblNombreCurso.TabIndex = 12;
            this.lblNombreCurso.Text = "Nombre del curso";
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblCodigoCurso.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCurso.ForeColor = System.Drawing.Color.White;
            this.lblCodigoCurso.Location = new System.Drawing.Point(69, 54);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(89, 25);
            this.lblCodigoCurso.TabIndex = 11;
            this.lblCodigoCurso.Text = "ABC000";
            // 
            // pbBlueBox
            // 
            this.pbBlueBox.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            this.pbBlueBox.Location = new System.Drawing.Point(11, 15);
            this.pbBlueBox.Name = "pbBlueBox";
            this.pbBlueBox.Size = new System.Drawing.Size(852, 164);
            this.pbBlueBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBlueBox.TabIndex = 10;
            this.pbBlueBox.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(628, 66);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 58);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(105, 84);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(489, 23);
            this.txtBuscar.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox4.Image = global::Sinapxon.Properties.Resources.round_search;
            this.pictureBox4.Location = new System.Drawing.Point(67, 79);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(42, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(580, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Sinapxon.Properties.Resources.Bloque_G3;
            this.pictureBox2.Location = new System.Drawing.Point(24, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(900, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // frmGestionarMisClassrooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSolicitarClassroom);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarMisClassrooms";
            this.Text = "frmGestionarMisClassrooms";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSolicitarClassroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAniadirTema;
        private System.Windows.Forms.Button btnAniadirEvaluacion;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnVerClassroom;
        private System.Windows.Forms.PictureBox pbBlueBox;
        private System.Windows.Forms.Label lblCodigoCurso;
        private System.Windows.Forms.Label lblNombreCurso;
    }
}