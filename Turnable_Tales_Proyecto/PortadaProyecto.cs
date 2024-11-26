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
        /// <summary>
        /// en la función buttonUsuario_Clic
        /// Crea una instancia para abrir el formulario, luego lo muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            this.Hide();
            usuario.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// En la función buttonSalir_Click regresa a la portada General de este proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            PortadaGeneral port1 = (PortadaGeneral)Application.OpenForms["PortadaGeneral"];
            if (port1 != null)
            {
                this.Hide();
                port1.Show();
                this.Close();
            }
        }

        private void PortadaProyecto_Load(object sender, EventArgs e)
        {

        }
    }
}
