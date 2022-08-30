
// Ejemplo 1
using repaso_conceptos;

int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
int todosLosNumeros = numeros.Count();
Console.WriteLine(todosLosNumeros);

int numerosImpares = numeros.Count( n => n % 2 == 1); //Esto resume las líneas 9 a 13

numerosImpares = numeros.Count(  // ESTO
    n =>                         // HACE
    {                            // LO MISMO
        return n % 2 == 1;       // QUE LA 
    });                          // LÍNEA 7
Console.WriteLine(numerosImpares);


// Ejemplo 2
var misClientes = new List<Cliente>();
misClientes.Add(new repaso_conceptos.Cliente { Apellido = "Perez", Nombre = "Juan" });
misClientes.Add(new Cliente { Apellido = "De Tal", Nombre = "Fulano" });

//IEnumerable < Cliente > juanes = misClientes.Where(cadaCliente => cadaCliente.Nombre == "Juan");
// Esto es LinQ 'language integrated query'. Permite mapear para que se consulte directamente a la BD.

var juanes = misClientes.Where(             // TODO
    cadaCliente => {                        // ESTO
        if (cadaCliente.Nombre == "Juan")   // ESTÁ
            return true;                    // RESUMIDO
        else                                // EN LA
            return false;                   // LÍNEA
    });                                     // 24


foreach (Cliente c in juanes)
{
    string n = c.Nombre;

    Console.WriteLine(n);
}


// Query Expression

// Ejemplo 1

// Fuente de datos
int[] puntajes = { 90, 71, 82, 93, 75, 82 };

IEnumerable<int> resultados =       // LINQ
    from puntaje in puntajes        // ESTO
    where puntaje > 80              // ES
    orderby puntaje descending      // UNA
    select puntaje;                 // QUERY EXPRESSION

foreach (var r in resultados)
{
    Console.WriteLine(r);
}

IEnumerable<Cliente> resultado2 =
    from cliente in misClientes
    where cliente.Nombre == "Juan"
    orderby cliente.Nombre descending
    select cliente;

foreach (var name in resultado2)
{
    Console.WriteLine(name.Nombre + " " + name.Apellido);
}

var resultado3 = // Aquí le pongo 'var' porque no lo puedo escribir a nivel de tipo porque es anónimo
    from cliente in misClientes
    where cliente.Nombre == "Juan"
    orderby cliente.Nombre descending
    select new { cliente.Nombre };

foreach (var c in resultado3)
{
    Console.WriteLine(c);
}