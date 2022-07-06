using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Colegio
{
    public class Persona
    {
        public string NombreCompleto { get; set; }
        public int Dni { get; set; }

        public Persona()
        {
            NombreCompleto = "Juan Pérez";
            Dni = 2220022;
        }
    }
}
