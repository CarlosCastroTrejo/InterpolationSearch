using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Busqueda_por_Interpolacion
{
    class Program
    {

        static int Interpolacion(int[] arreglo, int numero)
        {
            int low = 0;
            int middle = -1;
            int high = arreglo.Length - 1;
            int index = -1;

            while (low <= high)
            {
                middle = low + ((high - low) / (arreglo[high] - arreglo[low])) * (numero-arreglo[low]);

                if (arreglo[middle] == numero)
                {
                    index = middle;
                    return index;
                }
                else
                {
                    if (arreglo[middle] < numero)
                    {
                        low = middle + 1;
                    }
                    else
                    {
                        high = middle - 1;
                    }

                }
            }

            return index;
        }
        static void Main(string[] args)
        {
            int numero = 0,posicion=0;
            Stopwatch reloj = new Stopwatch();

            int[] arreglo = new int[13] { 1, 3, 10, 14, 22, 32, 44, 58, 69, 101, 115, 133, 244 };
            Console.WriteLine("Que numero buscas en el arreglo");
            numero = Convert.ToInt32(Console.ReadLine());

            reloj.Start();
            posicion = Interpolacion(arreglo, numero);
            reloj.Stop();

            Console.WriteLine("\nEl numero que buscas se encuentra en la posicion: "+posicion);
            Console.WriteLine("El algoritmo se tardo: " + reloj.Elapsed);



            Console.ReadLine();

        }
    }
}
