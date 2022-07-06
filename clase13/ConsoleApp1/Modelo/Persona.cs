using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modelo
{
    internal class Persona
    {
        // ======== PROPIEDADES ========
        public string NombreCompleto { get; set; }
        public string NumeroDocumento { get; set; }
        public int Edad { get; set; }
        public bool EstaCasado { get; set; }

        // ======== CONSTRUCTOR ========
        public Persona()
        {
            Console.WriteLine("Se ha instanciado una nueva Persona");
        }

        public Persona(string nombreCompleto, string numeroDocumento, int edad, bool estaCasado)
        {
            NombreCompleto = nombreCompleto;
            NumeroDocumento = numeroDocumento;
            Edad = edad;
            EstaCasado = estaCasado;
        }



        // ======== MÉTODOS O FUNCIONES ========
        public string ObtenerSaludo()
        {
            return $"Hola! Soy {NombreCompleto}";
        }

        public string ObtenerSaludo(string nombrePersonaAQuienSaludar)
        {
            return $"Hola {nombrePersonaAQuienSaludar}, soy {NombreCompleto}";
        }
    }
}
