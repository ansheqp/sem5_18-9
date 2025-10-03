using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opción;
            int num, suma = 0;

            do
            {
                Console.WriteLine("Ingrese un numero:");
                num=int.Parse(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine(1+" ");
                }
                Console.WriteLine("\nSuma:"+suma);

                Console.WriteLine("\n¿Dese continuar? (Presione N para salir):");
                opción = Console.ReadLine();

            } while (opción!="N");
            

        }
    }
}
