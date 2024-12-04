namespace Turnable_Tales_Proyecto
{
    partial class MostrarNombre
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarNombre));
            button1 = new Button();
            buttonSalir = new Button();
            pictureBoxUsuario = new PictureBox();
            labelHora = new Label();
            labelFecha = new Label();
            labelUsuario = new Label();
            textBoxUsuario = new TextBox();
            textBoxFecha = new TextBox();
            textBoxHora = new TextBox();
            horafecha = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Equis;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(11, 20);
            button1.Name = "button1";
            button1.Size = new Size(33, 27);
            button1.TabIndex = 72;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.BackgroundImage = (Image)resources.GetObject("buttonSalir.BackgroundImage");
            buttonSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Location = new Point(200, 384);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(167, 41);
            buttonSalir.TabIndex = 71;
            buttonSalir.Text = "CERRAR SESIÓN";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.BackColor = Color.Transparent;
            pictureBoxUsuario.BackgroundImage = Properties.Resources.UsSimple_removebg_preview;
            pictureBoxUsuario.Location = new Point(148, 20);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.Size = new Size(92, 83);
            pictureBoxUsuario.TabIndex = 70;
            pictureBoxUsuario.TabStop = false;
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.BackColor = Color.Transparent;
            labelHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelHora.ForeColor = Color.White;
            labelHora.Location = new Point(26, 301);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(85, 25);
            labelHora.TabIndex = 69;
            labelHora.Text = "H O R A:";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.BackColor = Color.Transparent;
            labelFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFecha.ForeColor = Color.White;
            labelFecha.Location = new Point(26, 207);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(94, 25);
            labelFecha.TabIndex = 68;
            labelFecha.Text = "F E C H A:";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.BackColor = Color.Transparent;
            labelUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.White;
            labelUsuario.Location = new Point(26, 119);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(128, 25);
            labelUsuario.TabIndex = 67;
            labelUsuario.Text = "U S U A R I O:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Enabled = false;
            textBoxUsuario.Location = new Point(160, 119);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(197, 31);
            textBoxUsuario.TabIndex = 73;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            // 
            // textBoxFecha
            // 
            textBoxFecha.Enabled = false;
            textBoxFecha.Location = new Point(160, 207);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.Size = new Size(197, 31);
            textBoxFecha.TabIndex = 74;
            textBoxFecha.TextChanged += textBoxFecha_TextChanged;
            // 
            // textBoxHora
            // 
            textBoxHora.Enabled = false;
            textBoxHora.Location = new Point(160, 301);
            textBoxHora.Name = "textBoxHora";
            textBoxHora.Size = new Size(197, 31);
            textBoxHora.TabIndex = 75;
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick;
            // 
            // MostrarNombre
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.cafex2;
            ClientSize = new Size(378, 444);
            Controls.Add(textBoxHora);
            Controls.Add(textBoxFecha);
            Controls.Add(textBoxUsuario);
            Controls.Add(button1);
            Controls.Add(buttonSalir);
            Controls.Add(pictureBoxUsuario);
            Controls.Add(labelHora);
            Controls.Add(labelFecha);
            Controls.Add(labelUsuario);
            Name = "MostrarNombre";
            Text = "MostrarNombre";
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button buttonSalir;
        private PictureBox pictureBoxUsuario;
        private Label labelHora;
        private Label labelFecha;
        private Label labelUsuario;
        private TextBox textBoxUsuario;
        private TextBox textBoxFecha;
        private TextBox textBoxHora;
        private System.Windows.Forms.Timer horafecha;
    }
}