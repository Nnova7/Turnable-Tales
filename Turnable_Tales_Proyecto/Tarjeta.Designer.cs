namespace Turnable_Tales_Proyecto
{
    partial class Tarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarjeta));
            buttonRegresar = new Button();
            buttonMusica = new Button();
            buttonUsuario = new Button();
            buttonTicket = new Button();
            labelTitulo = new Label();
            labelFrase = new Label();
            label1 = new Label();
            labelNomDiap = new Label();
            labelLinea = new Label();
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
            buttonRegresar.TabIndex = 2;
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
            buttonMusica.TabIndex = 194;
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
            buttonUsuario.TabIndex = 195;
            buttonUsuario.UseVisualStyleBackColor = false;
            // 
            // buttonTicket
            // 
            buttonTicket.BackColor = Color.Transparent;
            buttonTicket.BackgroundImage = Properties.Resources.descargarticket;
            buttonTicket.Location = new Point(1083, 515);
            buttonTicket.Name = "buttonTicket";
            buttonTicket.Size = new Size(175, 58);
            buttonTicket.TabIndex = 197;
            buttonTicket.UseVisualStyleBackColor = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(376, 60);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(398, 41);
            labelTitulo.TabIndex = 198;
            labelTitulo.Text = "T U R N T A B L E   T A L E S";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFrase
            // 
            labelFrase.AutoSize = true;
            labelFrase.BackColor = Color.Transparent;
            labelFrase.ForeColor = Color.White;
            labelFrase.Location = new Point(470, 120);
            labelFrase.Name = "labelFrase";
            labelFrase.Size = new Size(190, 15);
            labelFrase.TabIndex = 199;
            labelFrase.Text = "\"TU VIDA, TU MUSICA, TU VINILO.\"\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(156, 148);
            label1.Name = "label1";
            label1.Size = new Size(893, 3);
            label1.TabIndex = 200;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelNomDiap
            // 
            labelNomDiap.AutoSize = true;
            labelNomDiap.BackColor = Color.Transparent;
            labelNomDiap.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomDiap.ForeColor = Color.White;
            labelNomDiap.Location = new Point(453, 162);
            labelNomDiap.Name = "labelNomDiap";
            labelNomDiap.Size = new Size(240, 41);
            labelNomDiap.TabIndex = 201;
            labelNomDiap.Text = "PAGO EN OXXO";
            labelNomDiap.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelLinea
            // 
            labelLinea.AutoSize = true;
            labelLinea.BackColor = Color.White;
            labelLinea.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLinea.ForeColor = Color.White;
            labelLinea.Location = new Point(197, 296);
            labelLinea.Name = "labelLinea";
            labelLinea.Size = new Size(893, 3);
            labelLinea.TabIndex = 202;
            labelLinea.Text = resources.GetString("labelLinea.Text");
            labelLinea.TextAlign = ContentAlignment.TopCenter;
            // 
            // Tarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(1286, 594);
            Controls.Add(labelLinea);
            Controls.Add(labelNomDiap);
            Controls.Add(label1);
            Controls.Add(labelFrase);
            Controls.Add(labelTitulo);
            Controls.Add(buttonTicket);
            Controls.Add(buttonUsuario);
            Controls.Add(buttonMusica);
            Controls.Add(buttonRegresar);
            Name = "Tarjeta";
            Text = "Tarjeta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegresar;
        private Button buttonMusica;
        private Button buttonUsuario;
        private Button buttonTicket;
        private Label labelTitulo;
        private Label labelFrase;
        private Label label1;
        private Label labelNomDiap;
        private Label labelLinea;
    }
}