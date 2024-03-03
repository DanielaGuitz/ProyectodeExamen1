using System;

class Program
{
    //-------------------------------------------------------METODOS-------------------------------------------------------
    //LENGTH
    public static void Main(string[] args)
    {
        
        string cadena = "Bienvenido";
        string[] arrayCadena = { "hola", "como", "estas" };
        int[] arrayNumeros = { 1, 2, 4 };

        int longitudCadena = cadena.Length;
        Console.WriteLine($"La longitud de la cadena es: {longitudCadena}");

        int longitudArrayCadena = arrayCadena.Length;
        Console.WriteLine($"La longitud del array de cadenas es: {longitudArrayCadena}");

        int longitudArrayNumeros = arrayNumeros.Length;
        Console.WriteLine($"La longitud del array de números es: {longitudArrayNumeros}");


        //TOUPPER
        string cadenaOriginal = "Hola, mundo!";
        string cadenaEnMayusculas = cadenaOriginal.ToUpper();

        Console.WriteLine($"Cadena original: {cadenaOriginal}");
        Console.WriteLine($"Cadena en mayúsculas: {cadenaEnMayusculas}");
        //TOLOWER
        string mayusculas = "CONVERTIRME A MINÚSCULAS";
        string minusculas = mayusculas.ToLower();
        Console.WriteLine($"Minúsculas: {minusculas}");


        //INDEXOF
        string frase = "La programación es divertida";
        int indice = frase.IndexOf("es");
        Console.WriteLine($"La primera ocurrencia de 'es' comienza en el índice: {indice}");
        //LASTINDEXOF
        string oracion = " Ejemplo dentro de esta cadena de texto";
        int indice1 = oracion.LastIndexOf("cadena");
        Console.WriteLine($"La ultima ocurrencia de 'cadena' finaliza en el indice {indice1}");

        //SUBSTRING
        string original = "Estamos extrayendo una subcadena";
        string subcadena = original.Substring(8, 10); // Comienza en el índice 12 y toma 6 caracteres.
        Console.WriteLine($"Subcadena: {subcadena}");

        //REPLACE
        string texto = "Estudio Ingenieria Industrial";
        string nuevaFrase = texto.Replace("Industrial", "En Sistemas");//Parabra a reemplazar y por cual
        Console.WriteLine($"Frase original: {texto}");
        Console.WriteLine($"Frase modificada: {nuevaFrase}");

        //TRIM
        string cadenaConEspacios = "   Este es un ejemplo con espacios en blanco.   ";
        string cadenaSinEspacios = cadenaConEspacios.Trim();
        Console.WriteLine($"Cadena Sin Espacios: {cadenaSinEspacios}");

        //STARTSWITH
        string prueba = "Mi nombre es Daniela.";
        bool comienzaConCSharp = prueba.StartsWith("Mi");
        Console.WriteLine($"La frase comienza con 'Mi': {comienzaConCSharp}");

        //ENDSWITH
        string nombreArchivo = "documento.txt";
        bool terminaConTxt = nombreArchivo.EndsWith(".txt");
        Console.WriteLine($"El nombre del archivo termina con '.txt': {terminaConTxt}");

        //FORMAT
        string nombre = "Daniela";
        int edad = 18;
        string mensaje = string.Format("Hola, mi nombre es {0} y tengo {1} años.", nombre, edad);
        Console.WriteLine("FORMAT: " + mensaje);

        //REMOVE
        string originalremove = "Aprendiendo que es Remove";
        string resultadoRemove= original.Remove(5, 6); // Elimina desde la posición 5, 6 caracteres. 
        Console.WriteLine("REMOVE:" + resultadoRemove);


        //--------------------------------------------------PROPIEDADES---------------------------------------

        //LENGTH





        //ARRAY
        int[] miArreglo = { 1, 2, 3, 4, 5 };
        int longitudArreglo = miArreglo.Length;
        Console.WriteLine($"Longitud del arreglo: {longitudArreglo}");

        //LIST<T>
        List<string> nombres = new List<string> { "Juan", "Ana", "Carlos" };
        int cantidadNombres = nombres.Count;
        Console.WriteLine($"Cantidad de elementos en la lista: {cantidadNombres}");

        //DATETIME-NOW
        DateTime currentDateTime = DateTime.Now;


        //CONSOLE-foregroundcolor
        Console.ForegroundColor = ConsoleColor.Green;
        //Backgroundcolor
        Console.BackgroundColor = ConsoleColor.Black;

        //Null0rEmpty- Null0rWhiteSpace
        string cadenaVacia = "";
        bool esNullOrEmpty = string.IsNullOrEmpty(cadenaVacia); // Devuelve true

        string cadenaEspacios = "    ";
        bool esNullOrWhiteSpace = string.IsNullOrWhiteSpace(cadenaEspacios); // Devuelve true

        //IsReadOnly
       
        //Chars
        string primercadena = "Hola";
        char[] caracteres = primercadena.ToCharArray(); // Devuelve {'H', 'o', 'l', 'a'}


        //--------------------------------------------OPERACIONES CON CADENAS-------------------------------------
        //COMPARACION DE CADENAS
        string cadena1 = "Hola";
        string cadena2 = "Hola";

        if (cadena1.Equals(cadena2))
        {
            Console.WriteLine("Las cadenas son iguales");
        }
        //CBUSQUEDA DE PATRONES
        string busqueda = "La programación es divertida";
        if (frase.Contains("programación"))
        {
            Console.WriteLine("La palabra 'programación' está en la frase");
        }

        //FORMAT
        string nombre = "Ana";
        int edad = 30;

        // Formateo de cadenas usando string.Format
        string mensaje1 = string.Format("Hola, {0}. Tienes {1} años.", nombre, edad);

        Console.WriteLine(mensaje1)





    }
}



