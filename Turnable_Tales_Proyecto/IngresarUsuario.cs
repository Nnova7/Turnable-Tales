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
    public partial class IngresarUsuario : Form
    {
        public string nombreUsuario { get; set; }
        //Constructor para recibir los datos
        public IngresarUsuario()
        {
            InitializeComponent();
        }
        public IngresarUsuario(string n)
        {
            InitializeComponent();
            nombreUsuario = n;
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
            usuario.Show();//Mostrar
            this.Close();//Cerrar
        }

        /// <summary>
        /// Comprobamos la cuenta y contraseña de los usuarios
        /// </summary>
        private string cuentaIngresada = ""; // Variable para almacenar la cuenta ingresada
        private void textBoxCuentaU_TextChanged(object sender, EventArgs e)
        {
            //Guardar cuenta ingresada
            cuentaIngresada = textBoxCuentaU.Text.Trim();//trim para quitar espacios en blanco
        }
        private string contraIngresada = ""; // Variable para almacenar la contraseña
        private void textBoxContraU_TextChanged(object sender, EventArgs e)
        {
            contraIngresada = textBoxContraU.Text.Trim();//trim para quitar espacios en blanco
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            string cuentaIngresada = textBoxCuentaU.Text;
            string contraseñaIngresada = textBoxContraU.Text;

            // Validar si los campos están vacíos
            if (string.IsNullOrEmpty(cuentaIngresada) || string.IsNullOrEmpty(contraseñaIngresada))
            {
                MessageBox.Show("Por favor ingrese una cuenta y una contraseña", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto de la clase Datos
            Datos obj = new Datos();

            // Consultar lista de usuarios
            List<Usuarios> lista = obj.ConsultarTodosUsuarios();
            bool simon = false;
            string nombreUsuario = "";

            // Bloquear cuentas específicas
            if ((cuentaIngresada == "admin" && contraseñaIngresada == "meilleure") ||
                (cuentaIngresada == "guest" && contraseñaIngresada == "ennemie"))
            {
                MessageBox.Show("Acceso denegado.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Terminar la ejecución
            }

            // Verificar cuenta y contraseña
            foreach (Usuarios x in lista)
            {
                if (x.Cuenta == cuentaIngresada && x.Contraseña == contraseñaIngresada)
                {
                    simon = true;
                    nombreUsuario = x.NombreCompleto;
                    break;
                }
            }

            // Verificar si se logró validar correctamente el usuario
            if (simon)
            {
                MessageBox.Show($"Bienvenido, {nombreUsuario}", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir Form de Lista de géneros
                ListaGeneros formGeneros = new ListaGeneros(nombreUsuario);
                formGeneros.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acceso denegado. Cuenta o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngresarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
