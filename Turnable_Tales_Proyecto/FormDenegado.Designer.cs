namespace Turnable_Tales_Proyecto
{
    partial class FormDenegado
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
            buttonRegresa = new Button();
            labelRestriccion = new Label();
            labelLimite = new Label();
            labeltxtAviso = new Label();
            SuspendLayout();
            // 
            // buttonRegresa
            // 
            buttonRegresa.FlatStyle = FlatStyle.Popup;
            buttonRegresa.ForeColor = SystemColors.ControlLight;
            buttonRegresa.Image = Properties.Resources.Captura_de_pantalla_2024_11_22_225105;
            buttonRegresa.Location = new Point(425, 20);
            buttonRegresa.Name = "buttonRegresa";
            buttonRegresa.Size = new Size(61, 47);
            buttonRegresa.TabIndex = 15;
            buttonRegresa.UseVisualStyleBackColor = true;
            // 
            // labelRestriccion
            // 
            labelRestriccion.BackColor = Color.Transparent;
            labelRestriccion.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRestriccion.ForeColor = Color.White;
            labelRestriccion.Location = new Point(31, 153);
            labelRestriccion.Name = "labelRestriccion";
            labelRestriccion.Size = new Size(414, 36);
            labelRestriccion.TabIndex = 14;
            labelRestriccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLimite
            // 
            labelLimite.BackColor = Color.Transparent;
            labelLimite.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLimite.ForeColor = Color.White;
            labelLimite.Location = new Point(71, 218);
            labelLimite.Name = "labelLimite";
            labelLimite.Size = new Size(323, 36);
            labelLimite.TabIndex = 13;
            labelLimite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labeltxtAviso
            // 
            labeltxtAviso.BackColor = Color.Transparent;
            labeltxtAviso.Font = new Font("Consolas", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            labeltxtAviso.ForeColor = Color.White;
            labeltxtAviso.Location = new Point(71, 30);
            labeltxtAviso.Name = "labeltxtAviso";
            labeltxtAviso.Size = new Size(323, 86);
            labeltxtAviso.TabIndex = 12;
            labeltxtAviso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDenegado
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Maroon;
            ClientSize = new Size(516, 274);
            Controls.Add(buttonRegresa);
            Controls.Add(labelRestriccion);
            Controls.Add(labelLimite);
            Controls.Add(labeltxtAviso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDenegado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDenegado";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRegresa;
        private Label labelRestriccion;
        private Label labelLimite;
        private Label labeltxtAviso;
    }
}