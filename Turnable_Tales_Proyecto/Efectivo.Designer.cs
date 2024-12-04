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
            pictureBoxDatos = new PictureBox();
            buttonCambio = new Button();
            buttonTicket = new Button();
            textBoxNPedido = new TextBox();
            textBoxSub = new TextBox();
            textBoxImp = new TextBox();
            textBoxTot = new TextBox();
            textBoxCam = new TextBox();
            textBoxPagoCon = new TextBox();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
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
            buttonRegresar.Click += buttonRegresar_Click;
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
            buttonMusica.TabIndex = 192;
            buttonMusica.UseVisualStyleBackColor = false;
            // 
            // pictureBoxDatos
            // 
            pictureBoxDatos.BackColor = Color.Transparent;
            pictureBoxDatos.BackgroundImage = Properties.Resources.datos;
            pictureBoxDatos.Location = new Point(420, 204);
            pictureBoxDatos.Name = "pictureBoxDatos";
            pictureBoxDatos.Size = new Size(412, 369);
            pictureBoxDatos.TabIndex = 193;
            pictureBoxDatos.TabStop = false;
            // 
            // buttonCambio
            // 
            buttonCambio.BackColor = Color.Transparent;
            buttonCambio.BackgroundImage = Properties.Resources.cambio;
            buttonCambio.Location = new Point(567, 470);
            buttonCambio.Name = "buttonCambio";
            buttonCambio.Size = new Size(126, 38);
            buttonCambio.TabIndex = 194;
            buttonCambio.UseVisualStyleBackColor = false;
            // 
            // buttonTicket
            // 
            buttonTicket.BackColor = Color.Transparent;
            buttonTicket.BackgroundImage = Properties.Resources.verTicket;
            buttonTicket.Location = new Point(1099, 547);
            buttonTicket.Name = "buttonTicket";
            buttonTicket.Size = new Size(157, 26);
            buttonTicket.TabIndex = 195;
            buttonTicket.UseVisualStyleBackColor = false;
            buttonTicket.Click += buttonTicket_Click;
            // 
            // textBoxNPedido
            // 
            textBoxNPedido.BackColor = Color.Black;
            textBoxNPedido.Enabled = false;
            textBoxNPedido.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNPedido.Location = new Point(647, 244);
            textBoxNPedido.Name = "textBoxNPedido";
            textBoxNPedido.Size = new Size(151, 26);
            textBoxNPedido.TabIndex = 196;
            textBoxNPedido.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxSub
            // 
            textBoxSub.BackColor = Color.Black;
            textBoxSub.Enabled = false;
            textBoxSub.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSub.Location = new Point(647, 284);
            textBoxSub.Name = "textBoxSub";
            textBoxSub.Size = new Size(151, 26);
            textBoxSub.TabIndex = 197;
            textBoxSub.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxImp
            // 
            textBoxImp.BackColor = Color.Black;
            textBoxImp.Enabled = false;
            textBoxImp.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxImp.Location = new Point(647, 319);
            textBoxImp.Name = "textBoxImp";
            textBoxImp.Size = new Size(151, 26);
            textBoxImp.TabIndex = 198;
            textBoxImp.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxTot
            // 
            textBoxTot.BackColor = Color.Black;
            textBoxTot.Enabled = false;
            textBoxTot.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTot.Location = new Point(647, 357);
            textBoxTot.Name = "textBoxTot";
            textBoxTot.Size = new Size(151, 26);
            textBoxTot.TabIndex = 199;
            textBoxTot.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCam
            // 
            textBoxCam.BackColor = Color.Black;
            textBoxCam.Enabled = false;
            textBoxCam.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCam.Location = new Point(647, 534);
            textBoxCam.Name = "textBoxCam";
            textBoxCam.Size = new Size(151, 26);
            textBoxCam.TabIndex = 200;
            textBoxCam.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPagoCon
            // 
            textBoxPagoCon.BackColor = Color.Black;
            textBoxPagoCon.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPagoCon.Location = new Point(647, 441);
            textBoxPagoCon.Name = "textBoxPagoCon";
            textBoxPagoCon.Size = new Size(151, 26);
            textBoxPagoCon.TabIndex = 201;
            textBoxPagoCon.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(12, 13);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(175, 174);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 202;
            pictureBoxLogo.TabStop = false;
            // 
            // Efectivo
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(1286, 594);
            Controls.Add(pictureBoxLogo);
            Controls.Add(textBoxPagoCon);
            Controls.Add(textBoxCam);
            Controls.Add(textBoxTot);
            Controls.Add(textBoxImp);
            Controls.Add(textBoxSub);
            Controls.Add(textBoxNPedido);
            Controls.Add(buttonTicket);
            Controls.Add(buttonCambio);
            Controls.Add(pictureBoxDatos);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Efectivo";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
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
        private PictureBox pictureBoxDatos;
        private Button buttonCambio;
        private Button buttonTicket;
        private TextBox textBoxNPedido;
        private TextBox textBoxSub;
        private TextBox textBoxImp;
        private TextBox textBoxTot;
        private TextBox textBoxCam;
        private TextBox textBoxPagoCon;
        private PictureBox pictureBoxLogo;
    }
}