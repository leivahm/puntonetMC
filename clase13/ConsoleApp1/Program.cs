using ConsoleApp1.Modelo;

Persona persona1 = new Persona()
{
    NombreCompleto = "Ezequiel Etchecoin",
    NumeroDocumento = "2341556",
    Edad = 30,
    EstaCasado = true
};

var persona2 = new Persona("Marcelo Leiva", "23721352", 48, true);

var persona3 = new Persona { NombreCompleto = "Carlos Moscoso" };

Console.WriteLine(persona1.ObtenerSaludo());
Console.WriteLine(persona1.ObtenerSaludo("Carlos"));

Console.WriteLine(persona2.ObtenerSaludo());
Console.WriteLine(persona2.ObtenerSaludo("Naty"));

Console.WriteLine(persona3.ObtenerSaludo());
Console.WriteLine(persona3.ObtenerSaludo("Cecilia"));

//Esta clase también se incorpora desde el namespace ConsoleApp1.Modelo
var miOcupacion = new Ocupacion();