using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_tp1
{
    public class Omnibus : transportePublico
    {
        public Omnibus(int cantPasajeros) : base(cantPasajeros)
        {
        }
        public Omnibus(string nombre, int cantPasajeros) : base(nombre, cantPasajeros)
        {
        }

        public override void Avanzar()
        {
            throw new NotImplementedException();
        }

        public override void Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
