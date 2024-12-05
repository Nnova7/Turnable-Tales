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
        public FormVentas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(); //se crea instancia
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

        
    }
}
