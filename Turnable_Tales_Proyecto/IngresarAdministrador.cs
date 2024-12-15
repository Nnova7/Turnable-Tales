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
            string cuentaIngresada = textBoxCuentaA.Text;
            string contraseñaIngresada = textBoxContraA.Text;

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
            bool band = false;
            string nombreUsuario = obj.ConsultarCuentaContraAdmin(cuentaIngresada, contraseñaIngresada);

            foreach (Usuarios x in lista)
            {
                if (x.Cuenta == cuentaIngresada)
                {
                    if (x.Contraseña == contraseñaIngresada)
                    {
                        band = true;
                        nombreUsuario = x.NombreCompleto;
                        break;
                    }
                }

            }

            /////////////////////////////////////////////////////////
            ///

            // Verificar cuenta y contraseña

            // Verificar si el nombre de usuario no es nulo ni vacío
            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show($"Bienvenido, {nombreUsuario}", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir Form7
                FormMenuAdmin formAdmin = new FormMenuAdmin(nombreUsuario);
                formAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acceso denegado. Cuenta o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
