using Clase14;

//Persona p = null;
//for (int i = 0; i < 10; i++)
//{
//    p = new Persona();
//    //GC.Collect(); // Método para recolectar los objetos no referenciados
//}

//Console.WriteLine(p.nombre + " " + p.apellido);


/* Las líneas anteriores son las originales
   Lo que sigue es para hacer un colector (lista) de los elementos no referenciados */
var personas = new List<Persona>();
for (int i = 0; i < 100; i++)
{
    var p = new Persona();
    personas.Add(p);
}

foreach (var item in personas)
{
    Console.Write(item.nombre + " " + item.apellido + "   ");
}
//En este ejemplo se trata de demostrar que se carga la memoria con los datos de la lista

