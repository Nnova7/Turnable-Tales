namespace Turnable_Tales_Proyecto
{
    partial class IngresarUsuario
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
            buttonSiguiente = new Button();
            textBoxContraU = new TextBox();
            textBoxCuentaU = new TextBox();
            buttonAtras = new Button();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.BackColor = Color.Transparent;
            buttonSiguiente.BackgroundImageLayout = ImageLayout.Center;
            buttonSiguiente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiguiente.ForeColor = SystemColors.ButtonHighlight;
            buttonSiguiente.Image = Properties.Resources.cafe;
            buttonSiguiente.Location = new Point(189, 433);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(198, 36);
            buttonSiguiente.TabIndex = 65;
            buttonSiguiente.Text = "SIGUIENTE";
            buttonSiguiente.UseVisualStyleBackColor = false;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // textBoxContraU
            // 
            textBoxContraU.BackColor = Color.Silver;
            textBoxContraU.Location = new Point(117, 374);
            textBoxContraU.Name = "textBoxContraU";
            textBoxContraU.PasswordChar = '*';
            textBoxContraU.PlaceholderText = "Ingresa la contraseña";
            textBoxContraU.Size = new Size(341, 27);
            textBoxContraU.TabIndex = 64;
            textBoxContraU.TextAlign = HorizontalAlignment.Center;
            textBoxContraU.TextChanged += textBoxContraU_TextChanged;
            // 
            // textBoxCuentaU
            // 
            textBoxCuentaU.BackColor = Color.Silver;
            textBoxCuentaU.Location = new Point(117, 267);
            textBoxCuentaU.Name = "textBoxCuentaU";
            textBoxCuentaU.PlaceholderText = "Ingresa tu cuenta";
            textBoxCuentaU.Size = new Size(341, 27);
            textBoxCuentaU.TabIndex = 63;
            textBoxCuentaU.TextAlign = HorizontalAlignment.Center;
            textBoxCuentaU.TextChanged += textBoxCuentaU_TextChanged;
            // 
            // buttonAtras
            // 
            buttonAtras.BackColor = Color.Transparent;
            buttonAtras.FlatStyle = FlatStyle.Popup;
            buttonAtras.Image = Properties.Resources.flechaizq;
            buttonAtras.Location = new Point(10, 280);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(68, 72);
            buttonAtras.TabIndex = 62;
            buttonAtras.UseVisualStyleBackColor = false;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(117, 332);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 61;
            label2.Text = "C O N T R A S E Ñ A:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(117, 226);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 60;
            label1.Text = "C U E N T A:";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.cafe;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(103, 104);
            button1.Name = "button1";
            button1.Size = new Size(364, 78);
            button1.TabIndex = 59;
            button1.Text = "U S U A R I O";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(189, 67);
            label3.Name = "label3";
            label3.Size = new Size(186, 15);
            label3.TabIndex = 58;
            label3.Text = "I N I C I A R  S E S I Ó N  C O M O:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(141, 35);
            label4.Name = "label4";
            label4.Size = new Size(294, 32);
            label4.TabIndex = 57;
            label4.Text = "I N I C I O  D E  S E S I Ó N";
            // 
            // IngresarUsuario
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.cafe;
            ClientSize = new Size(587, 511);
            Controls.Add(buttonSiguiente);
            Controls.Add(textBoxContraU);
            Controls.Add(textBoxCuentaU);
            Controls.Add(buttonAtras);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(750, 55);
            Name = "IngresarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IngresarUsuario";
            TopMost = true;
            Load += IngresarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSiguiente;
        private TextBox textBoxContraU;
        private TextBox textBoxCuentaU;
        private Button buttonAtras;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}