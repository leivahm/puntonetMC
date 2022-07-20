using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20.Clases
{
    public partial class Persona
    {   //en la prop. autoimplementada se genera una variable anónima
        public Persona()
        {
            Nombre = "";
            Apellido = "";
        }

        public string Nombre { get; set; } //propiedad autoimplementada

        public partial int CalcularEdad();   
    }
}
