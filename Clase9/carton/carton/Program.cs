var azar = new Random(DateTime.Now.Millisecond);
var carton = new int[3, 9];


/* ===== Generamos nros al azar para el cartón ===== */
for (int c = 0; c < 9; c++)
{
    for (int f = 0; f < 3; f++)
    {
        int nuevoNro = 0; // columna 1
        bool encontreUnoNuevo = false;
        while (!encontreUnoNuevo)
        {
            if (c == 0)
            {
                nuevoNro = azar.Next(1, 10); // 1 al 9
            }
            else if (c == 8) // columna 9
            {
                nuevoNro = azar.Next(80, 91); // 80 al 90
            }
            else // resto de columnas
            {
                nuevoNro = azar.Next(c * 10, c * 10 + 10);
            }

            // Buscamos si el nuevoNro existe en la columna
            encontreUnoNuevo = true;
            for (int f2 = 0; f2 < 3; f2++)
            {
                if (carton[f2, c] == nuevoNro)
                {
                    encontreUnoNuevo=false;
                    break;
                }
            }
            // Si sale del bucle y no encuentra repetidos, econtreUnoNuevo es  = True
            // y sale del bucle
        }

        carton[f, c] = nuevoNro;
    }
}


// Ordenamos las columnas de menor a mayor
for (int c = 0; c < 9; c++)
{
    for (int f = 0; f < 3; f++)
    {
        for (int k = f+1; k < 3; k++)
        {
            if (carton[f, c] > carton[k, c])
            {
                int aux = carton[f, c];
                carton[f, c] = carton[k, c];
                carton[k, c] = aux;
            }
        }
    }
}

var borrados = 0;
while (borrados < 12)
{
    var filaBorrar = azar.Next(0, 3);
    var columnaBorrar = azar.Next(0, 9);

    if (carton[filaBorrar, columnaBorrar] == 0)
    {
        continue;
    }

    // contamos cuantos ceros hay en esta fila.
    var cerosEnFila = 0;
    for (int c = 0; c < 9; c++)
    {
        if (carton[filaBorrar, c] == 0)
        {
            cerosEnFila++;
        }
    }

    // contamos cuántos ceros hay en esta columna
    var cerosEnColumna = 0;
    for (int f = 0; f < 3; f++)
    {
        if (carton[f, columnaBorrar] == 0)
        {
            cerosEnColumna++;
        }
    }

    // contamos cuántos ítems tenemos en cada columna
    var itemsPorColumna = new int[9];
    for (int c = 0; c < 9; c++)
    {
        for (int f = 0; f < 3; f++)
        {
            if (carton[f, c] != 0)
            {
                itemsPorColumna[c]++;
            }
        }
    }

    // contamos cuántas columnas hay con un sólo número
    var columnasConUnSoloNumero = 0;
    for (int c = 0; c < 9; c++)
    {
        if (itemsPorColumna[c] == 1)
        {
            columnasConUnSoloNumero++;
        }
    }

    // si hay 4 ceros en la fila o si hay 2 ceros en la columna
    // no hago nada
    if (cerosEnFila == 4 || cerosEnColumna == 2)
    {
        continue;
    }

    // si hay 3 columnas con 1 solo nro, a partir de ahora
    // debo borrar solo las columnas que tienen 3 items
    if (columnasConUnSoloNumero == 3 && itemsPorColumna[columnaBorrar] != 3)
    {
        continue;
    }

    // si no entró por las opciones anteriores, borramos el número
    carton[filaBorrar, columnaBorrar] = 0;
    borrados++;

}




/* ===== Mostramos el cartón por pantalla ===== */
Console.WriteLine("----------------------------------------------");
for (int f = 0; f < 3; f++)
{
    for (int c = 0; c < 9; c++)
    {
        if (c == 0)
            Console.Write("|");

        if (carton[f, c] == 0) //si es cero, mostramos espacios
            Console.Write("    |");
        else
            Console.Write($" {carton[f, c]:00} |");
    }
    Console.WriteLine(" ");
}
Console.WriteLine("----------------------------------------------\n");


Console.ReadLine();