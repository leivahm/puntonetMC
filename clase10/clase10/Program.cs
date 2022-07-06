// Pilas


var miPila = new Stack<int>();

miPila.Push(0);
miPila.Push(1);
miPila.Push(2);
miPila.Push(3);

Console.WriteLine(miPila.Pop());
Console.WriteLine(miPila.Pop());
Console.WriteLine(miPila.Pop());
Console.WriteLine(miPila.Pop() + "\n");

miPila.Capacity


//Colas
var miCola = new Queue<int>();

miCola.Enqueue(1);
miCola.Enqueue(2);
miCola.Enqueue(3);
miCola.Enqueue(4);

Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());

