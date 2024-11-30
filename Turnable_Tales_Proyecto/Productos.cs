using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnable_Tales_Proyecto
{
    public class Productos
    {
        private int id;
        private string artista;
        private string genero;
        private string nombre;
        private int precio;
        private int cantidad;
        private string imagen;
        private string descripcion;

        public Productos() { }//CONSTRUCTOR VACIO

        public Productos(int id, string artista, string genero, string nombre, int precio, int cantidad, string imagen, string descripcion)
        {
            this.Id = id;
            this.Artista = artista;
            this.Genero = genero;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Imagen = imagen;
            this.Descripcion = descripcion;
        }//Constructor con parametros

        public int Id { get => id; set => id = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
