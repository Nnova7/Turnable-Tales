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
        public string NombreUsuario
        {
            get { return textBoxUsuario.Text; }
            set { textBoxUsuario.Text = value; }
        } // Propiedad para recibir el nombre

        public MostrarNombre(string n)
        {
            InitializeComponent();
            NombreUsuario = n;
        }
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
            ListaGeneros lista = new ListaGeneros(); //Crea instancia
            this.Hide();// Oculta el Form de atras
            lista.ShowDialog(); //Muestra
            this.Close(); //Cierra
        }
        /// <summary>
        /// Se colocó la fecha en tiempo real y la hora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void horafecha_Tick(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToShortTimeString();
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void textBoxFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarNombre_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NombreUsuario))
            {
                textBoxUsuario.Text = NombreUsuario;
            }
            else
            {
                textBoxUsuario.Text = "Usuario desconocido";
            }
        }
    }
}
