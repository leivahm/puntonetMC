
// Ejemplo 1
int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
int todosLosNumeros = numeros.Count();
Console.WriteLine(todosLosNumeros);

int numerosImpares = numeros.Count( n => n % 2 == 1); //Esto resume las líneas 9 a 13

numerosImpares = numeros.Count(  // ESTO
    n =>                         // HACE
    {                            // LO MISMO
        return n % 2 == 1;       // QUE LA 
    });                          // LÍNEA 7
Console.WriteLine(numerosImpares);