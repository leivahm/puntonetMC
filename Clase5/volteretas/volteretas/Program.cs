// See https://aka.ms/new-console-template for more information
Console.Write("Cuántas vueltas quiere dar? => ");

var totalDeVueltas = int.Parse(Console.ReadLine());

// EJEMPLO DE UN BUCLE INFINITO
/* while (true)
{
    Console.WriteLine("Seguimos dando vueltas");
}*/

var contador = 0; // se usa "var" para declarar una variable a la cual se inicializa de modo que tome el tipo de acuerdo al valor asignado
var x = 5.0M;
var resultado = contador + x;

while (contador < totalDeVueltas)
{
    contador++; //contador = contador + 1;
    Console.WriteLine("Seguimos dando vueltas, vuelta número: " + contador);
}

Console.WriteLine("\nCuántas vueltas quiere dar?");

var respuesta = "S";
contador = 0;

while (respuesta.ToUpper() != "N")
{
    contador++; //contador = contador + 1
    Console.WriteLine("Seguimos dando vueltas, vuelta número: " + contador);

    Console.WriteLine("Seguimos= (S/N)");
    respuesta = Console.ReadLine();
}

//       decl.   cond.  paso
for (int i = 0; i < 12; i++)
{
    Console.WriteLine("Mi bolsita tiene " + (i+1) + " caramelos");
    // RECORDAR !!! el PASO lo hace al finalizar la ejecución
}

var counter = 0;
while (counter < 12)
{
    counter++;
    Console.WriteLine("Mi bolsita tiene " + counter + " caramelos");
}

for (counter = 0; counter < 12; counter+=2)
{
    Console.WriteLine($"Mi bolsita tiene {counter} caramelos");
}

// counter+=2 === counter = counter + 2
// counter+=8 === counter = counter + 8