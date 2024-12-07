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
    public partial class FormListado : Form
    {
        public string nombreUsuario { get; set; }
        public FormListado()
        {
            InitializeComponent();
        }
        //Constructor para pasarle el nombre
        public FormListado(string n)
        {
            InitializeComponent();
            nombreUsuario = n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(nombreUsuario); //se crea instancia
            mostrar.Show(); // Mostrar
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario actual 
        }

        private void FormListado_Load(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;//Configurar el ListView para mostrar iconos grandes
            listView1.LargeImageList = imageListDiscos;//Asociar el ImageList al ListView

            List<Productos> lista;//Crear una lista para almacenar los productos obtenidos de la base de datos

            //Instanciar un objeto de la clase Datos y consultar todos los productos
            Datos obj = new Datos();
            lista = obj.ConsultarTodos();

            //Ordenar la lista de productos por la cantidad de menor a mayor
            var listaOrdenada = lista.OrderBy(producto => producto.Cantidad).ToList();

            //Recorrer la lista ordenada y agregar cada producto al ListView
            foreach (var dato in listaOrdenada)
            {
                //Crear un nuevo ítem para el ListView con el ID y las existencias del producto
                ListViewItem item = new ListViewItem($"ID: {dato.Id}\nExistencias: {dato.Cantidad}");

                //Asociar la clave de la imagen al ítem
                item.ImageKey = dato.Imagen;

                //Agregar el ítem al ListView
                listView1.Items.Add(item);
            }
            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                textBoxUsuario.Text = nombreUsuario;
            }
            else
            {
                textBoxUsuario.Text = "Usuario desconocido";
            }//if
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToShortTimeString();
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
