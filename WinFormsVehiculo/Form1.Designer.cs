namespace WinFormsVehiculo
{
    partial class Form1
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
            buttonEncendido = new Button();
            labelEncender = new Label();
            buttonAcelerar = new Button();
            labelAcelerar = new Label();
            buttonClosh = new Button();
            labelClush = new Label();
            buttonSubirPalanca = new Button();
            labelCambio = new Label();
            buttonFrenoMano = new Button();
            labelFrenoMano = new Label();
            buttonBajarCambio = new Button();
            buttonDesacelerar = new Button();
            buttonFrenar = new Button();
            buttonLuces = new Button();
            labelLuces = new Label();
            buttonBocina = new Button();
            SuspendLayout();
            // 
            // buttonEncendido
            // 
            buttonEncendido.Location = new Point(34, 23);
            buttonEncendido.Name = "buttonEncendido";
            buttonEncendido.Size = new Size(126, 29);
            buttonEncendido.TabIndex = 0;
            buttonEncendido.Text = "Encender";
            buttonEncendido.UseVisualStyleBackColor = true;
            buttonEncendido.Click += buttonEncendido_Click;
            // 
            // labelEncender
            // 
            labelEncender.AutoSize = true;
            labelEncender.Font = new Font("Segoe UI", 12F);
            labelEncender.Location = new Point(530, 24);
            labelEncender.Name = "labelEncender";
            labelEncender.Size = new Size(145, 28);
            labelEncender.TabIndex = 1;
            labelEncender.Text = "Auto: Apagado";
            // 
            // buttonAcelerar
            // 
            buttonAcelerar.Location = new Point(34, 119);
            buttonAcelerar.Name = "buttonAcelerar";
            buttonAcelerar.Size = new Size(126, 29);
            buttonAcelerar.TabIndex = 2;
            buttonAcelerar.Text = "Acelerar";
            buttonAcelerar.UseVisualStyleBackColor = true;
            buttonAcelerar.Click += buttonAcelerar_Click;
            // 
            // labelAcelerar
            // 
            labelAcelerar.AutoSize = true;
            labelAcelerar.Font = new Font("Segoe UI", 12F);
            labelAcelerar.Location = new Point(530, 120);
            labelAcelerar.Name = "labelAcelerar";
            labelAcelerar.Size = new Size(228, 28);
            labelAcelerar.TabIndex = 3;
            labelAcelerar.Text = "Velocidad actual: 0 Km/h";
            // 
            // buttonClosh
            // 
            buttonClosh.Location = new Point(34, 168);
            buttonClosh.Name = "buttonClosh";
            buttonClosh.Size = new Size(126, 29);
            buttonClosh.TabIndex = 4;
            buttonClosh.Text = "Closh";
            buttonClosh.UseVisualStyleBackColor = true;
            buttonClosh.Click += buttonClosh_Click;
            // 
            // labelClush
            // 
            labelClush.AutoSize = true;
            labelClush.Font = new Font("Segoe UI", 12F);
            labelClush.Location = new Point(530, 169);
            labelClush.Name = "labelClush";
            labelClush.Size = new Size(150, 28);
            labelClush.TabIndex = 5;
            labelClush.Text = "Closh: Apagado";
            // 
            // buttonSubirPalanca
            // 
            buttonSubirPalanca.Location = new Point(34, 213);
            buttonSubirPalanca.Name = "buttonSubirPalanca";
            buttonSubirPalanca.Size = new Size(126, 29);
            buttonSubirPalanca.TabIndex = 6;
            buttonSubirPalanca.Text = "Subir Cambio";
            buttonSubirPalanca.UseVisualStyleBackColor = true;
            buttonSubirPalanca.Click += buttonSubirPalanca_Click;
            // 
            // labelCambio
            // 
            labelCambio.AutoSize = true;
            labelCambio.Font = new Font("Segoe UI", 12F);
            labelCambio.Location = new Point(530, 214);
            labelCambio.Name = "labelCambio";
            labelCambio.Size = new Size(100, 28);
            labelCambio.TabIndex = 7;
            labelCambio.Text = "Cambio: 0";
            // 
            // buttonFrenoMano
            // 
            buttonFrenoMano.Location = new Point(34, 71);
            buttonFrenoMano.Name = "buttonFrenoMano";
            buttonFrenoMano.Size = new Size(126, 29);
            buttonFrenoMano.TabIndex = 8;
            buttonFrenoMano.Text = "Freno de Mano";
            buttonFrenoMano.UseVisualStyleBackColor = true;
            buttonFrenoMano.Click += button1_Click;
            // 
            // labelFrenoMano
            // 
            labelFrenoMano.AutoSize = true;
            labelFrenoMano.Font = new Font("Segoe UI", 12F);
            labelFrenoMano.Location = new Point(530, 72);
            labelFrenoMano.Name = "labelFrenoMano";
            labelFrenoMano.Size = new Size(245, 28);
            labelFrenoMano.TabIndex = 9;
            labelFrenoMano.Text = "Freno de mano: Encendido";
            // 
            // buttonBajarCambio
            // 
            buttonBajarCambio.Location = new Point(34, 263);
            buttonBajarCambio.Name = "buttonBajarCambio";
            buttonBajarCambio.Size = new Size(126, 29);
            buttonBajarCambio.TabIndex = 10;
            buttonBajarCambio.Text = "Bajar Cambio";
            buttonBajarCambio.UseVisualStyleBackColor = true;
            buttonBajarCambio.Click += button2_Click;
            // 
            // buttonDesacelerar
            // 
            buttonDesacelerar.Location = new Point(34, 369);
            buttonDesacelerar.Name = "buttonDesacelerar";
            buttonDesacelerar.Size = new Size(126, 29);
            buttonDesacelerar.TabIndex = 11;
            buttonDesacelerar.Text = "Desacelerar";
            buttonDesacelerar.UseVisualStyleBackColor = true;
            buttonDesacelerar.Click += buttonDesacelerar_Click;
            // 
            // buttonFrenar
            // 
            buttonFrenar.Location = new Point(34, 319);
            buttonFrenar.Name = "buttonFrenar";
            buttonFrenar.Size = new Size(126, 29);
            buttonFrenar.TabIndex = 12;
            buttonFrenar.Text = "Frenar";
            buttonFrenar.UseVisualStyleBackColor = true;
            buttonFrenar.Click += buttonFrenar_Click;
            // 
            // buttonLuces
            // 
            buttonLuces.Location = new Point(34, 415);
            buttonLuces.Name = "buttonLuces";
            buttonLuces.Size = new Size(126, 29);
            buttonLuces.TabIndex = 13;
            buttonLuces.Text = "Luces";
            buttonLuces.UseVisualStyleBackColor = true;
            buttonLuces.Click += button1_Click_1;
            // 
            // labelLuces
            // 
            labelLuces.AutoSize = true;
            labelLuces.Font = new Font("Segoe UI", 12F);
            labelLuces.Location = new Point(530, 415);
            labelLuces.Name = "labelLuces";
            labelLuces.Size = new Size(155, 28);
            labelLuces.TabIndex = 14;
            labelLuces.Text = "Luces: Apagadas";
            // 
            // buttonBocina
            // 
            buttonBocina.Location = new Point(34, 463);
            buttonBocina.Name = "buttonBocina";
            buttonBocina.Size = new Size(126, 29);
            buttonBocina.TabIndex = 15;
            buttonBocina.Text = "Bocina";
            buttonBocina.UseVisualStyleBackColor = true;
            buttonBocina.Click += buttonBocina_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 599);
            Controls.Add(buttonBocina);
            Controls.Add(labelLuces);
            Controls.Add(buttonLuces);
            Controls.Add(buttonFrenar);
            Controls.Add(buttonDesacelerar);
            Controls.Add(buttonBajarCambio);
            Controls.Add(labelFrenoMano);
            Controls.Add(buttonFrenoMano);
            Controls.Add(labelCambio);
            Controls.Add(buttonSubirPalanca);
            Controls.Add(labelClush);
            Controls.Add(buttonClosh);
            Controls.Add(labelAcelerar);
            Controls.Add(buttonAcelerar);
            Controls.Add(labelEncender);
            Controls.Add(buttonEncendido);
            Name = "Form1";
            Text = "Vas a 0 Km/h";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEncendido;
        private Label labelEncender;
        private Button buttonAcelerar;
        private Label labelAcelerar;
        private Button buttonClosh;
        private Label labelClush;
        private Button buttonSubirPalanca;
        private Label labelCambio;
        private Button buttonFrenoMano;
        private Label labelFrenoMano;
        private Button buttonBajarCambio;
        private Button buttonDesacelerar;
        private Button buttonFrenar;
        private Button buttonLuces;
        private Label labelLuces;
        private Button buttonBocina;
    }
}
