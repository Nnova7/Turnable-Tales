using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnable_Tales_Proyecto
{
    public class Elemento
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }

        public Elemento(int id, int cantidad, string descripcion)
        {
            Id = id;
            Cantidad = cantidad;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Cantidad: {Cantidad}, Descripción: {Descripcion}";
        }
    }
}
