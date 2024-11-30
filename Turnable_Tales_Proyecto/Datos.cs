﻿using MySql.Data.MySqlClient;//LIBRERIA PARA EL MANEJO DE LA BASE DE DATOS!!
using System;
using System.Collections.Generic;//Manejo de listas
using System.Windows.Forms;//Mostrar mensajes en ventanas

namespace Turnable_Tales_Proyecto
{
    public class Datos
    {
        private MySqlConnection conexion;

        public Datos()
        {
            this.Conectar();
        }//Constructor

        /// <summary>
        /// Cierra la conexion con la base de datos
        /// </summary>
        public void Desconectar()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();//Cierra la conexion
            }
        }//Desconectar

        /// <summary>
        ///  /// Consulta todos los registros y devuelve una lista con objetos de la clase del registro
        /// Para usarse...
        ///                 AdmonBD obj = new AdmonBD(); // Instancia de la clase de administración de base de datos
        ///                 data = obj.consulta(); // Obtiene los registros de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Productos> ConsultarTodos()
        {
            List<Productos> datos = new List<Productos>();//Lista de tipo productos para almacenarlos
            Productos aux;
            int id = 0, precio = 0, cantidad = 0;
            string artista, genero, nombre, imagen, descripcion;
            try
            {
                string query = "SELECT * FROM discos";//Consulta SQL para obtener todos los registros
                MySqlCommand command = new MySqlCommand(query, this.conexion);//Prepara el comando sql
                MySqlDataReader reader = command.ExecuteReader();//Ejecuta la consulta y obtiene la informacion
                while (reader.Read())//Recorre los registros uno por uno
                {
                    //Obtiene los valores de cada columna de la tabla de datos
                    id = Convert.ToInt32(reader["id"]);
                    precio = Convert.ToInt32(reader["precio"]);
                    cantidad = Convert.ToInt32(reader["cantidad"]);
                    artista = Convert.ToString(reader["artista"]) ?? "";
                    genero = Convert.ToString(reader["genero"]) ?? "";
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    imagen = Convert.ToString(reader["imagen"]) ?? "";
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";

                    //Se crea la instancia con los datos recopilados
                    aux = new Productos(id, artista, genero, nombre, precio, cantidad, imagen, descripcion);
                    datos.Add(aux);//Se agrega el objeto a la lista
                }//while
                reader.Close();
            }//try
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la base de datos: " + ex.Message);
                this.Desconectar();//Desconecta la base de datos en caso de error
            }//catch

            return datos;//Devuelve la lista
        }//Consultar todos

        /// <summary>
        /// Se inserta un registro en la base de datos
        /// Para usarse...
        ///                  AdmonBD obj = new AdmonBD(); // Instancia de la clase de administración de base de datos
        ///                 obj.insertar(id, artista, genero, nombre, precio, cantidad, imagen, descripcion); // Inserta el nuevo registro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="artista"></param>
        /// <param name="genero"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        /// <param name="imagen"></param>
        /// <param name="descripcion"></param>
        public void Insertar(int id, string artista, string genero, string nombre, int precio, int cantidad, string imagen, string descripcion)
        {
            string query = "";//Cadena para el comando sql
            try
            {
                //crea el comando sql para insertar un registro en la tabla de discos
                query = "INSERT INTO prendas (id,artista,genero,nombre,precio,cantidad,imagen,descripcion) VALUES ("
                    + "'" + id + "´,"
                    + "'" + artista + "´,"
                    + "'" + genero + "´,"
                    + "'" + nombre + "´,"
                    + "'" + precio + "´,"
                    + "'" + cantidad + "´,"
                    + "'" + imagen + "´,"
                    + "'" + descripcion + "´,)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);//Prepara el comando
                cmd.ExecuteNonQuery();//ejecuta el comando
            }//try
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nClave duplucada" + ex.Message);//Manejar errores
                this.Desconectar();//dESCONECTA LA BASE EN CASO DE ERROR
            }//catch

        }//insertar

        /// <summary>
        /// Consultar un registro por medio del id
        /// Para usar...
        ///             AdmonBD obj = new AdmonBD(); // Instancia de la clase de administración de base de datos
        ///             Productos aux = obj.consultaUnRegistro(Convert.ToInt32(this.textBoxidMod.Text)); // Consulta un registro por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Productos ConsultarUnRegistro(int idBuscado)
        {
            Productos aux = null;
            int id = 0, precio = 0, cantidad = 0;
            string artista, genero, nombre, imagen, descripcion;

            try
            {
                string query = "SELECT * FROM discos where id=" + idBuscado + ";";//Consultar sql con filtro de id
                MySqlCommand command = new MySqlCommand(query, this.conexion);//Prepara el comando
                MySqlDataReader reader = command.ExecuteReader();//Ejecuta la consulta
                while (reader.Read())//lee el unico registro encontrado
                {
                    id = Convert.ToInt32(reader["id"]);
                    precio = Convert.ToInt32(reader["precio"]);
                    cantidad = Convert.ToInt32(reader["cantidad"]);
                    artista = Convert.ToString(reader["artista"]) ?? "";
                    genero = Convert.ToString(reader["genero"]) ?? "";
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    imagen = Convert.ToString(reader["imagen"]) ?? "";
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";

                    aux = new Productos(id, artista, genero, nombre, precio, cantidad, imagen, descripcion);
                }//while
                reader.Close();
            }//try
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la base de datos: " + ex.Message);
                this.Desconectar();
            }//catch

            return aux;
        }//consultarUnRegistro

        /// <summary>
        /// Eliminar un registro por medio de un id
        /// Para usarse...
        ///                 AdmonBD obj = new AdmonBD(); // Instancia de la clase de administración de base de datos
        ///                  obj.eliminar(Convert.ToInt32(this.textBoxEliminar.Text)); // Elimina el registro con el ID especificado
        /// </summary>
        /// <param name="id"></param>
        public void EliminarUnRegistro(int id)
        {
            string query = ""; //Cadena para el comando sql
            try
            {
                query = "DELETE FROM discos WHERE id=" + id + ";";//crea el comando
                MySqlCommand cmd = new MySqlCommand(query, conexion);//prepara el comando
                cmd.ExecuteNonQuery();//Ejecuta el comando
            }//try
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError " + ex.Message);//manejo de errores
                this.Desconectar();//Desconectar base de datos
            }//catch
        }//Eliminar un registro

        /// <summary>
        /// Actualiza un registro
        /// Para usar...
        ///                AdmonBD obj = new AdmonBD(); // Instancia de la clase de administración de base de datos
        ///               obj.actualizar(id, producto, imagen, precio); // Actualiza el registro con los nuevos valores
        /// </summary>
        /// <param name="id"></param>
        /// <param name="artista"></param>
        /// <param name="genero"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        /// <param name="imagen"></param>
        /// <param name="descripcion"></param>
        public void ActualizarUnRegistro(int id, string artista, string genero, string nombre, int precio, int cantidad, string imagen, string descripcion)
        {
            try
            {
                string query = "UPDATE discos SET artista='" + artista
                + "', genero='" + genero
                + "', nombre='" + nombre
                + "', precio=" + precio
                + ", cantidad=" + cantidad
                + ", imagen='" + imagen
                + "', descripcion='" + descripcion
                + "' WHERE id=" + id + ";";

                MySqlCommand cmd = new MySqlCommand(query, conexion);//prepara el comando
                cmd.ExecuteNonQuery();//Ejecuta el comando
            }//try
            catch (Exception ex)
            {
                MessageBox.Show("Error en la actualizacion: " + ex.Message);//Manejo de errores
                this.Desconectar();//Desconecta la base de datos
            }//catch
        }//actualizar

        /// <summary>
        /// Establece la conexion con la base de datos
        /// </summary>
        public void Conectar()
        {
            string cadena = "Server=localhost; Database=productos; User=root; Password=; SslMode=none;";
            try
            {
                conexion = new MySqlConnection(cadena);//Crear la conexion
                conexion.Open();//Abrir la conexion
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//MANEJO DE ERRORES
            }
        }//Conectar

    }//clase
}//namespace