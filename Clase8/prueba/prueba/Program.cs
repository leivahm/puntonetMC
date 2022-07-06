Console.WriteLine("Ingrese las notas de los exámenes");

Console.Write("Ingrese la cantidad de alumnos: ");
int cantidadAlumnos = int.Parse(Console.ReadLine());

Console.Write("\nIngrese la cantidad de notas por alumno: ");
int cantidadNotas = int.Parse(Console.ReadLine());

int[,] notas = new int[cantidadNotas, cantidadAlumnos];

int lengthFilas = notas.GetUpperBound(0) + 1; //método GetUpperBound(0)+1 devuelve el índice del último elemento de la fila (-1 si está vacía)
int lengthColumnas = notas.GetUpperBound(1) + 1; // método GetUpperBound(1)+1 devuelve el índice del último elemento de la columna (-1 si está vacía)


for (int columna = 0; columna < lengthColumnas; columna++)
{   
    Console.WriteLine($"\nNotas del alumno N°: {columna + 1}: ");

    // ahora recorremos filas
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Cargue la nota N° {fila + 1}: ");
        notas[fila, columna] = int.Parse(Console.ReadLine());
    }
}

for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine("=================  ==================\n");
    Console.WriteLine($"Notas del alumno N°: {columna + 1}: ");
   
    // ahora recorremos filas
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"La nota N° {fila + 1}: ");
        Console.WriteLine(notas[fila, columna]);
    }
}





Console.ReadKey();