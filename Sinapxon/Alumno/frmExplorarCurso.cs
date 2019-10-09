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
    public partial class frmExplorarCurso : Form
    {
        public frmExplorarCurso()
        {
            InitializeComponent();
        }

        private void BtnVerClassroom_Click(object sender, EventArgs e)
        {
            frmExplorarClassroom formExplorarClassroom = new frmExplorarClassroom();
            formExplorarClassroom.Visible = true;
        }
    }
}
