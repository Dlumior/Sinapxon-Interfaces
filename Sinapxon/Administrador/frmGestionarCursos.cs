using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Administrador
{
    public partial class frmGestionarCursos : Form
    {
        private frmAdministrador _padre = null;
        public frmGestionarCursos()
        {
            InitializeComponent();
        }

        public frmGestionarCursos(frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;
        }

        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        private void btnAniadirCurso_Click(object sender, EventArgs e)
        {
            Padre.openChildForm(new frmAgregarCurso("Añadir"));
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            Padre.openChildForm(new frmAgregarCurso("Editar"));
        }
    }
}
