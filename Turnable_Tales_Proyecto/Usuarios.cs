using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnable_Tales_Proyecto
{
    public class Usuarios
    {
        private int id;
        private string nombreCompleto;
        private string cuenta;
        private string contraseña;
        private int monto;

        public Usuarios() { }

        public Usuarios(int id, string nombreCompleto, string cuenta, string contraseña, int monto)
        {
            this.Id = id;
            this.NombreCompleto = nombreCompleto;
            this.Cuenta = cuenta;
            this.Contraseña = contraseña;
            this.Monto = monto;
        }

        public int Id { get => id; set => id = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Monto { get => monto; set => monto = value; }
    }
}
