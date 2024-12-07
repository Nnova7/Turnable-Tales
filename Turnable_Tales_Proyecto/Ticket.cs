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

namespace Turnable_Tales_Proyecto
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            MostrarNombre mostrar = new MostrarNombre(); //se crea instancia
            //this.Hide();
            mostrar.ShowDialog(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            ListaGeneros listageneros = new ListaGeneros(); //se crea instancia
            this.Hide();
            listageneros.ShowDialog(); // Mostrar
            this.Close(); // Cerrar el formulario actual 
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            // Ruta para guardar el PDF
            FileStream fs = new FileStream(@"C:\Users\valer\Downloads\Ticket_TT.pdf", FileMode.Create);
            Document doc = new Document(PageSize.A6, 19, 20, 20, 20);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            // Abrir documento
            doc.Open();

            //Crear borde carmin redondeado

            PdfContentByte canvas = pw.DirectContent;

            // Configurar color y ancho del borde
            canvas.SetColorStroke(new BaseColor(150, 0, 24)); // carmin
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

            //logo
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
            List<Impresion> tickets = GetSampleTickets(); // Obtener datos
            foreach (var ticket in tickets)
            {
                AddCellToTable(table, ticket.Cantidad.ToString(), contentFont, Element.ALIGN_CENTER);
                AddCellToTable(table, ticket.Articulo, contentFont, Element.ALIGN_LEFT);
                AddCellToTable(table, ticket.Precio.ToString("F2"), contentFont, Element.ALIGN_RIGHT);
            }
            doc.Add(table);

            // Espaciado
            doc.Add(Chunk.NEWLINE);

            // Totales
            double subtotal = 0;
            foreach (var ticket in tickets)
            {
                subtotal += ticket.Precio * ticket.Cantidad;
            }
            double impuesto = subtotal * 0.06; // 6% de impuesto
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

            // Opciones de pago
            Paragraph paymentOptions = new Paragraph("PAGO EN OXXO", contentFont)
            {
                Alignment = Element.ALIGN_RIGHT
            };
            paymentOptions.IndentationRight = 6; // Espaciado desde la derecha
            doc.Add(paymentOptions);

            // Espaciado
            doc.Add(Chunk.NEWLINE);

            // Mensaje final
            Paragraph footer = new Paragraph("GRACIAS POR SU COMPRA", contentFont)
            {
                Alignment = Element.ALIGN_CENTER
            };
            doc.Add(footer);

            // Cerrar documento
            doc.Close();
            fs.Close();

            MessageBox.Show("Documento generado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private List<Impresion> GetSampleTickets()
        {
            return new List<Impresion>
            {
                new Impresion { Cantidad = 1, Articulo = "Disco 1", Precio = 400 },
                new Impresion { Cantidad = 1, Articulo = "Disco 2", Precio = 200 }
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToShortTimeString();
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                textBoxUsuario.Text = nombreUsuario;
            }
            else
            {
                textBoxUsuario.Text = "Usuario desconocido";
            }
        }
    }
}
