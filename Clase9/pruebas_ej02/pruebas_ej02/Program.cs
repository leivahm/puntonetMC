

int[] vector = new int[18];
int[] vectorBingo = new int[15];
Random azar = new Random();

/* ===== CARGA DEL VECTOR ===== */

Console.Write("\n\nVector[18]: ");
for (int i = 1; i <= vector.Length; i++)
{   //Llenamos el vector de nros random del 0 al 89
    if (i < 10)
    {
        vector[i - 1] = (azar.Next((i * 10), ((i * 10) + 10)));
        vector[i - 1] = vector[i - 1] - 10;
        while (vector[i - 1] < 1 || vector[i - 1] > 89)
        {   //Aquí elimino la posibilidad del valor '0' (cero)
            vector[i - 1] = (azar.Next((i * 10), ((i * 10) + 10)));
            vector[i - 1] = vector[i - 1] - 10;
        }
        Console.Write(vector[i - 1] + " ");

    }
    else
    {
        vector[i - 1] = (azar.Next((i * 10), ((i * 10) + 10)));
        vector[i - 1] = vector[i - 1] - 100;
        while (vector[i - 1] < 1 || vector[i - 1] > 89)
        {   
            vector[i - 1] = (azar.Next((i * 10), ((i * 10) + 10)));
            vector[i - 1] = vector[i - 1] - 100;
        }
        Console.Write(vector[i - 1] + " ");
    }
}

/* ===== ORDENAMIENTO ===== */

int auxiliar = 0;
for (int i = 0; i < vector.Length - 1; i++)
{   //Ordeno de menor a mayor 
    for (int j = 0; j < vector.Length - 1; j++)
    {
        if (vector[vector.Length - (i + 1)] > vector[vector.Length - (j + 1)])
        {
            auxiliar = vector[vector.Length - (j + 1)];
            vector[vector.Length - (j + 1)] = vector[vector.Length - (i + 1)];
            vector[vector.Length - (i + 1)] = auxiliar;
        }
    }
}
if (vector[0] > vector[1])
{   //a veces me sale el v[0] > al v[1]
    auxiliar = vector[1];
    vector[1] = vector[0];
    vector[0] = auxiliar;
}

Console.Write("\nOrdenado: ");
foreach (var item in vector)
{
    Console.Write(item + " ");
}


/* ===== ANULAR REPETIDOS ===== */
bool bandera = true;
while (!bandera)
{
    for (int i = 1; i <= vector.Length - 2; i++)
    {   //Comprobamos repetidos
        for (int j = 1; j < vector.Length - 2; j++)
        {
            if (vector[i - 1] == vector[j])
            {
                vector[j] = azar.Next(1, 90);
                bandera = true;
            }
            else
            {
                bandera = false;
            }
        }
        
    }
}


Console.Write("\nVector[18] OK: ");
foreach (var item in vector)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");
Console.ReadLine();



