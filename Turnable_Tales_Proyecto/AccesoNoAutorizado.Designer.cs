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
            label3 = new Label();
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
            label6.Font = new Font("Segoe UI Variable Display", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(42, 68);
            label6.Name = "label6";
            label6.Size = new Size(764, 58);
            label6.TabIndex = 77;
            label6.Text = "A C C E S O   N O   A U T O R I Z A D O";
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(197, 126);
            label3.Name = "label3";
            label3.Size = new Size(280, 23);
            label3.TabIndex = 78;
            label3.Text = "I N I C I A R  S E S I Ó N  C O M O:";
            label3.Click += label3_Click;
            // 
            // AccesoNoAutorizado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.rojito;
            ClientSize = new Size(830, 219);
            Controls.Add(label3);
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
        private Label label3;
    }
}