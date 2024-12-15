using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Turnable_Tales_Proyecto.Love;

namespace Turnable_Tales_Proyecto
{
    public static class ListaGlobal
    {
        private static List<Elemento> miLista = new List<Elemento>();

        public static void Insertar(int id, int cantidad, string descripcion)
        {
            miLista.Add(new Elemento(id, cantidad, descripcion));

            // Show a MessageBox to notify the user when an element is added
            MessageBox.Show("Elemento agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static List<Elemento> ObtenerLista()
        {
            return miLista;
        }


        

        // Method to clear the list and restore quantities in the database
        public static void EliminarLista()
        {
            try
            {
                Datos datos = new Datos();
                Productos productos = new Productos();
                

                // Iterar sobre los elementos de la lista y restaurar la cantidad en la base de datos
                foreach (var elemento in miLista)
                {
                    productos = datos.ConsultarUnRegistro(elemento.Id);
                    // Restaurar la cantidad original en la base de datos
                    // Supongamos que la cantidad original es la que estaba antes de ser modificada en el carrito
                    datos.ActualizarCantidad(elemento.Id, elemento.Cantidad+productos.Cantidad);
                }

                // Limpiar la lista global
                miLista.Clear();

                // Show a MessageBox to notify the user that the list has been cleared and quantities restored
                MessageBox.Show("La lista ha sido eliminada correctamente y las cantidades han sido restauradas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones si ocurre algún error
                MessageBox.Show("Error al restaurar las cantidades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
