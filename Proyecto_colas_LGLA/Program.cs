using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_colas_LGLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cola cola = null;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("------MENU Colas------");
                Console.WriteLine("1.- Establecer Tamaño");
                Console.WriteLine("");
                Console.WriteLine("2.- Insert");
                Console.WriteLine("");
                Console.WriteLine("3.- Extract");
                Console.WriteLine("");
                Console.WriteLine("4.- Count");
                Console.WriteLine("");
                Console.WriteLine("5.- Imprimir");
                Console.WriteLine("");
                Console.WriteLine("6.- Salir");
                Console.WriteLine("-----------------------");
                Console.Write("Seleccionar Opción => ");
                Console.WriteLine("");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa el tamaño de la cola: ");
                        int count = Convert.ToInt32(Console.ReadLine());
                        cola = new cola(count);
                        Console.WriteLine();
                        break;

                    case 2:
                        if (cola == null)
                        {
                            Console.WriteLine("Primero establece el tamaño de la cola");
                        }
                        else
                        {
                            Console.Write("Ingresa el número que quieres insertar: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            if (cola.Insert(num))
                                Console.WriteLine("El elemento se inserto");
                        }
                        break;

                    case 3:
                        if (cola == null)
                        {
                            Console.WriteLine("La cola esta vacia");
                        }
                        else
                        {
                            cola.Extract();
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        if (cola == null)
                        {
                            Console.WriteLine("La cola esta vacia");
                        }

                        cola.Count();
                        Console.ReadKey();
                        break;

                    case 5:
                        if (cola == null)
                        {
                            Console.WriteLine("Primero llena la cola");
                        }
                        else
                        {
                            cola.Print();
                        }
                        break;

                    case 6:
                        exit = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

            }
        }
    }
}
