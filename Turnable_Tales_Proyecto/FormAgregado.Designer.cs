namespace Turnable_Tales_Proyecto
{
    partial class FormAgregado
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
            label2 = new Label();
            buttonRegresa = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 9);
            label2.Name = "label2";
            label2.Size = new Size(283, 240);
            label2.TabIndex = 23;
            label2.Text = " SE REALIZO\r\n LA ACCION\r\nCON EXITO!!\r\n\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonRegresa
            // 
            buttonRegresa.BackgroundImage = Properties.Resources.Captura_de_pantalla_2024_11_22_225105;
            buttonRegresa.FlatStyle = FlatStyle.Popup;
            buttonRegresa.Location = new Point(320, 9);
            buttonRegresa.Name = "buttonRegresa";
            buttonRegresa.Size = new Size(71, 47);
            buttonRegresa.TabIndex = 22;
            buttonRegresa.UseVisualStyleBackColor = true;
            buttonRegresa.Click += buttonRegresa_Click;
            // 
            // FormAgregado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(403, 205);
            Controls.Add(label2);
            Controls.Add(buttonRegresa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAgregado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            Load += FormAgregado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button buttonRegresa;
    }
}