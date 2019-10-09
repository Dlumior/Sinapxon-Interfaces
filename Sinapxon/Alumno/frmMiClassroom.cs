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
        public frmMiClassroom()
        {
            InitializeComponent();
            lblTitulo.Text = "APLICA";
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTemas_Click(object sender, EventArgs e)
        {
            frmTemas formTemas = new frmTemas();
            /*
            formTemas.MdiParent = this;
            lblTitulo.Visible = false;
            btnTemas.Visible = false;
            btnEvaluaciones.Visible = false;
            btnX.Visible = false;
            */
            formTemas.Visible = true;
            
        }

        private void BtnEvaluaciones_Click(object sender, EventArgs e)
        {
            frmEvaluaciones formEvaluaciones = new frmEvaluaciones();
            formEvaluaciones.Visible = true;
        }
    }
}
