﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnable_Tales_Proyecto
{
    public partial class FormDenegado : Form
    {
        public FormDenegado()
        {
            InitializeComponent();
        }

        public FormDenegado(string error)
        {
            InitializeComponent();
            this.labelError.Text = error;
        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegresa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDenegado_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                textBoxUsuario.Text = nombreUsuario;
            }
            else
            {
                textBoxUsuario.Text = "Usuario desconocido";
            }
        }
    }
}
