using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proyecto_colas_LGLA
{
    internal class cola
    {
        private nodo inicio;
        private int count = 0;
        private int MAX;

        public cola(int max)
        {
            MAX = max;
            inicio = null;
        }

        private bool underflow()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        private bool overflow()
        {
            if (count == MAX)
                return true;
            else
                return false;
        }

        public void Print()
        {
            if (underflow())
            {
                Console.WriteLine("La cola esta vacia");
                return;
            }
            nodo act = inicio;
            Console.WriteLine("Los elementos de la cola son:");
            while (act != null)
            {
                Console.Write(act.Valor + " ");
                act = act.Sig;
            }
            Console.WriteLine();

        }

        public int Count()
        {
            nodo act = inicio;
            count = 0;
            while (act != null)
            {
                count++;
                act = act.Sig;
            }
            Console.WriteLine($"La cola tiene {count} Nodos");
            return count;
        }

        public bool Insert(int num)
        {
            if (overflow())
            {
                Console.WriteLine("La cola esta llena");
                return false;
            }
            else
            {
                nodo nuevoNodo = new nodo(num);
                if (underflow())
                {
                    inicio = nuevoNodo;
                }
                else
                {
                    nodo act = inicio;
                    while (act.Sig != null)
                    {
                        act = act.Sig;
                    }
                    act.Sig = nuevoNodo;
                }
                count++;
                return true;
            }
            //regresa true al insertar exitosamente
            //false si la cola esta llena y no se pudo insertar
        }

        public int Extract()
        {
            if (underflow())
            {
                Console.WriteLine("No se pudo extraer");
                return -1;
            }

            int valor = inicio.Valor;
            inicio = inicio.Sig;
            count--;
            Console.WriteLine($"Elemento extraído: {valor}");
            return valor;



            //regresa el valor extraido de la cola
            //si esta vacia regresa -1 porque no pudo extraer
        }
    }
 }

