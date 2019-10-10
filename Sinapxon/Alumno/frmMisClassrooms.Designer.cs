namespace Sinapxon.Alumno
{
    partial class frmMisClassrooms
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
            this.btnX = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIrClassroom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mis Classrooms";
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(12, 12);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 23);
            this.btnX.TabIndex = 2;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(817, 443);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnIrClassroom
            // 
            this.btnIrClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrClassroom.Location = new System.Drawing.Point(713, 615);
            this.btnIrClassroom.Name = "btnIrClassroom";
            this.btnIrClassroom.Size = new System.Drawing.Size(121, 23);
            this.btnIrClassroom.TabIndex = 4;
            this.btnIrClassroom.Text = "Ir al classroom";
            this.btnIrClassroom.UseVisualStyleBackColor = true;
            this.btnIrClassroom.Click += new System.EventHandler(this.BtnIrClassroom_Click);
            // 
            // frmMisClassrooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.btnIrClassroom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMisClassrooms";
            this.Text = "frmMisCursos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIrClassroom;
    }
}