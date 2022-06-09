using EntityFramework.Entities;
using EntityFramework.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir) {

              try 
              { 

                Console.WriteLine(" ");
                Console.WriteLine("Menú de opciones");
                Console.WriteLine(" ");
                Console.WriteLine("1. Mostrar tabla Shippers");
                Console.WriteLine("2. Mostrar tabla Customers");
                Console.WriteLine("3. Agregar nuevo Shippers");
                Console.WriteLine("4. Modificar Shippers");
                Console.WriteLine("5. Eliminar Shippers");
                Console.WriteLine("6. Salir");
                Console.WriteLine(" ");
                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion) 
                {

                    case 1:
                        MostrarTablaShippers();
                        break;
                    
                    case 2:
                        MostrarTablaCustomers();
                        break;

                    case 3:
                        NuevoShippers();
                        break;

                    case 4:
                        ModificarShippers();
                        break;

                    case 5:
                        EliminarShippers();
                            
                        break;
                        
                    case 6:
                        salir = true;
                            break;
                        default:
                            Console.Write("Seleccione una opción entre 1 y 6");
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


        // Métodos de los case //

        // Método del Case 1
        public static void MostrarTablaShippers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Tabla Shippers");
                Console.WriteLine(" ");

                ShippersLogic shippersLogic = new ShippersLogic();

                foreach (var item in shippersLogic.GetAll())
                {
                    Console.WriteLine($"ID: {item.ShipperID} // Nombre: {item.CompanyName} // Teléfono: {item.Phone} ");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("La excepción es: " + e.Message);
                Console.ReadKey();
            }
        }

        // Método del Case 2
        public static void MostrarTablaCustomers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Listado Customers");
                Console.WriteLine(" ");

                CustomersLogic customersLogic = new CustomersLogic();

                foreach (var item in customersLogic.GetAll())
                {
                    Console.WriteLine($"ID: {item.CustomerID} // Nombre: {item.CompanyName}" +
                                      $" // Nombre de contacto: {item.ContactName} // Título de contacto: {item.ContactTitle}" +
                                      $" // Correo Electrónico: {item.Address} // Ciudad: {item.City} // Región: {item.Region} " +
                                      $" // Código postal: {item.PostalCode} // País: {item.Country} // Teléfono: {item.Phone} // Fax: {item.Fax}");
                }

                Console.WriteLine(" ");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("La excepción es: " + e.Message);
                Console.ReadKey();
            }

        }

        // Método del Case 3
        public static void NuevoShippers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Nuevo Shippers");
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese el teléfono: ");
                string telefono = Console.ReadLine();

                ShippersLogic shippersLogic = new ShippersLogic();

                shippersLogic.Add(new Shippers
                {
                    CompanyName = nombre,
                    Phone = telefono
                });

                Console.WriteLine(" ");
                Console.WriteLine("Se agregó");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("La excepción es: " + e.Message);
                Console.ReadKey();
            }
        }

        // Método del Case 4

        public static void ModificarShippers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Modificar Shippers");
                Console.WriteLine(" ");

                ShippersLogic shippersLogic = new ShippersLogic();

                foreach (var item in shippersLogic.GetAll())
                {
                    Console.WriteLine($"ID: {item.ShipperID} - Nombre: {item.CompanyName} - Teléfono: {item.Phone} ");
                }

                Console.WriteLine();
                Console.WriteLine("Modifique el ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Modifique el nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("Modifique el telefono: ");
                string telefono = Console.ReadLine();


                shippersLogic.Update(new Shippers
                {
                    ShipperID = id,
                    CompanyName = nombre,
                    Phone = telefono

                });

                Console.WriteLine(" ");
                Console.WriteLine("Se modificó");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("La excepción es: " + e.Message);
                Console.ReadKey();
            }
        }

        // Método del Case 5

        public static void EliminarShippers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Eliminar Shippers");
                Console.WriteLine(" ");

                ShippersLogic shippersLogic = new ShippersLogic();

                foreach (var item in shippersLogic.GetAll())
                {
                    Console.WriteLine($"ID: {item.ShipperID} // Nombre: {item.CompanyName} // Teléfono: {item.Phone} ");
                }

                Console.WriteLine(" ");
                Console.WriteLine("Ingrese el ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                shippersLogic.Delete(id);
                Console.WriteLine("Se eliminó");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("La excepción es: " + e.Message);
                Console.ReadKey(); ;
            }
        }
        
    }
}
