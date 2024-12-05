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
            labelError = new Label();
            buttonRegresa = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelError
            // 
            labelError.BackColor = Color.Transparent;
            labelError.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelError.ForeColor = Color.White;
            labelError.Location = new Point(12, 148);
            labelError.Name = "labelError";
            labelError.Size = new Size(397, 77);
            labelError.TabIndex = 27;
            labelError.Text = "ERROR\r\n\r\n";
            labelError.TextAlign = ContentAlignment.MiddleCenter;
            labelError.Click += labelError_Click;
            // 
            // buttonRegresa
            // 
            buttonRegresa.BackgroundImage = Properties.Resources.Captura_de_pantalla_2024_11_22_225105;
            buttonRegresa.FlatStyle = FlatStyle.Popup;
            buttonRegresa.Location = new Point(348, 12);
            buttonRegresa.Name = "buttonRegresa";
            buttonRegresa.Size = new Size(80, 52);
            buttonRegresa.TabIndex = 26;
            buttonRegresa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 67);
            label2.Name = "label2";
            label2.Size = new Size(287, 93);
            label2.TabIndex = 25;
            label2.Text = " NO SE LOGRO REALIZAR \r\n  LA ACCION\r\n\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormDenegado
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Maroon;
            ClientSize = new Size(440, 273);
            Controls.Add(labelError);
            Controls.Add(buttonRegresa);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDenegado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDenegado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelError;
        private Button buttonRegresa;
        private Label label2;
    }
}