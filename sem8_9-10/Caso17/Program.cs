using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int aleatorio, Cant1 = 0, Cant2 = 0, Cant3 = 0; 
             
            do
            {
                aleatorio = rnd.Next(5, 501);
                Console.WriteLine(aleatorio);
                
                if (aleatorio < 10)
                    Cant1 ++ ;

                else if (aleatorio < 100)
                    Cant2 ++;
                else
                    Cant3 ++;


            }while (!(aleatorio % 3 == 0 && (aleatorio >= 10 && aleatorio <= 99))) ;


            Console.WriteLine("Cantidad de 1 dígito:" + Cant1);
            Console.WriteLine("Cantidad de 2 dígito:" + Cant2);
            Console.WriteLine("Cantidad de 3 dígito:" + Cant3);
        }
    }
}
