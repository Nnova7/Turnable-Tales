using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Turnable_Tales_Proyecto
{
    public partial class PortadaProyecto : Form
    {
        public PortadaProyecto()
        {
            InitializeComponent();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.ShowDialog();
            this.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            PortadaGeneral port1 = (PortadaGeneral)Application.OpenForms["PortadaGeneral"];
            if (port1 != null)
            {
                port1.Show();
                this.Close();
            }
        }
    }
}
