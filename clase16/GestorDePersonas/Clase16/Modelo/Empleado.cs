using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Modelo
{
    public sealed class Empleado : Persona // el modificador de acceso "sealed" impide que la clase sea heredada
    {
        private int _salarioBruto;

        public string Ocupacion { get; set; }
        public string Empresa { get; set; }
        public string ObraSocial { get; set; }

        public int SalarioBruto //solamente se va a poder cargar un salario bruto
        {  //para tener solo un set necesito un campo privado. Propiedad de solo escritura (con set "establecer")
            set => _salarioBruto = value; // => es como el código con llaves pero "con una única instrucción"
        }

        public int SalarioNeto { get => ObtenerSalarioNeto(); } // Básicamente es una propiedad de solo lectura (con get "obtener")

        private int ObtenerSalarioNeto() //la propiedad anterior "SalarioNeto" obtiene el salario con esta clase privada
        {
            var salarioNeto = _salarioBruto * 0.85;
            return (int)salarioNeto;
        }


    }
}
