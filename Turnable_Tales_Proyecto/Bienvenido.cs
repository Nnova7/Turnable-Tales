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
    public partial class Bienvenido : Form
    {
        private bool Abrir;
        public Bienvenido()
        {
            InitializeComponent();
        }

        public Bienvenido(bool a)
        {
            InitializeComponent();
            this.Abrir = a;
        }
        

        /// <summary>
        /// Con el boton siguiente nos dirige a la lista de Generos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if(Abrir){
                ListaGeneros listaGeneros = new ListaGeneros(); //Crear instancia de ListaGeneros
                listaGeneros.Show(); //Mostrar el formulario ListaGeneros
                this.Close(); //Cerrar el formulario actual (Bienvenido)
            }
            else
            {
                FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
                formMenuAdmin.Show();
                this.Close();
            }
            
        }
    }
}
