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
    public partial class IngresarAdministrador : Form
    {
        public IngresarAdministrador()
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
            usuario.Show();//Muestra
            this.Close();//Cierra
        }

        private void IngresarAdministrador_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Comprobamos la cuenta y contraseña de Administrador
        /// </summary>
        private string cuentaIngresada = ""; // Variable para almacenar la cuenta ingresada
        private void textBoxCuentaA_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la cuenta ingresada
            cuentaIngresada = textBoxCuentaA.Text.Trim();//Trim es para quitar espacios en blanco
        }
        private string contraseñaIngresada = ""; // Variable para almacenar la contraseña ingresada
        private void textBoxContraA_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la contraseña ingresada
            contraseñaIngresada = textBoxContraA.Text.Trim();//Trim es para quitar espacios en blanco
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            // Si los campos están vacios
            if (string.IsNullOrEmpty(cuentaIngresada) || string.IsNullOrEmpty(contraseñaIngresada))
            {
                // Muestra un mensaje 
                MessageBox.Show("Por favor ingrese una cuenta y una contraseña", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto de la clase Datos
            Datos obj = new Datos();

            // Verificar si la cuenta y contraseña son válidas
            bool accesoPermitido = obj.ConsultarCuentaContraAdmin(cuentaIngresada, contraseñaIngresada);

            //Si lo que recibe en acceso permitido es correcto entonces realiza la siguiente acción
            if (accesoPermitido)
            {
                MessageBox.Show("Bienvenido", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mostrar Form de Bienvenido y ocultar el formulario actual
                Bienvenido bienvenido = new Bienvenido();
                bienvenido.Show();//Muestra
                this.Hide();//Oculta
            }
            else
            {
                // Muestra un mensaje
                MessageBox.Show("Cuenta o contraseña incorrectas", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
