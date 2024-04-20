using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito.Carro
{
    public class Carro
    {
        public bool bocina { get; set; }
        public bool closh {  get; set; }
        public string Marca { get; }
        private int desa {  get; }
        public bool FrenoMano { get; set;  }
        public bool luces {  get; set; }
        public int palanca { get; set; }
        public int Modeolo { get; }
        public string Color { get; set; }
        public string owner { get; set; }
        public bool Encendido { get; set; }
        public int velocidad_actual { get; set; }
        private int MAXVELOCIDAD { get;}
        private int Revolucion { get; }
        private int capafreno { get; }
        public Carro(string m, int model, string col, string dueño)
        {
            capafreno = 10;
            desa = 5;
            Marca = m;
            Modeolo = model;
            Color = col;
            closh = false;
            palanca = 0;
            bocina = false;
            owner = dueño;
            luces = false;
            Revolucion = 5;
            FrenoMano = true;
            Encendido = false;
            velocidad_actual = 0;
            MAXVELOCIDAD = 250;
        }
        public void Encender()
        {
            if (!Encendido)
            {
                Encendido = true;
            }
            else
            {
                {
                    if (palanca == 0 && FrenoMano)
                    {
                        Encendido = false;
                    }
                }
            }
        }
        public void Chloshar()
        {
            if(!closh)
            {
                closh = true;
            }
            else
            {
                closh = false;
            }
        }
        public void Subirfreno()
        {
           if(!FrenoMano && velocidad_actual <= desa)
            {
                FrenoMano = true;
                velocidad_actual = 0;         
            }
            else
            {
                FrenoMano = false;
            }
        }

        public void Encenderluces()
        {
                if (luces)
                {
                    luces = false;
                }
                else
                {
                    luces = true;
                }
        }
        public int Acelerar()
        {
            if (Encendido && velocidad_actual < MAXVELOCIDAD && palanca != 0 && !closh)
            {
                if (FrenoMano && velocidad_actual < MAXVELOCIDAD)
                {
                    velocidad_actual += 2;
                    return velocidad_actual;
                }
                else
                {
                    velocidad_actual += (palanca * Revolucion) ;
                    if (velocidad_actual > MAXVELOCIDAD)
                    {
                        velocidad_actual = MAXVELOCIDAD;
                        return velocidad_actual;
                    }
                    else
                    {
                        return velocidad_actual;
                    }
                }
            }
            else if (velocidad_actual > MAXVELOCIDAD)
            {
                velocidad_actual = MAXVELOCIDAD;
                return velocidad_actual;
            }
            return velocidad_actual;
        }
        public void Frenos()
        {
            if (velocidad_actual > desa)
            {
                velocidad_actual -= capafreno;
            }
        }
        public int salir(int op)
        {
            if(!Encendido && FrenoMano && velocidad_actual == 0 && palanca == 0 && !luces)
            {
                return 0;
            }
            return 9;
        }
        public void desacelr()
        {
            if (velocidad_actual > desa)
            {
                velocidad_actual -= desa;
            }
        }
        public void cambioArriba()
        {
            if (closh && palanca < 5)
            {
                palanca++;
            }
        }
        public void cambioAbajo()
        {
            if (closh && palanca > 0)
            {
                palanca--;
            }
        }
        public void bocinar()
        {
            if(Encendido)
            {
                if(!bocina)
                {
                    Console.Beep();
                    bocina = true;
                }
                else
                {
                    Console.Beep();
                    bocina = false;
                }
            }
        }
    }
}