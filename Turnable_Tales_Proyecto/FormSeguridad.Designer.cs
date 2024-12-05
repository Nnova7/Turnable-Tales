namespace Turnable_Tales_Proyecto
{
    partial class FormSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeguridad));
            buttonCancelar = new Button();
            buttonActualizar = new Button();
            labelShowExistencias = new Label();
            labelShowPrecio = new Label();
            labelShowGenero = new Label();
            labelShowTitulo = new Label();
            labelShowArtista = new Label();
            labeltxtExistencias = new Label();
            labeltxtPrecio = new Label();
            labeltxtGenero = new Label();
            labeltxtArtista = new Label();
            labeltxtTitulo = new Label();
            pictureBoxImagen = new PictureBox();
            labelShowId = new Label();
            labeltxtId = new Label();
            labeltxtAviso = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.FlatStyle = FlatStyle.Popup;
            buttonCancelar.ForeColor = SystemColors.ButtonHighlight;
            buttonCancelar.Image = (Image)resources.GetObject("buttonCancelar.Image");
            buttonCancelar.Location = new Point(476, 364);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(258, 55);
            buttonCancelar.TabIndex = 86;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            buttonActualizar.FlatStyle = FlatStyle.Popup;
            buttonActualizar.ForeColor = SystemColors.ButtonHighlight;
            buttonActualizar.Image = (Image)resources.GetObject("buttonActualizar.Image");
            buttonActualizar.Location = new Point(48, 364);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(337, 55);
            buttonActualizar.TabIndex = 85;
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // labelShowExistencias
            // 
            labelShowExistencias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelShowExistencias.ForeColor = Color.White;
            labelShowExistencias.Location = new Point(424, 312);
            labelShowExistencias.Name = "labelShowExistencias";
            labelShowExistencias.Size = new Size(311, 28);
            labelShowExistencias.TabIndex = 84;
            labelShowExistencias.Text = "...\r\n\r\n";
            labelShowExistencias.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelShowPrecio
            // 
            labelShowPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelShowPrecio.ForeColor = Color.White;
            labelShowPrecio.Location = new Point(423, 264);
            labelShowPrecio.Name = "labelShowPrecio";
            labelShowPrecio.Size = new Size(311, 28);
            labelShowPrecio.TabIndex = 83;
            labelShowPrecio.Text = "...\r\n\r\n";
            labelShowPrecio.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelShowGenero
            // 
            labelShowGenero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelShowGenero.ForeColor = Color.White;
            labelShowGenero.Location = new Point(423, 220);
            labelShowGenero.Name = "labelShowGenero";
            labelShowGenero.Size = new Size(311, 28);
            labelShowGenero.TabIndex = 82;
            labelShowGenero.Text = "...\r\n\r\n";
            labelShowGenero.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelShowTitulo
            // 
            labelShowTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelShowTitulo.ForeColor = Color.White;
            labelShowTitulo.Location = new Point(423, 126);
            labelShowTitulo.Name = "labelShowTitulo";
            labelShowTitulo.Size = new Size(311, 28);
            labelShowTitulo.TabIndex = 81;
            labelShowTitulo.Text = "...\r\n\r\n";
            labelShowTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelShowArtista
            // 
            labelShowArtista.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelShowArtista.ForeColor = Color.White;
            labelShowArtista.Location = new Point(423, 176);
            labelShowArtista.Name = "labelShowArtista";
            labelShowArtista.Size = new Size(311, 28);
            labelShowArtista.TabIndex = 80;
            labelShowArtista.Text = "...\r\n\r\n";
            labelShowArtista.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtExistencias
            // 
            labeltxtExistencias.AutoSize = true;
            labeltxtExistencias.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labeltxtExistencias.ForeColor = Color.White;
            labeltxtExistencias.Location = new Point(326, 320);
            labeltxtExistencias.Name = "labeltxtExistencias";
            labeltxtExistencias.Size = new Size(92, 17);
            labeltxtExistencias.TabIndex = 79;
            labeltxtExistencias.Text = "EXISTENCIAS:";
            labeltxtExistencias.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtPrecio
            // 
            labeltxtPrecio.AutoSize = true;
            labeltxtPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labeltxtPrecio.ForeColor = Color.White;
            labeltxtPrecio.Location = new Point(326, 264);
            labeltxtPrecio.Name = "labeltxtPrecio";
            labeltxtPrecio.Size = new Size(86, 28);
            labeltxtPrecio.TabIndex = 78;
            labeltxtPrecio.Text = "PRECIO:";
            labeltxtPrecio.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtGenero
            // 
            labeltxtGenero.AutoSize = true;
            labeltxtGenero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labeltxtGenero.ForeColor = Color.White;
            labeltxtGenero.Location = new Point(322, 220);
            labeltxtGenero.Name = "labeltxtGenero";
            labeltxtGenero.Size = new Size(97, 28);
            labeltxtGenero.TabIndex = 77;
            labeltxtGenero.Text = "GENERO:";
            labeltxtGenero.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtArtista
            // 
            labeltxtArtista.AutoSize = true;
            labeltxtArtista.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labeltxtArtista.ForeColor = Color.White;
            labeltxtArtista.Location = new Point(326, 176);
            labeltxtArtista.Name = "labeltxtArtista";
            labeltxtArtista.Size = new Size(98, 28);
            labeltxtArtista.TabIndex = 76;
            labeltxtArtista.Text = "ARTISTA:";
            labeltxtArtista.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtTitulo
            // 
            labeltxtTitulo.AutoSize = true;
            labeltxtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labeltxtTitulo.ForeColor = Color.White;
            labeltxtTitulo.Location = new Point(326, 126);
            labeltxtTitulo.Name = "labeltxtTitulo";
            labeltxtTitulo.Size = new Size(86, 28);
            labeltxtTitulo.TabIndex = 75;
            labeltxtTitulo.Text = "TITULO:";
            labeltxtTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImagen.Location = new Point(48, 80);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(260, 260);
            pictureBoxImagen.TabIndex = 74;
            pictureBoxImagen.TabStop = false;
            // 
            // labelShowId
            // 
            labelShowId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelShowId.ForeColor = Color.White;
            labelShowId.Location = new Point(423, 80);
            labelShowId.Name = "labelShowId";
            labelShowId.Size = new Size(311, 28);
            labelShowId.TabIndex = 73;
            labelShowId.Text = "...\r\n\r\n";
            labelShowId.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtId
            // 
            labeltxtId.AutoSize = true;
            labeltxtId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labeltxtId.ForeColor = Color.White;
            labeltxtId.Location = new Point(326, 80);
            labeltxtId.Name = "labeltxtId";
            labeltxtId.Size = new Size(38, 28);
            labeltxtId.TabIndex = 72;
            labeltxtId.Text = "ID:";
            labeltxtId.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtAviso
            // 
            labeltxtAviso.BackColor = Color.Transparent;
            labeltxtAviso.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labeltxtAviso.ForeColor = Color.White;
            labeltxtAviso.Location = new Point(74, 18);
            labeltxtAviso.Name = "labeltxtAviso";
            labeltxtAviso.Size = new Size(660, 39);
            labeltxtAviso.TabIndex = 71;
            labeltxtAviso.Text = "¿SEGURO QUE DESEA ELIMINAR EL DISCO?";
            labeltxtAviso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormSeguridad
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonActualizar);
            Controls.Add(labelShowExistencias);
            Controls.Add(labelShowPrecio);
            Controls.Add(labelShowGenero);
            Controls.Add(labelShowTitulo);
            Controls.Add(labelShowArtista);
            Controls.Add(labeltxtExistencias);
            Controls.Add(labeltxtPrecio);
            Controls.Add(labeltxtGenero);
            Controls.Add(labeltxtArtista);
            Controls.Add(labeltxtTitulo);
            Controls.Add(pictureBoxImagen);
            Controls.Add(labelShowId);
            Controls.Add(labeltxtId);
            Controls.Add(labeltxtAviso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSeguridad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seguridad";
            Load += FormSeguridad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonActualizar;
        private Label labelShowExistencias;
        private Label labelShowPrecio;
        private Label labelShowGenero;
        private Label labelShowTitulo;
        private Label labelShowArtista;
        private Label labeltxtExistencias;
        private Label labeltxtPrecio;
        private Label labeltxtGenero;
        private Label labeltxtArtista;
        private Label labeltxtTitulo;
        private PictureBox pictureBoxImagen;
        private Label labelShowId;
        private Label labeltxtId;
        private Label labeltxtAviso;
    }
}