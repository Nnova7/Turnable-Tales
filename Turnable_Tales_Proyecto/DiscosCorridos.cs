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
    public partial class DiscosCorridos : Form
    {
        public DiscosCorridos()
        {
            InitializeComponent();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            ListaGeneros lista = new ListaGeneros();
            this.Hide();
            lista.Show();
            this.Close();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(); //se crea instancia
            this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonIncomodo_Click(object sender, EventArgs e)
        {
            Incomodo mostrar = new Incomodo(); //se crea instancia
            this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonSad_Click(object sender, EventArgs e)
        {
            Sad mostrar = new Sad(); //se crea instancia
            this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }
    }
}
