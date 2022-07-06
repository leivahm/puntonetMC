



//Console.WriteLine("Ingrese la cantidad de alumnos: ");
//// Ingresamos el tamaño del vector
//int cantidadAlumnos = int.Parse(Console.ReadLine());

////tipo[] notas = new tipo[tamaño]
//int[] notas = new int[cantidadAlumnos];

//Console.WriteLine("Ingrese las notas de cada alumno");



//// Recorremos el vector para cargar
//for (int posicion = 0; posicion < notas.Length; posicion++)
//{
//    Console.WriteLine($"Nota del alumno N° {posicion + 1}: ");
//    notas[posicion] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("\n=======================\n");

//for (int posicion = 0; posicion < notas.Length;posicion++)
//{
//    Console.WriteLine($"La nota del alumno N° {posicion + 1}: '{notas[posicion]}'");
//}

Console.WriteLine("Notas de Exámenes\nIngrese la cantidad de alumnos: ");
int students = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de Materias a evaluar:");
int subjects = int.Parse(Console.ReadLine());

// Tipo[,] nombre = new tipo[fileSize, columnSize];
int[,] grades = new int[subjects, students];

// Cantidad de flias
int lengthFilas = grades.GetUpperBound(0) + 1;

// Cantidad de columnas
int lengthColumnas = grades.GetUpperBound(1) + 1;

// Recorremos columnas
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine($"\nNotas del alumno N°: {columna + 1}: ");

    // Recorremos filas
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.WriteLine($"Cargue la nota N° {fila + 1}: ");
        grades[fila, columna] = int.Parse(Console.ReadLine());
    }
}

// Ahora visualizamos los alumnos y sus notas
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine($"================================\nNotas del alumno N°: {columna + 1}: ");

    //Recorremos filas otra vez
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"La nota n° {fila + 1}. ");
        Console.WriteLine(grades[fila, columna]);
    }
}







Console.WriteLine("Ingrese la longitud del vector: ");
var n = int.Parse(Console.ReadLine());

int[] vector = new int[n];
int[] vectorInv = new int[n];
int contador = 1;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Ingrese el " + (i + 1) + "° valor de " + n + " valores: ");
    vector[i] = int.Parse(Console.ReadLine());
    vectorInv[n - contador] = vector[i];
    contador++;
}

Console.WriteLine();



foreach (var v in vector)
{
    Console.Write(v + " ");
}

Console.WriteLine();

foreach (var v in vectorInv)
{
    Console.Write(v + " ");
}