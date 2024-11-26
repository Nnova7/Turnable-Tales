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
    public partial class DiscosK_pop : Form
    {
        public DiscosK_pop()
        {
            InitializeComponent();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(); //se crea instancia
            this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            ListaGeneros lista = new ListaGeneros();
            this.Hide();
            lista.Show();
            this.Close();
        }

        private void buttonWorld_Click(object sender, EventArgs e)
        {
            TheWorld mostrar = new TheWorld(); //se crea instancia
            this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonLove_Click(object sender, EventArgs e)
        {
            Love mostrar = new Love(); //se crea instancia
            this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }
    }
}
