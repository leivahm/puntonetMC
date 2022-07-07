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

        protected string Clave() //protected pone una capa de seguridad para el acceso al valor del return
        { //este método también está encapsulando la clave "A95DA8E3G"
            return "A95DA8E3G";
        }
    }
}

// Herencia permite heredar de la clase padre todos los atributos, métodos y constructores
// El modificador "Internal" se ven como públicos pero dentro de ese proyecto solamente
// "Private" solamente lo ve la clase
// "Protected" solamente lo ven los herederos
// "Internal" lo ven todos los miembros del proyecto
// "Public" lo ve todo el mundo
// A las clases Padres se les puede llamar Super Clase, Clase Base
// Las clases Hijas también se llaman Derivadas o SubClases también