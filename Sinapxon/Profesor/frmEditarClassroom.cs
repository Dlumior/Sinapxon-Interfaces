using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Profesor
{
    public partial class frmEditarClassroom : Form
    {
        public frmEditarClassroom()
        {
            InitializeComponent();
        }

        private void btnAniadirTema_Click(object sender, EventArgs e)
        {
            frmAniadirTema formAniadirTema = new frmAniadirTema();
            formAniadirTema.Visible = true;
        }

        private void btnAniadirEvaluacion_Click(object sender, EventArgs e)
        {
            frmAniadirEvaluacion formAniadirEvaluacion = new frmAniadirEvaluacion();
            formAniadirEvaluacion.Visible = true;
        }
    }
}
