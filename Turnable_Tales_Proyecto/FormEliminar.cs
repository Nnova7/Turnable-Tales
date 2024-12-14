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
    public partial class FormEliminar : Form
    {
        public string nombreUsuario
        {
            get { return textBoxUsuario.Text; }
            set { textBoxUsuario.Text = value; }
        } // Propiedad para recibir el nombre
        public FormEliminar()
        {
            InitializeComponent();
        }
        //constructor para pasar el nombre
        public FormEliminar(string n)
        {
            InitializeComponent();
            nombreUsuario = n;
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(nombreUsuario); //se crea instancia
            mostrar.ShowDialog(); // Mostrar
        }*/

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario actual 
        }

        private void FormEliminar_Load(object sender, EventArgs e)
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

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))//Si el textbox esta vacio
            {
                FormDenegado form = new FormDenegado("INTRODUZCA UN ID");
                form.ShowDialog();
                return;
            }

            if (!int.TryParse(this.textBoxId.Text, out int id))//Si el id no es un numero
            {
                FormDenegado formDenegado2 = new FormDenegado("EL ID DEBE SER UN NUMERO");
                formDenegado2.ShowDialog();
                return;
            }//if

            Datos obj = new Datos();
            List<Productos> lista = new List<Productos>();

            if (obj.numDeRegistros() > 6)//Si se pueden eliminar discos
            {
                lista = obj.ConsultarTodos();
                bool simon = false;

                for (int i = 0; i < lista.Count; i++)//ENCONTRAR EL ID
                {
                    if (Convert.ToInt32(textBoxId.Text) == lista[i].Id)
                    {
                        simon = true;
                    }//if
                }//for

                if (simon)//Si el id EXISTE
                {
                    FormSeguridad formSeguridad = new FormSeguridad(Convert.ToInt32(this.textBoxId.Text));
                    formSeguridad.ShowDialog();
                }//if
                else//SI EL ID NO EXISTE
                {
                    FormDenegado formDenegado = new FormDenegado("EL ID NO HA SIDO ENCONTRADO");
                    formDenegado.ShowDialog();
                    return;
                }//else
            }
            else//SI NO SE PUEDEN ELIMINAR MAS DISCOS
            {
                FormDenegado formDenegado = new FormDenegado("SE ALCANZO EL NUMERO MINIMO\nDE DISCOS");
                formDenegado.ShowDialog();
                return;
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxId.Text = string.Empty;
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
