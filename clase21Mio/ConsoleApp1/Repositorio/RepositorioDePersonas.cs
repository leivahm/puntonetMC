using ConsoleApp1.Modelo;
using Newtonsoft.Json;

namespace ConsoleApp1.Repositorio
{
    public class RepositorioDePersonas
    {
        //Usamos un diccionario para guardar las personas.
        public Dictionary<string, Persona> Personas { get; set; }

        public RepositorioDePersonas()
        {
            Personas = new Dictionary<string, Persona>();
        }

        public void Insertar(Persona persona)
        {
            var numeroDocumento = persona.NumeroDeDocumento;
            var personaExiste = Personas.ContainsKey(numeroDocumento);
            if(!personaExiste)
            {
                Personas[numeroDocumento] = persona;
            }
        }

        public void Eliminar(string numeroDocumento)
        {
            Personas[numeroDocumento] = null;
        }

        public void Actualizar(Persona persona)
        {
            var personaAActualizar = Personas[persona.NumeroDeDocumento];
            if(personaAActualizar != null)
            {
                personaAActualizar.Nombre = persona.Nombre;
                personaAActualizar.Apellido = persona.Apellido;
                personaAActualizar.FechaNacimiento = persona.FechaNacimiento;
            }
        }

        public bool Existe(string numeroDeDocumento)
        {
            return Personas.ContainsKey(numeroDeDocumento);
        }

        public bool Existe(Persona persona)
        {
            return Existe(persona.NumeroDeDocumento);
        }
    }
}
