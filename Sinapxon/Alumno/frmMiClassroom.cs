using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Alumno
{
    public partial class frmMiClassroom : Form
    {
        private int altura = 0, boxAltura = 119;

        public frmMiClassroom()
        {
            InitializeComponent();
            agregarTema();
            agregarTema();
            agregarTema();
        }

        private void agregarTema()
        {
            //
            // lbl Nombre del tema
            //
            Label lblNombTema = new Label();
            lblNombTema.BackColor = Color.FromArgb(0, 0, 90);
            lblNombTema.Font = new Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombTema.ForeColor = Color.White;
            lblNombTema.Location = new Point(76, 66 + altura);
            lblNombTema.Name = "lblNombreTema";
            lblNombTema.Size = new Size(300, 23);
            lblNombTema.Text = "Nombre del tema";
            lblNombTema.Visible = true;
            tabPageTema.Controls.Add(lblNombTema);

            //
            // Picture box Check
            //
            PictureBox pbCheck = new PictureBox();
            pbCheck.Location = new Point(814, 59 + altura);
            pbCheck.BackColor = Color.FromArgb(0, 0, 90);
            pbCheck.Size = new Size(36, 36);
            pbCheck.SizeMode = PictureBoxSizeMode.AutoSize;
            pbCheck.Image = global::Sinapxon.Properties.Resources.baseline_check_circle_white_18dp;
            pbCheck.Name = "pbChecked";
            tabPageTema.Controls.Add(pbCheck);

            //
            // btn Ver tema
            //
            Button btnEntrarTema = new Button();
            btnEntrarTema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnEntrarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnEntrarTema.FlatAppearance.BorderSize = 0;
            btnEntrarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEntrarTema.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEntrarTema.Location = new System.Drawing.Point(645, 59 + altura);
            btnEntrarTema.Name = "btnVerTema";
            btnEntrarTema.Size = new System.Drawing.Size(122, 36);
            btnEntrarTema.Text = "Ver tema";
            btnEntrarTema.UseVisualStyleBackColor = false;
            btnEntrarTema.Click += new System.EventHandler(this.btnVerTema_Click);
            tabPageTema.Controls.Add(btnEntrarTema);

            //
            // Picture box Contenedor azul
            //
            PictureBox boxBase = new PictureBox();
            boxBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            boxBase.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            boxBase.Location = new Point(6, 18 + altura);
            boxBase.Name = "pictureBoxBlue";
            boxBase.Size = new Size(888, 119);
            boxBase.SizeMode = PictureBoxSizeMode.StretchImage;
            boxBase.BackColor = Color.FromArgb(130, 130, 130);
            tabPageTema.Controls.Add(boxBase);

            altura = altura + boxAltura;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTemas_Click(object sender, EventArgs e)
        {
            frmTemas formTemas = new frmTemas();
            formTemas.Visible = true;
            
        }

        private void BtnEvaluaciones_Click(object sender, EventArgs e)
        {
            frmEvaluaciones formEvaluaciones = new frmEvaluaciones();
            formEvaluaciones.Visible = true;
        }

        private void btnVerTema_Click(object sender, EventArgs e)
        {
            frmTema formTema = new frmTema();
            formTema.Visible = true;
        }
    }
}
