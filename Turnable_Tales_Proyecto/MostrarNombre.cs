using System;
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
    public partial class MostrarNombre : Form
    {
        public MostrarNombre()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Regresa a la portada principal del proyecto cuando seleccione cerrar sesión.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            PortadaProyecto portadaProyecto = new PortadaProyecto();
            this.Hide();
            portadaProyecto.Show();
            this.Close();
        }
        /// <summary>
        /// Regresa al form anterior que es donde se muestran las listas de genero del proyecto cuando seleccione la equis.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ListaGeneros lista = new ListaGeneros();
            this.Hide();
            lista.Show();
            this.Close();
        }
    }
}
