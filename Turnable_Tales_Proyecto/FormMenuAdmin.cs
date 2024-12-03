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
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarDisco_Click(object sender, EventArgs e)
        {
            FormAgregarDisco agregarDisc = new FormAgregarDisco(); //se crea instancia
            this.Hide();
            agregarDisc.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonVentasTotales_Click(object sender, EventArgs e)
        {
            FormVentas ventas = new FormVentas(); //se crea instancia
            this.Hide();
            ventas.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonEliminaDisco_Click(object sender, EventArgs e)
        {
            FormEliminar eliminar = new FormEliminar(); //se crea instancia
            this.Hide();
            eliminar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonGraficas_Click(object sender, EventArgs e)
        {
            FormGraficas graficas = new FormGraficas(); //se crea instancia
            this.Hide();
            graficas.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonListado_Click(object sender, EventArgs e)
        {
            FormListado listado = new FormListado(); //se crea instancia
            this.Hide();
            listado.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(); //se crea instancia
            this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }
    }
}
