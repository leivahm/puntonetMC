using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20.Clases
{
    public static class MisExtensiones //clase estática
    {
        public static int CalcularCredito(this Proveedor p) //método estático
        {
            if (p.Nombre == "Juan")
            {
                return 100;
            }

            return 0;
        }

        public static int ContarPalabras(this string s, char separador = ' ') //método estático
        {
            return s.Split(separador).Length; //Los string tienen un método que devuelve un array con todos los textos separados por espacios
        } //El array tiene un string con todo ya separado

        //public static int ContarPalabras(this string s, string separador) //sobrecarga de ContarPalabras
        //{
        //    return s.Split(separador).Length;
        //}
    }
}
