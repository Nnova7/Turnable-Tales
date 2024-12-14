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
    public partial class FormAgregarDisco : Form
    {
        public string nombreUsuario
        {
            get { return textBoxUsuario.Text; }
            set { textBoxUsuario.Text = value; }
        } // Propiedad para recibir el nombre

        public FormAgregarDisco()
        {
            InitializeComponent();
        }//Constructor

        //constructor para pasarle el nombre
        public FormAgregarDisco(string n)
        {
            InitializeComponent();
            nombreUsuario = n;
        }//Constructor

        /*private void button1_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(nombreUsuario); //se crea instancia
            mostrar.ShowDialog(); // Mostrar
        }*/

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario actual 
        }

        private void FormAgregarDisco_Load(object sender, EventArgs e)
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

        private void agregar()
        {
            Datos obj = new Datos();

            string artista = this.textBoxArtista.Text;
            string genero = this.textBoxGenero.Text;
            string nombre = this.textBoxTitulo.Text;
            string imagen = this.textBoxImagen.Text;
            string descripcion = this.textBoxDescripcion.Text;

            if (!int.TryParse(this.textBoxId.Text, out int id))
            {
                FormDenegado formDenegado2 = new FormDenegado("EL ID DEBE SER UN NUMERO");
                formDenegado2.ShowDialog();
                return;
            }

            if (!int.TryParse(this.textBoxPrecio.Text, out int precio))
            {
                FormDenegado formDenegado2 = new FormDenegado("EL PRECIO DEBE SER UN NUMERO");
                formDenegado2.ShowDialog();
                return;
            }

            if (!int.TryParse(this.textBoxExistencias.Text, out int cantidad))
            {
                FormDenegado formDenegado2 = new FormDenegado("LA CANTIDAD DEBE SER UN NUMERO");
                formDenegado2.ShowDialog();
                return;
            }

            obj.Insertar(id, artista, genero, nombre, precio, cantidad, imagen, descripcion);
            obj.Desconectar();
        }//agregar
        private void buttonActualiza_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();

            //Revisa que se hallan llenado todos los campo
            if (string.IsNullOrEmpty(textBoxId.Text)
                || string.IsNullOrEmpty(textBoxArtista.Text)
                || string.IsNullOrEmpty(textBoxDescripcion.Text)
                || string.IsNullOrEmpty(textBoxExistencias.Text)
                || string.IsNullOrEmpty(textBoxGenero.Text)
                || string.IsNullOrEmpty(textBoxImagen.Text)
                || string.IsNullOrEmpty(textBoxPrecio.Text)
                || string.IsNullOrEmpty(textBoxTitulo.Text)
                )
            {//En caso de que no hallan sido llenados
                FormDenegado form = new FormDenegado("ASEGURESE DE LLENAR TODOS LOS CAMPOS");
                form.ShowDialog();
                return;//Sale de la funcion (no se continua el programa)
            }//if

            if (!int.TryParse(this.textBoxId.Text, out int id))
            {
                FormDenegado formDenegado2 = new FormDenegado("EL ID DEBE SER UN NUMERO");
                formDenegado2.ShowDialog();
                return;
            }

            if (obj.numDeRegistros() < 10)
            {//Si se pueden agregar discos
                bool simon = false;
                List<Productos> list = new List<Productos>();
                list = obj.ConsultarTodos();
                foreach (Productos p in list)
                {
                    if (p.Id == Convert.ToInt32(textBoxId.Text))
                    {
                        simon = true;
                    }//if
                }//foreach

                if (!simon)//Si no se repite el id
                {
                    this.agregar();
                }//if
                else
                {
                    FormDenegado formDenegado = new FormDenegado("EL ID YA HA SIDO UTILIZADO");
                    formDenegado.ShowDialog();
                }//else
            }
            else//en caso de que no se puedan agregar discos
            {
                FormDenegado formDenegado = new FormDenegado("SE ALCANZO EL NUMERO MAXIMO DE VINILOS");
                formDenegado.ShowDialog();
            }//else
        }//buttonActualiza_Click

        private void Limpiar()
        {
            this.textBoxId.Text = string.Empty;
            this.textBoxArtista.Text = string.Empty;
            this.textBoxGenero.Text = string.Empty;
            this.textBoxTitulo.Text = string.Empty;
            this.textBoxPrecio.Text = string.Empty;
            this.textBoxExistencias.Text = string.Empty;
            this.textBoxImagen.Text = string.Empty;
            this.textBoxDescripcion.Text = string.Empty;
        }//limpiar

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
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

        private void buttonMusica_Click(object sender, EventArgs e)
        {
            //llama a la funcion de pausar y reproducir musica
            AudioPlayer.ToggleMusic();
        }
    }
}
