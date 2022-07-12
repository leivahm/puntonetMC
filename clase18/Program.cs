////Ejemplo de Herencia Múltiple de Interfaces + ejemplos

// public interface IBebida
// {
//     decimal Volumen {get; set;}
//     bool Gasificada {get; set;}
//     string Color {get; set;}
//     decimal Calorias {get; set;}
//     bool Alcoholica {get; set;}
// }

// public interface IBebidasAlcoholicas
// {
//     decimal Graduacion {get; set;}
// }

// public interface ICerveza : IBebidasAlcoholicas, IBebida
// {
//     int IBU {get; set;} //IBU es el índice de amargura de la cerveza
// }

// public class Gaseosa : IBebida
// {
//     public decimal Volumen {get; set;}
//     public bool Gasificada {get; set;}
//     public string Color {get; set;}
//     public decimal Calorias {get; set;}
//     public bool Alcoholica {get; set;}

// }

// public class Cerveza : ICerveza
// {
//     public decimal Volumen {get; set;}
//     public bool Gasificada {get; set;}
//     public string Color {get; set;}
//     public decimal Calorias {get; set;}
//     public bool Alcoholica {get; set;}
//     public int IBU {get; set;}   
//     public decimal Graduacion {get; set;}
// }

// :::::::::::: Aquí empieza la codificación usando las clases y las interfaces de Models ::::::::::::

using clase18.Models;
var alumno = new Alumno()
{
    Nombre = "Joaquín",
    Apellido = "Mateos",
    DNI = "12312312",
    Legajo = "1234"
};

var docente = new Docente()
{
    Nombre = "Eze",
    Apellido = "Etchecoin",
    DNI = "10223118",
    Horas = 12
};

// Console.WriteLine("Alumno: " + alumno.Nombre + " " + alumno.Apellido + "\nDNI: " + alumno.DNI);
// Console.WriteLine("\nDocente: " + docente.Nombre + " " + docente.Apellido + "\nDNI: " + docente.DNI);

Console.WriteLine(ObtenerDatos(docente));
Console.WriteLine(ObtenerDatos(alumno));

var listado = new List<IPersona>();
listado.Add(alumno);
listado.Add(docente);

var nuevoListado = ObtenerPersonasByNombre(listado,"Eze");

Console.WriteLine(nuevoListado.Count);

List<IPersona> ObtenerPersonasByNombre(List<IPersona> personas, string nombre){
    var nuevaLista = new List<IPersona>();
    foreach(var p in personas){
        if(p.Nombre==nombre){
            nuevaLista.Add(p);
        }
    }
    return nuevaLista;
}


string ObtenerDatos(IPersona persona){
    var datos = persona.Nombre + " " + persona.Apellido;

    return datos;
}