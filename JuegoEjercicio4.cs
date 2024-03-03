using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100
        int intentos = 0;
        int intentoUsuario;

        Console.WriteLine("******************************* ADIVINA EL NÚMERO SECRETO!*******************************************");

        do
        {
            Console.Write("\n¿Cuál crees que sea el número secreto?: ");
            if (int.TryParse(Console.ReadLine(), out intentoUsuario))
            {
                intentos++;

                if (intentoUsuario == numeroSecreto)
                {
                    Console.WriteLine($"\n¡WOW! Adivinaste el número secreto es: {numeroSecreto} en {intentos} intentos.");
                    break;
                }
                else if (intentoUsuario < numeroSecreto)
                {
                    Console.WriteLine("El número secreto es mayor. Sigue intentándolo.");
                }
                else
                {
                    Console.WriteLine("\n\tEl número secreto es menor.Intenta de nuevo!.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número entero válido.");
            }
        } while (true);
    }
}