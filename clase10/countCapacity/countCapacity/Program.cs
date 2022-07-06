var listaNros = new List<int>();

var random = new Random();
for (int i = 0; i < 17; i++)
{
    var numero = random.Next(50);
    listaNros.Add(numero);

    var count = listaNros.Count;
    var capacity = listaNros.Capacity;
    Console.WriteLine($"Count: {count}, Capacity: {capacity}");

}

