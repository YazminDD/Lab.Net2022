using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_tp1
{
    public abstract class transportePublico
    {
        private int pasajeros;
        private string nombre;
        public int Pasajeros {
        get { return pasajeros; }
            set { pasajeros = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public transportePublico(int cantPasajeros)
        {
            this.pasajeros = cantPasajeros;
        }

        public transportePublico(string nombre, int cantPasajeros)
        {
            this.pasajeros = cantPasajeros;
            this.nombre = nombre;
        }

        public transportePublico()
        {
        }

        public abstract void Avanzar();


        public abstract void Detenerse();
        
     }
}
