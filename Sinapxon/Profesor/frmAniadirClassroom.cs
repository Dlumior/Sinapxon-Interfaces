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
    public partial class frmAniadirClassroom : Form
    {
        public frmAniadirClassroom()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmDatosClassroom formDatosClassroom = new frmDatosClassroom();
            formDatosClassroom.Visible = true;
        }
    }
}
