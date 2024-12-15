using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnable_Tales_Proyecto
{
    public partial class IngresarInvitado : Form
    {
        public IngresarInvitado()
        {
            InitializeComponent();
        }
        /// <summary>
        /// en buttonAtras_Click
        /// Regresa al form donde se escoge el tipo de usuario a ingresar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();//Se muestra
            this.Close();//Se cierra
        }

        private void IngresarInvitado_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Comprobamos la cuenta y contraseña del Invitado
        /// </summary>
        private string cuentaIngresada = ""; // Variable para almacenar la cuenta ingresada
        private void textBoxCuentaI_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la cuenta ingresada
            cuentaIngresada = textBoxCuentaI.Text.Trim();//Trim es para quitar espacios en blanco
        }
        private string contraseñaIngresada = ""; // Variable para almacenar la contraseña ingresada
        private void textBoxContraA_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la contraseña ingresada
            contraseñaIngresada = textBoxContraA.Text.Trim();//Trim es para quitar espacios en blanco
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            string cuentaIngresada = textBoxCuentaI.Text.Trim();
            string contraseñaIngresada = textBoxContraA.Text.Trim();

            // Validar si los campos están vacíos
            if (string.IsNullOrEmpty(cuentaIngresada) || string.IsNullOrEmpty(contraseñaIngresada))
            {
                MessageBox.Show("Por favor ingrese una cuenta y una contraseña", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto de la clase Datos
            Datos obj = new Datos();

            // Verificar cuenta y contraseña
            //////////////////////////////////////////////////////////////////////

            List<Usuarios> lista = obj.ConsultarTodosUsuarios();
            bool simon = false;
            string nombreUsuario = obj.ConsultarCuentaContraInv(cuentaIngresada, contraseñaIngresada);

            foreach (Usuarios x in lista)
            {
                if (x.Cuenta == cuentaIngresada)
                {
                    if (x.Contraseña == contraseñaIngresada)
                    {
                        simon = true;
                        nombreUsuario = x.NombreCompleto;
                        break;
                    }
                }

            }



            /////////////////////////////////////////////////////////
            ///

            // Verificar si el nombre de usuario no es nulo ni vacío
            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show($"Bienvenido, {nombreUsuario}", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /// Abrir Form de Lista de generos
                ListaGeneros formGeneros = new ListaGeneros(nombreUsuario);
                formGeneros.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acceso denegado. Cuenta o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngresarInvitado_Load_1(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {
           
        }
}
}
