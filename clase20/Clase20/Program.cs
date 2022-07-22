using Clase20.Clases;



var p = new Persona //Aquí llama al constructor sin parámetros...
{ 
    Nombre = "Juan",  //... y aquí inicializo
    Apellido = "Perez"
};

var miArray = new int[] { 1, 2, 3, 4, 5 };

var p2 = new Persona(); //Aquí estoy inicializando (es lo mismo que arriba)
p2.Nombre = "María";
p2.Apellido = "López";

var p3 = new Persona("Enrique", "Aballay"); //Aquí paso como parámetros al constructor

var pr = new Proveedor("Juan", "Ulla"); //Aquí paso los parámetros porque Proveedor hereda de Persona

Console.WriteLine(pr.CalcularCredito());

var miChar = new char();
miChar = 'a';
Console.WriteLine((short)miChar); //devuelve código ASCII
//Console.WriteLine((byte)miChar); //también devuelve código ASCII
//Console.WriteLine((sbyte)miChar);//idem -> código ASCII

var miTexto = "Cuántas palabras tiene este texto?";
Console.WriteLine(miTexto.ContarPalabras() + "\n");


//TIPOS ANÓNIMOS  (un tipo es una clase)
var auto1 = new //no declaramos la clase en su espacio pero igual la toma como clase
{ // a continuación se cargan las propiedades y los valores
    Marca = "Ford",
    Modelo = "Mustang",
    Anho = "1969"
}; // Y se puede usar auto1 como una clase


Console.WriteLine(auto1.Marca);
Console.WriteLine(auto1.Modelo);
Console.WriteLine(auto1.Anho);

var pr2 = new
{
    pr.Nombre, //Aquí establezco la propiedad de otra variable
    pr.Apellido, // y asigno el nombre y el valor para el objeto de tipo anónimo "pr2"
    TipoProveedor = "Limpieza",
    Edad = 23,
    FechaAlta = new DateTime(2022,6,30)
};

Console.WriteLine("\n" + pr2.Nombre);
Console.WriteLine(pr2.Apellido);
Console.WriteLine(pr2.Edad);
Console.WriteLine(pr2.FechaAlta);

Console.WriteLine(pr2.TipoProveedor);


//EXPRESIONES LAMBDA
//Ejemplo 1
int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
int numerosImpares= numeros.Count(n => n % 2 == 1);

