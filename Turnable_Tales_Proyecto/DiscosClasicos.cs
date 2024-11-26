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
    public partial class DiscosClasicos : Form
    {
        public DiscosClasicos()
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

        private void DiscosClasicos_Load(object sender, EventArgs e)
        {

        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            ListaGeneros lista = new ListaGeneros();
            this.Hide();
            lista.Show();
            this.Close();
        }

        private void buttonCarmen_Click(object sender, EventArgs e)
        {
            Carmen mostrar = new Carmen(); //se crea instancia
            this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonVestila_Click(object sender, EventArgs e)
        {
            Vestila mostrar = new Vestila(); //se crea instancia
            this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }
    }
}
