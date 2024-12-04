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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            pictureBoxTicket = new PictureBox();
            buttonUsuario = new Button();
            buttonMusica = new Button();
            buttonRegresar = new Button();
            pictureBoxLogo = new PictureBox();
            buttonTicket = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTicket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTicket
            // 
            pictureBoxTicket.BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_03_at_9_15_30_AM;
            pictureBoxTicket.Location = new Point(346, 12);
            pictureBoxTicket.Name = "pictureBoxTicket";
            pictureBoxTicket.Size = new Size(392, 555);
            pictureBoxTicket.TabIndex = 0;
            pictureBoxTicket.TabStop = false;
            // 
            // buttonUsuario
            // 
            buttonUsuario.BackColor = Color.Transparent;
            buttonUsuario.FlatStyle = FlatStyle.Popup;
            buttonUsuario.Image = Properties.Resources.Imagen1_removebg_preview;
            buttonUsuario.Location = new Point(994, 2);
            buttonUsuario.Margin = new Padding(2);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(92, 78);
            buttonUsuario.TabIndex = 192;
            buttonUsuario.UseVisualStyleBackColor = false;
            buttonUsuario.Click += buttonUsuario_Click;
            // 
            // buttonMusica
            // 
            buttonMusica.BackColor = Color.Transparent;
            buttonMusica.FlatStyle = FlatStyle.Popup;
            buttonMusica.Image = (Image)resources.GetObject("buttonMusica.Image");
            buttonMusica.Location = new Point(905, -2);
            buttonMusica.Name = "buttonMusica";
            buttonMusica.Size = new Size(84, 86);
            buttonMusica.TabIndex = 193;
            buttonMusica.UseVisualStyleBackColor = false;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.Transparent;
            buttonRegresar.BackgroundImage = Properties.Resources.flechaizq;
            buttonRegresar.FlatStyle = FlatStyle.Popup;
            buttonRegresar.Location = new Point(9, 296);
            buttonRegresar.Margin = new Padding(0);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(60, 67);
            buttonRegresar.TabIndex = 194;
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(12, 13);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(175, 174);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 203;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonTicket
            // 
            buttonTicket.BackColor = Color.Transparent;
            buttonTicket.BackgroundImage = Properties.Resources.descargarticket;
            buttonTicket.Location = new Point(1083, 515);
            buttonTicket.Name = "buttonTicket";
            buttonTicket.Size = new Size(175, 58);
            buttonTicket.TabIndex = 204;
            buttonTicket.UseVisualStyleBackColor = false;
            buttonTicket.Click += buttonTicket_Click;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(1286, 594);
            Controls.Add(buttonTicket);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonMusica);
            Controls.Add(buttonUsuario);
            Controls.Add(pictureBoxTicket);
            Name = "Ticket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTicket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxTicket;
        private Button buttonUsuario;
        private Button buttonMusica;
        private Button buttonRegresar;
        private PictureBox pictureBoxLogo;
        private Button buttonTicket;
    }
}