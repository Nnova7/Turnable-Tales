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
    public partial class DiscosRock : Form
    {
        public DiscosRock()
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

        private void buttonEureka_Click(object sender, EventArgs e)
        {
            Eureka mostrar = new Eureka(); //se crea instancia
            this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonCaifanes_Click(object sender, EventArgs e)
        {
            Silencio mostrar = new Silencio(); //se crea instancia
            this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }
    }
}
