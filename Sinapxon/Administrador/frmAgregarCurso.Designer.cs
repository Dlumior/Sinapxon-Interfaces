namespace Sinapxon.Administrador
{
    partial class frmAgregarCurso
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCodigoCurso = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblRequisitos = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.txtCodigoCurso = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvRequisitos = new System.Windows.Forms.DataGridView();
            this.btnAgregarRequisito = new System.Windows.Forms.Button();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.btnAgregarEspecialidad = new System.Windows.Forms.Button();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar curso";
            // 
            // btnCodigoCurso
            // 
            this.btnCodigoCurso.AutoSize = true;
            this.btnCodigoCurso.Location = new System.Drawing.Point(57, 85);
            this.btnCodigoCurso.Name = "btnCodigoCurso";
            this.btnCodigoCurso.Size = new System.Drawing.Size(86, 13);
            this.btnCodigoCurso.TabIndex = 1;
            this.btnCodigoCurso.Text = "Codigo del curso";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Location = new System.Drawing.Point(60, 162);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(90, 13);
            this.lblNombreCurso.TabIndex = 2;
            this.lblNombreCurso.Text = "Nombre del curso";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(60, 227);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(109, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción del curso";
            // 
            // lblRequisitos
            // 
            this.lblRequisitos.AutoSize = true;
            this.lblRequisitos.Location = new System.Drawing.Point(60, 371);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.Size = new System.Drawing.Size(56, 13);
            this.lblRequisitos.TabIndex = 4;
            this.lblRequisitos.Text = "Requisitos";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(60, 529);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 5;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(495, 162);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 6;
            this.lblIdioma.Text = "Idioma";
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.BackColor = System.Drawing.Color.White;
            this.txtCodigoCurso.Location = new System.Drawing.Point(60, 101);
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.Size = new System.Drawing.Size(267, 20);
            this.txtCodigoCurso.TabIndex = 7;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.BackColor = System.Drawing.Color.White;
            this.txtNombreCurso.Location = new System.Drawing.Point(63, 178);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(354, 20);
            this.txtNombreCurso.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(63, 258);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(742, 92);
            this.txtDescripcion.TabIndex = 9;
            // 
            // dgvRequisitos
            // 
            this.dgvRequisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitos.Location = new System.Drawing.Point(63, 403);
            this.dgvRequisitos.Name = "dgvRequisitos";
            this.dgvRequisitos.Size = new System.Drawing.Size(742, 105);
            this.dgvRequisitos.TabIndex = 10;
            // 
            // btnAgregarRequisito
            // 
            this.btnAgregarRequisito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRequisito.Location = new System.Drawing.Point(649, 371);
            this.btnAgregarRequisito.Name = "btnAgregarRequisito";
            this.btnAgregarRequisito.Size = new System.Drawing.Size(156, 26);
            this.btnAgregarRequisito.TabIndex = 11;
            this.btnAgregarRequisito.Text = "Agregar requisito";
            this.btnAgregarRequisito.UseVisualStyleBackColor = true;
            this.btnAgregarRequisito.Click += new System.EventHandler(this.btnAgregarRequisito_Click);
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Location = new System.Drawing.Point(63, 560);
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.Size = new System.Drawing.Size(742, 109);
            this.dgvEspecialidades.TabIndex = 12;
            // 
            // btnAgregarEspecialidad
            // 
            this.btnAgregarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEspecialidad.Location = new System.Drawing.Point(621, 531);
            this.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad";
            this.btnAgregarEspecialidad.Size = new System.Drawing.Size(183, 23);
            this.btnAgregarEspecialidad.TabIndex = 13;
            this.btnAgregarEspecialidad.Text = "Agregar especialidad";
            this.btnAgregarEspecialidad.UseVisualStyleBackColor = true;
            this.btnAgregarEspecialidad.Click += new System.EventHandler(this.btnAgregarEspecialidad_Click);
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(498, 178);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(307, 20);
            this.txtIdioma.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(719, 16);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.btnAgregarEspecialidad);
            this.Controls.Add(this.dgvEspecialidades);
            this.Controls.Add(this.btnAgregarRequisito);
            this.Controls.Add(this.dgvRequisitos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.txtCodigoCurso);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblRequisitos);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.btnCodigoCurso);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarCurso";
            this.Text = "frmAgregarCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label btnCodigoCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.TextBox txtCodigoCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvRequisitos;
        private System.Windows.Forms.Button btnAgregarRequisito;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Button btnAgregarEspecialidad;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Button btnGuardar;
    }
}