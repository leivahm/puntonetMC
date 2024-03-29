﻿Console.Write("Creamos una matriz de 2 dimensiones, defina la cantidad de Columnas: ");
int nroColumnas= int.Parse(Console.ReadLine());

Console.Write("\nAhora defina la cantidad de Filas: ");
int nroFilas = int.Parse(Console.ReadLine());

double[,] numero = new double[nroFilas, nroColumnas];
double[] promedios = new double[nroColumnas];
double[] acumulador = new double[nroFilas];

for (int columna = 0; columna < nroColumnas; columna++)
{
    Console.WriteLine($"\nCargue los valores de la columna N° {columna + 1}");
    
    for (int fila = 0; fila < nroFilas; fila++)
    {
        Console.Write($"Ingrese el valor de la fila N° {fila + 1}: ");
        numero[fila, columna] = double.Parse(Console.ReadLine());
        acumulador[fila] = numero[fila, columna];
    }
    promedios[columna] = acumulador.Average();
}

for(int columna = 0; columna < nroColumnas; columna++)
{
    Console.WriteLine($"\nValores de la columna N° {columna + 1}");

    for (int fila = 0; fila < nroFilas; fila++)
    {
        Console.Write($"Fila N° {fila + 1}: ");
        Console.WriteLine(numero[fila, columna]);
    }
    Console.Write($"Promedio: {promedios[columna]}");
}