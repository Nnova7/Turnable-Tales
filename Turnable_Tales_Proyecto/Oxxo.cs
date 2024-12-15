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
    public partial class Oxxo : Form
    {
        private List<Elemento> ticketList = new List<Elemento>(); // Lista de discos compras
        private List<Productos> productosList = new List<Productos>(); // Lista de productos con precio

        private void PopulateTextBoxes()
        {
            double subtotal = 0;

            // Iterar sobre la lista de tickets para calcular el subtotal
            foreach (var ticket in ticketList)
            {
                //buscar el producto correspondiente en la lista de productos
                var producto = productosList.FirstOrDefault(p => p.Id == ticket.Id);
                if (producto != null)
                {
                    //calcular el importe
                    double importe = ticket.Cantidad * producto.Precio;

                    //acumular el subtotal
                    subtotal += importe;
                }
            }

            //calcular impuestos y total
            double impuesto = subtotal * 0.06; // 6% de impuesto
            double total = subtotal + impuesto;

            //mostrar resultados en los TextBoxes correspondientes
            textBoxValor.Text = total.ToString("F2");
        }
        public string nombreUsuario
        {
            get { return textBoxUsuario.Text; }
            set { textBoxUsuario.Text = value; }
        } // Propiedad para recibir el nombre
        public Oxxo()
        {
            InitializeComponent();
        }
        public Oxxo(string n)
        {
            InitializeComponent();
            nombreUsuario = n;
            ticketList = ListaGlobal.ObtenerLista() ?? new List<Elemento>();
            // Crear una instancia de ProductosGlobal para obtener la lista de productos
            var Datos = new Datos();
            productosList = Datos.ConsultarTodos() ?? new List<Productos>(); // Asume que tienes una fuente global para los productos
            PopulateTextBoxes();
        }

        /*private void buttonUsuario_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(nombreUsuario); //se crea instancia
            //this.Hide();
            mostrar.ShowDialog(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }*/

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            ListaGeneros listageneros = new ListaGeneros(nombreUsuario); //se crea instancia
            this.Hide();
            listageneros.ShowDialog(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(nombreUsuario); //se crea instancia
            this.Hide();
            ticket.ShowDialog(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToShortTimeString();
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Oxxo_Load(object sender, EventArgs e)
        {
            GenerateRandomValues();

            // Establecer las fechas en los TextBox
            textBoxFechaCrea.Text = DateTime.Now.ToString("dd/MM/yy"); //fecha actual
            textBoxPagAntes.Text = DateTime.Now.AddDays(3).ToString("dd/MM/yy"); //fecha 3 días despues


            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                textBoxUsuario.Text = nombreUsuario;
            }
            else
            {
                textBoxUsuario.Text = "Usuario desconocido";
            }
        }

        private void GenerateRandomValues()
        {
            Random random = new Random();

            // Generar número de pedido
            int randomNum = random.Next(1000, 10000);
            textBoxNPedido.Text = randomNum.ToString();
        }
        private void buttonMusica_Click(object sender, EventArgs e)
        {
            //llama a la funcion de pausar y reproducir musica
            AudioPlayer.ToggleMusic();
        }
    }
}
