using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Turnable_Tales_Proyecto
{
    public partial class FormGraficas : Form
    {
        public string nombreUsuario { get; set; }
        public FormGraficas()
        {
            InitializeComponent();
        }
        //Constructor para pasar el nombre
        public FormGraficas(string n)
        {
            InitializeComponent();
            nombreUsuario = n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(nombreUsuario); //se crea instancia
            mostrar.ShowDialog(); // Mostrar
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario actual 
        }

        private void FormGraficas_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            List<Productos> list = obj.ConsultarTodos();
            string[] series = new string[list.Count];//Sacar el tamaño del arreglo del tamaño de la lista
            int[] puntos = new int[list.Count];

            chart1.Titles.Add("GRAFICA DE EXISTENCIAS");

            int i = 0;
            foreach (var item in list)
            {
                series[i] = item.Nombre;
                puntos[i] = item.Cantidad;
                i++;
            }//foreach

            for (int j = 0; j < list.Count; j++)
            {
                Series serie = chart1.Series.Add(series[j]);
                serie.Label = puntos[j].ToString();
                serie.Points.Add(puntos[j]);
            }//for
        }//FormGraficas_Load

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
