// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Borra la pantalla 
//Console.Clear();

// Pedimos al usuario que introduzca su nombre
Console.WriteLine("Hola, ingrese su nombre: ");

// Leemos el nombre del usuario
string nombre;  //también se puede hacer en una sola línea
                //string nombre = Console.ReadLine();

nombre = Console.ReadLine(); //Aquí espera que el usuario escriba algo

Console.WriteLine("\nPor favor, ahora ingrese su apellido: ");
string apellido = Console.ReadLine();

// Mostramos el nombre
Console.Write("\nHola " + nombre);
Console.WriteLine(", este es mi segundo programa.\n Pulse una tecla para finalizar...");

Console.ReadKey();