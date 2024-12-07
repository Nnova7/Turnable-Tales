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
    public partial class FormMenuAdmin : Form//MENU PRINCIPAL DEL ADMINISTRADOR
    {
        public string nombreUsuario { get; set; }
        public FormMenuAdmin()
        {
            InitializeComponent();
        }//CONSTRUCTOR
        public FormMenuAdmin(string n)
        {
            InitializeComponent();
            nombreUsuario = n;
        }//constructor para pasarle el nombre

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarDisco_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            if (obj.numDeRegistros() < 10)//En caso de que se puedan agregar discos
            {
                FormAgregarDisco formAgregarDisco = new FormAgregarDisco();
                this.Hide();
                formAgregarDisco.ShowDialog();
                this.Show();
            }//if
            else//En caso de que este lleno sale la restriccion
            {
                FormDenegado formDenegado=new FormDenegado("SE ALCANZO EL NUMERO MAXIMO DE VINILOS");
                formDenegado.ShowDialog();
            }//else
        }//buttonAgregarDisco_Click

        private void buttonVentasTotales_Click(object sender, EventArgs e)
        {
            FormVentas ventas = new FormVentas(); //se crea instancia
            this.Hide();
            ventas.ShowDialog(); 
            this.Show(); 
        }

        private void buttonEliminaDisco_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            if(obj.numDeRegistros() > 6)//Si se pueden eliminar discos
            {
                FormEliminar formEliminar = new FormEliminar();
                this.Hide();
                formEliminar.ShowDialog();
                this.Show();
            }//if
            else//En caso de que no haya discos sale la restriccion
            {
                FormDenegado formDenegado = new FormDenegado("SE ALCANZO EL NUMERO MINIMO DE DISCOS");
                formDenegado.ShowDialog();
            }//else 
        }//buttonEliminaDisco_Click

        private void buttonGraficas_Click(object sender, EventArgs e)
        {
            FormGraficas graficas = new FormGraficas(); //se crea instancia
            this.Hide();
            graficas.ShowDialog(); // Mostrar
            this.Show(); // Cerrar el formulario actual 
        }//buttonGraficas_Click

        private void buttonListado_Click(object sender, EventArgs e)
        {
            FormListado listado = new FormListado(); //se crea instancia
            this.Hide();
            listado.ShowDialog(); // Mostrar
            this.Show(); // Cerrar el formulario actual 
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(nombreUsuario); //se crea instancia
            mostrar.ShowDialog(); // Mostrar
        }
    }
}
