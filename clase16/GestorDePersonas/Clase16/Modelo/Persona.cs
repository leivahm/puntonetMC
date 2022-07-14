using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Modelo
{
    public abstract class Persona // "abstract" impide que una clase pueda ser instanciada
    {  // "abstrac" me indica que la clase Persona sirve para abstraer cosas
        // o sea que la clase Persona NECESITA tener hijos porque sino no puede ser instanciada

        private DateTime _fechaNacimiento; //determina la fecha de manera privada

        private int _numeroDeDocumento;

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento {
            get
            {   //retorna la fecha en una cadena
                return _fechaNacimiento.ToString("dd/MM/yyyyy");
            }
            set
            {
                _fechaNacimiento = Convert.ToDateTime(value);
            } 
        }
        public string NumeroDeDocumento {
            get
            {
                return _numeroDeDocumento.ToString();
            }
            set
            {
                int numeroDeDocumentoConvertido;
                var sePuedeConvertir = int.TryParse(value, out numeroDeDocumentoConvertido);

                if(!sePuedeConvertir)
                {
                    _numeroDeDocumento = 0;
                }
                else
                {
                    _numeroDeDocumento = numeroDeDocumentoConvertido;
                }
                    //_numeroDeDocumento = Convert.ToInt32(value); //puede ser también de esta forma
            }
        }

        public int ObtenerEdad()
        {
            var fechaHoraActual = DateTime.Today; //propiedad que nos devuelve la fecha de hoy
            var edadDateTime = fechaHoraActual - _fechaNacimiento; // esto define un TimeSpan (período de tiempo)

            return (int)edadDateTime.TotalDays / 365;
        }  //Si no lo casteo me da error. El casting trata como "entero" al campo "decimal"
    }
}