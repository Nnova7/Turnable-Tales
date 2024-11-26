namespace Turnable_Tales_Proyecto
{
    partial class Sad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sad));
            pictureBox1 = new PictureBox();
            buttonSonido = new Button();
            buttonUsuario = new Button();
            labelTitulo = new Label();
            labelFrase = new Label();
            label1 = new Label();
            labelLinea = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_1_;
            pictureBox1.Location = new Point(10, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 199;
            pictureBox1.TabStop = false;
            // 
            // buttonSonido
            // 
            buttonSonido.FlatStyle = FlatStyle.Popup;
            buttonSonido.Image = (Image)resources.GetObject("buttonSonido.Image");
            buttonSonido.Location = new Point(1053, 21);
            buttonSonido.Name = "buttonSonido";
            buttonSonido.Size = new Size(93, 89);
            buttonSonido.TabIndex = 198;
            buttonSonido.UseVisualStyleBackColor = true;
            // 
            // buttonUsuario
            // 
            buttonUsuario.BackColor = Color.Transparent;
            buttonUsuario.FlatStyle = FlatStyle.Flat;
            buttonUsuario.Image = Properties.Resources.Imagen1_removebg_preview;
            buttonUsuario.ImageAlign = ContentAlignment.MiddleRight;
            buttonUsuario.Location = new Point(1169, 21);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(93, 89);
            buttonUsuario.TabIndex = 195;
            buttonUsuario.UseVisualStyleBackColor = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(376, 18);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(595, 61);
            labelTitulo.TabIndex = 193;
            labelTitulo.Text = "T U R N T A B L E   T A L E S";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFrase
            // 
            labelFrase.AutoSize = true;
            labelFrase.BackColor = Color.Transparent;
            labelFrase.ForeColor = Color.White;
            labelFrase.Location = new Point(506, 79);
            labelFrase.Name = "labelFrase";
            labelFrase.Size = new Size(288, 25);
            labelFrase.TabIndex = 194;
            labelFrase.Text = "\"TU VIDA, TU MÚSICA, TU VINILO.\"\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(185, 139);
            label1.Name = "label1";
            label1.Size = new Size(1784, 4);
            label1.TabIndex = 201;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelLinea
            // 
            labelLinea.AutoSize = true;
            labelLinea.BackColor = Color.White;
            labelLinea.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLinea.ForeColor = Color.White;
            labelLinea.Location = new Point(185, 125);
            labelLinea.Name = "labelLinea";
            labelLinea.Size = new Size(1784, 4);
            labelLinea.TabIndex = 200;
            labelLinea.Text = resources.GetString("labelLinea.Text");
            labelLinea.TextAlign = ContentAlignment.TopCenter;
            // 
            // Sad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1302, 633);
            Controls.Add(label1);
            Controls.Add(labelLinea);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSonido);
            Controls.Add(buttonUsuario);
            Controls.Add(labelTitulo);
            Controls.Add(labelFrase);
            Name = "Sad";
            Text = "Sad";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonSonido;
        private Button buttonUsuario;
        private Label labelTitulo;
        private Label labelFrase;
        private Label label1;
        private Label labelLinea;
    }
}