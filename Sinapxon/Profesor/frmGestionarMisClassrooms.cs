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
    public partial class frmGestionarMisClassrooms : Form
    {
        public frmGestionarMisClassrooms()
        {
            InitializeComponent();
        }

        private void BtnEditarClassroom_Click(object sender, EventArgs e)
        {

        }

        private void BtnAniadirClassroom_Click(object sender, EventArgs e)
        {
            frmAniadirClassroom formAniadirClassroom = new frmAniadirClassroom();
            formAniadirClassroom.Visible = true;
        }
    }
}
