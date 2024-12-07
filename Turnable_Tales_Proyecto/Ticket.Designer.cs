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
            ((System.ComponentModel.ISupportInitialize)pictureBoxTicket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTicket
            // 
            pictureBoxTicket.BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_03_at_9_15_30_AM;
            pictureBoxTicket.Location = new Point(494, 20);
            pictureBoxTicket.Margin = new Padding(4, 5, 4, 5);
            pictureBoxTicket.Name = "pictureBoxTicket";
            pictureBoxTicket.Size = new Size(560, 925);
            pictureBoxTicket.TabIndex = 0;
            pictureBoxTicket.TabStop = false;
            // 
            // buttonMusica
            // 
            buttonMusica.BackColor = Color.Transparent;
            buttonMusica.FlatStyle = FlatStyle.Popup;
            buttonMusica.Image = (Image)resources.GetObject("buttonMusica.Image");
            buttonMusica.Location = new Point(1139, -3);
            buttonMusica.Margin = new Padding(4, 5, 4, 5);
            buttonMusica.Name = "buttonMusica";
            buttonMusica.Size = new Size(120, 143);
            buttonMusica.TabIndex = 193;
            buttonMusica.UseVisualStyleBackColor = false;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.Transparent;
            buttonRegresar.BackgroundImage = Properties.Resources.flechaizq;
            buttonRegresar.FlatStyle = FlatStyle.Popup;
            buttonRegresar.Location = new Point(13, 493);
            buttonRegresar.Margin = new Padding(0);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(86, 112);
            buttonRegresar.TabIndex = 194;
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(17, 22);
            pictureBoxLogo.Margin = new Padding(4, 5, 4, 5);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(250, 290);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 203;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonTicket
            // 
            buttonTicket.BackColor = Color.Transparent;
            buttonTicket.BackgroundImage = Properties.Resources.descargarticket;
            buttonTicket.Location = new Point(1547, 858);
            buttonTicket.Margin = new Padding(4, 5, 4, 5);
            buttonTicket.Name = "buttonTicket";
            buttonTicket.Size = new Size(250, 97);
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
            textBoxHora.Location = new Point(1302, 95);
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
            textBoxFecha.Location = new Point(1302, 59);
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
            textBoxUsuario.Location = new Point(1302, 22);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(197, 24);
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
            cerrarSesion.Location = new Point(1302, 585);
            cerrarSesion.Name = "cerrarSesion";
            cerrarSesion.Size = new Size(209, 46);
            cerrarSesion.TabIndex = 243;
            cerrarSesion.Text = "C E R R A R  S E S I Ó N";
            cerrarSesion.UseVisualStyleBackColor = false;
            cerrarSesion.Click += cerrarSesion_Click;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(1837, 990);
            Controls.Add(cerrarSesion);
            Controls.Add(textBoxHora);
            Controls.Add(textBoxFecha);
            Controls.Add(textBoxUsuario);
            Controls.Add(buttonTicket);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonMusica);
            Controls.Add(pictureBoxTicket);
            Margin = new Padding(4, 5, 4, 5);
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
    }
}