namespace Turnable_Tales_Proyecto
{
    partial class FormListado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListado));
            buttonRegresar = new Button();
            listView1 = new ListView();
            buttonMusica = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            labelLinea = new Label();
            labelTitulo = new Label();
            labelFrase = new Label();
            labelMenu = new Label();
            imageListDiscos = new ImageList(components);
            textBoxHora = new TextBox();
            textBoxFecha = new TextBox();
            textBoxUsuario = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            cerrarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonRegresar
            // 
            buttonRegresar.FlatStyle = FlatStyle.Popup;
            buttonRegresar.Image = (Image)resources.GetObject("buttonRegresar.Image");
            buttonRegresar.Location = new Point(20, 325);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(82, 97);
            buttonRegresar.TabIndex = 61;
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ActiveCaptionText;
            listView1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.ForeColor = SystemColors.ButtonHighlight;
            listView1.Location = new Point(369, 254);
            listView1.Name = "listView1";
            listView1.Size = new Size(627, 338);
            listView1.TabIndex = 60;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // buttonMusica
            // 
            buttonMusica.FlatStyle = FlatStyle.Popup;
            buttonMusica.Image = (Image)resources.GetObject("buttonMusica.Image");
            buttonMusica.Location = new Point(253, 33);
            buttonMusica.Name = "buttonMusica";
            buttonMusica.Size = new Size(105, 102);
            buttonMusica.TabIndex = 59;
            buttonMusica.UseVisualStyleBackColor = true;
            buttonMusica.Click += buttonMusica_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(453, 104);
            label2.Name = "label2";
            label2.Size = new Size(455, 50);
            label2.TabIndex = 58;
            label2.Text = "A D M I N I S T R A D O R\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(207, 163);
            label1.Name = "label1";
            label1.Size = new Size(893, 3);
            label1.TabIndex = 57;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelLinea
            // 
            labelLinea.AutoSize = true;
            labelLinea.BackColor = Color.White;
            labelLinea.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLinea.ForeColor = Color.White;
            labelLinea.Location = new Point(207, 90);
            labelLinea.Name = "labelLinea";
            labelLinea.Size = new Size(893, 3);
            labelLinea.TabIndex = 56;
            labelLinea.Text = resources.GetString("labelLinea.Text");
            labelLinea.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(432, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(493, 50);
            labelTitulo.TabIndex = 52;
            labelTitulo.Text = "T U R N T A B L E   T A L E S";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFrase
            // 
            labelFrase.AutoSize = true;
            labelFrase.BackColor = Color.Transparent;
            labelFrase.ForeColor = Color.White;
            labelFrase.Location = new Point(567, 59);
            labelFrase.Name = "labelFrase";
            labelFrase.Size = new Size(237, 20);
            labelFrase.TabIndex = 53;
            labelFrase.Text = "\"TU VIDA, TU MUSICA, TU VINILO.\"\r\n";
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.BackColor = Color.Transparent;
            labelMenu.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu.ForeColor = Color.White;
            labelMenu.Location = new Point(336, 186);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(703, 36);
            labelMenu.TabIndex = 51;
            labelMenu.Text = "LISTADO DE DISCOS ORDENADOS POR EXISTENCIAS";
            // 
            // imageListDiscos
            // 
            imageListDiscos.ColorDepth = ColorDepth.Depth8Bit;
            imageListDiscos.ImageStream = (ImageListStreamer)resources.GetObject("imageListDiscos.ImageStream");
            imageListDiscos.TransparentColor = Color.Transparent;
            imageListDiscos.Images.SetKeyName(0, "SadBoys4Lifell.jpg");
            imageListDiscos.Images.SetKeyName(1, "Incomodo.jpg");
            imageListDiscos.Images.SetKeyName(2, "Caifanes.jpg");
            imageListDiscos.Images.SetKeyName(3, "Eureka.jpg");
            imageListDiscos.Images.SetKeyName(4, "LoveYourselfAnswer.jpg");
            imageListDiscos.Images.SetKeyName(5, "TheWorldep1.jpeg");
            imageListDiscos.Images.SetKeyName(6, "VestiLaGiubba.jpg");
            // 
            // textBoxHora
            // 
            textBoxHora.BackColor = SystemColors.InactiveCaptionText;
            textBoxHora.BorderStyle = BorderStyle.None;
            textBoxHora.Enabled = false;
            textBoxHora.ForeColor = Color.White;
            textBoxHora.Location = new Point(1083, 110);
            textBoxHora.Name = "textBoxHora";
            textBoxHora.Size = new Size(197, 20);
            textBoxHora.TabIndex = 242;
            // 
            // textBoxFecha
            // 
            textBoxFecha.BackColor = SystemColors.InactiveCaptionText;
            textBoxFecha.BorderStyle = BorderStyle.None;
            textBoxFecha.Enabled = false;
            textBoxFecha.ForeColor = Color.White;
            textBoxFecha.Location = new Point(1083, 74);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.Size = new Size(197, 20);
            textBoxFecha.TabIndex = 241;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = SystemColors.InactiveCaptionText;
            textBoxUsuario.BorderStyle = BorderStyle.None;
            textBoxUsuario.Enabled = false;
            textBoxUsuario.ForeColor = Color.White;
            textBoxUsuario.Location = new Point(1083, 37);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(197, 20);
            textBoxUsuario.TabIndex = 240;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // cerrarSesion
            // 
            cerrarSesion.BackColor = SystemColors.ActiveCaptionText;
            cerrarSesion.ForeColor = SystemColors.ButtonHighlight;
            cerrarSesion.Location = new Point(1071, 565);
            cerrarSesion.Name = "cerrarSesion";
            cerrarSesion.Size = new Size(209, 46);
            cerrarSesion.TabIndex = 243;
            cerrarSesion.Text = "C E R R A R  S E S I Ó N";
            cerrarSesion.UseVisualStyleBackColor = false;
            cerrarSesion.Click += cerrarSesion_Click;
            // 
            // FormListado
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1302, 633);
            Controls.Add(cerrarSesion);
            Controls.Add(textBoxHora);
            Controls.Add(textBoxFecha);
            Controls.Add(textBoxUsuario);
            Controls.Add(buttonRegresar);
            Controls.Add(listView1);
            Controls.Add(buttonMusica);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelLinea);
            Controls.Add(labelTitulo);
            Controls.Add(labelFrase);
            Controls.Add(labelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormListado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegresar;
        private ListView listView1;
        private Button buttonMusica;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label labelLinea;
        private Label labelTitulo;
        private Label labelFrase;
        private Label labelMenu;
        private ImageList imageListDiscos;
        private TextBox textBoxHora;
        private TextBox textBoxFecha;
        private TextBox textBoxUsuario;
        private System.Windows.Forms.Timer timer1;
        private Button cerrarSesion;
    }
}