using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnable_Tales_Proyecto
{
    public partial class FormSeguridad : Form
    {
        private int idEliminar;
        public FormSeguridad()
        {
            InitializeComponent();
        }

        public FormSeguridad(int id)
        {
            InitializeComponent();
            this.idEliminar = id;
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            obj.EliminarUnRegistro(idEliminar);
            obj.Desconectar();
            this.Close();
        }

        private void FormSeguridad_Load(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            Productos aux;
            aux = datos.ConsultarUnRegistro(idEliminar);
            this.labelShowId.Text = Convert.ToString(aux.Id);
            this.labelShowTitulo.Text = aux.Nombre;
            this.labelShowArtista.Text = aux.Artista;
            this.labelShowGenero.Text = aux.Genero;
            this.labelShowPrecio.Text = Convert.ToString(aux.Precio);
            this.labelShowExistencias.Text = Convert.ToString(aux.Cantidad);

        }
    }
}
