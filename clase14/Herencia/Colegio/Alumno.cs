using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Colegio
{
    public class Alumno : Persona
    {
        public string Curso { get; set; }
        public string Division { get; set; }

        public string recuperarClave()
        { //este método devuelve el contenido "protegido" del método Clave en la clase Persona
            return Clave();
        }
    }
}
