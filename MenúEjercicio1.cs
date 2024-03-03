using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            double numero = ObtenerNumero();

            MostrarMenu();

            string opcion = Console.ReadLine();

            switch (opcion)
            {
          case "1":
                    Console.WriteLine($"El factorial de {numero} es: {CalcularFactorial((int)numero)}");
                    break;
          case "2":
                    Console.WriteLine($"La raíz cuadrada de {numero} es: {CalcularRaizCuadrada(numero)}");
                    break;
          case "3":
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    return;
      default:
          Console.WriteLine("Opción no válida. Por favor, seleccione 1, 2 o 3.");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("*******************************MENÚ*********************************");
        Console.WriteLine("Bienvenido! Por favor, ingrese el número de la operación que desea realizar");
        Console.WriteLine("1. Calcular el factorial del número");
        Console.WriteLine("2. Calcular la raíz cuadrada del número");
        Console.WriteLine("3. Salir del programa");
       
    }

    static double ObtenerNumero()
    {
        while (true)
        {
            Console.Write("Ingrese un número:: ");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }
    }

    static long CalcularFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * CalcularFactorial(n - 1);
        }
    }

    static double CalcularRaizCuadrada(double n)
    {
        return Math.Sqrt(n);
    }
}
