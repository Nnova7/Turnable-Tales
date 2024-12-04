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
    public partial class FormGraficas : Form
    {
        public FormGraficas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(); //se crea instancia
            //this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menu = new FormMenuAdmin(); //se crea instancia
            this.Hide();
            menu.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }
    }
}
