using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_tp1
{
    public class Taxi : transportePublico
    {
        public Taxi(int cantPasajeros) : base(cantPasajeros)
        {
        }

        public Taxi(string nombre, int cantPasajeros) : base(nombre, cantPasajeros)
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

