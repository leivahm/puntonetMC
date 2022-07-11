using Clase16.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Repositorio
{
    public class RepositorioDePersona
    {
        public List<Persona> Personas { get; set; } // <1> Aquí hay un espacio de una lista de Personas pero no hay lista
        

        //Aquí creamos un constructor. Los constructores tienen el mismo nombre de la clase
        //...por lo que devuelve una instancia de esa clase
        public RepositorioDePersona()
        { // <1> cuando yo instancio la lista de personas recién ahí va a ser creada
            Personas = new List<Persona>();
        }

        public void Insertar(Persona persona)
        {
            Personas.Add(persona);
        }

        public void Eliminar(string numeroDocumento) // "void" me indica que no me va a devolver nada, solamente va a procesar
        {
            // Definir cómo eliminar una persona de la Lista de Personas
        }

        public void Actualizar(Persona persona)
        {
            // Definir cómo actualizar una persona de la Lista de Personas
            foreach (var personaActual in Personas)
            {
                if  (personaActual.NumeroDocumento == persona.NumeroDocumento)
                {
                    personaActual.Nombre = persona.Nombre;
                    personaActual.Apellido  = persona.Apellido;
                    personaActual.FechaNacimiento = persona.FechaNacimiento;
                }
            }
        }

        public void Actualizar(string numeroDocumento, string nombre, string apellido)
        {
            foreach(var personaActual in Personas)
            {
                if (personaActual.NumeroDocumento == numeroDocumento)
                {
                    personaActual.Nombre = nombre;
                    personaActual.Apellido = apellido;

                }
            }
        }
    }
}
