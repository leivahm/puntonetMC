Console.Write("Ingrese una longitud para el vector: ");
var n = int.Parse(Console.ReadLine());

int[] vector = new int[n];
int[] vectorInv = new int[n];
Random azar = new Random();
int contador = 1;

for (int i = 0; i < n; i++)
{
    vector[i] = azar.Next(1, 100);
    Console.Write(vector[i] + " ");
    vectorInv[n-contador] = vector[i];
    contador++;
}

Console.WriteLine();


foreach (var v in vectorInv)
{
    Console.Write(v + " ");
}

Console.ReadKey();