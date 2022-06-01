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

            // Ejercicio 2

            try
            {
                Console.WriteLine("------------------------------------------- ");
                Console.WriteLine(" ");
                Console.WriteLine("Ejercicio 2 División");
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
                Console.WriteLine("¡Solo Chuck Norris divide por cero!");
                
            }

            catch (FormatException)
            {
                Console.WriteLine("¡Seguro ingreso una letra o no ingresó nada!");
                
            }

            catch (Exception ms)
            {
                Console.WriteLine("Otros errores : " + ms.Message);
                
            }

            finally
            {
                Console.WriteLine("La división finalizó");
                Console.ReadKey();
            }

            // Ejercicio 3

            try
            {
                Console.WriteLine("------------------------------------------- ");
                Console.WriteLine(" ");
                Console.WriteLine("Ejercicio 3 Excepción");
                Console.WriteLine(" ");

                Logic excepcion = new Logic();
                excepcion.EnviaExcepcion();
            }

            catch (InvalidOperationException ms)
            {
                Console.WriteLine(ms.Message);
                Console.ReadKey();
            }

            // Ejercicio 4

            try
            {
                Console.WriteLine("------------------------------------------- ");
                Console.WriteLine(" ");
                Console.WriteLine("Ejercicio 4 Excepción Personalizada");
                Console.WriteLine(" ");

                Logic excepcionPersonalizada = new Logic();
                excepcionPersonalizada.ExcepcionPersonalizada();
            }

            catch (ExcepcionPersonalizada ms)
            {
                Console.WriteLine(ms.Message);
                Console.ReadKey();
            }
        }
    }
}
