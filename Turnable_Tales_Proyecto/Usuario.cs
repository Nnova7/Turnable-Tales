﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Turnable_Tales_Proyecto
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        /// <summary>
        /// buttonAdministrador_Click
        /// Nos enviará a un form donde pordamos ingresar los datos como administrador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdministrador_Click(object sender, EventArgs e)
        {
            IngresarAdministrador administrador = new IngresarAdministrador();
            this.Hide();
            administrador.Show();
            this.Close();
        }
        /// <summary>
        /// buttonAtras_Click
        /// En esta función regresa para la portada del proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            PortadaProyecto portada = (PortadaProyecto)Application.OpenForms["PortadaProyecto"];
            if (portada != null)
            {
                this.Hide();
                portada.Show();
                this.Close();
            }
        }

        /// <summary>
        /// buttonUsuario_Click
        /// Nos enviará a un form donde pordamos ingresar los datos como usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            IngresarUsuario usuario = new IngresarUsuario();
            this.Hide();
            usuario.Show();
            this.Close();
        }
    }
}