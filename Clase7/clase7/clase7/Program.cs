// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Clear();

string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Fiat", "Toyota" };
int[] nros = { 2, 4, 6, 8, 16, 32, 64, 128, 256 };

Console.WriteLine(nros[2] + " " + cars[0]);

string[] frutas = new string[4];

frutas[0] = "Pera";
frutas[1] = "Manzana";
frutas[2] = "Banana";
frutas[3] = "Kiwi";

Console.WriteLine(frutas[2]);
Console.WriteLine(frutas[3]);
Console.WriteLine("");

for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine(frutas[i]);
}

int[] ints = new int[5];

ints[0] = int.Parse(Console.ReadLine());
ints[1] = int.Parse(Console.ReadLine());
ints[2] = int.Parse(Console.ReadLine());
ints[3] = int.Parse(Console.ReadLine());
ints[4] = int.Parse(Console.ReadLine());

int[] numeros = new int[5];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"por favor ingrese el número {i+1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

int acumulador = 0; // si no inicializo "acumulador" me da error

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"\nMostrando la posición ({i + 1}): {numeros[i]}");
    acumulador += numeros[i];
}

Console.WriteLine($"\nLa suma total de los números es: {acumulador}");

