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

        private int id;
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
            this.id = id;
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

            p = d.ConsultarUnRegistro(this.id);
            this.label10.Text = p.Artista;
            this.label9.Text = p.Genero;
            this.label8.Text = p.Nombre;
            this.label12.Text = p.Precio.ToString();
            this.label11.Text = p.Id.ToString();

            this.descripcionLove.Text = p.Descripcion;
            this.textBoxNumero.Text = p.Cantidad.ToString();

            // domainUpDownCantidad.Text = p.Cantidad.ToString();

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



        //para poder asignar valores y mandar valores
        public class Elemento
        {
            public int Id { get; set; }
            public int Cantidad { get; set; }
            public string Descripcion { get; set; }

            public Elemento(int id, int cantidad, string descripcion)
            {
                Id = id;
                Cantidad = cantidad;
                Descripcion = descripcion;
            }


            //lista que se le manda a vale  
            public override string ToString()
            {
                return $"ID: {Id}, Cantidad: {Cantidad}, Descripcion: {Descripcion}";
            }
            public static class ListaGlobal
            {
                private static List<Elemento> miLista = new List<Elemento>();

                public static void Insertar(int id, int cantidad, string descripcion)
                {
                    miLista.Add(new Elemento(id, cantidad, descripcion));
                }

                public static List<Elemento> ObtenerLista()
                {
                    return miLista;
                }
            }
        }

        //agregar id y depues string


        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
