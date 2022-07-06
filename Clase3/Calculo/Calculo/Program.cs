// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();

Console.WriteLine("Este programa calcula la superficie de un rectángulo\n");

// decimal v = decimal.Parse("222");

Console.WriteLine("Ingrese la base del rectángulo: ");
//string baseRectanguloTexto = Console.ReadLine();
//double baseRectangulo = double.Parse(baseRectanguloTexto); 

double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectángulo:");
double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo = (baseRectangulo * alturaRectangulo) / 2;

Console.WriteLine("\nLa superficie del rectangulo es: " + superficieRectangulo);

// Aquí estoy definiendo una variable y asigno la condición verdadera
bool esMayorADiez = superficieRectangulo > 10;

if (esMayorADiez)
{
    // Mostrar mensaje solamente si es mayor a diez
    Console.WriteLine("\nLa superficie del rectángulo es mayor a 10");
}

Console.ReadKey();