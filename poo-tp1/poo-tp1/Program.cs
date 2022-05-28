using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_tp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<transportePublico> listaTransportes = new List<transportePublico>();

            //Aquí se crean los 5 omnibus con su cantidad de pasajeros

            for (int i = 1; i < 6; i++)
            {

                listaTransportes.Add(new Omnibus("Omnibus "+i, i*2));

            }

            //Aquí se crean los 5 taxis con su cantidad de pasajeros

            for (int t = 1; t < 6; t++) {

                listaTransportes.Add(new Taxi("Taxi " +t, t*2));

            }
            


            foreach (transportePublico transportePublico in listaTransportes) {
            
            
            Console.WriteLine(transportePublico.Nombre + " : " + transportePublico.Pasajeros + " pasajeros");
            
            
            
            
            }




            Console.ReadLine();
        }
    }
}
