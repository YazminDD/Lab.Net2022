using EF.LinQ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.LinQ.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine(" ");
                    Console.WriteLine("Menú de opciones");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. ");
                    Console.WriteLine("2. Productos sin stock");
                    Console.WriteLine("3. Productos que tienen stock y que cuestan más de 3 por unidad");
                    Console.WriteLine("4. Clientes de la región WA");
                    Console.WriteLine("5. Productos donde el ID  sea igual a 789");
                    Console.WriteLine("6. Nombres de los clientes en mayúscula y minúscula");
                    Console.WriteLine("7. Clientes de la Región WA y fecha de orden mayor a 1/1/1997");
                    Console.WriteLine("8. Salir");
                    Console.WriteLine(" ");
                    Console.Write("Seleccione una opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {

                        case 1:
                            Consulta1();
                            break;

                        case 2:
                            Consulta2();
                            break;

                        case 3:
                            Consulta3();
                            break;

                        case 4:
                            Consulta4);
                            break;

                        case 5:
                            Consulta5();
                            break;

                        case 6:
                            Consulta6();
                            break;

                        case 7:
                            Consulta7();
                            break;

                        case 8:
                            salir = true;
                            break;
                        default:
                            Console.Write("Seleccione una opción entre 1 y 8");
                            break;
                    }
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Seleccione una opción válida");
                }

                Console.ReadLine();
            }

        }

        #region

           // Consulta 1

           
           // Consulta 2

           public static void Consulta2()
           {
             try
             {
                Console.Clear();
                Console.WriteLine("Consulta 2");
                Console.WriteLine("Productos sin stock");
                Console.WriteLine(" ");

                ProductsLogic productsLogic = new ProductsLogic();
                var productos = productsLogic.ProductosSinStock();

                foreach (var p in productos)
                {
                    Console.WriteLine($"Nombre: {p.ProductName}");
                }
             }

             catch (Exception e)
             {
                Console.WriteLine(e.Message);
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
             }
           }

                  
        #endregion

    }
}

