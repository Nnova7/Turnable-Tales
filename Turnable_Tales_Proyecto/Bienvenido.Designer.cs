namespace Turnable_Tales_Proyecto
{
    partial class Bienvenido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenido));
            pictureBoxLogo = new PictureBox();
            label2 = new Label();
            buttonSiguiente = new Button();
            buttonBienvenido = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImage = (Image)resources.GetObject("pictureBoxLogo.BackgroundImage");
            pictureBoxLogo.Location = new Point(44, 45);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(224, 207);
            pictureBoxLogo.TabIndex = 365;
            pictureBoxLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(509, 604);
            label2.Name = "label2";
            label2.Size = new Size(305, 15);
            label2.TabIndex = 364;
            label2.Text = "S I S T E M A  D E  E S C R I T O R I O  S T A N D A L O N E ";
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.BackColor = Color.Transparent;
            buttonSiguiente.FlatStyle = FlatStyle.Flat;
            buttonSiguiente.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSiguiente.Image = (Image)resources.GetObject("buttonSiguiente.Image");
            buttonSiguiente.Location = new Point(1222, 330);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(66, 85);
            buttonSiguiente.TabIndex = 370;
            buttonSiguiente.UseVisualStyleBackColor = true;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // buttonBienvenido
            // 
            buttonBienvenido.BackColor = Color.Transparent;
            buttonBienvenido.BackgroundImage = Properties.Resources.Fondo;
            buttonBienvenido.Font = new Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBienvenido.ForeColor = SystemColors.ButtonHighlight;
            buttonBienvenido.Image = Properties.Resources.Fondo;
            buttonBienvenido.Location = new Point(145, 258);
            buttonBienvenido.Name = "buttonBienvenido";
            buttonBienvenido.Size = new Size(1016, 236);
            buttonBienvenido.TabIndex = 369;
            buttonBienvenido.Text = "B I E N V E N I D O";
            buttonBienvenido.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(474, 280);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 368;
            pictureBox1.TabStop = false;
            // 
            // Bienvenido
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(1302, 633);
            Controls.Add(buttonSiguiente);
            Controls.Add(buttonBienvenido);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label2);
            Name = "Bienvenido";
            Text = "Bienvenido";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxLogo;
        private Label label2;
        private Button buttonSiguiente;
        private Button buttonBienvenido;
        private PictureBox pictureBox1;
    }
}