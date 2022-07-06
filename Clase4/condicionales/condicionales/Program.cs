// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();

//======= Ejemplo de condicional If ========

 //Pedimos al usuario que ingrese la edad
Console.Write("Ingrese su edad: ");

// Obtenemos la edad por teclado
int edad = int.Parse(Console.ReadLine());

Console.Write("\nIngrese su equipo de futbol: ");
string equipo = Console.ReadLine();

Console.WriteLine("\nLa edad ingresada es: " + edad);

bool condicion = edad < 18 && (equipo == "river" || equipo == "River" || equipo == "RIVER");

/* CONDICIONALES:
 * ADN -> && (Y)
 * OR  -> || (O)
 * Igual que -> ==
 * Distinto que -> !=
*/

// Evaluamos la edad
if (condicion)
{
    // Instrucciones si se cumple la condición evaluada
    Console.WriteLine("\nUsted es menor de edad.");
    Console.WriteLine("Prohibida la entrada");
}
else
{
    // Instrucciones si no se cumple la condicón evaluada
    Console.WriteLine("\nUsted es mayor de edad.");
    Console.WriteLine("Puede ingresar");
}

Console.Write("\nIngrese la edad: ");
edad = int.Parse(Console.ReadLine());


if (edad < 0 || edad > 110)
{
    Console.WriteLine("La edad no es válida.");
}
else if (edad < 12)
{
    Console.WriteLine("Va a la primaria");
}
else if (edad < 18)
{
    Console.WriteLine("Va al secundario");
}
else if (edad < 28)
{
    Console.WriteLine("Va a la facultad");
}
else
{
    Console.WriteLine("A trabajar, no queda otra.");
}

//=== Ejemplo de Switch ===
Console.Write("\nIngrese el primer Nro: ");
double nroUno = double.Parse(Console.ReadLine());

Console.Write("\nIngrese el segundo Nro: ");
double nroDos = double.Parse(Console.ReadLine());

double resultado;

Console.WriteLine("\n1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Producto");
Console.WriteLine("4 - División");

Console.WriteLine("\nIngrese la operación a realizar:");
string operacion = Console.ReadLine();

switch (operacion)
{
    case "1":
        resultado = nroUno + nroDos;
        Console.WriteLine("\nSumando...\nResultado: " + resultado);
        break;

    case "2":
        resultado = nroUno - nroDos;
        Console.WriteLine("\nRestando...\nResultado: " + resultado);
        break;
    
    case "3":
        resultado = nroUno * nroDos;
        Console.WriteLine("\nMultiplicando...\nResultado: " + resultado);
        break;
    
    case "4" when nroDos != 0:
        resultado = nroUno / nroDos;
        Console.WriteLine("\nDividiendo...\nResultado: " + resultado);
        break;
    
    default:
        Console.WriteLine("\nSeleccionó una opción no válida");
        break ;
}

Console.WriteLine("Desea continuar? (S/N)");
var texto = Console.ReadLine();

if (texto.ToUpper() == "S")
{
    Console.WriteLine("Usted ingresó que SÍ");
}
else if (texto.ToLower() == "n")
{
    Console.WriteLine("Usted ingresó que NO");
}
else
{
    Console.WriteLine("Usted no entendió nada");
}




Console.ReadKey();