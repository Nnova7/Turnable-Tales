using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Turnable_Tales_Proyecto
{
    public partial class Ticket : Form
    {
        private List<Elemento> ticketList;
        private List<Productos> productosList; // Lista de productos con precio

        public string nombreUsuario
        {
            get { return textBoxUsuario.Text; }
            set { textBoxUsuario.Text = value; }
        } // Propiedad para recibir el nombre

        private void PopulateTextBoxes()
        {
            double subtotal = 0;

            // Llenar TextBox1 con la lista de discos
            textBoxDato1.Clear();
            foreach (var ticket in ticketList)
            {
                // Buscar el producto en la lista de productos
                var producto = productosList.FirstOrDefault(p => p.Id == ticket.Id);
                if (producto != null)
                {
                    // Calcular el importe del producto
                    double importe = ticket.Cantidad * producto.Precio;

                    // Acumular el subtotal
                    subtotal += importe;

                    // Agregar los datos del producto al TextBox
                    textBoxDato1.AppendText($"{ticket.Cantidad}  {producto.Nombre}  {importe:F2}\n");
                }
            }

            // Calcular impuesto y total
            double impuesto = subtotal * 0.06f;
            double total = subtotal + impuesto;

            // Llenar con el desglose
            textBoxDato2.Text = $"SUBTOTAL: {subtotal:F2}\nIMPUESTO: {impuesto:F2}\nTOTAL: {total:F2}";

            Datos datos = new Datos();
            List<Usuarios> lista = new List<Usuarios>();
            lista = datos.ConsultarTodosUsuarios();
            foreach (var usuario in lista)
            {
                if (usuario.NombreCompleto == nombreUsuario)
                {
                    datos.ActualizarMontoPorNombre(nombreUsuario, Convert.ToInt32(total) + usuario.Monto);
                }
            }
        }

        public Ticket()
        {
            InitializeComponent();
        }
        public Ticket(string n)
        {
            InitializeComponent();
            nombreUsuario = n;
            ticketList = ListaGlobal.ObtenerLista() ?? new List<Elemento>();
            // Crear una instancia de ProductosGlobal para obtener la lista de productos
            var Datos = new Datos();
            productosList = Datos.ConsultarTodos() ?? new List<Productos>(); // Asume que tienes una fuente global para los productos
            PopulateTextBoxes();
        }

        /*private void buttonUsuario_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(nombreUsuario); //se crea instancia
            //this.Hide();
            mostrar.ShowDialog(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }*/

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            ListaGeneros listageneros = new ListaGeneros(nombreUsuario); //se crea instancia
            this.Hide();
            listageneros.ShowDialog(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            // Crear un SaveFileDialog para que el usuario seleccione la ubicación y nombre del archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo PDF (.pdf)|.pdf", // Solo permite guardar como PDF
                Title = "Guardar Ticket como PDF",
                FileName = "Ticket_TT.pdf" // Nombre sugerido por defecto
            };

            // Mostrar el diálogo y verificar si el usuario presionó "Guardar"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtener la ruta seleccionada por el usuario
                    string filePath = saveFileDialog.FileName;

                    // Crear el archivo PDF en la ruta seleccionada
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        Document doc = new Document(PageSize.A6, 19, 20, 20, 20);
                        PdfWriter pw = PdfWriter.GetInstance(doc, fs);

                        // Abrir documento
                        doc.Open();

                        // Crear borde carmín redondeado
                        PdfContentByte canvas = pw.DirectContent;

                        // Configurar color y ancho del borde
                        canvas.SetColorStroke(new BaseColor(150, 0, 24)); // Carmín
                        canvas.SetLineWidth(2); // Ancho del borde

                        // Dibujar rectángulo redondeado
                        float margin = 0.5f; // Márgenes internos
                        float radius = 15; // Radio de las esquinas
                        canvas.RoundRectangle(
                            doc.Left + margin,   // Coordenada X inicial
                            doc.Bottom + margin, // Coordenada Y inicial
                            doc.Right - doc.Left - 0 * margin, // Ancho
                            doc.Top - doc.Bottom - 1 * margin, // Altura
                            radius               // Radio de esquinas
                        );

                        // Aplicar el borde
                        canvas.Stroke();

                        // Fuentes
                        var titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        var contentFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                        // Agregar espacio antes de la imagen
                        doc.Add(new Paragraph(" ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7)));

                        // Logo
                        using (MemoryStream ms = new MemoryStream())
                        {
                            Properties.Resources.TurntableTi.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.ToArray());
                            img.ScaleToFit(70f, 70f);
                            img.Alignment = Element.ALIGN_CENTER;
                            doc.Add(img);
                        }

                        // Encabezado
                        Paragraph header = new Paragraph("Tu vida, tu música, tu vinilo", titleFont)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        doc.Add(header);

                        // Espaciado
                        doc.Add(Chunk.NEWLINE);

                        // Tabla de datos de compra
                        PdfPTable table = new PdfPTable(3);
                        table.WidthPercentage = 98;
                        table.SetWidths(new float[] { 0.5f, 4f, 2f });

                        // Encabezados de la tabla
                        AddCellToTable(table, " ", contentFont, Element.ALIGN_CENTER);
                        AddCellToTable(table, "ARTÍCULO", contentFont, Element.ALIGN_LEFT);
                        AddCellToTable(table, "IMPORTE", contentFont, Element.ALIGN_RIGHT);

                        // Agregar datos dinámicos
                        foreach (var ticket in ticketList)
                        {
                            var producto = productosList.FirstOrDefault(p => p.Id == ticket.Id);
                            if (producto != null)
                            {
                                AddCellToTable(table, ticket.Cantidad.ToString(), contentFont, Element.ALIGN_CENTER);
                                AddCellToTable(table, producto.Nombre, contentFont, Element.ALIGN_LEFT);
                                AddCellToTable(table, (producto.Precio * ticket.Cantidad).ToString("F2"), contentFont, Element.ALIGN_RIGHT);
                            }
                        }
                        doc.Add(table);

                        // Espaciado
                        doc.Add(Chunk.NEWLINE);

                        // Totales
                        double subtotal = ticketList.Sum(t => productosList.FirstOrDefault(p => p.Id == t.Id)?.Precio * t.Cantidad ?? 0);
                        double impuesto = subtotal * 0.06;
                        double total = subtotal + impuesto;

                        Paragraph totals = new Paragraph(
                            $"SUBTOTAL: {subtotal:F2}\nIMPUESTO: {impuesto:F2}\nTOTAL: {total:F2}", contentFont)
                        {
                            Alignment = Element.ALIGN_RIGHT
                        };
                        totals.IndentationRight = 6; // Espaciado desde la derecha
                        doc.Add(totals);
                        
                        // Espaciado
                        doc.Add(Chunk.NEWLINE);

                        // Hora
                        Paragraph timeParagraph = new Paragraph($"{textBoxHora.Text} {textBoxFecha.Text}", contentFont)
                        {
                            Alignment = Element.ALIGN_RIGHT
                        };
                        doc.Add(timeParagraph);

                        // Mensaje final
                        Paragraph footer = new Paragraph("GRACIAS POR SU COMPRA", contentFont)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        doc.Add(footer);

                        // Cerrar documento
                        doc.Close();
                    }

                    // Mensaje de éxito
                    MessageBox.Show("Documento generado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Mensaje de error
                    MessageBox.Show($"Ocurrió un error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mensaje si el usuario canceló
                MessageBox.Show("No se guardó el archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método para agregar celdas a la tabla
        static void AddCellToTable(PdfPTable table, string text, iTextSharp.text.Font font, int alignament)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font))
            {
                BorderWidth = 0f,
                HorizontalAlignment = alignament,
                Padding = 2
            };
            table.AddCell(cell);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToShortTimeString();
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            // Establecer la hora de la compra
            textBoxHora.Text = DateTime.Now.ToString("HH:mm:ss");
            textBoxFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");

            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                textBoxUsuario.Text = nombreUsuario;
            }
            else
            {
                textBoxUsuario.Text = "Usuario desconocido";
            }

            textBoxHF.Text = $"{DateTime.Now.ToString("yyyy-MM-dd")} {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            PortadaProyecto portada = new PortadaProyecto();
            this.Hide();
            portada.ShowDialog();
            this.Close();
        }

        private void buttonMusica_Click(object sender, EventArgs e)
        {
            //llama a la funcion de pausar y reproducir musica
            AudioPlayer.ToggleMusic();
        }

        private void textBoxDato2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
