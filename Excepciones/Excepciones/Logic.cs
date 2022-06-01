using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class Logic
    {
        public void EnviaExcepcion()
        {
            throw new InvalidOperationException();
        }
        
        public void ExcepcionPersonalizada()
        {
            throw new ExcepcionPersonalizada("Mensaje de excepción personalizada");
        }

    }
}
