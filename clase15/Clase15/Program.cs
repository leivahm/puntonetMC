// ::::::::PRIMERA PARTE::::::::
// Tema de hoy Tipos de valor/referencia - Polimorfismo

//int primerNro = 1986;
//int segundoNro = primerNro;

//Console.WriteLine(primerNro);
//Console.WriteLine(segundoNro);

//primerNro = 1978;

//Console.WriteLine(primerNro);
//Console.WriteLine(segundoNro);

// ::::::::SEGUNDA PARTE::::::::
//using Clase15.Modelos;

//var miPrimerClase = new MiClase
//{
//    Id = 1,
//    Nombre = "Juancito Pérez"
//};
//Console.WriteLine(miPrimerClase.Nombre);

//var miSegundaClase = miPrimerClase; // aquí se hace una referencia de miPrimerClase
//Console.WriteLine(miSegundaClase.Nombre); // nótese que no existe la palabra reservada "new" en la línea anterior

//miPrimerClase.Nombre = "Andrés Gómez";

//Console.WriteLine(miPrimerClase.Nombre);
//Console.WriteLine(miSegundaClase.Nombre);

// // ::::::::TERCERA PARTE::::::::
//using Clase15.Modelos;

//var miPrimerClase = new MiClase
//{
//    Id = 1,
//    Nombre = "Pepe"
//};
//var miSegundaClase = new MiClase
//{
//    Id = 2,
//    Nombre = "Quino"
//};

//var miLista = new List<MiClase>();
//miLista.Add(miPrimerClase);
//miLista.Add(miSegundaClase);

//foreach (var item in miLista)
//{
//    Console.WriteLine(item.Nombre);
//    if (item.Id == 1)
//        item.Nombre = "Roberto";
//}
//Console.WriteLine(miPrimerClase.Nombre);
//Console.WriteLine(miSegundaClase.Nombre);


// ::::::::CUARTA PARTE::::::::
using Clase15.Modelos;

var primerPersona = new Persona
{
    Apellido = "Mateos",
    Nombre = "Joaquín"
};


var primerDocente = new Docente
{
    Salario = 70000,
    Nombre = "Juan Pablo",
    Apellido = "Ferreyra"
};

var primerAlumno = new Alumno
{
    Legajo = 1234,
    Apellido = "Rodríguez",
    Nombre = "Ricardo"
};

var personas = new List<Persona>();
personas.Add(primerPersona);
personas.Add(primerDocente);    
personas.Add(primerAlumno);

//Lo que quiero ahora es mostrar el salario de una "Persona" si lo tuviere
foreach (var persona in personas)
{   // En el ciclo verificamos que tipo de "Persona" sea igual a tipo de "Docente"
    if (persona.GetType() == typeof(Docente))
    {
        var docente = (Docente)persona; // Casteo => a la clase "Persona" se intenta tratar como clase "Docente"
        Console.WriteLine(docente.Salario); // imprime el salario de la persona
    }
}