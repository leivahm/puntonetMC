using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class HombreAranha : Entidad, iHombre, iAranha //en la herencia 1° van las "clases" y después las "interfaces"
    {   
        public string Nombre { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string Apelllido { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }

        public void Cazar()
        {
            throw new NotImplementedException();
        }

        public void Morir()
        {
            throw new NotImplementedException();
        }

        public void Nacer()
        {
            throw new NotImplementedException();
        }

        public void Tejer()
        {
            throw new NotImplementedException();
        }
    }
}
