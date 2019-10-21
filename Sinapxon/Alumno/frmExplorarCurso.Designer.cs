namespace Sinapxon.Alumno
{
    partial class frmExplorarCurso
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
            this.dgvClassrooms = new System.Windows.Forms.DataGridView();
            this.btnVerClassroom = new System.Windows.Forms.Button();
            this.gbRequisitos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassrooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Técnicas de programación";
            // 
            // dgvClassrooms
            // 
            this.dgvClassrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassrooms.Location = new System.Drawing.Point(17, 231);
            this.dgvClassrooms.Name = "dgvClassrooms";
            this.dgvClassrooms.Size = new System.Drawing.Size(769, 289);
            this.dgvClassrooms.TabIndex = 1;
            // 
            // btnVerClassroom
            // 
            this.btnVerClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClassroom.Location = new System.Drawing.Point(663, 584);
            this.btnVerClassroom.Name = "btnVerClassroom";
            this.btnVerClassroom.Size = new System.Drawing.Size(123, 23);
            this.btnVerClassroom.TabIndex = 2;
            this.btnVerClassroom.Text = "Ver classroom";
            this.btnVerClassroom.UseVisualStyleBackColor = true;
            this.btnVerClassroom.Click += new System.EventHandler(this.BtnVerClassroom_Click);
            // 
            // gbRequisitos
            // 
            this.gbRequisitos.Location = new System.Drawing.Point(17, 90);
            this.gbRequisitos.Name = "gbRequisitos";
            this.gbRequisitos.Size = new System.Drawing.Size(769, 100);
            this.gbRequisitos.TabIndex = 3;
            this.gbRequisitos.TabStop = false;
            this.gbRequisitos.Text = "Requisitos";
            // 
            // frmExplorarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 642);
            this.Controls.Add(this.gbRequisitos);
            this.Controls.Add(this.btnVerClassroom);
            this.Controls.Add(this.dgvClassrooms);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmExplorarCurso";
            this.Text = "frmExplorarCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassrooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClassrooms;
        private System.Windows.Forms.Button btnVerClassroom;
        private System.Windows.Forms.GroupBox gbRequisitos;
    }
}