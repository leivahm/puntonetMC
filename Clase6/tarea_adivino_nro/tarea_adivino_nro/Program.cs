// See https://aka.ms/new-console-template for more information

// Genera un número entero aleatorio de 1 a 20

int numeroSecreto, nroRegistrado, contador;
var deNuevo = "S";

do { 

    numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
    contador = 1;
    deNuevo = "S";

    Console.Clear();

    do
    {
        Console.Write("Pensé un número del 1 al 20, adivina cuál es: ");
        nroRegistrado = Int16.Parse(Console.ReadLine());
        if (nroRegistrado > numeroSecreto)
        {
            Console.WriteLine("\nUh, muy grande. Vamos de nuevo...");
        }
        else if (nroRegistrado < numeroSecreto)
        {
            Console.WriteLine("\nMuy pequeño. Elige otro número.");
        }
        else
        {
            Console.WriteLine($"\nFelicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
            Console.WriteLine($"Lo lograste en {contador} intentos!!");
            Console.WriteLine("\n¿Jugamos de nuevo? (S/N): ");
            deNuevo = Console.ReadLine();
        }
        contador++;

    }
    while (nroRegistrado != numeroSecreto);

}
while (deNuevo.ToUpper() == "S");

if (deNuevo.ToUpper() != "N")
{
    Console.WriteLine("Opción no válida.");
}
else
{
    Console.WriteLine("\nPrograma cerrado correctacmente.\n¡Gracias, adiós!\n\n\n");
}