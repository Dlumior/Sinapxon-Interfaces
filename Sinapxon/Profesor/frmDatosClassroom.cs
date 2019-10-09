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
    public partial class frmDatosClassroom : Form
    {
        public frmDatosClassroom()
        {
            InitializeComponent();
        }

        private void BtnEnviarSolicitud_Click(object sender, EventArgs e)
        {
            frmConfirmacionEnvioSolicitudClassroom formConfirmacion = new frmConfirmacionEnvioSolicitudClassroom();
            formConfirmacion.Visible = true;
        }
    }
}
