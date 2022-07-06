int[] numeros = new int[10];
int promedio, acumulador = 0;
int mayor = 0;
int menor = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"por favor ingrese el {i + 1}° de 10 números: ");
    numeros[i] = int.Parse(Console.ReadLine());
    acumulador += numeros[i];
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}

promedio = (acumulador / 10);

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Mostrando la posición ({i + 1}): {numeros[i]}");
}

Console.WriteLine($"\nLa suma total de los números es: {acumulador}\nEl mayor ingresado es: {mayor}\nEl menor ingresado es: {menor}\nEl promedio de todos los números es: {promedio}");