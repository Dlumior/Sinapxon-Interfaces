﻿using System;
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
    public partial class frmEvaluacion : Form
    {
        public frmEvaluacion()
        {
            InitializeComponent();
        }

        private void btnGuardarEvaluacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}