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
        public string nombreUsuario
        {
            get { return textBoxUsuario.Text; }
            set { textBoxUsuario.Text = value; }
        } // Propiedad para recibir el nombre
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

        /*private void button1_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(nombreUsuario); //se crea instancia
            mostrar.Show(); // Mostrar
        }*/

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario actual 
        }

        private void FormListado_Load(object sender, EventArgs e)
        {
            // Configurar el ListView para mostrar iconos grandes
            listView1.View = View.LargeIcon;
            listView1.LargeImageList = imageListDiscos; // Asociar el ImageList al ListView

            List<Productos> lista; // Crear una lista para almacenar los productos obtenidos de la base de datos

            // Instanciar un objeto de la clase Datos y consultar todos los productos
            Datos obj = new Datos();
            lista = obj.ConsultarTodos();

            // Ordenar la lista de productos por la cantidad de menor a mayor
            var listaOrdenada = lista.OrderBy(producto => producto.Cantidad).ToList();

            // Recorrer la lista ordenada y agregar cada producto al ListView
            foreach (var dato in listaOrdenada)
            {
                // Crear un nuevo ítem para el ListView con el ID y las existencias del producto
                ListViewItem item = new ListViewItem($"ID: {dato.Id}\nExistencias: {dato.Cantidad}");

                // Asegurarse de que la imagen exista en el ImageList
                if (!string.IsNullOrEmpty(dato.Imagen))
                {
                    // Verificar si la imagen ya está en el ImageList
                    if (!imageListDiscos.Images.ContainsKey(dato.Imagen))
                    {
                        // Cargar la imagen de los recursos usando el nombre de imagen
                        Image imagen = (Image)Properties.Resources.ResourceManager.GetObject(dato.Imagen);
                        if (imagen != null)
                        {
                            // Añadir la imagen al ImageList si no existe
                            imageListDiscos.Images.Add(dato.Imagen, imagen);
                        }
                        else
                        {
                            // Si la imagen no se encuentra en los recursos, mostrar un mensaje
                            MessageBox.Show($"Imagen '{dato.Imagen}' no encontrada en los recursos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Asociar la clave de la imagen al ítem
                    item.ImageKey = dato.Imagen;
                }

                // Agregar el ítem al ListView
                listView1.Items.Add(item);
            }

            // Mostrar el nombre de usuario en el TextBox si está disponible
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
