using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1

            Console.WriteLine("Ejercicio 1 División");
            Console.WriteLine(" ");

            try
            {

                Console.WriteLine("El resultado es ");
            }
            catch (DivideByZeroException ms)
            {
                Console.WriteLine(ms.Message);
            }
            finally
            {
                Console.WriteLine("La división finalizó");
                Console.ReadKey();
            }
        }
    }
}
