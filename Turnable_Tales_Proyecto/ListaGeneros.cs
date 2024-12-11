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
    public partial class ListaGeneros : Form
    {
        //Pare recibir el nombre
        public string nombreUsuario
        {
            get { return textBoxUsuario.Text; }
            set { textBoxUsuario.Text = value; }
        } // Propiedad para recibir el nombre
        public ListaGeneros()
        {
            InitializeComponent();
        }
        public ListaGeneros(string n)
        {
            InitializeComponent();
            nombreUsuario = n;
        }//constructor para recibir el nombre

        /*private void buttonUsuario_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(nombreUsuario); //se crea instancia
            //this.Hide();
            mostrar.ShowDialog(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }*/

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void buttonRock1_Click(object sender, EventArgs e)
        {
            Love eurekaForm = new Love(nombreUsuario, 5);//crea instancia
            this.Hide();//oculta
            eurekaForm.ShowDialog();//muestra
            this.Close();//cierra

        }

        private void buttonRock2_Click(object sender, EventArgs e)
        {
            Love silencioForm = new Love(nombreUsuario, 6);//crea instancia
            this.Hide();//oculta
            silencioForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonCorridos1_Click(object sender, EventArgs e)
        {
            Love incomodoForm = new Love(nombreUsuario, 7);//creainstancia
            this.Hide();//oculta
            incomodoForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonCorridos2_Click(object sender, EventArgs e)
        {
            Love sadForm = new Love(nombreUsuario, 8);//crea instancia
            this.Hide();//oculta
            sadForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonClasica1_Click(object sender, EventArgs e)
        {
            Love carmenForm = new Love(nombreUsuario, 2);//se crea instancia
            this.Hide();//esconde el form anterior
            carmenForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonClasica2_Click(object sender, EventArgs e)
        {
            Love vestiForm = new Love(nombreUsuario, 1);//se crea instancia
            this.Hide();//esconde el form anterior
            vestiForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonPop1_Click(object sender, EventArgs e)
        {
            Love WorldForm = new Love(nombreUsuario, 3);//se crea instancia
            this.Hide();//esconde el form anterior
            WorldForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonPop2_Click(object sender, EventArgs e)
        {
            Love loveForm = new Love(nombreUsuario, 4);//se crea instancia
            this.Hide();//esconde el form anterior
            loveForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void ListaGeneros_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                textBoxUsuario.Text = nombreUsuario;
            }
            else
            {
                textBoxUsuario.Text = "Usuario desconocido";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToShortTimeString();
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            PortadaProyecto portada = new PortadaProyecto();
            this.Hide();
            portada.ShowDialog();
            this.Close();
        }
    }
}
