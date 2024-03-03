//DECLARACIÓN DE VARIABLE STRING 
using System.Net.Sockets;
using System.Text;

string ejemplo = "Hola, soy una cadena";

//INMUTABILIDAD DE LAS CADENAS DE TEXTO
string cadena1 = "Hola";
string cadena2 = cadena1 + ", mundo!";

//LONGITUD DE LAS CADENAS DE TEXTO 
string miCadena = "Hola, mundo!";
int longitud = miCadena.Length;
Console.WriteLine($"La longitud de la cadena es: {longitud}");

//Concatenación
string primera = "Hola";
string segunda = "mundo!";
string concatenada = cadena1 + ", " + cadena2;

//Formato
string nombre = "Juan";
int edad = 25;
string mensaje = string.Format("Mi nombre es {0} y tengo {1} años.", nombre, edad);

//Comparación 
string ejemplo1 = "Hola";
string ejemplo2 = "Hola";
bool sonIguales = cadena1.Equals(cadena2);  // O también cadena1 == cadena2


//CARACTERES DE ESCAPE
string conComillas = "Este es un ejemplo de comillas dobles: \"Hola\"";
string conSaltoDeLinea = "Primera línea\nSegunda línea";

Console.WriteLine(conComillas);
Console.WriteLine(conSaltoDeLinea);

//SECUENCIAS DE ESCAPES
string mostrar= "Hola, soy una secuencia de escape:\n\t- Línea 1\n\t- Línea 2";
Console.WriteLine(mensaje);

//COMO SE ALMACENAN LAS CADENAS EN MEMORIA
//referencias hash
string almacen1 = "Hola";
string almacen2 = "¿Como estas?";

Console.WriteLine($"Referencia de cadena1: {GetHashCode(cadena1)}");
Console.WriteLine($"Referencia de cadena2: {GetHashCode(cadena2)}");

    static int GetHashCode(string str)
{
    return str.GetHashCode();
}
//uso de StringBuilder
StringBuilder builder = new StringBuilder("Hola");
builder.Append(", mundo!");

Console.WriteLine(builder.ToString());

//ASIGNACION DE CADENAS 
string asignacion1 = "Hola";
string asignacion2 = " Mundo";
string saludo = cadena1 + cadena2;
//OTRO TIPO DE DATOS
int numero1 = 5;
int numero2 = 3;
int suma = numero1 + numero2;

// CADENAS LITERALES
// Sin cadena literal
string rutaNormal = "C:\\Directorio\\Archivo.txt";

// Con cadena literal
string rutaLiteral = @"C:\Directorio\Archivo.txt";

//VARIABLES TIPPO STRING
// Solicitar el nombre y la edad al usuario
Console.Write("Ingrese su nombre: ");
string nombrepersona = Console.ReadLine();

Console.Write("Ingrese su edad: ");
int años= int.Parse(Console.ReadLine());

// Crear un mensaje personalizado
string texto = $"Hola, {nombre}! Tienes {edad} años.";

// Mostrar el mensaje
Console.WriteLine(mensaje);

//CONCATENACION USANDO +
string cadenamuestra1 = "Hola,";
string cadenamuestra2 = "bienvenido";
string resultado = cadenamuestra1 + cadenamuestra2;
Console.WriteLine(resultado);

//CONCATENACION USANDO CONCAT()Ç
string prueba1 = "Hola, ";
string prueba2= "mundo!";
string final= string.Concat(prueba1, prueba2);

Console.WriteLine(final);

//USO DE STRINGBUILDER
StringBuilder resultadoBuilder = new StringBuilder();

for (int i = 1; i <= 5; i++)
{
    resultadoBuilder.Append("Iteración ").Append(i).AppendLine();
}

string resultadoFinal = resultadoBuilder.ToString();
Console.WriteLine(resultadoFinal);








