// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! This is the VARIABLES class");

const string constanteTexto = "¡Bienvenidos!"; // Una constante es un valor que no va a cambiar
const float constpi = 3.1416f;

// Datos numéricos
byte numeroByte = 8;
int numeroInteger = -2; 
long numeroLong = 500;
double numeroDouble = 800;
float numeroFloat = 400;


// Datos lógicos

//bool datoBoolFalso = false; // 0 - off
//bool datoBoolVerdadero = true; // 1 - on

//bool estaLloviendo = false;
//bool boolean = true;

// Datos de texto

string datoString = "Milenio3";


Console.WriteLine(numeroByte + numeroInteger - numeroLong);

datoString = "La mejor startup...";

Console.WriteLine(datoString); //Console.WriteLine() -> instrucción de entrada

Console.WriteLine("Ingrese un valor: ");

datoString = Console.ReadLine(); //Console.ReadLine() -> instrucción de entrada
Console.WriteLine(datoString);

Console.WriteLine(numeroInteger + constpi);

Console.WriteLine("Ingrese un número entero: ");

int nroInteger = Convert.ToInt32(Console.ReadLine());