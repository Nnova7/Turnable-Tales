namespace Turnable_Tales_Proyecto
{
    public partial class PortadaGeneral : Form
    {
        public PortadaGeneral()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// buttonSiguiente_Click
        /// En este botón lo que hace es que no permite cambiar a otro Form y continuar con nuestro diseño
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            PortadaProyecto segundaPortada = new PortadaProyecto();
            segundaPortada.ShowDialog();
            this.Show();
        }
    }
}
