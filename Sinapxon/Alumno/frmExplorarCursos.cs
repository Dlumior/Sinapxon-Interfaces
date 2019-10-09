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
    public partial class frmExplorarCursos : Form
    {
        public frmExplorarCursos()
        {
            InitializeComponent();
        }

        private void BtnVerCurso_Click(object sender, EventArgs e)
        {
            frmExplorarCurso formExplorarCurso = new frmExplorarCurso();
            formExplorarCurso.Visible = true;
        }
    }
}
