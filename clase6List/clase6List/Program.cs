/*
 1) Array
 2) Listas  (es como un array pero a través de métodos podemos agregar remover ubicar elementos de manera mas sencilla)
 3) Colas   (es una estructura de datos, ref el 1er elemo q ingresa a la lista tmb es el primero que sale)
 4) Pilas   (colección de objetos, ref el último en ingresar es el 1ero en salir)
 5) Diccionarios (ubico un determinado valor a través de una clave)
 etc...
 */

////Inicialización de Array (necesario indicar el valor [10])
//var miArray = new int[10];

////Recorro un array
//for (int i = 0; i < miArray.Length; i++)
//{
//    Console.WriteLine(miArray[i]);
//}

//foreach(var item in miArray)
//{
//    Console.WriteLine(item);
//}


////Inicializar una Lista, se especifica el tipo de datos en doble comillas angulares
//var personas = new List<string>(); //las clases son como moldes q nos permite crear funcionalidad
////List es un tipo de dato que se instancia con los () y se asigna a la variable miLista

//personas.Add("Ezequiel");   //los métodos de extensión son funcionalidades extra que se agregan a miLista
//personas.Add("Joaquín");
//personas.Add("Eugenio");

//foreach (var person in personas)
//{
//    Console.WriteLine(person);
//}

/*
Escribir un programa que permita al usuario confeccionar
una lista de nombres. Se debe ofrecer las siguientes opciones:
agregar un elemento (al final o en una posición determinada),
quitar un elemento, mostrar en qué posición se encuentra
un determinado elemento, invertir la lista.
 */

//var listaNros = new List<int>();

//var random = new Random();
//for (int i = 0; i < 9; i++)
//{
//    var numero = random.Next(200);
//    listaNros.Add(numero);

//    var count = listaNros.Count;
//    var capacity = listaNros.Capacity;
//    Console.WriteLine($"Count: {count}, Capacity: {capacity}, valor: {listaNros[i]}");
//}


var listaNombres = new List<string>();

Console.WriteLine("Bienvenido a Lista.\n");

string entradaUsuario;

do
{
    Console.WriteLine("Seleccione una de las siguientes opciones: ");
    Console.WriteLine("1-Agregar un elemento");
    Console.WriteLine("2-Quitar un elemento");
    Console.WriteLine("3-Ubicar un elemento");
    Console.WriteLine("4-Invertir la lista");
    Console.WriteLine("5-Ver el contenido de la lista");

    entradaUsuario = Console.ReadLine();

    switch (entradaUsuario)
    {
        case "0":
            //Sale del programa
            break;

        case "1":
            //Agregar un elemento
            Console.WriteLine("ingrese el elemento: ");
            var nuevoElemento = Console.ReadLine();

            Console.WriteLine("\nDónde desea agregar el elemento?");
            Console.WriteLine("1-Al final");
            Console.WriteLine("2-En una posición determinada");

            var opcionParaIngresar = Console.ReadLine();
            switch (opcionParaIngresar)
            {
                case "1":
                    //Al final
                    listaNombres.Add(nuevoElemento);
                    break;

                case "2":
                    //Ingresar un elemento en una posición
                    Console.WriteLine("\nIngrese posición: ");
                    var posicionAIngresar = int.Parse(Console.ReadLine());

                    listaNombres.Insert(posicionAIngresar, nuevoElemento);

                    break;
            }
            break;

        case "2":
            //Quitar elemento
            Console.WriteLine("\nIngrese el elemento que desea quitar: ");
            var elementoARemover = Console.ReadLine();
            listaNombres.Remove(elementoARemover);

            break;

        case "3":
            //Ubicar un elemento
            Console.WriteLine("\nIngrese el elemento que desea ubicar: ");
            var elementoAUbicar = Console.ReadLine();
            var posicion = listaNombres.IndexOf(elementoAUbicar);
            if (posicion > -1)
            {
                Console.WriteLine("\nEl elemento se encuentra en la posición " + posicion);
            }
            else
            {
                Console.WriteLine("\nEse elemento no existe\n");
            }

            break;

        case "4":
            //Invertir la lista
            listaNombres.Reverse();
            Console.WriteLine("\nLa lista se ha invertido.\n");

            break;

        case "5":
            //ver lista
            if(listaNombres.Count == 0)
            {
                Console.WriteLine("\nLa lista está vacía.\n");
            }
            else
            {
                foreach (var item in listaNombres)
                {
                    Console.WriteLine(item);
                }
            }

            break;
    }
}
while (entradaUsuario != "0");