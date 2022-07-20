using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20.Clases
{
    public partial class Persona
    {
        private string _apellido; //de aquí hacia el final de la propiedad apellido
        public string Apellido
        {  // es una propiedad no autoimplementada
            get
            {
                //if (string.IsNullOrWhiteSpace(Apellido))
                //{  //ejemplo de código dentro del get
                //    return "Vacío";
                //}

                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }

        public partial int CalcularEdad()
        {
            return 52;
        }
    }
}
