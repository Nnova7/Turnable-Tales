﻿namespace Turnable_Tales_Proyecto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarjeta));
            buttonRegresar = new Button();
            buttonMusica = new Button();
            buttonTicket = new Button();
            labelTitulo = new Label();
            labelFrase = new Label();
            label1 = new Label();
            labelNomDiap = new Label();
            labelLinea = new Label();
            buttonVisa = new Button();
            buttonMaster = new Button();
            buttonAmerican = new Button();
            buttonCarnet = new Button();
            pictureBox1 = new PictureBox();
            textBoxNPedido = new TextBox();
            textBoxSub = new TextBox();
            textBoxImp = new TextBox();
            textBoxTot = new TextBox();
            textBoxCosEnvio = new TextBox();
            buttonGuardar = new Button();
            labelNTarjeta = new Label();
            labelFCaducidad = new Label();
            labelCSeguridad = new Label();
            textBoxNTarjeta = new TextBox();
            textBoxMes = new TextBox();
            textBoxCVV = new TextBox();
            textBoxAnio = new TextBox();
            pictureBoxLogo = new PictureBox();
            textBoxHora = new TextBox();
            textBoxFecha = new TextBox();
            textBoxUsuario = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            buttonRegresar.TabIndex = 2;
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // buttonMusica
            // 
            buttonMusica.BackColor = Color.Transparent;
            buttonMusica.FlatStyle = FlatStyle.Popup;
            buttonMusica.Image = (Image)resources.GetObject("buttonMusica.Image");
            buttonMusica.Location = new Point(236, 4);
            buttonMusica.Name = "buttonMusica";
            buttonMusica.Size = new Size(84, 86);
            buttonMusica.TabIndex = 194;
            buttonMusica.UseVisualStyleBackColor = false;
            buttonMusica.Click += buttonMusica_Click;
            // 
            // buttonTicket
            // 
            buttonTicket.BackColor = Color.Transparent;
            buttonTicket.BackgroundImage = Properties.Resources.verTicket;
            buttonTicket.Location = new Point(1100, 546);
            buttonTicket.Name = "buttonTicket";
            buttonTicket.Size = new Size(158, 27);
            buttonTicket.TabIndex = 197;
            buttonTicket.UseVisualStyleBackColor = false;
            buttonTicket.Click += buttonTicket_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(400, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(595, 61);
            labelTitulo.TabIndex = 198;
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
            labelFrase.Size = new Size(288, 25);
            labelFrase.TabIndex = 199;
            labelFrase.Text = "\"TU VIDA, TU MUSICA, TU VINILO.\"\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 93);
            label1.Name = "label1";
            label1.Size = new Size(1784, 4);
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
            labelNomDiap.Location = new Point(466, 109);
            labelNomDiap.Name = "labelNomDiap";
            labelNomDiap.Size = new Size(455, 61);
            labelNomDiap.TabIndex = 201;
            labelNomDiap.Text = "PAGO CON TARJETA";
            labelNomDiap.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelLinea
            // 
            labelLinea.AutoSize = true;
            labelLinea.BackColor = Color.White;
            labelLinea.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLinea.ForeColor = Color.White;
            labelLinea.Location = new Point(193, 184);
            labelLinea.Name = "labelLinea";
            labelLinea.Size = new Size(1784, 4);
            labelLinea.TabIndex = 202;
            labelLinea.Text = resources.GetString("labelLinea.Text");
            labelLinea.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonVisa
            // 
            buttonVisa.BackgroundImage = Properties.Resources.visa;
            buttonVisa.FlatStyle = FlatStyle.Popup;
            buttonVisa.Location = new Point(120, 221);
            buttonVisa.Name = "buttonVisa";
            buttonVisa.Size = new Size(129, 68);
            buttonVisa.TabIndex = 203;
            buttonVisa.UseVisualStyleBackColor = true;
            // 
            // buttonMaster
            // 
            buttonMaster.BackgroundImage = Properties.Resources.mastercad;
            buttonMaster.FlatStyle = FlatStyle.Popup;
            buttonMaster.Location = new Point(255, 221);
            buttonMaster.Name = "buttonMaster";
            buttonMaster.Size = new Size(96, 76);
            buttonMaster.TabIndex = 204;
            buttonMaster.UseVisualStyleBackColor = true;
            // 
            // buttonAmerican
            // 
            buttonAmerican.BackgroundImage = Properties.Resources.americanexpress;
            buttonAmerican.FlatStyle = FlatStyle.Popup;
            buttonAmerican.Location = new Point(357, 221);
            buttonAmerican.Name = "buttonAmerican";
            buttonAmerican.Size = new Size(75, 68);
            buttonAmerican.TabIndex = 205;
            buttonAmerican.UseVisualStyleBackColor = true;
            // 
            // buttonCarnet
            // 
            buttonCarnet.BackgroundImage = Properties.Resources.carnet;
            buttonCarnet.FlatStyle = FlatStyle.Popup;
            buttonCarnet.Location = new Point(438, 221);
            buttonCarnet.Name = "buttonCarnet";
            buttonCarnet.Size = new Size(100, 68);
            buttonCarnet.TabIndex = 206;
            buttonCarnet.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.resumenpedido;
            pictureBox1.Location = new Point(850, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 286);
            pictureBox1.TabIndex = 207;
            pictureBox1.TabStop = false;
            // 
            // textBoxNPedido
            // 
            textBoxNPedido.BackColor = Color.Black;
            textBoxNPedido.Enabled = false;
            textBoxNPedido.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNPedido.ForeColor = SystemColors.Menu;
            textBoxNPedido.Location = new Point(1083, 280);
            textBoxNPedido.Name = "textBoxNPedido";
            textBoxNPedido.Size = new Size(151, 35);
            textBoxNPedido.TabIndex = 208;
            textBoxNPedido.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxSub
            // 
            textBoxSub.BackColor = Color.Black;
            textBoxSub.Enabled = false;
            textBoxSub.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSub.ForeColor = SystemColors.Menu;
            textBoxSub.Location = new Point(1083, 361);
            textBoxSub.Name = "textBoxSub";
            textBoxSub.Size = new Size(151, 35);
            textBoxSub.TabIndex = 209;
            textBoxSub.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxImp
            // 
            textBoxImp.BackColor = Color.Black;
            textBoxImp.Enabled = false;
            textBoxImp.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxImp.ForeColor = SystemColors.Menu;
            textBoxImp.Location = new Point(1083, 401);
            textBoxImp.Name = "textBoxImp";
            textBoxImp.Size = new Size(151, 35);
            textBoxImp.TabIndex = 210;
            textBoxImp.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxTot
            // 
            textBoxTot.BackColor = Color.Black;
            textBoxTot.Enabled = false;
            textBoxTot.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTot.ForeColor = SystemColors.Menu;
            textBoxTot.Location = new Point(1083, 446);
            textBoxTot.Name = "textBoxTot";
            textBoxTot.Size = new Size(151, 35);
            textBoxTot.TabIndex = 211;
            textBoxTot.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCosEnvio
            // 
            textBoxCosEnvio.BackColor = Color.Black;
            textBoxCosEnvio.Enabled = false;
            textBoxCosEnvio.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCosEnvio.ForeColor = SystemColors.Menu;
            textBoxCosEnvio.Location = new Point(1083, 316);
            textBoxCosEnvio.Name = "textBoxCosEnvio";
            textBoxCosEnvio.Size = new Size(151, 35);
            textBoxCosEnvio.TabIndex = 212;
            textBoxCosEnvio.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.Transparent;
            buttonGuardar.BackgroundImage = Properties.Resources.guardar;
            buttonGuardar.Location = new Point(850, 515);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(112, 55);
            buttonGuardar.TabIndex = 213;
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // labelNTarjeta
            // 
            labelNTarjeta.AutoSize = true;
            labelNTarjeta.BackColor = Color.Transparent;
            labelNTarjeta.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNTarjeta.ForeColor = Color.White;
            labelNTarjeta.Location = new Point(127, 314);
            labelNTarjeta.Name = "labelNTarjeta";
            labelNTarjeta.Size = new Size(282, 27);
            labelNTarjeta.TabIndex = 214;
            labelNTarjeta.Text = "NUMERO DE LA TARJETA*";
            // 
            // labelFCaducidad
            // 
            labelFCaducidad.AutoSize = true;
            labelFCaducidad.BackColor = Color.Transparent;
            labelFCaducidad.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFCaducidad.ForeColor = Color.White;
            labelFCaducidad.Location = new Point(127, 387);
            labelFCaducidad.Name = "labelFCaducidad";
            labelFCaducidad.Size = new Size(275, 27);
            labelFCaducidad.TabIndex = 215;
            labelFCaducidad.Text = "FECHA DE CADUCIDAD*";
            // 
            // labelCSeguridad
            // 
            labelCSeguridad.AutoSize = true;
            labelCSeguridad.BackColor = Color.Transparent;
            labelCSeguridad.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCSeguridad.ForeColor = Color.White;
            labelCSeguridad.Location = new Point(127, 454);
            labelCSeguridad.Name = "labelCSeguridad";
            labelCSeguridad.Size = new Size(285, 27);
            labelCSeguridad.TabIndex = 216;
            labelCSeguridad.Text = "CODIGO DE SEGURIDAD*";
            // 
            // textBoxNTarjeta
            // 
            textBoxNTarjeta.BackColor = Color.Black;
            textBoxNTarjeta.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNTarjeta.ForeColor = SystemColors.Menu;
            textBoxNTarjeta.Location = new Point(127, 337);
            textBoxNTarjeta.MaxLength = 16;
            textBoxNTarjeta.Name = "textBoxNTarjeta";
            textBoxNTarjeta.PlaceholderText = "XXXX XXXX XXXX XXXX";
            textBoxNTarjeta.Size = new Size(305, 35);
            textBoxNTarjeta.TabIndex = 217;
            textBoxNTarjeta.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxMes
            // 
            textBoxMes.BackColor = Color.Black;
            textBoxMes.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMes.ForeColor = SystemColors.Menu;
            textBoxMes.Location = new Point(127, 408);
            textBoxMes.MaxLength = 2;
            textBoxMes.Name = "textBoxMes";
            textBoxMes.PlaceholderText = "MES";
            textBoxMes.Size = new Size(88, 35);
            textBoxMes.TabIndex = 218;
            textBoxMes.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCVV
            // 
            textBoxCVV.BackColor = Color.Black;
            textBoxCVV.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCVV.ForeColor = SystemColors.Menu;
            textBoxCVV.Location = new Point(127, 475);
            textBoxCVV.MaxLength = 3;
            textBoxCVV.Name = "textBoxCVV";
            textBoxCVV.PlaceholderText = "CVV/CVC/CID";
            textBoxCVV.Size = new Size(144, 35);
            textBoxCVV.TabIndex = 219;
            textBoxCVV.TextAlign = HorizontalAlignment.Center;
            textBoxCVV.TextChanged += textBoxCVV_TextChanged;
            // 
            // textBoxAnio
            // 
            textBoxAnio.BackColor = Color.Black;
            textBoxAnio.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxAnio.ForeColor = SystemColors.Menu;
            textBoxAnio.Location = new Point(255, 408);
            textBoxAnio.MaxLength = 2;
            textBoxAnio.Name = "textBoxAnio";
            textBoxAnio.PlaceholderText = "AÑO";
            textBoxAnio.Size = new Size(83, 35);
            textBoxAnio.TabIndex = 220;
            textBoxAnio.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(12, 13);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(175, 174);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 221;
            pictureBoxLogo.TabStop = false;
            // 
            // textBoxHora
            // 
            textBoxHora.BackColor = SystemColors.InactiveCaptionText;
            textBoxHora.BorderStyle = BorderStyle.None;
            textBoxHora.Enabled = false;
            textBoxHora.ForeColor = Color.White;
            textBoxHora.Location = new Point(1061, 77);
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
            textBoxFecha.Location = new Point(1061, 41);
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
            textBoxUsuario.Location = new Point(1061, 4);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(197, 24);
            textBoxUsuario.TabIndex = 240;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Tarjeta
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(1286, 594);
            Controls.Add(textBoxHora);
            Controls.Add(textBoxFecha);
            Controls.Add(textBoxUsuario);
            Controls.Add(pictureBoxLogo);
            Controls.Add(textBoxAnio);
            Controls.Add(textBoxCVV);
            Controls.Add(textBoxMes);
            Controls.Add(textBoxNTarjeta);
            Controls.Add(labelCSeguridad);
            Controls.Add(labelFCaducidad);
            Controls.Add(labelNTarjeta);
            Controls.Add(buttonGuardar);
            Controls.Add(textBoxCosEnvio);
            Controls.Add(textBoxTot);
            Controls.Add(textBoxImp);
            Controls.Add(textBoxSub);
            Controls.Add(textBoxNPedido);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCarnet);
            Controls.Add(buttonAmerican);
            Controls.Add(buttonMaster);
            Controls.Add(buttonVisa);
            Controls.Add(labelLinea);
            Controls.Add(labelNomDiap);
            Controls.Add(label1);
            Controls.Add(labelFrase);
            Controls.Add(labelTitulo);
            Controls.Add(buttonTicket);
            Controls.Add(buttonMusica);
            Controls.Add(buttonRegresar);
            Name = "Tarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarjeta";
            Load += Tarjeta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegresar;
        private Button buttonMusica;
        private Button buttonTicket;
        private Label labelTitulo;
        private Label labelFrase;
        private Label label1;
        private Label labelNomDiap;
        private Label labelLinea;
        private Button buttonVisa;
        private Button buttonMaster;
        private Button buttonAmerican;
        private Button buttonCarnet;
        private PictureBox pictureBox1;
        private TextBox textBoxNPedido;
        private TextBox textBoxSub;
        private TextBox textBoxImp;
        private TextBox textBoxTot;
        private TextBox textBoxCosEnvio;
        private Button buttonGuardar;
        private Label labelNTarjeta;
        private Label labelFCaducidad;
        private Label labelCSeguridad;
        private TextBox textBoxNTarjeta;
        private TextBox textBoxMes;
        private TextBox textBoxCVV;
        private TextBox textBoxAnio;
        private PictureBox pictureBoxLogo;
        private TextBox textBoxHora;
        private TextBox textBoxFecha;
        private TextBox textBoxUsuario;
        private System.Windows.Forms.Timer timer1;
    }
}