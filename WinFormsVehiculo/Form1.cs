using Carrito.Carro;
using System.Windows.Forms;
namespace WinFormsVehiculo
{
    public partial class Form1 : Form
    {
        Carro carrito;
        public Form1()
        {
            InitializeComponent();
            carrito = new Carro("Toyota", 2024, "Rojo", "Juan");
            buttonAcelerar.Enabled = false;
            buttonDesacelerar.Enabled = false;
            buttonSubirPalanca.Enabled = false;
            buttonBajarCambio.Enabled = false;
            this.BackColor = Color.Black;
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = Color.White;
                }
                if (control is Button)
                {
                    Button boton = (Button) control;
                    if(boton.Enabled)
                    {
                        boton.BackColor = Color.Green;
                        boton.ForeColor = Color.Cyan;
                    }
                    else
                    {
                        boton.BackColor = Color.Red;
                    }
                }
            }
        }

        private void buttonEncendido_Click(object sender, EventArgs e)
        {
            carrito.Encender();
            if (carrito.Encendido)
            {
                labelEncender.Text = $"Auto: Encendido";
                labelAcelerar.Text = $"Velocidad actual: {carrito.velocidad_actual} Km/h";
                buttonAcelerar.Enabled = true;
                buttonDesacelerar.Enabled = true;
                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        Button boton = (Button)control;
                        if (boton.Enabled)
                        {
                            boton.BackColor = Color.Green;
                            boton.ForeColor = Color.Cyan;
                        }
                        else
                        {
                            boton.BackColor = Color.Red;
                        }
                    }
                }
            }
            else
            {
                labelEncender.Text = $"Auto: Apagado";
                labelAcelerar.Text = $"Velocidad actual: {carrito.velocidad_actual} Km/h";
                buttonAcelerar.Enabled = false;
                buttonDesacelerar.Enabled = false;
                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        Button boton = (Button)control;
                        if (boton.Enabled)
                        {
                            boton.BackColor = Color.Green;
                            boton.ForeColor = Color.Cyan;
                        }
                        else
                        {
                            boton.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            carrito.Acelerar();
            labelAcelerar.Text = $"Velocidad actual: {carrito.velocidad_actual} Km/h";
        }

        private void buttonClosh_Click(object sender, EventArgs e)
        {
            carrito.Chloshar();
            if (carrito.closh)
            {
                labelClush.Text = $"Closh: Encendido";
                buttonSubirPalanca.Enabled = true;
                buttonBajarCambio.Enabled = true;
                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        Button boton = (Button)control;
                        if (boton.Enabled)
                        {
                            boton.BackColor = Color.Green;
                            boton.ForeColor = Color.Cyan;
                        }
                        else
                        {
                            boton.BackColor = Color.Red;
                        }
                    }
                }
            }
            else
            {
                labelClush.Text = $"Closh: Apagador";
                buttonSubirPalanca.Enabled = false;
                buttonBajarCambio.Enabled = false;
                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        Button boton = (Button)control;
                        if (boton.Enabled)
                        {
                            boton.BackColor = Color.Green;
                            boton.ForeColor = Color.Cyan;
                        }
                        else
                        {
                            boton.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void buttonSubirPalanca_Click(object sender, EventArgs e)
        {
            carrito.cambioArriba();
            labelCambio.Text = $"Cambio: {carrito.palanca}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carrito.Subirfreno();
            if (carrito.FrenoMano)
            {
                labelFrenoMano.Text = $"Freno de mano: Encendido";
                labelAcelerar.Text = $"Velocidad actual: {carrito.velocidad_actual} Km/h";
            }
            else
            {
                labelFrenoMano.Text = $"Freno de mano: Apagado";
                labelAcelerar.Text = $"Velocidad actual: {carrito.velocidad_actual} Km/h";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            carrito.cambioAbajo();
            labelCambio.Text = $"Cambio: {carrito.palanca}";
        }

        private void buttonDesacelerar_Click(object sender, EventArgs e)
        {
            carrito.desacelr();
            labelAcelerar.Text = $"Velocidad actual: {carrito.velocidad_actual} Km/h";
        }

        private void buttonFrenar_Click(object sender, EventArgs e)
        {
            carrito.Frenos();
            labelAcelerar.Text = $"Velocidad actual: {carrito.velocidad_actual} Km/h";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            carrito.Encenderluces();
            if (carrito.luces)
            {
                labelLuces.Text = $"Luces: Encendidas";
                this.BackColor = Color.White;
                foreach (Control control in Controls)
                {
                    if (control is Label)
                    {
                        control.ForeColor = Color.Black;
                    }
                }
            }
            else
            {
                labelLuces.Text = $"Luces: Apagadas";
                this.BackColor = Color.Black;
                foreach (Control control in Controls)
                {
                    if (control is Label)
                    {
                        control.ForeColor = Color.White;
                    }
                }
            }
        }

        private void buttonBocina_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }

        private void labelEncender_Click(object sender, EventArgs e)
        {

        }
    }
}