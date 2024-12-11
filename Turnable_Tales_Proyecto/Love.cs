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
        public string nombreUsuario
        {
            get { return textBoxUsuario.Text; }
            set { textBoxUsuario.Text = value; }
        } // Propiedad para recibir el nombre

        public int id;
        public Love(int id)
        {

            InitializeComponent();
            this.id = id;
        }
        //constructor para pasar el nombre
        public Love(string n, int id)
        {
            InitializeComponent();
            nombreUsuario = n;
            id = id;
        }

        /*private void buttonUsuario_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(nombreUsuario); //se crea instancia
            //this.Hide();
            mostrar.Show(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }*/

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            ListaGeneros discos = new ListaGeneros(nombreUsuario);// se crea instancia
            this.Hide();//esconde el form de atras
            discos.Show();//muestra
            this.Close();//cierra
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Tarjeta tarjeta = new Tarjeta(nombreUsuario); //se crea instancia
            this.Hide();
            tarjeta.ShowDialog(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Efectivo efectivo = new Efectivo(nombreUsuario); //se crea instancia
            this.Hide();
            efectivo.ShowDialog(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Oxxo oxxo = new Oxxo(nombreUsuario); //se crea instancia
            this.Hide();
            oxxo.ShowDialog(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToShortTimeString();
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Love_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                textBoxUsuario.Text = nombreUsuario;
            }
            else
            {
                textBoxUsuario.Text = "Usuario desconocido";
            }
            Productos p = new Productos();
            Datos d = new Datos();

            p = d.ConsultarUnRegistro(id);
            label10.Text = p.Artista;
            label9.Text = p.Genero;
            label8.Text = p.Nombre;
            label12.Text = p.Precio.ToString();
            label11.Text = p.Id.ToString();
            domainUpDownCantidad.Text = p.Cantidad.ToString();                                                
            descripcionLove.Text = p.Descripcion;
            //textBoxNumero (es el numero de existencias)

        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            PortadaProyecto portada = new PortadaProyecto();
            this.Hide();
            portada.ShowDialog();
            this.Close();
        }

        private void buttonEliminarTodo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //Hacer lista de carrito con varieble o vector de todo * cantidad de discos

        }

        private void domainUpDownCantidad_SelectedItemChanged(object sender, EventArgs e)
        {
            //cantidad de discos valor
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
