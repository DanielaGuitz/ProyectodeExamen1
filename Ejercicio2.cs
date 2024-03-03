//Dos numeros y un operador matemático
using System;

class Program
{
    static void Main()
    {
        int numero1 = ObtenerEntero("Ingrese el primer número entero: ");
        int numero2 = ObtenerEntero("Ingrese el segundo número entero: ");
        char operador = ObtenerOperador();

        double resultado = RealizarOperacion(numero1, numero2, operador);

        Console.WriteLine($"El resultado de la operación es: {resultado}");
    }

    static int ObtenerEntero(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número entero válido.");
            }
        }
    }

    static char ObtenerOperador()
    {
        while (true)
        {
            Console.Write("Ingrese un operador matemático (+, -, *, /): ");
            char operador = Console.ReadKey().KeyChar;

            if (EsOperadorValido(operador))
            {
                Console.WriteLine(); // Salto de línea para mejorar la presentación
                return operador;
            }
            else
            {
                Console.WriteLine("\nOperador no válido. Por favor, ingrese un operador válido.");
            }
        }
    }

    static bool EsOperadorValido(char operador)
    {
        return operador == '+' || operador == '-' || operador == '*' || operador == '/';
    }

    static double RealizarOperacion(int numero1, int numero2, char operador)
    {
        switch (operador)
        {
            case '+':
                return numero1 + numero2;
            case '-':
                return numero1 - numero2;
            case '*':
                return numero1 * numero2;
            case '/':
                if (numero2 != 0)
                {
                    return (double)numero1 / numero2;
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero. Por favor, ingrese un divisor diferente de cero.");
                    Environment.Exit(0);
                    return 0; // Esta línea nunca se ejecutará, pero se coloca para evitar un error de compilación
                }
            default:
                Console.WriteLine("Operador no válido.");
                Environment.Exit(0);
                return 0; // Esta línea nunca se ejecutará, pero se coloca para evitar un error de compilación
        }


    }
}

   

    
 

