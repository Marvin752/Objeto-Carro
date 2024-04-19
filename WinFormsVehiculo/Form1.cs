using Carrito.Carro;
namespace WinFormsVehiculo
{
    public partial class Form1 : Form
    {
        Carro carrito;
        public Form1()
        {
            InitializeComponent();
            carrito = new Carro("Toyota", 2024, "Rojo", "Juan");
        }

        private void buttonEncendido_Click(object sender, EventArgs e)
        {
            carrito.Encender();
           if(carrito.Encendido)
            {
                labelEncender.Text = $"Auto: Encendido";
                labelAcelerar.Text = $"Velocidad actual: {carrito.velocidad_actual} Km/h";
            }
           else
            {
                labelEncender.Text = $"Auto: Apagado";
                labelAcelerar.Text = $"Velocidad actual: {carrito.velocidad_actual} Km/h";
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
            if(carrito.closh)
            {
                labelClush.Text = $"Closh: Encendido";
            }
            else
            {
                labelClush.Text = $"Closh: Apagador";
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
            if(carrito.FrenoMano)
            {
                labelFrenoMano.Text = $"Freno de mano: Encendido";
            }
            else
            {
                labelFrenoMano.Text = $"Freno de mano: Apagado";
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
            if(carrito.luces)
            {
                labelLuces.Text = $"Luces: Encendidas";
            }
            else
            {
                labelLuces.Text = $"Luces: Apagadas";
            }
        }

        private void buttonBocina_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }
    }
}
