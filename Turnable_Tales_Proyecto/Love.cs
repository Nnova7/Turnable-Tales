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
    public partial class Love : Form
    {
        public Love()
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
            ListaGeneros discos = new ListaGeneros();// se crea instancia
            this.Hide();//esconde el form de atras
            discos.Show();//muestra
            this.Close();//cierra
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Tarjeta tarjeta = new Tarjeta(); //se crea instancia
            this.Hide();
            tarjeta.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Efectivo efectivo = new Efectivo(); //se crea instancia
            this.Hide();
            efectivo.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Oxxo oxxo = new Oxxo(); //se crea instancia
            this.Hide();
            oxxo.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }
    }
}
