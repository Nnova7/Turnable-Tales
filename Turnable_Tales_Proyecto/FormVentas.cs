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
    public partial class FormVentas : Form
    {
        public string nombreUsuario { get; set; }
        public FormVentas()
        {
            InitializeComponent();
        }
        //constructor para pasar el nombre
        public FormVentas(string n)
        {
            InitializeComponent();
            nombreUsuario = n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(nombreUsuario); //se crea instancia
            mostrar.ShowDialog(); // MostraR
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            this.labeltxtVentas.Text = "EL TOTAL DE VENTAS ES DE $" + this.totalVentas();
        }//FormVentas_Load

        public int totalVentas()
        {
            int suma = 0;
            Datos obj = new Datos();
            List<Usuarios> lista = new List<Usuarios>();
            lista = obj.ConsultarTodosUsuarios();

            foreach (var item in lista)
            {
                suma += item.Monto;

            }
            obj.Desconectar();
            return suma;
        }//totalVentas

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario actual 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToShortTimeString();
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
