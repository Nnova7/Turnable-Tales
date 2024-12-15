namespace Turnable_Tales_Proyecto
{
    partial class Usuario
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
            buttonAtras = new Button();
            buttonUsuario = new Button();
            buttonInvitado = new Button();
            buttonAdministrador = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonAtras
            // 
            buttonAtras.BackColor = Color.Transparent;
            buttonAtras.FlatStyle = FlatStyle.Popup;
            buttonAtras.Image = Properties.Resources.flechaizq;
            buttonAtras.Location = new Point(11, 256);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(68, 72);
            buttonAtras.TabIndex = 49;
            buttonAtras.UseVisualStyleBackColor = false;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // buttonUsuario
            // 
            buttonUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUsuario.ForeColor = SystemColors.ButtonHighlight;
            buttonUsuario.Image = Properties.Resources.cafe;
            buttonUsuario.Location = new Point(122, 254);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(364, 78);
            buttonUsuario.TabIndex = 48;
            buttonUsuario.Text = "U S U A R I O";
            buttonUsuario.UseVisualStyleBackColor = true;
            buttonUsuario.Click += buttonUsuario_Click;
            // 
            // buttonInvitado
            // 
            buttonInvitado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInvitado.ForeColor = SystemColors.ButtonHighlight;
            buttonInvitado.Image = Properties.Resources.cafe;
            buttonInvitado.Location = new Point(122, 383);
            buttonInvitado.Name = "buttonInvitado";
            buttonInvitado.Size = new Size(364, 78);
            buttonInvitado.TabIndex = 47;
            buttonInvitado.Text = "I N V I T A D O";
            buttonInvitado.UseVisualStyleBackColor = true;
            buttonInvitado.Click += buttonInvitado_Click;
            // 
            // buttonAdministrador
            // 
            buttonAdministrador.BackColor = Color.Salmon;
            buttonAdministrador.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdministrador.ForeColor = SystemColors.ButtonHighlight;
            buttonAdministrador.Image = Properties.Resources.cafe;
            buttonAdministrador.Location = new Point(122, 129);
            buttonAdministrador.Name = "buttonAdministrador";
            buttonAdministrador.Size = new Size(364, 78);
            buttonAdministrador.TabIndex = 46;
            buttonAdministrador.Text = "A D M I N I S T R A D O R";
            buttonAdministrador.UseVisualStyleBackColor = false;
            buttonAdministrador.Click += buttonAdministrador_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(208, 78);
            label3.Name = "label3";
            label3.Size = new Size(186, 15);
            label3.TabIndex = 45;
            label3.Text = "I N I C I A R  S E S I Ó N  C O M O:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(158, 41);
            label4.Name = "label4";
            label4.Size = new Size(294, 32);
            label4.TabIndex = 44;
            label4.Text = "I N I C I O  D E  S E S I Ó N";
            // 
            // Usuario
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.cafe;
            ClientSize = new Size(587, 511);
            Controls.Add(buttonAtras);
            Controls.Add(buttonUsuario);
            Controls.Add(buttonInvitado);
            Controls.Add(buttonAdministrador);
            Controls.Add(label3);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(750, 55);
            Name = "Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            TopMost = true;
            Load += Usuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAtras;
        private Button buttonUsuario;
        private Button buttonInvitado;
        private Button buttonAdministrador;
        private Label label3;
        private Label label4;
    }
}