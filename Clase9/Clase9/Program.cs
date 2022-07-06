

int[] vector = new int[18];
int[] vectorBingo = new int[15];
Random azar = new Random();

Console.Write("Vector[18]: ");
for (int i = 1 ; i <= vector.Length; i++)
{   //Llenamos el vector de nros random del 0 al 89
    if (i < 10)
    {
        vector[i - 1] = (azar.Next((i * 10), ((i * 10) + 9)));
        vector[i - 1] = vector[i - 1] - 10;
        while (vector[i - 1] < 1)
        {   //Aquí elimino la posibilidad del valor '0' (cero)
            vector[i - 1] = (azar.Next((i * 10), ((i * 10) + 9)));
            vector[i - 1] = vector[i - 1] - 10;
        }
        Console.Write(vector[i - 1] + " ");

    }
    else
    {
        vector[i - 1] = (azar.Next((i * 10), ((i * 10) + 9)));
        vector[i - 1] = vector[i - 1] - 100;
        while (vector[i - 1] < 1)
        {   //Aquí elimino la posibilidad del valor '0' (cero)
            vector[i - 1] = (azar.Next((i * 10), ((i * 10) + 9)));
            vector[i - 1] = vector[i - 1] - 10;
        }
        Console.Write(vector[i - 1] + " ");
    }
}
Console.WriteLine("\n");


//vector[0] = (columnA.Next(1, 9));
//vector[1] = (columnB.Next(10, 19));
//vector[2] = (columnC.Next(20, 29));
//vector[3] = (columnD.Next(30, 39));
//vector[4] = (columnE.Next(40, 49));
//vector[5] = (columnF.Next(50, 59));
//vector[6] = (columnG.Next(60, 69));
//vector[7] = (columnH.Next(70, 79));
//vector[8] = (columnI.Next(80, 89));
//vector[9] = (columnA.Next(1, 9));
//vector[10] = (columnB.Next(10, 19));
//vector[11] = (columnC.Next(20, 29));
//vector[12] = (columnD.Next(30, 39));
//vector[13] = (columnE.Next(40, 49));
//vector[14] = (columnF.Next(50, 59));
//vector[15] = (columnG.Next(60, 69));
//vector[16] = (columnH.Next(70, 79));
//vector[17] = (columnI.Next(80, 89));

Console.Write("Selecciono 3 posiciones al azar: ");
int[] aux = new int[3]; //Seleccionamos 3 posiciones al azar  SIN REPETIR para eliminar del vector
Random itemToRemove = new Random();
for (int i = 0; i < aux.Length; i++)
{
    if (i == 0)
    {
        aux[i] = itemToRemove.Next(0, 17);
    } else
    {
        if (i == 2)
        {
            aux[i] = itemToRemove.Next(0, 17);
            while ((aux[i] == aux[i - 1]) || (aux[i] == aux[i - 2]))
            {
                aux[i] = itemToRemove.Next(0, 17);
            }
        }
        else
        {
            aux[i] = itemToRemove.Next(0, 17);
            while (aux[i] == aux[i - 1])
            {
                aux[i] = itemToRemove.Next(0, 17);
            }
        }

    }
    Console.Write(aux[i] + "° | ");
}
Console.WriteLine("\n");


Console.Write("vectorBingo[15]: ");
int contador = 0;
for (int i = 0; i < vector.Length -1; i++)
{   //Anulamos 3# y queda la tarjeta de 15#
    if (i != aux[0] && i != aux[1] && i != aux[2])
    {
        vectorBingo[contador] = vector[i];
        Console.Write(vectorBingo[contador] + " ");
        contador++;
    }
}
Console.WriteLine("\n");


int auxiliar = 0;
Console.Write("Ordenando: ");
for (int i = 0; i < vectorBingo.Length ; i++)
{   //Ordenamos el vector 
    for (int j = 0; j < vectorBingo.Length - 1; j++)
    {
        if (vectorBingo[vectorBingo.Length - (i + 1)] > vectorBingo[vectorBingo.Length - (j + 1)])
        {
            auxiliar = vectorBingo[vectorBingo.Length - (j + 1)];
            vectorBingo[vectorBingo.Length - (j + 1)] = vectorBingo[vectorBingo.Length - (i + 1)];
            vectorBingo[vectorBingo.Length - (i + 1)] = auxiliar;
        }
    }
    Console.Write(vectorBingo[i] + " ");
}
Console.WriteLine();


Console.Write("vectorBingo[15] ordenado: ");
foreach (var item in vectorBingo)
{
    Console.Write(item + " ");
}
Console.WriteLine();


bool bandera = true;
while (bandera)
{   //Comprobamos repetidos
    for (int i = 0; i < vectorBingo.Length-1; i++)
    {
        for (int j = 0; j < vectorBingo.Length - 1; j++)
        {
            if (vectorBingo[vectorBingo.Length - (i + 1)] == vectorBingo[vectorBingo.Length - (j + 2)])
            {
                vectorBingo[vectorBingo.Length - (j + 2)] = vectorBingo[vectorBingo.Length - (j + 2)] - 1;
                if (vectorBingo[vectorBingo.Length - (j + 2)] == 0)
                {
                    vectorBingo[vectorBingo.Length - (j + 2)] = vectorBingo[vectorBingo.Length - (j + 2)] + azar.Next(2, 9);
                }
                bandera = false;
            }
            else
            {
                bandera = true;
            }
        }
    }
}
Console.WriteLine();

Console.Write("Tarjeta de Bingo al Azar: ");
foreach (var item in vectorBingo)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");
Console.ReadLine();















//Console.WriteLine("columnA: " + columnA );

//var dato = Console.ReadLine();

//int n = int.Parse(dato);

//int[] vector = new int[n];

//Random azar = new Random();

//for (int i = 0; i < vector.Length; i++)
//{
//    vector[i] = azar.Next(100);
//}

//var contador = 0;

//foreach (int i in vector)
//{
//    contador++;
//    Console.Write(contador + ":" + i + " ");
//}

//Console.WriteLine("\nIngrese posición a modificar: ");
//var k = int.Parse(Console.ReadLine());

//if (k > vector.Length-1 || k < 0)
//{
//    Console.Error.WriteLine("Indice incorrecto");
//}
//else
//{
//    Console.Error.WriteLine("Ingrese nuevo valor: ");

//    while (true)
//    {
//        var nuevoValor = int.Parse(Console.ReadLine());
//        if (nuevoValor > 0 && nuevoValor < 100)
//        {
//            vector[k - 1] = (int)nuevoValor;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Recuerde que el valor debe ser positivo menor a 100: ");
//        }
//    }
//}

//contador = 0;

//foreach (int i in vector)
//{
//    contador++;
//    Console.WriteLine(contador + ":" + i + " ");
//}


//if (dato == null)
//{ // UN VALOR NULL NO ES UN DATO VACÍO
//    int n = 0;
//} UN VALOR NULL NO EXISTE


