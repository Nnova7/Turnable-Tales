namespace Baseball
{
    public partial class Jugador : Form
    {
        //Variables con las que podremos acceder a los datos
        //Inicializadas automaticamente

        public string NumUniforme { get; set; }
        public string Nombre { get; set; }
        public string Ponches { get; set; }
        public string Errores { get; set; }
        public string Posicion { get; set; }
        public int Hits { get; set; }

        List<Jugador> jugadores = new List<Jugador>();


        public Jugador()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonCaptura_Click(object sender, EventArgs e)
        {
            Jugador jugadorInfo = new Jugador();
            jugadorInfo.NumUniforme = txtNumUniforme.Text;
            jugadorInfo.Nombre = txtNombre.Text;    
            jugadorInfo.Ponches = txtPonches.Text;
            jugadorInfo.Hits = (int)numHits.Value;
            jugadorInfo.Errores = txtErrores.Text;
            //posicion
            if (radioButtonPitcher.Checked)
            {
                jugadorInfo.Posicion = "Pitcher";
            }
            else if (radioButtonPosicion.Checked)
            {
                jugadorInfo.Posicion = "Jugador de posicion";
            }
            else if (radioButtonBateador.Checked)
            {
                jugadorInfo.Posicion = "Bateador designado";
            }
            else
            {
                MessageBox.Show("Selecciona una posicion");
                return;
            }
            jugadores.Add(jugadorInfo);//Se agrega a la lista
            MessageBox.Show("Los datos se han capturado");
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            //Variable para mostrar datos
            string infoJugadores = "";

            foreach (Jugador jug in jugadores)
            {
                //Añadimos la informacion
                infoJugadores += $"Nombre: {jug.Nombre}\r\n Uniforme: {jug.NumUniforme}\r\n" +
                    $" Posicion: {jug.Posicion}\r\n Hits: {jug.Hits}\r\n" +
                    $"Ponches: {jug.Ponches}\r\n Errores: {jug.Errores}\r\n";

                txtMuestra.Text = infoJugadores;
                txtMuestra.Text = infoJugadores;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
