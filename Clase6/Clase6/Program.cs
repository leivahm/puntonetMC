// See https://aka.ms/new-console-template for more information

// Diferencia entre declaración implícita (var) y explícita (int u otro tipo de dato)
/*
 * 
 * 
int numero1, numero2, numero3;
// var numero4, numero5;

var miVariable = 0;

Console.WriteLine($"El contenido de mi variable es: {miVariable}");

var miVariable2 = "texto";

Console.WriteLine($"El contenido de mi Variable es: {miVariable2}"); 
 
*/

/*
 Escribir un programa que haga lo siguiente:

1) Borrar la pantalla.
2) Pedir el nombre de la persona. >> INGRESO DE DATOS
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!" >> IMPRIMIR EN PANTALLA
4) Preguntar si se quiere continuar. >> CONDICIONAL "IF"
5) Si la respuesta es "S" repetir desde el punto 1. >> BUCLE
6) Si la respuesta es "N" finalizar el programa mostrando 
    un mensaje que diga "Programa finalizado correctamente" >> IMPRIMIR EN PANTALLA
7) Si la respuesta no es ni "S" ni "N" que también finalice el programa, pero mostrando
    el mensaje que diga "Opción no válida". >> IMPRIMIR EN PANTALLA
 
 */


// =================================================
/*var opcionElegida = "s";

while (opcionElegida.ToUpper() == "S")
{

    Console.Clear(); // Borro la pantalla 

    Console.Write("Ingrese su nombre, por favor: "); // Show msg: Pido el nombre de la persona
    var nombreIngresado = Console.ReadLine(); // Guardo el ingreso en la variable

    Console.WriteLine($"\n\n¡Hola {nombreIngresado}!\n"); // Show msg: Saludo

    Console.Write($"{nombreIngresado}, deseas continuar? ('S' para sí, 'N' para no): ");
    opcionElegida = Console.ReadLine(); // Guardo la opción elegida

    if (opcionElegida.ToUpper() == "N")
    {
        Console.WriteLine("\nPrograma finalizado correctamente");
    }
    else
    {
        Console.WriteLine("\nOpción no válida");
    }

} */

// =================================================

string opcionElegida;

do
{
    Console.Clear(); // Borro la pantalla 

    Console.Write("Ingrese su nombre, por favor: "); // Show msg: Pido el nombre de la persona
    var nombreIngresado = Console.ReadLine(); // Guardo el ingreso en la variable

    Console.WriteLine($"\n\n¡Hola {nombreIngresado}!\n"); // Show msg: Saludo

    Console.Write($"{nombreIngresado}, deseas continuar? ('S' para sí, 'N' para no): ");
    opcionElegida = Console.ReadLine(); // Guardo la opción elegida
}
while (opcionElegida.ToUpper() == "S");


if (opcionElegida.ToUpper() == "N")
{
    Console.WriteLine("\nPrograma finalizado correctamente.");
}
else
{
    Console.WriteLine("\nOpción no válida.");
}