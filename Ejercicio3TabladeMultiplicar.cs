using System;

class Program
{
    //Tabla de Multiplicar
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine($"Tabla de multiplicar del {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
        else
        {
            Console.WriteLine("¡Error! Por favor, ingrese un número entero válido.");
        }
    }
    
    }

