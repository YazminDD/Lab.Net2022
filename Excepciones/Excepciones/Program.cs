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
            int num1, num2, resultadoDivision;

            
            // Ejercicio 1        

            try
            {
                Console.WriteLine("Ejercicio 1 División");
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese el primer número");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                num2 = Convert.ToInt32(Console.ReadLine());
                resultadoDivision = Operacion.Dividir(num1, num2);
                Console.WriteLine("El resultado es : " + resultadoDivision);
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
