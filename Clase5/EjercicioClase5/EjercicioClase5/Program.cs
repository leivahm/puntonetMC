// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string respuesta = "s";

while (respuesta.ToUpper() == "S")
{
    Console.Clear();

    Console.Write("Por favor, ingrese su nombre: ");
    var nombre = Console.ReadLine();

    Console.WriteLine($"\n\n\n¡Hola {nombre}!");

    Console.Write("¿Desea continuar? S/N: ");
    respuesta = Console.ReadLine();
}

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("\nPrograma finalizado correctamente");
}
else
{
    Console.WriteLine("\nOpción no válida");
}