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
    public partial class frmMisClassrooms : Form
    {
        private bool _irClassroom = false;
        private Form formularioActivo = null;

        public bool IrClassroom { get => _irClassroom; set => _irClassroom = value; }

        public frmMisClassrooms()
        {
            InitializeComponent();
            this.BringToFront();
        }

        public void openChildForm(Panel panelClassroom,Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelClassroom.Controls.Add(formularioHijo);
            panelClassroom.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIrClassroom_Click(object sender, EventArgs e)
        {
            /*
            Panel panelClassroom = new Panel();
            panelClassroom.Dock = DockStyle.Left;
            panelClassroom.BringToFront();
            openChildForm(panelClassroom,new frmMiClassroom());
            */
            frmMiClassroom formMiClassroom = new frmMiClassroom();
            formMiClassroom.Visible = true;
        }
    }
}
