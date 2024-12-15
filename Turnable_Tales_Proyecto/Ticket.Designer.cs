namespace Turnable_Tales_Proyecto
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            pictureBoxTicket = new PictureBox();
            buttonMusica = new Button();
            buttonRegresar = new Button();
            pictureBoxLogo = new PictureBox();
            buttonTicket = new Button();
            textBoxHora = new TextBox();
            textBoxFecha = new TextBox();
            textBoxUsuario = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            cerrarSesion = new Button();
            textBoxDato1 = new TextBox();
            textBoxDato2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTicket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTicket
            // 
            pictureBoxTicket.BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_03_at_9_15_30_AM;
            pictureBoxTicket.Location = new Point(395, 16);
            pictureBoxTicket.Margin = new Padding(3, 4, 3, 4);
            pictureBoxTicket.Name = "pictureBoxTicket";
            pictureBoxTicket.Size = new Size(448, 740);
            pictureBoxTicket.TabIndex = 0;
            pictureBoxTicket.TabStop = false;
            // 
            // buttonMusica
            // 
            buttonMusica.BackColor = Color.Transparent;
            buttonMusica.FlatStyle = FlatStyle.Popup;
            buttonMusica.Image = (Image)resources.GetObject("buttonMusica.Image");
            buttonMusica.Location = new Point(911, -2);
            buttonMusica.Margin = new Padding(3, 4, 3, 4);
            buttonMusica.Name = "buttonMusica";
            buttonMusica.Size = new Size(96, 114);
            buttonMusica.TabIndex = 193;
            buttonMusica.UseVisualStyleBackColor = false;
            buttonMusica.Click += buttonMusica_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.Transparent;
            buttonRegresar.BackgroundImage = Properties.Resources.flechaizq;
            buttonRegresar.FlatStyle = FlatStyle.Popup;
            buttonRegresar.Location = new Point(38, 346);
            buttonRegresar.Margin = new Padding(0);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(69, 72);
            buttonRegresar.TabIndex = 194;
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(21, 18);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(174, 175);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 203;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonTicket
            // 
            buttonTicket.BackColor = Color.Transparent;
            buttonTicket.BackgroundImage = Properties.Resources.descargarticket;
            buttonTicket.Location = new Point(1238, 686);
            buttonTicket.Margin = new Padding(3, 4, 3, 4);
            buttonTicket.Name = "buttonTicket";
            buttonTicket.Size = new Size(200, 78);
            buttonTicket.TabIndex = 204;
            buttonTicket.UseVisualStyleBackColor = false;
            buttonTicket.Click += buttonTicket_Click;
            // 
            // textBoxHora
            // 
            textBoxHora.BackColor = SystemColors.InactiveCaptionText;
            textBoxHora.BorderStyle = BorderStyle.None;
            textBoxHora.Enabled = false;
            textBoxHora.ForeColor = Color.White;
            textBoxHora.Location = new Point(1042, 76);
            textBoxHora.Margin = new Padding(2);
            textBoxHora.Name = "textBoxHora";
            textBoxHora.Size = new Size(158, 20);
            textBoxHora.TabIndex = 242;
            // 
            // textBoxFecha
            // 
            textBoxFecha.BackColor = SystemColors.InactiveCaptionText;
            textBoxFecha.BorderStyle = BorderStyle.None;
            textBoxFecha.Enabled = false;
            textBoxFecha.ForeColor = Color.White;
            textBoxFecha.Location = new Point(1042, 47);
            textBoxFecha.Margin = new Padding(2);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.Size = new Size(158, 20);
            textBoxFecha.TabIndex = 241;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = SystemColors.InactiveCaptionText;
            textBoxUsuario.BorderStyle = BorderStyle.None;
            textBoxUsuario.Enabled = false;
            textBoxUsuario.ForeColor = Color.White;
            textBoxUsuario.Location = new Point(1042, 18);
            textBoxUsuario.Margin = new Padding(2);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(158, 20);
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
            cerrarSesion.Location = new Point(1086, 547);
            cerrarSesion.Margin = new Padding(2);
            cerrarSesion.Name = "cerrarSesion";
            cerrarSesion.Size = new Size(167, 37);
            cerrarSesion.TabIndex = 243;
            cerrarSesion.Text = "C E R R A R  S E S I Ó N";
            cerrarSesion.UseVisualStyleBackColor = false;
            cerrarSesion.Click += cerrarSesion_Click;
            // 
            // textBoxDato1
            // 
            textBoxDato1.Location = new Point(433, 182);
            textBoxDato1.Margin = new Padding(2, 2, 2, 2);
            textBoxDato1.Name = "textBoxDato1";
            textBoxDato1.Size = new Size(236, 27);
            textBoxDato1.TabIndex = 244;
            // 
            // textBoxDato2
            // 
            textBoxDato2.Location = new Point(608, 308);
            textBoxDato2.Margin = new Padding(2, 2, 2, 2);
            textBoxDato2.Name = "textBoxDato2";
            textBoxDato2.Size = new Size(69, 27);
            textBoxDato2.TabIndex = 245;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(1470, 792);
            Controls.Add(textBoxDato2);
            Controls.Add(textBoxDato1);
            Controls.Add(cerrarSesion);
            Controls.Add(textBoxHora);
            Controls.Add(textBoxFecha);
            Controls.Add(textBoxUsuario);
            Controls.Add(buttonTicket);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonMusica);
            Controls.Add(pictureBoxTicket);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ticket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket";
            Load += Ticket_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTicket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxTicket;
        private Button buttonMusica;
        private Button buttonRegresar;
        private PictureBox pictureBoxLogo;
        private Button buttonTicket;
        private TextBox textBoxHora;
        private TextBox textBoxFecha;
        private TextBox textBoxUsuario;
        private System.Windows.Forms.Timer timer1;
        private Button cerrarSesion;
        private TextBox textBoxDato1;
        private TextBox textBoxDato2;
    }
}