namespace Turnable_Tales_Proyecto
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            button1 = new Button();
            buttonMusica = new Button();
            buttonUsuario = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            labelLinea = new Label();
            labelTitulo = new Label();
            labelFrase = new Label();
            labelMenu = new Label();
            buttonRegresar = new Button();
            labeltxtVentas = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.Imagen1_removebg_preview;
            button1.Location = new Point(1176, 30);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(97, 89);
            button1.TabIndex = 213;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonMusica
            // 
            buttonMusica.FlatStyle = FlatStyle.Popup;
            buttonMusica.Image = (Image)resources.GetObject("buttonMusica.Image");
            buttonMusica.Location = new Point(1092, 30);
            buttonMusica.Name = "buttonMusica";
            buttonMusica.Size = new Size(93, 89);
            buttonMusica.TabIndex = 212;
            buttonMusica.UseVisualStyleBackColor = true;
            // 
            // buttonUsuario
            // 
            buttonUsuario.FlatStyle = FlatStyle.Popup;
            buttonUsuario.ForeColor = SystemColors.ButtonFace;
            buttonUsuario.Location = new Point(1181, 30);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(93, 89);
            buttonUsuario.TabIndex = 207;
            buttonUsuario.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 208;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(421, 103);
            label2.Name = "label2";
            label2.Size = new Size(455, 50);
            label2.TabIndex = 211;
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
            label1.Size = new Size(893, 3);
            label1.TabIndex = 210;
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
            labelLinea.Size = new Size(893, 3);
            labelLinea.TabIndex = 209;
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
            labelTitulo.Size = new Size(493, 50);
            labelTitulo.TabIndex = 205;
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
            labelFrase.Size = new Size(237, 20);
            labelFrase.TabIndex = 206;
            labelFrase.Text = "\"TU VIDA, TU MUSICA, TU VINILO.\"\r\n";
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.BackColor = Color.Transparent;
            labelMenu.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu.ForeColor = Color.White;
            labelMenu.Location = new Point(521, 177);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(239, 36);
            labelMenu.TabIndex = 204;
            labelMenu.Text = "VENTAS TOTALES\r\n";
            // 
            // buttonRegresar
            // 
            buttonRegresar.FlatStyle = FlatStyle.Popup;
            buttonRegresar.Image = (Image)resources.GetObject("buttonRegresar.Image");
            buttonRegresar.Location = new Point(9, 256);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(82, 97);
            buttonRegresar.TabIndex = 203;
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // labeltxtVentas
            // 
            labeltxtVentas.AutoSize = true;
            labeltxtVentas.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labeltxtVentas.ForeColor = Color.White;
            labeltxtVentas.Location = new Point(348, 328);
            labeltxtVentas.Name = "labeltxtVentas";
            labeltxtVentas.Size = new Size(566, 54);
            labeltxtVentas.TabIndex = 214;
            labeltxtVentas.Text = "EL TOTAL DE VENTAS ES DE $\r\n";
            labeltxtVentas.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormVentas
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1302, 633);
            Controls.Add(labeltxtVentas);
            Controls.Add(button1);
            Controls.Add(buttonMusica);
            Controls.Add(buttonUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelLinea);
            Controls.Add(labelTitulo);
            Controls.Add(labelFrase);
            Controls.Add(labelMenu);
            Controls.Add(buttonRegresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVentas";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button buttonMusica;
        private Button buttonUsuario;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label labelLinea;
        private Label labelTitulo;
        private Label labelFrase;
        private Label labelMenu;
        private Button buttonRegresar;
        private Label labeltxtVentas;
    }
}