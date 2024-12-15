namespace Turnable_Tales_Proyecto
{
    partial class IngresarInvitado
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
            label4 = new Label();
            label5 = new Label();
            buttonSiguiente = new Button();
            textBoxCuentaI = new TextBox();
            buttonAtras = new Button();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBoxContraA = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(97, 175);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(160, 180);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 75;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.BackColor = Color.Transparent;
            buttonSiguiente.BackgroundImage = Properties.Resources.cafe;
            buttonSiguiente.BackgroundImageLayout = ImageLayout.Center;
            buttonSiguiente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiguiente.ForeColor = SystemColors.ButtonHighlight;
            buttonSiguiente.Location = new Point(189, 437);
            buttonSiguiente.Margin = new Padding(3, 2, 3, 2);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(198, 36);
            buttonSiguiente.TabIndex = 84;
            buttonSiguiente.Text = "SIGUIENTE";
            buttonSiguiente.UseVisualStyleBackColor = false;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // textBoxCuentaI
            // 
            textBoxCuentaI.BackColor = Color.Silver;
            textBoxCuentaI.Location = new Point(111, 244);
            textBoxCuentaI.Margin = new Padding(3, 2, 3, 2);
            textBoxCuentaI.Name = "textBoxCuentaI";
            textBoxCuentaI.PlaceholderText = "Ingresa tu cuenta";
            textBoxCuentaI.Size = new Size(341, 27);
            textBoxCuentaI.TabIndex = 82;
            textBoxCuentaI.TextAlign = HorizontalAlignment.Center;
            textBoxCuentaI.TextChanged += textBoxCuentaI_TextChanged;
            // 
            // buttonAtras
            // 
            buttonAtras.BackColor = Color.Transparent;
            buttonAtras.FlatStyle = FlatStyle.Popup;
            buttonAtras.Image = Properties.Resources.flechaizq;
            buttonAtras.Location = new Point(10, 280);
            buttonAtras.Margin = new Padding(3, 2, 3, 2);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(68, 72);
            buttonAtras.TabIndex = 81;
            buttonAtras.UseVisualStyleBackColor = false;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(111, 321);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 80;
            label2.Text = "C O N T R A S E Ñ A:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(111, 203);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 79;
            label1.Text = "C U E N T A:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.cafe;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(134, 119);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(318, 58);
            button1.TabIndex = 78;
            button1.Text = "I N V I T A D O";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxContraA
            // 
            textBoxContraA.BackColor = Color.Silver;
            textBoxContraA.Location = new Point(111, 363);
            textBoxContraA.Margin = new Padding(3, 2, 3, 2);
            textBoxContraA.Name = "textBoxContraA";
            textBoxContraA.PasswordChar = '*';
            textBoxContraA.PlaceholderText = "Ingresa la contraseña";
            textBoxContraA.Size = new Size(341, 27);
            textBoxContraA.TabIndex = 86;
            textBoxContraA.TextAlign = HorizontalAlignment.Center;
            textBoxContraA.TextChanged += textBoxContraA_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(189, 74);
            label7.Name = "label7";
            label7.Size = new Size(186, 15);
            label7.TabIndex = 88;
            label7.Text = "I N I C I A R  S E S I Ó N  C O M O:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(141, 42);
            label8.Name = "label8";
            label8.Size = new Size(294, 32);
            label8.TabIndex = 87;
            label8.Text = "I N I C I O  D E  S E S I Ó N";
            // 
            // IngresarInvitado
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.cafe;
            ClientSize = new Size(587, 511);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBoxContraA);
            Controls.Add(buttonSiguiente);
            Controls.Add(textBoxCuentaI);
            Controls.Add(buttonAtras);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(750, 55);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IngresarInvitado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IngresarInvitado";
            TopMost = true;
            Load += IngresarInvitado_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label5;
        private Button buttonSiguiente;
        private TextBox textBoxCuentaI;
        private Button buttonAtras;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBoxContraA;
        private Label label7;
        private Label label8;
    }
}