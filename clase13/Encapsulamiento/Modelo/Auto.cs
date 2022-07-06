using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento.Modelo
{
    internal class Auto
    {
        // ========== CAMPOSS ==========
        private string _tipoDeMotor; //pongo un guión bajo antes del nombre para diferenciar un CAMPO de una PROPIEDAD
        private string _anhoDeFabricacion;

        private bool _bujiasOkey;


        public string TipoDeMotor
        {
            get { return _tipoDeMotor; }
            set
            {
                if (value == null || value == "")
                {
                    _tipoDeMotor = "Nafta";
                }
                else
                {
                    _tipoDeMotor = value;
                }
            }
        }
        
        // ========== PROPIEDADES AUTOIMPLEMENTADAS ==========
        //Son autoimplementadas porque tienen solo el get y el set
        public bool EstaEncendido { get; set; }
        public int AnhoDeFabricacion { get; set; }
        public string Marca { get; set; }

    }
}
