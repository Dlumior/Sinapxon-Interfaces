namespace Sinapxon.Login
{
    partial class frmOvlideContrasenia
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
            this.lblOlvideContrasenia = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnEnviarContraseña = new System.Windows.Forms.Button();
            this.chbCorreo = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOlvideContrasenia
            // 
            this.lblOlvideContrasenia.AutoSize = true;
            this.lblOlvideContrasenia.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvideContrasenia.Location = new System.Drawing.Point(27, 25);
            this.lblOlvideContrasenia.Name = "lblOlvideContrasenia";
            this.lblOlvideContrasenia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOlvideContrasenia.Size = new System.Drawing.Size(213, 25);
            this.lblOlvideContrasenia.TabIndex = 0;
            this.lblOlvideContrasenia.Text = "Olvidé mi contraseña";
            this.lblOlvideContrasenia.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(182, 94);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(425, 20);
            this.txtCorreo.TabIndex = 2;
            // 
            // btnEnviarContraseña
            // 
            this.btnEnviarContraseña.Location = new System.Drawing.Point(475, 175);
            this.btnEnviarContraseña.Name = "btnEnviarContraseña";
            this.btnEnviarContraseña.Size = new System.Drawing.Size(132, 23);
            this.btnEnviarContraseña.TabIndex = 3;
            this.btnEnviarContraseña.Text = "Enviar contraseña";
            this.btnEnviarContraseña.UseVisualStyleBackColor = true;
            // 
            // chbCorreo
            // 
            this.chbCorreo.AutoSize = true;
            this.chbCorreo.Location = new System.Drawing.Point(40, 94);
            this.chbCorreo.Name = "chbCorreo";
            this.chbCorreo.Size = new System.Drawing.Size(136, 17);
            this.chbCorreo.TabIndex = 4;
            this.chbCorreo.Text = "Usar correo electronico";
            this.chbCorreo.UseVisualStyleBackColor = true;
            this.chbCorreo.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(40, 130);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Usar nickname";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 20);
            this.textBox1.TabIndex = 7;
            // 
            // frmOvlideContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 210);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chbCorreo);
            this.Controls.Add(this.btnEnviarContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblOlvideContrasenia);
            this.Name = "frmOvlideContrasenia";
            this.Text = "frmOvlideContrasenia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOlvideContrasenia;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnEnviarContraseña;
        private System.Windows.Forms.CheckBox chbCorreo;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}