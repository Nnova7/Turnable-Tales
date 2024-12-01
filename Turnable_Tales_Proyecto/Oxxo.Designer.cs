namespace Turnable_Tales_Proyecto
{
    partial class Oxxo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oxxo));
            buttonRegresar = new Button();
            buttonMusica = new Button();
            buttonUsuario = new Button();
            buttonTicket = new Button();
            SuspendLayout();
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
            buttonRegresar.TabIndex = 1;
            buttonRegresar.UseVisualStyleBackColor = false;
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
            // buttonUsuario
            // 
            buttonUsuario.BackColor = Color.Transparent;
            buttonUsuario.FlatStyle = FlatStyle.Popup;
            buttonUsuario.Image = Properties.Resources.Imagen1_removebg_preview;
            buttonUsuario.Location = new Point(994, 2);
            buttonUsuario.Margin = new Padding(2);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(92, 78);
            buttonUsuario.TabIndex = 194;
            buttonUsuario.UseVisualStyleBackColor = false;
            // 
            // buttonTicket
            // 
            buttonTicket.BackColor = Color.Transparent;
            buttonTicket.BackgroundImage = Properties.Resources.descargarticket;
            buttonTicket.Location = new Point(1083, 515);
            buttonTicket.Name = "buttonTicket";
            buttonTicket.Size = new Size(175, 58);
            buttonTicket.TabIndex = 196;
            buttonTicket.UseVisualStyleBackColor = false;
            // 
            // Oxxo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(1286, 594);
            Controls.Add(buttonTicket);
            Controls.Add(buttonUsuario);
            Controls.Add(buttonMusica);
            Controls.Add(buttonRegresar);
            Name = "Oxxo";
            Text = "Oxxo";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRegresar;
        private Button buttonMusica;
        private Button buttonUsuario;
        private Button buttonTicket;
    }
}