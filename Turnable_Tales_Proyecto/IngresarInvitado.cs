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
            usuario.Show();
            this.Close();
        }

        private void IngresarInvitado_Load(object sender, EventArgs e)
        {

        }
    }
}
