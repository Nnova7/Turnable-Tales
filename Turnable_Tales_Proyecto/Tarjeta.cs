using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace Turnable_Tales_Proyecto
{
    public partial class Tarjeta : Form
    {
        private bool optionSelected = false; // Indica si se presionó algún botón de opción
        private List<Elemento> ticketList = new List<Elemento>(); // Lista de discos comprados
        private List<Productos> productosList = new List<Productos>(); // Lista de productos con precios

        private void PopulateTextBoxes()
        {
            double subtotal = 0;

            // Iterar sobre la lista de tickets para calcular el subtotal
            foreach (var ticket in ticketList)
            {
                // Buscar el producto correspondiente en la lista de productos
                var producto = productosList.FirstOrDefault(p => p.Id == ticket.Id);
                if (producto != null)
                {
                    // Calcular el importe
                    double importe = ticket.Cantidad * producto.Precio;

                    // Acumular el subtotal
                    subtotal += importe;

                }
            }
            //obtener y agregar el costo de envio
            if (decimal.TryParse(textBoxCosEnvio.Text, out decimal randomCost))
            {
                subtotal += (double)randomCost;
            }

            // Calcular impuestos y total
            double impuesto = subtotal * 0.06; // 6% de impuesto
            double total = subtotal + impuesto;

            // Mostrar resultados en los TextBoxes correspondientes
            textBoxSub.Text = subtotal.ToString("F2");
            textBoxImp.Text = impuesto.ToString("F2");
            textBoxTot.Text = total.ToString("F2");
        }

        public string nombreUsuario
        {
            get { return textBoxUsuario.Text; }
            set { textBoxUsuario.Text = value; }
        } // Propiedad para recibir el nombre
        public Tarjeta()
        {
            InitializeComponent();
        }
        public Tarjeta(string n)
        {
            InitializeComponent();
            nombreUsuario = n;
            this.Load += Tarjeta_Load; // Vincula el evento Load
            // Inicializa el estado del botón
            buttonGuardar.Enabled = false;
            buttonTicket.Enabled = false;
            //cambio de texto
            textBoxNTarjeta.TextChanged += ValidateInputs;
            textBoxMes.TextChanged += ValidateInputs;
            textBoxAnio.TextChanged += ValidateInputs;
            textBoxCVV.TextChanged += ValidateInputs;

            buttonVisa.Click += OptionButtonClicked;
            buttonMaster.Click += OptionButtonClicked;
            buttonAmerican.Click += OptionButtonClicked;
            buttonCarnet.Click += OptionButtonClicked;

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

        private void GenerateRandomValues()
        {
            Random random = new Random();

            // Generar número de pedido
            int randomNum = random.Next(1000, 10000);
            textBoxNPedido.Text = randomNum.ToString();

            // Generar costo de envío
            decimal randomCost = random.Next(500, 1701) / 10m;
            textBoxCosEnvio.Text = randomCost.ToString("F2");
        }

        private void OptionButtonClicked(object sender, EventArgs e)
        {
            optionSelected = true; // Se registra que una opción fue seleccionada
            ValidateInputs(null, null); // Valida nuevamente los datos
        }

        private void ValidateInputs(object sender, EventArgs e)
        {
            // Verifica si todos los campos están llenos y si se seleccionó una opción
            buttonGuardar.Enabled =
                !string.IsNullOrWhiteSpace(textBoxNTarjeta.Text) &&
                !string.IsNullOrWhiteSpace(textBoxMes.Text) &&
                !string.IsNullOrWhiteSpace(textBoxAnio.Text) &&
                !string.IsNullOrWhiteSpace(textBoxCVV.Text) &&
                optionSelected;
        }


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

        private void Tarjeta_Load(object sender, EventArgs e)
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Verifica si los campos son válidos y si se seleccionó una opción
            if (string.IsNullOrWhiteSpace(textBoxNTarjeta.Text) ||
                string.IsNullOrWhiteSpace(textBoxMes.Text) ||
                string.IsNullOrWhiteSpace(textBoxAnio.Text) ||
                string.IsNullOrWhiteSpace(textBoxCVV.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!optionSelected)
            {
                MessageBox.Show("Por favor, seleccione una opción antes de continuar.", "Opción faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todo está correcto, realiza la operación
            if (decimal.TryParse(textBoxNTarjeta.Text, out _) && decimal.TryParse(textBoxMes.Text, out _) && decimal.TryParse(textBoxAnio.Text, out _) && decimal.TryParse(textBoxCVV.Text, out _))
            {
                MessageBox.Show("Todos los datos son válidos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Deshabilitar los TextBox para evitar modificaciones
                textBoxNTarjeta.Enabled = false;
                textBoxMes.Enabled = false;
                textBoxAnio.Enabled = false;
                textBoxCVV.Enabled = false;
                buttonGuardar.Enabled = false;
                buttonVisa.Enabled = false;
                buttonMaster.Enabled = false;
                buttonAmerican.Enabled = false;
                buttonCarnet.Enabled = false;
                buttonTicket.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void textBoxCVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMusica_Click(object sender, EventArgs e)
        {
            //llama a la funcion de pausar y reproducir musica
            AudioPlayer.ToggleMusic();
        }
    }
}
