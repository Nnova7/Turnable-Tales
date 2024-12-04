namespace Turnable_Tales_Proyecto
{
    partial class IngresarAdministrador
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
            textBoxContraA = new TextBox();
            textBoxCuentaA = new TextBox();
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
            buttonSiguiente.BackgroundImage = Properties.Resources.cafe;
            buttonSiguiente.BackgroundImageLayout = ImageLayout.Center;
            buttonSiguiente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiguiente.ForeColor = SystemColors.ButtonHighlight;
            buttonSiguiente.Location = new Point(203, 521);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(198, 36);
            buttonSiguiente.TabIndex = 74;
            buttonSiguiente.Text = "SIGUIENTE";
            buttonSiguiente.UseVisualStyleBackColor = false;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // textBoxContraA
            // 
            textBoxContraA.BackColor = Color.Silver;
            textBoxContraA.Location = new Point(141, 423);
            textBoxContraA.Name = "textBoxContraA";
            textBoxContraA.PlaceholderText = "Ingresa la contraseña";
            textBoxContraA.Size = new Size(341, 31);
            textBoxContraA.TabIndex = 73;
            textBoxContraA.TextAlign = HorizontalAlignment.Center;
            textBoxContraA.TextChanged += textBoxContraA_TextChanged;
            // 
            // textBoxCuentaA
            // 
            textBoxCuentaA.BackColor = Color.Silver;
            textBoxCuentaA.Location = new Point(141, 294);
            textBoxCuentaA.Name = "textBoxCuentaA";
            textBoxCuentaA.PlaceholderText = "Ingresa tu cuenta";
            textBoxCuentaA.Size = new Size(341, 31);
            textBoxCuentaA.TabIndex = 72;
            textBoxCuentaA.TextAlign = HorizontalAlignment.Center;
            textBoxCuentaA.TextChanged += textBoxCuentaA_TextChanged;
            // 
            // buttonAtras
            // 
            buttonAtras.BackColor = Color.Transparent;
            buttonAtras.FlatStyle = FlatStyle.Popup;
            buttonAtras.Image = Properties.Resources.flechaizq;
            buttonAtras.Location = new Point(10, 280);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(68, 72);
            buttonAtras.TabIndex = 71;
            buttonAtras.UseVisualStyleBackColor = false;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(141, 381);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 70;
            label2.Text = "C O N T R A S E Ñ A:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(141, 253);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 69;
            label1.Text = "C U E N T A:";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.cafe;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(134, 119);
            button1.Name = "button1";
            button1.Size = new Size(364, 78);
            button1.TabIndex = 68;
            button1.Text = "A D M I N I S T R A D O R";
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
            label3.Size = new Size(229, 19);
            label3.TabIndex = 67;
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
            label4.Size = new Size(348, 37);
            label4.TabIndex = 66;
            label4.Text = "I N I C I O  D E  S E S I Ó N";
            // 
            // IngresarAdministrador
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.cafe;
            ClientSize = new Size(585, 633);
            Controls.Add(buttonSiguiente);
            Controls.Add(textBoxContraA);
            Controls.Add(textBoxCuentaA);
            Controls.Add(buttonAtras);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(750, 55);
            Name = "IngresarAdministrador";
            StartPosition = FormStartPosition.Manual;
            Text = "IngresarAdministrador";
            Load += IngresarAdministrador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSiguiente;
        private TextBox textBoxContraA;
        private TextBox textBoxCuentaA;
        private Button buttonAtras;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}