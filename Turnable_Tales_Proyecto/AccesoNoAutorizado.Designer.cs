namespace Turnable_Tales_Proyecto
{
    partial class AccesoNoAutorizado
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
            buttonRegresar = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2024_11_22_2251051;
            buttonRegresar.FlatStyle = FlatStyle.Popup;
            buttonRegresar.Location = new Point(-8, -2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(68, 54);
            buttonRegresar.TabIndex = 0;
            buttonRegresar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(310, 97);
            label6.Name = "label6";
            label6.Size = new Size(294, 32);
            label6.TabIndex = 77;
            label6.Text = "I N I C I O  D E  S E S I Ó N";
            label6.Click += label6_Click;
            // 
            // AccesoNoAutorizado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.rojito;
            ClientSize = new Size(830, 219);
            Controls.Add(label6);
            Controls.Add(buttonRegresar);
            Name = "AccesoNoAutorizado";
            Text = "AccesoNoAutorizado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegresar;
        private Label label6;
    }
}