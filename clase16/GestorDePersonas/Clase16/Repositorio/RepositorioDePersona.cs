using Clase16.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Repositorio
{
    public class RepositorioDePersona
    {//Usamos un diccionario para guardar las personas

        public Dictionary<string, Persona> Personas { get; set; } // Creamos un Diccionario de TClave "string" y de Valor "Persona"
        //En esta lista vamos a empezar a guardar las personas



        //Aquí creamos un constructor. Los constructores tienen el mismo nombre de la clase
        //...por lo que devuelve una instancia de esa clase
        public RepositorioDePersona()
        { // <1> cuando instancio la lista de personas recién ahí va a ser creada
            Personas = new Dictionary<string, Persona>();
        }

        public void Insertar(Persona persona)
        {
            var numeroDocumento = persona.NumeroDeDocumento;
            var personaExiste = Personas.ContainsKey(numeroDocumento); //Este método devuelve un bool que indica si la persona ya existe o no
            if (!personaExiste)
            {
                Personas[numeroDocumento] = persona;
            }
        }

        public void Eliminar(string numeroDocumento) // "void" me indica que no me va a devolver nada, solamente va a procesar
        {
            //Persona personaAEliminar = null;
            //foreach(var persona in Personas)
            //{
            //    if (persona.NumeroDeDocumento == numeroDocumento)
            //    {
            //        personaAEliminar = persona;
            //        break;
            //    }
            //}
            //LinQ -> librería útil para manejar conjunto de datos: lista, array o lo que fuere (buscar y leer)
            //if(personaAEliminar != null)
            //{
            //    Personas.Remove(personaAEliminar);
            //}
            Personas[numeroDocumento] = null; //este manejo de datos es mucho más sencillo
        }

        public void Actualizar(Persona persona)
        {
            // Definir cómo actualizar una persona de la Lista de Personas
            var personaAActualizar = Personas[persona.NumeroDeDocumento];
            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = persona.Nombre;
                personaAActualizar.Apellido = persona.Apellido;
                personaAActualizar.FechaNacimiento = persona.FechaNacimiento;
            }
            
            //foreach (var personaActual in Personas)
            //{
            //    if  (personaActual.NumeroDocumento == persona.NumeroDocumento)
            //    {
            //        personaActual.Nombre = persona.Nombre;
            //        personaActual.Apellido  = persona.Apellido;
            //        personaActual.FechaNacimiento = persona.FechaNacimiento;
            //    }
            //}
        }

        public void Actualizar(string numeroDocumento, string nombre, string apellido)
        {
            var personaAActualizar = Personas[numeroDocumento];
            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = nombre;
                personaAActualizar.Apellido = apellido;
            }
        }

        public bool Existe(string numeroDeDocumento)
        {
            return Personas.ContainsKey(numeroDeDocumento); //Retorna un ContainsKey que devuelve un boolean
        }

        public bool Existe(Persona persona) //Aquí estoy sobre cargando el método "Existe"
        { // Aquí Existe se llama a sí mismo pero usa otro parámetro 
            return Existe(persona.NumeroDeDocumento);
        }
    }
}
