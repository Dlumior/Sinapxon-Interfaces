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
    public partial class frmGestionarProfesor : Form
    {
        private frmAdministrador _padre = null;
        public frmGestionarProfesor()
        {
            InitializeComponent();
        }

        public frmGestionarProfesor(frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;
        }

        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmListaUsuarios formListaUsuario = new frmListaUsuarios("profesores");
            formListaUsuario.Visible = true;
        }
    }
}
