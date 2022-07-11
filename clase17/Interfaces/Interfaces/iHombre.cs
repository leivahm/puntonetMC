using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface iHombre : iEntidad
    {
        public string Nombre { get; set; }
        public string Apelllido { get; set; }

        void Nacer();
        void Morir();
    }
}
