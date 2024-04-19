using Carrito.Carro;
Carro miCarro = new Carro("Toyota", 2024, "Rojo", "Juan");
int op = 0, op2 = 0;
Console.WriteLine("Bienvenido ¿Cómo se llama?\n");
Console.Write("> ");
miCarro.owner = Console.ReadLine();
Console.WriteLine("\n¿De que color desea su auto?\n");
Console.Write("> ");
miCarro.Color = Console.ReadLine();
Console.Clear();
do
{
    try
    {
        Console.Clear();
        Console.WriteLine($"Bienvenid@ {miCarro.owner} ¿Qué desa hacer hoy en su {miCarro.Marca} modelo {miCarro.Modeolo} de color {miCarro.Color}?\n");
        Console.WriteLine("1) Manejar");
        Console.WriteLine("0) No hacer nada\n");
        Console.Write("> ");
        op = Convert.ToInt32(Console.ReadLine());
        if (op != 0)
        {
           
                switch (op)
                {
                    case 1:
                        do
                        {
                        try
                        {
                            Console.Clear();
                            if (miCarro.Encendido)
                            {
                                Console.Write("Estado del auto:");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(" Encendido");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("Estado del auto:");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" Apagado");
                                Console.ResetColor();
                            }
                            if (miCarro.FrenoMano)
                            {
                                Console.Write("\nEstado del freno de mano:");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(" Arriba");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("\nEstado del freno de mano:");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" Abajo");
                                Console.ResetColor();
                            }
                            if (miCarro.luces)
                            {
                                Console.Write("\nEstado de las luces:");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(" Encendidas");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("\nEstado de las luces:");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" Apagadas");
                                Console.ResetColor();
                            }
                            if (miCarro.velocidad_actual == 0)
                            {
                                Console.Write("\nVelocidad actual:");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($" {miCarro.velocidad_actual} Km/h");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("\nVelocidad actual:");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($" {miCarro.velocidad_actual} Km/h");
                                Console.ResetColor();
                            }
                            if (miCarro.closh == false)
                            {
                                Console.Write("\nClosh:");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($" Suelto");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("\nClosh:");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($" Presionado");
                                Console.ResetColor();
                            }
                            if (miCarro.palanca == 0)
                            {
                                Console.Write("\nVelocidades (Cambios):");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($" {miCarro.palanca}");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("\nVelocidades (Cambios):");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($" {miCarro.palanca}");
                                Console.ResetColor();
                            }
                            Console.WriteLine("\n\n");
                            Console.WriteLine("1) Enceder/Apagar el auto");
                            Console.WriteLine("2) Subir/Bajar freno de mano");
                            Console.WriteLine("3) Encender/Apagar luces");
                            Console.WriteLine("4) Acelerar");
                            Console.WriteLine("5) Frenar");
                            Console.WriteLine("6) Aumentar cambio");
                            Console.WriteLine("7) Disminuir cambio");
                            Console.WriteLine("8) Desacelerar");
                            Console.WriteLine("9) Bocinar");
                            Console.WriteLine("10) Closh");
                            Console.WriteLine("0) Salir del auto\n");
                            Console.Write("> ");
                            op2 = Convert.ToInt32(Console.ReadLine());
                            switch (op2)
                            {
                                case 0:
                                    op2 = miCarro.salir(op2);
                                    break;
                                case 1:
                                    miCarro.Encender();
                                    break;
                                case 2:
                                    miCarro.Subirfreno();
                                    break;
                                case 3:
                                    miCarro.Encenderluces();
                                    break;
                                case 4:
                                    for (int i = 0; i < 3; i++)
                                    {
                                        Console.WriteLine($"\n{miCarro.Acelerar()} Km/h");
                                    }
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    for (int i = 0; i < 3; i++)
                                    {
                                        miCarro.Frenos();
                                        Console.WriteLine($"\n{miCarro.velocidad_actual} Km/h");
                                    }
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    miCarro.cambioArriba();
                                    break;
                                case 7:
                                    miCarro.cambioAbajo();
                                    break;
                                case 8:
                                    for (int i = 0; i < 3; i++)
                                    {
                                        miCarro.desacelr();
                                        Console.WriteLine($"\n{miCarro.velocidad_actual} Km/h");
                                    }
                                    Console.ReadKey();
                                    break;
                                case 9:
                                    miCarro.bocinar();
                                    break;
                                case 10:
                                    miCarro.Chloshar();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("La opción ingresada no es valida\n");
                                    Console.WriteLine("Presione \"ENTER\" para continuar\n");
                                    Console.Write("> ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("El caracter ingresado no es valido\n");
                Console.WriteLine("Presione \"ENTER\" para continuar\n");
                Console.Write("> ");
                Console.ReadKey();
                Console.Clear();
                op2 = 1;
            }
        } while (op2 != 0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("La opción ingresada no es valida\n");
                        Console.WriteLine("Presione \"ENTER\" para continuar\n");
                        Console.Write("> ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
        }
    }catch(Exception)
    {
        Console.Clear();
        Console.WriteLine("El caracter ingresado no es valido\n");
        Console.WriteLine("Presione \"ENTER\" para continuar\n");
        Console.Write("> ");
        Console.ReadKey();
        Console.Clear();
        op = 1;
    }
} while(op != 0);
Console.WriteLine($"\nQue tengas un buen día {miCarro.owner}");