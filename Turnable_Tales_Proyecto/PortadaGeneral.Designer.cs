namespace Turnable_Tales_Proyecto
{
    partial class PortadaGeneral
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            btnCambio = new Button();
            lblFoto = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(292, 421);
            label2.Name = "label2";
            label2.Size = new Size(416, 27);
            label2.TabIndex = 7;
            label2.Text = "Dulce Mariana Andrade Olvera 3-C";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(349, 132);
            label1.Name = "label1";
            label1.Size = new Size(297, 28);
            label1.TabIndex = 6;
            label1.Text = "Cambiar de Imagenes";
            // 
            // btnCambio
            // 
            btnCambio.BackColor = Color.FromArgb(192, 192, 255);
            btnCambio.ForeColor = SystemColors.ButtonHighlight;
            btnCambio.Location = new Point(397, 307);
            btnCambio.Name = "btnCambio";
            btnCambio.Size = new Size(194, 56);
            btnCambio.TabIndex = 5;
            btnCambio.Text = "Enviar Imagen";
            btnCambio.UseVisualStyleBackColor = false;
            // 
            // lblFoto
            // 
            lblFoto.ImageIndex = 0;
            lblFoto.Location = new Point(325, 114);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(321, 258);
            lblFoto.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCambio);
            Controls.Add(lblFoto);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnCambio;
        private Label lblFoto;
    }
}
