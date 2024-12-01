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
        public ListaGeneros()
        {
            InitializeComponent();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(); //se crea instancia
            this.Hide();
            mostrar.ShowDialog(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void buttonRock1_Click(object sender, EventArgs e)
        {
            Eureka eurekaForm = new Eureka();//crea instancia
            this.Hide();//oculta
            eurekaForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonRock2_Click(object sender, EventArgs e)
        {
            Silencio silencioForm = new Silencio();//crea instancia
            this.Hide();//oculta
            silencioForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonCorridos1_Click(object sender, EventArgs e)
        {
            Incomodo incomodoForm = new Incomodo();//creainstancia
            this.Hide();//oculta
            incomodoForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonCorridos2_Click(object sender, EventArgs e)
        {
            Sad sadForm = new Sad();//crea instancia
            this.Hide();//oculta
            sadForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonClasica1_Click(object sender, EventArgs e)
        {
            Carmen carmenForm = new Carmen();//se crea instancia
            this.Hide();//esconde el form anterior
            carmenForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonClasica2_Click(object sender, EventArgs e)
        {
            Vestila vestiForm = new Vestila();//se crea instancia
            this.Hide();//esconde el form anterior
            vestiForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonPop1_Click(object sender, EventArgs e)
        {
            TheWorld WorldForm = new TheWorld();//se crea instancia
            this.Hide();//esconde el form anterior
            WorldForm.ShowDialog();//muestra
            this.Close();//cierra
        }

        private void buttonPop2_Click(object sender, EventArgs e)
        {
            Love loveForm = new Love();//se crea instancia
            this.Hide();//esconde el form anterior
            loveForm.ShowDialog();//muestra
            this.Close();//cierra
        }
    }
}
