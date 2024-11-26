namespace Baseball
{
    partial class Jugador
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
            groupBoxPosicion = new GroupBox();
            radioButtonBateador = new RadioButton();
            radioButtonPosicion = new RadioButton();
            radioButtonPitcher = new RadioButton();
            buttonCaptura = new Button();
            buttonMostrar = new Button();
            buttonSalir = new Button();
            groupBoxDatos = new GroupBox();
            numHits = new NumericUpDown();
            txtErrores = new TextBox();
            txtPonches = new TextBox();
            txtNombre = new TextBox();
            txtNumUniforme = new TextBox();
            labelErrores = new Label();
            labelHits = new Label();
            labelPonches = new Label();
            labelNombre = new Label();
            labelNumUniforme = new Label();
            txtMuestra = new TextBox();
            groupBoxPosicion.SuspendLayout();
            groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHits).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPosicion
            // 
            groupBoxPosicion.BackColor = Color.SkyBlue;
            groupBoxPosicion.Controls.Add(radioButtonBateador);
            groupBoxPosicion.Controls.Add(radioButtonPosicion);
            groupBoxPosicion.Controls.Add(radioButtonPitcher);
            groupBoxPosicion.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxPosicion.Location = new Point(31, 24);
            groupBoxPosicion.Name = "groupBoxPosicion";
            groupBoxPosicion.Size = new Size(246, 246);
            groupBoxPosicion.TabIndex = 0;
            groupBoxPosicion.TabStop = false;
            groupBoxPosicion.Text = "Posicion del jugador";
            // 
            // radioButtonBateador
            // 
            radioButtonBateador.AutoSize = true;
            radioButtonBateador.Location = new Point(38, 198);
            radioButtonBateador.Name = "radioButtonBateador";
            radioButtonBateador.Size = new Size(99, 24);
            radioButtonBateador.TabIndex = 2;
            radioButtonBateador.TabStop = true;
            radioButtonBateador.Text = "Bateador";
            radioButtonBateador.UseVisualStyleBackColor = true;
            // 
            // radioButtonPosicion
            // 
            radioButtonPosicion.AutoSize = true;
            radioButtonPosicion.Location = new Point(38, 119);
            radioButtonPosicion.Name = "radioButtonPosicion";
            radioButtonPosicion.Size = new Size(183, 24);
            radioButtonPosicion.TabIndex = 1;
            radioButtonPosicion.TabStop = true;
            radioButtonPosicion.Text = "Jugador de posicion";
            radioButtonPosicion.UseVisualStyleBackColor = true;
            // 
            // radioButtonPitcher
            // 
            radioButtonPitcher.AutoSize = true;
            radioButtonPitcher.Location = new Point(38, 44);
            radioButtonPitcher.Name = "radioButtonPitcher";
            radioButtonPitcher.Size = new Size(82, 24);
            radioButtonPitcher.TabIndex = 0;
            radioButtonPitcher.TabStop = true;
            radioButtonPitcher.Text = "Pitcher";
            radioButtonPitcher.UseVisualStyleBackColor = true;
            // 
            // buttonCaptura
            // 
            buttonCaptura.Location = new Point(31, 654);
            buttonCaptura.Name = "buttonCaptura";
            buttonCaptura.Size = new Size(94, 29);
            buttonCaptura.TabIndex = 1;
            buttonCaptura.Text = "Captura";
            buttonCaptura.UseVisualStyleBackColor = true;
            buttonCaptura.Click += buttonCaptura_Click;
            // 
            // buttonMostrar
            // 
            buttonMostrar.Location = new Point(369, 654);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(94, 29);
            buttonMostrar.TabIndex = 2;
            buttonMostrar.Text = "Mostrar";
            buttonMostrar.UseVisualStyleBackColor = true;
            buttonMostrar.Click += buttonMostrar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(718, 654);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(94, 29);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.BackColor = Color.SkyBlue;
            groupBoxDatos.Controls.Add(numHits);
            groupBoxDatos.Controls.Add(txtErrores);
            groupBoxDatos.Controls.Add(txtPonches);
            groupBoxDatos.Controls.Add(txtNombre);
            groupBoxDatos.Controls.Add(txtNumUniforme);
            groupBoxDatos.Controls.Add(labelErrores);
            groupBoxDatos.Controls.Add(labelHits);
            groupBoxDatos.Controls.Add(labelPonches);
            groupBoxDatos.Controls.Add(labelNombre);
            groupBoxDatos.Controls.Add(labelNumUniforme);
            groupBoxDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDatos.Location = new Point(369, 24);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Size = new Size(387, 273);
            groupBoxDatos.TabIndex = 4;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Datos del jugador";
            // 
            // numHits
            // 
            numHits.Location = new Point(201, 172);
            numHits.Name = "numHits";
            numHits.Size = new Size(150, 27);
            numHits.TabIndex = 9;
            // 
            // txtErrores
            // 
            txtErrores.Location = new Point(201, 219);
            txtErrores.Name = "txtErrores";
            txtErrores.Size = new Size(125, 27);
            txtErrores.TabIndex = 8;
            // 
            // txtPonches
            // 
            txtPonches.Location = new Point(201, 123);
            txtPonches.Name = "txtPonches";
            txtPonches.Size = new Size(125, 27);
            txtPonches.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(201, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtNumUniforme
            // 
            txtNumUniforme.Location = new Point(201, 37);
            txtNumUniforme.Name = "txtNumUniforme";
            txtNumUniforme.Size = new Size(125, 27);
            txtNumUniforme.TabIndex = 5;
            // 
            // labelErrores
            // 
            labelErrores.AutoSize = true;
            labelErrores.Location = new Point(79, 226);
            labelErrores.Name = "labelErrores";
            labelErrores.Size = new Size(59, 20);
            labelErrores.TabIndex = 4;
            labelErrores.Text = "Errores";
            labelErrores.Click += label5_Click;
            // 
            // labelHits
            // 
            labelHits.AutoSize = true;
            labelHits.Location = new Point(101, 172);
            labelHits.Name = "labelHits";
            labelHits.Size = new Size(37, 20);
            labelHits.TabIndex = 3;
            labelHits.Text = "Hits";
            // 
            // labelPonches
            // 
            labelPonches.AutoSize = true;
            labelPonches.Location = new Point(71, 123);
            labelPonches.Name = "labelPonches";
            labelPonches.Size = new Size(67, 20);
            labelPonches.TabIndex = 2;
            labelPonches.Text = "Ponches";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(71, 78);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(67, 20);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre";
            // 
            // labelNumUniforme
            // 
            labelNumUniforme.AutoSize = true;
            labelNumUniforme.Location = new Point(49, 37);
            labelNumUniforme.Name = "labelNumUniforme";
            labelNumUniforme.Size = new Size(89, 20);
            labelNumUniforme.TabIndex = 0;
            labelNumUniforme.Text = "# Uniforme";
            // 
            // txtMuestra
            // 
            txtMuestra.BackColor = Color.PeachPuff;
            txtMuestra.Location = new Point(31, 340);
            txtMuestra.Multiline = true;
            txtMuestra.Name = "txtMuestra";
            txtMuestra.Size = new Size(725, 279);
            txtMuestra.TabIndex = 5;
            // 
            // Jugador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 705);
            Controls.Add(txtMuestra);
            Controls.Add(groupBoxDatos);
            Controls.Add(buttonSalir);
            Controls.Add(buttonMostrar);
            Controls.Add(buttonCaptura);
            Controls.Add(groupBoxPosicion);
            Name = "Jugador";
            Text = "Form1";
            groupBoxPosicion.ResumeLayout(false);
            groupBoxPosicion.PerformLayout();
            groupBoxDatos.ResumeLayout(false);
            groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxPosicion;
        private RadioButton radioButtonBateador;
        private RadioButton radioButtonPosicion;
        private RadioButton radioButtonPitcher;
        private Button buttonCaptura;
        private Button buttonMostrar;
        private Button buttonSalir;
        private GroupBox groupBoxDatos;
        private Label labelNombre;
        private Label labelNumUniforme;
        private NumericUpDown numHits;
        private TextBox txtErrores;
        private TextBox txtPonches;
        private TextBox txtNombre;
        private TextBox txtNumUniforme;
        private Label labelErrores;
        private Label labelHits;
        private Label labelPonches;
        private TextBox txtMuestra;
    }
}
