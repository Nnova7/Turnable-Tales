namespace Turnable_Tales_Proyecto
{
    partial class Efectivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Efectivo));
            buttonRegresar = new Button();
            labelTitulo = new Label();
            labelFrase = new Label();
            labelLinea = new Label();
            label1 = new Label();
            labelNomDiap = new Label();
            buttonUsuario = new Button();
            buttonMusica = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            buttonRegresar.TabIndex = 0;
            buttonRegresar.UseVisualStyleBackColor = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(400, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(398, 41);
            labelTitulo.TabIndex = 57;
            labelTitulo.Text = "T U R N T A B L E   T A L E S";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFrase
            // 
            labelFrase.AutoSize = true;
            labelFrase.BackColor = Color.Transparent;
            labelFrase.ForeColor = Color.White;
            labelFrase.Location = new Point(521, 65);
            labelFrase.Name = "labelFrase";
            labelFrase.Size = new Size(190, 15);
            labelFrase.TabIndex = 58;
            labelFrase.Text = "\"TU VIDA, TU MUSICA, TU VINILO.\"\r\n";
            // 
            // labelLinea
            // 
            labelLinea.AutoSize = true;
            labelLinea.BackColor = Color.White;
            labelLinea.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLinea.ForeColor = Color.White;
            labelLinea.Location = new Point(193, 184);
            labelLinea.Name = "labelLinea";
            labelLinea.Size = new Size(893, 3);
            labelLinea.TabIndex = 60;
            labelLinea.Text = resources.GetString("labelLinea.Text");
            labelLinea.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 93);
            label1.Name = "label1";
            label1.Size = new Size(893, 3);
            label1.TabIndex = 61;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelNomDiap
            // 
            labelNomDiap.AutoSize = true;
            labelNomDiap.BackColor = Color.Transparent;
            labelNomDiap.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomDiap.ForeColor = Color.White;
            labelNomDiap.Location = new Point(474, 112);
            labelNomDiap.Name = "labelNomDiap";
            labelNomDiap.Size = new Size(293, 41);
            labelNomDiap.TabIndex = 62;
            labelNomDiap.Text = "PAGO EN EFECTIVO";
            labelNomDiap.TextAlign = ContentAlignment.TopCenter;
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
            buttonUsuario.TabIndex = 191;
            buttonUsuario.UseVisualStyleBackColor = false;
            // 
            // buttonMusica
            // 
            buttonMusica.BackColor = Color.Transparent;
            buttonMusica.FlatStyle = FlatStyle.Popup;
            buttonMusica.Image = (Image)resources.GetObject("buttonMusica.Image");
            buttonMusica.Location = new Point(905, -2);
            buttonMusica.Name = "buttonMusica";
            buttonMusica.Size = new Size(84, 86);
            buttonMusica.TabIndex = 192;
            buttonMusica.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.datos;
            pictureBox1.Location = new Point(420, 204);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 369);
            pictureBox1.TabIndex = 193;
            pictureBox1.TabStop = false;
            // 
            // Efectivo
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(1286, 594);
            Controls.Add(pictureBox1);
            Controls.Add(buttonMusica);
            Controls.Add(buttonUsuario);
            Controls.Add(labelNomDiap);
            Controls.Add(label1);
            Controls.Add(labelLinea);
            Controls.Add(labelFrase);
            Controls.Add(labelTitulo);
            Controls.Add(buttonRegresar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Efectivo";
            Text = "Efectivo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegresar;
        private Label labelTitulo;
        private Label labelFrase;
        private Label labelLinea;
        private Label label1;
        private Label labelNomDiap;
        private Button buttonUsuario;
        private Button buttonMusica;
        private PictureBox pictureBox1;
    }
}