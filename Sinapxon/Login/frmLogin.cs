using Sinapxon.Administrador;
using Sinapxon.Alumno;
using Sinapxon.Profesor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //pctLogoSinapxon.Image = Image.FromFile("Imagenes/SINAPXON_LOGO.png");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*
            frmPrincipal formPrincipal = new frmPrincipal();
            formPrincipal.Visible = true;
            this.Visible = true;
            */

            /*
            frmAlumno formAlumno = new frmAlumno();
            formAlumno.Visible = true;
            this.Visible = true;
            */

            
            frmProfesor formProfesor = new frmProfesor();
            formProfesor.Visible = true;
            this.Visible = true;
            

            /*
            frmAdministrador formAdministrador = new frmAdministrador();
            formAdministrador.Visible = true;
            this.Visible = true;
            */
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmRegistro formRegistro = new frmRegistro();
            formRegistro.Visible = true;
            this.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmOvlideContrasenia formOlvideContrasenia = new frmOvlideContrasenia();
            formOlvideContrasenia.Visible = true;
            this.Visible = true;
        }

        private void pctImagenSinapxon_Click(object sender, EventArgs e)
        {

        }
    }
}
