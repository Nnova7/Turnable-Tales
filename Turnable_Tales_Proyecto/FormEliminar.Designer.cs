﻿namespace Turnable_Tales_Proyecto
{
    partial class FormEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminar));
            buttonRegresar = new Button();
            buttonEnter = new Button();
            labeltxtDiscoaEliminar = new Label();
            labeltxtEliminardisco = new Label();
            labelFrase = new Label();
            labelTitulo = new Label();
            labelLinea = new Label();
            label1 = new Label();
            labelAdministrador = new Label();
            pictureBox1 = new PictureBox();
            buttonMusica = new Button();
            button1 = new Button();
            textBoxId = new TextBox();
            buttonLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonRegresar
            // 
            buttonRegresar.FlatStyle = FlatStyle.Popup;
            buttonRegresar.Image = (Image)resources.GetObject("buttonRegresar.Image");
            buttonRegresar.Location = new Point(12, 287);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(82, 97);
            buttonRegresar.TabIndex = 63;
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // buttonEnter
            // 
            buttonEnter.FlatStyle = FlatStyle.Popup;
            buttonEnter.Image = (Image)resources.GetObject("buttonEnter.Image");
            buttonEnter.Location = new Point(549, 434);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(196, 56);
            buttonEnter.TabIndex = 61;
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // labeltxtDiscoaEliminar
            // 
            labeltxtDiscoaEliminar.AutoSize = true;
            labeltxtDiscoaEliminar.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labeltxtDiscoaEliminar.ForeColor = Color.White;
            labeltxtDiscoaEliminar.Location = new Point(410, 287);
            labeltxtDiscoaEliminar.Name = "labeltxtDiscoaEliminar";
            labeltxtDiscoaEliminar.Size = new Size(481, 50);
            labeltxtDiscoaEliminar.TabIndex = 59;
            labeltxtDiscoaEliminar.Text = "ID DEL DISCO A ELIMINAR";
            labeltxtDiscoaEliminar.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtEliminardisco
            // 
            labeltxtEliminardisco.AutoSize = true;
            labeltxtEliminardisco.BackColor = Color.Transparent;
            labeltxtEliminardisco.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labeltxtEliminardisco.ForeColor = Color.White;
            labeltxtEliminardisco.Location = new Point(531, 199);
            labeltxtEliminardisco.Name = "labeltxtEliminardisco";
            labeltxtEliminardisco.Size = new Size(239, 36);
            labeltxtEliminardisco.TabIndex = 51;
            labeltxtEliminardisco.Text = "ELIMINAR DISCO\r\n";
            // 
            // labelFrase
            // 
            labelFrase.AutoSize = true;
            labelFrase.BackColor = Color.Transparent;
            labelFrase.ForeColor = Color.White;
            labelFrase.Location = new Point(531, 64);
            labelFrase.Name = "labelFrase";
            labelFrase.Size = new Size(237, 20);
            labelFrase.TabIndex = 53;
            labelFrase.Text = "\"TU VIDA, TU MUSICA, TU VINILO.\"\r\n";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(410, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(493, 50);
            labelTitulo.TabIndex = 52;
            labelTitulo.Text = "T U R N T A B L E   T A L E S";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelLinea
            // 
            labelLinea.AutoSize = true;
            labelLinea.BackColor = Color.White;
            labelLinea.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLinea.ForeColor = Color.White;
            labelLinea.Location = new Point(203, 92);
            labelLinea.Name = "labelLinea";
            labelLinea.Size = new Size(893, 3);
            labelLinea.TabIndex = 55;
            labelLinea.Text = resources.GetString("labelLinea.Text");
            labelLinea.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 183);
            label1.Name = "label1";
            label1.Size = new Size(893, 3);
            label1.TabIndex = 56;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelAdministrador
            // 
            labelAdministrador.AutoSize = true;
            labelAdministrador.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelAdministrador.ForeColor = Color.White;
            labelAdministrador.Location = new Point(431, 112);
            labelAdministrador.Name = "labelAdministrador";
            labelAdministrador.Size = new Size(455, 50);
            labelAdministrador.TabIndex = 57;
            labelAdministrador.Text = "A D M I N I S T R A D O R\r\n";
            labelAdministrador.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // buttonMusica
            // 
            buttonMusica.FlatStyle = FlatStyle.Popup;
            buttonMusica.Image = (Image)resources.GetObject("buttonMusica.Image");
            buttonMusica.Location = new Point(1102, 45);
            buttonMusica.Name = "buttonMusica";
            buttonMusica.Size = new Size(93, 89);
            buttonMusica.TabIndex = 58;
            buttonMusica.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.Imagen1_removebg_preview;
            button1.Location = new Point(1190, 45);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(97, 89);
            button1.TabIndex = 189;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.ActiveCaptionText;
            textBoxId.Location = new Point(431, 357);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "INTRODUZCA UN DATO";
            textBoxId.Size = new Size(428, 27);
            textBoxId.TabIndex = 190;
            textBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.FlatStyle = FlatStyle.Popup;
            buttonLimpiar.Image = (Image)resources.GetObject("buttonLimpiar.Image");
            buttonLimpiar.Location = new Point(503, 520);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(294, 54);
            buttonLimpiar.TabIndex = 223;
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // FormEliminar
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1302, 633);
            Controls.Add(buttonLimpiar);
            Controls.Add(textBoxId);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonEnter);
            Controls.Add(labeltxtDiscoaEliminar);
            Controls.Add(buttonMusica);
            Controls.Add(labelAdministrador);
            Controls.Add(label1);
            Controls.Add(labelLinea);
            Controls.Add(labelTitulo);
            Controls.Add(labelFrase);
            Controls.Add(labeltxtEliminardisco);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormEliminar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonRegresar;
        private Button buttonEnter;
        private Label labeltxtDiscoaEliminar;
        private Label labeltxtEliminardisco;
        private Label labelFrase;
        private Label labelTitulo;
        private Label labelLinea;
        private Label label1;
        private Label labelAdministrador;
        private PictureBox pictureBox1;
        private Button buttonMusica;
        private Button button1;
        private TextBox textBoxId;
        private Button buttonLimpiar;
    }
}