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
        public IngresarUsuario()
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
            // Obtener el texto ingresado en los cuadros de texto y eliminar espacios en blanco
            string cuentaIngresada = textBoxCuentaU.Text.Trim();
            string contraseñaIngresada = textBoxContraU.Text.Trim();
            //Si los campos están vacios
            if (string.IsNullOrEmpty(cuentaIngresada) || string.IsNullOrEmpty(contraIngresada))
            {
                // Mostrar un mensaje de advertencia indicando que los campos no pueden estar vacíos
                MessageBox.Show("Por favor ingrese una cuenta y una contraseña", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//Salir
            }

            // Crear una instancia de la clase Datos para interactuar con la base de datos
            Datos obj = new Datos();

            // Verificar cuenta y contraseña
            if (obj.ConsultarCuentaContraUsuario(cuentaIngresada, contraseñaIngresada))
            {
                //si es así muestra un mensaje
                MessageBox.Show("Bienvenido", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir Form de bienvenido
                Bienvenido bienvenido = new Bienvenido(true);
                bienvenido.Show();//mostrar
                //this.Hide();//ocultar
            }
            else
            {
                MessageBox.Show("Acceso denegado. Cuenta o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AccesoNoAutorizado noautorizado = new AccesoNoAutorizado();
                //this.Hide();
                noautorizado.ShowDialog();
                this.Close();
            }
        }
    }
}
