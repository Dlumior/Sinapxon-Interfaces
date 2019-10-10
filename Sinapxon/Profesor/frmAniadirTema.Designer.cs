namespace Sinapxon.Profesor
{
    partial class frmAniadirTema
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblLinkVideo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLinkVideo = new System.Windows.Forms.TextBox();
            this.gbArchivos = new System.Windows.Forms.GroupBox();
            this.btnAniadirArchivo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscarArchivo = new System.Windows.Forms.TextBox();
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.btnGuardarTema = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbArchivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añadir Tema";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del tema";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(19, 85);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblLinkVideo
            // 
            this.lblLinkVideo.AutoSize = true;
            this.lblLinkVideo.Location = new System.Drawing.Point(19, 29);
            this.lblLinkVideo.Name = "lblLinkVideo";
            this.lblLinkVideo.Size = new System.Drawing.Size(73, 13);
            this.lblLinkVideo.TabIndex = 3;
            this.lblLinkVideo.Text = "Link del video";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(18, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales del tema";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(22, 101);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(775, 55);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(775, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLinkVideo);
            this.groupBox2.Controls.Add(this.lblLinkVideo);
            this.groupBox2.Location = new System.Drawing.Point(18, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video";
            // 
            // txtLinkVideo
            // 
            this.txtLinkVideo.Location = new System.Drawing.Point(22, 61);
            this.txtLinkVideo.Name = "txtLinkVideo";
            this.txtLinkVideo.Size = new System.Drawing.Size(775, 20);
            this.txtLinkVideo.TabIndex = 4;
            // 
            // gbArchivos
            // 
            this.gbArchivos.Controls.Add(this.btnAniadirArchivo);
            this.gbArchivos.Controls.Add(this.button1);
            this.gbArchivos.Controls.Add(this.txtBuscarArchivo);
            this.gbArchivos.Controls.Add(this.dgvArchivos);
            this.gbArchivos.Location = new System.Drawing.Point(18, 371);
            this.gbArchivos.Name = "gbArchivos";
            this.gbArchivos.Size = new System.Drawing.Size(818, 216);
            this.gbArchivos.TabIndex = 6;
            this.gbArchivos.TabStop = false;
            this.gbArchivos.Text = "Archivos del curso";
            // 
            // btnAniadirArchivo
            // 
            this.btnAniadirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirArchivo.Location = new System.Drawing.Point(676, 39);
            this.btnAniadirArchivo.Name = "btnAniadirArchivo";
            this.btnAniadirArchivo.Size = new System.Drawing.Size(121, 23);
            this.btnAniadirArchivo.TabIndex = 3;
            this.btnAniadirArchivo.Text = "Añadir archivo";
            this.btnAniadirArchivo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(549, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar archivo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBuscarArchivo
            // 
            this.txtBuscarArchivo.Location = new System.Drawing.Point(22, 42);
            this.txtBuscarArchivo.Name = "txtBuscarArchivo";
            this.txtBuscarArchivo.Size = new System.Drawing.Size(521, 20);
            this.txtBuscarArchivo.TabIndex = 1;
            // 
            // dgvArchivos
            // 
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.Location = new System.Drawing.Point(22, 68);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.Size = new System.Drawing.Size(775, 135);
            this.dgvArchivos.TabIndex = 0;
            this.dgvArchivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArchivos_CellContentClick);
            // 
            // btnGuardarTema
            // 
            this.btnGuardarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTema.Location = new System.Drawing.Point(668, 605);
            this.btnGuardarTema.Name = "btnGuardarTema";
            this.btnGuardarTema.Size = new System.Drawing.Size(146, 23);
            this.btnGuardarTema.TabIndex = 7;
            this.btnGuardarTema.Text = "Guardar tema";
            this.btnGuardarTema.UseVisualStyleBackColor = true;
            // 
            // frmAniadirTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 642);
            this.Controls.Add(this.btnGuardarTema);
            this.Controls.Add(this.gbArchivos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAniadirTema";
            this.Text = "frmAniadirTema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbArchivos.ResumeLayout(false);
            this.gbArchivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblLinkVideo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLinkVideo;
        private System.Windows.Forms.GroupBox gbArchivos;
        private System.Windows.Forms.Button btnAniadirArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscarArchivo;
        private System.Windows.Forms.DataGridView dgvArchivos;
        private System.Windows.Forms.Button btnGuardarTema;
    }
}