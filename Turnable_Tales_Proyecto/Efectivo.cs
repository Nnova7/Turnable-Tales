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
    public partial class Efectivo : Form
    {
        private List<Elemento> ticketList = new List<Elemento>(); // Lista de discos compras
        private List<Productos> productosList = new List<Productos>(); // Lista de productos con precio
        public Efectivo(List<Elemento> tickets, List<Productos> productos)
        {
            InitializeComponent();
            ticketList = tickets ?? new List<Elemento>();
            productosList = productos ?? new List<Productos>();
            PopulateTextBoxes();
        }

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
            textBoxSub.Text = subtotal.ToString("F2");
            textBoxImp.Text = impuesto.ToString("F2");
            textBoxTot.Text = total.ToString("F2");
        }
        public string nombreUsuario
        {
            get { return textBoxUsuario.Text; }
            set { textBoxUsuario.Text = value; }
        } // Propiedad para recibir el nombre
        public Efectivo()
        {
            InitializeComponent();
        }
        public Efectivo(string n)
        {
            InitializeComponent();
            nombreUsuario = n;
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
            listageneros.ShowDialog(); //mostrar
            this.Close(); //cerrar el formulario actual 
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(nombreUsuario); //se crea instancia
            this.Hide();
            ticket.ShowDialog(); //mostrar
            this.Close(); //cerrar el formulario actual 
        }

        private void Efectivo_Load(object sender, EventArgs e)
        {
            GenerateRandomValues();
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

        private void ValidateInputs(object sender, EventArgs e)
        {
            //verifica si TextBoxPagoCon tiene datos
            buttonCambio.Enabled = !string.IsNullOrWhiteSpace(textBoxPagoCon.Text);
        }

        private void buttonMusica_Click(object sender, EventArgs e)
        {
            //llama a la funcion de pausar y reproducir musica
            AudioPlayer.ToggleMusic();
        }

        private void buttonCambio_Click(object sender, EventArgs e)
        {
            //realiza la resta y muestra el resultado
            if (decimal.TryParse(textBoxTot.Text, out decimal total) && decimal.TryParse(textBoxPagoCon.Text, out decimal pagoCon))
            {
                if (pagoCon >= total)
                {
                    textBoxCam.Text = (pagoCon - total).ToString("F2");
                    buttonTicket.Enabled = true; //habilitar el boton de Ticket
                }
                else
                {
                    MessageBox.Show("El pago no es suficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateRandomValues()
        {
            Random random = new Random();

            //generar numero de pedido
            int randomNum = random.Next(1000, 10000);
            textBoxNPedido.Text = randomNum.ToString();
        }
    }
}
