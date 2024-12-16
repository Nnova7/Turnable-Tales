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

        private void button1_Click(object sender, EventArgs e)
        {
            Love eurekaForm = new Love(nombreUsuario, 9);//crea instancia
            this.Hide();//oculta
            eurekaForm.ShowDialog();//muestra
            this.Close();//cierra

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Love eurekaForm = new Love(nombreUsuario, 10);//crea instancia
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

            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.buttonClasica1.Enabled = false;
            this.buttonClasica2.Enabled = false;
            this.buttonCorridos1.Enabled = false;
            this.buttonCorridos2.Enabled = false;
            this.buttonRock1.Enabled = false;
            this.buttonRock2.Enabled = false;
            this.buttonPop1.Enabled = false;
            this.buttonPop1.Enabled = false;

            // Configurar el ListView para mostrar iconos grandes
            listView1.View = View.LargeIcon;
            listView1.LargeImageList = imageList1; // Asociar el ImageList al ListView
            Image ResizeImage(Image img, int width, int height)
            {
                Bitmap bmp = new Bitmap(width, height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(img, 0, 0, width, height);
                }
                return bmp;
            }

            

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
                ListViewItem item = new ListViewItem($"NOMBRE: {dato.Nombre}\n\n");

                // Verificar que el nombre de la imagen existe en el ImageList
                if (!string.IsNullOrEmpty(dato.Imagen) && imageList1.Images.ContainsKey(dato.Imagen))
                {
                    // Asociar la clave de la imagen al ítem usando la clave correspondiente en el ImageList
                    item.ImageKey = dato.Imagen;
                }
                else
                {
                    // Si no se encuentra la imagen en el ImageList, asignar una imagen por defecto o manejar el error
                    item.ImageKey = "default";  // Asegúrate de que "default" esté presente en el ImageList
                }


                switch (dato.Id)
                {
                    case 1:
                        buttonClasica2.Enabled = true;
                        buttonClasica2.Text = dato.Nombre;
                        break;
                    case 2:
                        buttonClasica1.Enabled = true;
                        buttonClasica1.Text = dato.Nombre;
                        break;
                    case 3:
                        buttonPop1.Enabled = true;
                        buttonPop1.Text = dato.Nombre;
                        break;
                    case 4:
                        buttonPop2.Enabled = true;
                        buttonPop2.Text = dato.Nombre;
                        break;
                    case 5:
                        buttonRock1.Enabled = true;
                        buttonRock1.Text = dato.Nombre;
                        break;
                    case 6:
                        buttonRock2.Enabled = true;
                        buttonRock2.Text = dato.Nombre;
                        break;
                    case 7:
                        buttonCorridos1.Enabled = true;
                        buttonCorridos1.Text = dato.Nombre;
                        break;
                    case 8:
                        buttonCorridos2.Enabled = true;
                        buttonCorridos2.Text = dato.Nombre;
                        break;
                    case 9:
                        button1.Enabled = true;
                        button1.Text=dato.Nombre;
                        break;
                    case 10:
                        button2.Enabled = true;
                        button2.Text = dato.Nombre;
                        break;
                    default:
                        // Manejar casos que no están definidos explícitamente
                        break;
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

        private void buttonSonido_Click(object sender, EventArgs e)
        {
            //llama a la funcion de pausar y reproducir musica
            AudioPlayer.ToggleMusic();
        }
    }
}
