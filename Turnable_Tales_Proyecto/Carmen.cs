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
    public partial class Carmen : Form
    {
        public Carmen()
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
            DiscosClasicos discos = new DiscosClasicos();
            this.Hide();
            discos.Show();
            this.Close();
        }
    }
}
