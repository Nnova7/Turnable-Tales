﻿namespace Turnable_Tales_Proyecto
{
    partial class FormGraficas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraficas));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            pictureBox1 = new PictureBox();
            buttonRegresar = new Button();
            buttonMusica = new Button();
            label2 = new Label();
            label1 = new Label();
            labelLinea = new Label();
            labelTitulo = new Label();
            labelFrase = new Label();
            labelMenu = new Label();
            button1 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // buttonRegresar
            // 
            buttonRegresar.FlatStyle = FlatStyle.Popup;
            buttonRegresar.Image = (Image)resources.GetObject("buttonRegresar.Image");
            buttonRegresar.Location = new Point(12, 296);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(82, 97);
            buttonRegresar.TabIndex = 63;
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // buttonMusica
            // 
            buttonMusica.FlatStyle = FlatStyle.Popup;
            buttonMusica.Image = (Image)resources.GetObject("buttonMusica.Image");
            buttonMusica.Location = new Point(1092, 46);
            buttonMusica.Name = "buttonMusica";
            buttonMusica.Size = new Size(93, 89);
            buttonMusica.TabIndex = 62;
            buttonMusica.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(421, 113);
            label2.Name = "label2";
            label2.Size = new Size(455, 50);
            label2.TabIndex = 61;
            label2.Text = "A D M I N I S T R A D O R\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 184);
            label1.Name = "label1";
            label1.Size = new Size(893, 3);
            label1.TabIndex = 60;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelLinea
            // 
            labelLinea.AutoSize = true;
            labelLinea.BackColor = Color.White;
            labelLinea.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLinea.ForeColor = Color.White;
            labelLinea.Location = new Point(193, 93);
            labelLinea.Name = "labelLinea";
            labelLinea.Size = new Size(893, 3);
            labelLinea.TabIndex = 59;
            labelLinea.Text = resources.GetString("labelLinea.Text");
            labelLinea.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(400, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(493, 50);
            labelTitulo.TabIndex = 56;
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
            labelFrase.Size = new Size(237, 20);
            labelFrase.TabIndex = 57;
            labelFrase.Text = "\"TU VIDA, TU MUSICA, TU VINILO.\"\r\n";
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.BackColor = Color.Transparent;
            labelMenu.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu.ForeColor = Color.White;
            labelMenu.Location = new Point(493, 197);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(287, 36);
            labelMenu.TabIndex = 55;
            labelMenu.Text = "GRAFICA EN VENTAS";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.Imagen1_removebg_preview;
            button1.Location = new Point(1179, 46);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(97, 89);
            button1.TabIndex = 190;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chart1
            // 
            chart1.BackColor = SystemColors.ActiveCaptionText;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(383, 237);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            chart1.Size = new Size(689, 384);
            chart1.TabIndex = 191;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // FormGraficas
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1302, 633);
            Controls.Add(chart1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonMusica);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelLinea);
            Controls.Add(labelTitulo);
            Controls.Add(labelFrase);
            Controls.Add(labelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGraficas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGraficas";
            Load += FormGraficas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonRegresar;
        private Button buttonMusica;
        private Label label2;
        private Label label1;
        private Label labelLinea;
        private Label labelTitulo;
        private Label labelFrase;
        private Label labelMenu;
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}