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
    public partial class Sad : Form
    {
        public Sad()
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
            ListaGeneros discos = new ListaGeneros();//se crea instancia
            this.Hide();//Oculta el form de atras
            discos.Show();//Muestra
            this.Close();//Cierra
        }

        private void buttonTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta tarjeta = new Tarjeta(); //se crea instancia
            this.Hide();
            tarjeta.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonEfectivo_Click(object sender, EventArgs e)
        {
            Efectivo efectivo = new Efectivo(); //se crea instancia
            this.Hide();
            efectivo.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonOxxo_Click(object sender, EventArgs e)
        {
            Oxxo oxxo = new Oxxo(); //se crea instancia
            this.Hide();
            oxxo.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }
    }
}
