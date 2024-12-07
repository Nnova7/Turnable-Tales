namespace Turnable_Tales_Proyecto
{
    partial class FormMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAdmin));
            buttonMusica = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            labelLinea = new Label();
            labelTitulo = new Label();
            labelFrase = new Label();
            buttonListado = new Button();
            buttonGraficas = new Button();
            buttonEliminaDisco = new Button();
            buttonVentasTotales = new Button();
            buttonAgregarDisco = new Button();
            labelMenu = new Label();
            textBoxHora = new TextBox();
            textBoxFecha = new TextBox();
            textBoxUsuario = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonMusica
            // 
            buttonMusica.FlatStyle = FlatStyle.Popup;
            buttonMusica.Image = (Image)resources.GetObject("buttonMusica.Image");
            buttonMusica.Location = new Point(252, 39);
            buttonMusica.Name = "buttonMusica";
            buttonMusica.Size = new Size(93, 89);
            buttonMusica.TabIndex = 36;
            buttonMusica.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(421, 103);
            label2.Name = "label2";
            label2.Size = new Size(551, 61);
            label2.TabIndex = 35;
            label2.Text = "A D M I N I S T R A D O R\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 174);
            label1.Name = "label1";
            label1.Size = new Size(1784, 4);
            label1.TabIndex = 34;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelLinea
            // 
            labelLinea.AutoSize = true;
            labelLinea.BackColor = Color.White;
            labelLinea.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLinea.ForeColor = Color.White;
            labelLinea.Location = new Point(193, 89);
            labelLinea.Name = "labelLinea";
            labelLinea.Size = new Size(1784, 4);
            labelLinea.TabIndex = 33;
            labelLinea.Text = resources.GetString("labelLinea.Text");
            labelLinea.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(400, -6);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(595, 61);
            labelTitulo.TabIndex = 29;
            labelTitulo.Text = "T U R N T A B L E   T A L E S";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFrase
            // 
            labelFrase.AutoSize = true;
            labelFrase.BackColor = Color.Transparent;
            labelFrase.ForeColor = Color.White;
            labelFrase.Location = new Point(521, 49);
            labelFrase.Name = "labelFrase";
            labelFrase.Size = new Size(288, 25);
            labelFrase.TabIndex = 30;
            labelFrase.Text = "\"TU VIDA, TU MUSICA, TU VINILO.\"\r\n";
            // 
            // buttonListado
            // 
            buttonListado.FlatStyle = FlatStyle.Popup;
            buttonListado.Image = (Image)resources.GetObject("buttonListado.Image");
            buttonListado.Location = new Point(746, 448);
            buttonListado.Name = "buttonListado";
            buttonListado.Size = new Size(247, 102);
            buttonListado.TabIndex = 27;
            buttonListado.Text = "button7";
            buttonListado.UseVisualStyleBackColor = true;
            buttonListado.Click += buttonListado_Click;
            // 
            // buttonGraficas
            // 
            buttonGraficas.FlatStyle = FlatStyle.Popup;
            buttonGraficas.Image = (Image)resources.GetObject("buttonGraficas.Image");
            buttonGraficas.Location = new Point(302, 448);
            buttonGraficas.Name = "buttonGraficas";
            buttonGraficas.Size = new Size(247, 102);
            buttonGraficas.TabIndex = 26;
            buttonGraficas.Text = "button6";
            buttonGraficas.UseVisualStyleBackColor = true;
            buttonGraficas.Click += buttonGraficas_Click;
            // 
            // buttonEliminaDisco
            // 
            buttonEliminaDisco.FlatStyle = FlatStyle.Popup;
            buttonEliminaDisco.Image = (Image)resources.GetObject("buttonEliminaDisco.Image");
            buttonEliminaDisco.Location = new Point(940, 254);
            buttonEliminaDisco.Name = "buttonEliminaDisco";
            buttonEliminaDisco.Size = new Size(245, 102);
            buttonEliminaDisco.TabIndex = 25;
            buttonEliminaDisco.Text = "button5";
            buttonEliminaDisco.UseVisualStyleBackColor = true;
            buttonEliminaDisco.Click += buttonEliminaDisco_Click;
            // 
            // buttonVentasTotales
            // 
            buttonVentasTotales.FlatStyle = FlatStyle.Popup;
            buttonVentasTotales.Image = (Image)resources.GetObject("buttonVentasTotales.Image");
            buttonVentasTotales.Location = new Point(521, 254);
            buttonVentasTotales.Name = "buttonVentasTotales";
            buttonVentasTotales.Size = new Size(247, 102);
            buttonVentasTotales.TabIndex = 24;
            buttonVentasTotales.Text = "button4";
            buttonVentasTotales.UseVisualStyleBackColor = true;
            buttonVentasTotales.Click += buttonVentasTotales_Click;
            // 
            // buttonAgregarDisco
            // 
            buttonAgregarDisco.FlatStyle = FlatStyle.Popup;
            buttonAgregarDisco.Image = (Image)resources.GetObject("buttonAgregarDisco.Image");
            buttonAgregarDisco.Location = new Point(118, 254);
            buttonAgregarDisco.Name = "buttonAgregarDisco";
            buttonAgregarDisco.Size = new Size(247, 102);
            buttonAgregarDisco.TabIndex = 22;
            buttonAgregarDisco.Text = "button3";
            buttonAgregarDisco.UseVisualStyleBackColor = true;
            buttonAgregarDisco.Click += buttonAgregarDisco_Click;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.BackColor = Color.Transparent;
            labelMenu.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu.ForeColor = Color.White;
            labelMenu.Location = new Point(603, 191);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(98, 42);
            labelMenu.TabIndex = 23;
            labelMenu.Text = "MENU";
            // 
            // textBoxHora
            // 
            textBoxHora.BackColor = SystemColors.InactiveCaptionText;
            textBoxHora.BorderStyle = BorderStyle.None;
            textBoxHora.Enabled = false;
            textBoxHora.ForeColor = Color.White;
            textBoxHora.Location = new Point(1093, 112);
            textBoxHora.Name = "textBoxHora";
            textBoxHora.Size = new Size(197, 24);
            textBoxHora.TabIndex = 242;
            // 
            // textBoxFecha
            // 
            textBoxFecha.BackColor = SystemColors.InactiveCaptionText;
            textBoxFecha.BorderStyle = BorderStyle.None;
            textBoxFecha.Enabled = false;
            textBoxFecha.ForeColor = Color.White;
            textBoxFecha.Location = new Point(1093, 76);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.Size = new Size(197, 24);
            textBoxFecha.TabIndex = 241;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = SystemColors.InactiveCaptionText;
            textBoxUsuario.BorderStyle = BorderStyle.None;
            textBoxUsuario.Enabled = false;
            textBoxUsuario.ForeColor = Color.White;
            textBoxUsuario.Location = new Point(1093, 39);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(197, 24);
            textBoxUsuario.TabIndex = 240;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormMenuAdmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1302, 633);
            Controls.Add(textBoxHora);
            Controls.Add(textBoxFecha);
            Controls.Add(textBoxUsuario);
            Controls.Add(buttonMusica);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelLinea);
            Controls.Add(labelTitulo);
            Controls.Add(labelFrase);
            Controls.Add(buttonListado);
            Controls.Add(buttonGraficas);
            Controls.Add(buttonEliminaDisco);
            Controls.Add(buttonVentasTotales);
            Controls.Add(buttonAgregarDisco);
            Controls.Add(labelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMusica;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label labelLinea;
        private Label labelTitulo;
        private Label labelFrase;
        private Button buttonListado;
        private Button buttonGraficas;
        private Button buttonEliminaDisco;
        private Button buttonVentasTotales;
        private Button buttonAgregarDisco;
        private Label labelMenu;
        private TextBox textBoxHora;
        private TextBox textBoxFecha;
        private TextBox textBoxUsuario;
        private System.Windows.Forms.Timer timer1;
    }
}