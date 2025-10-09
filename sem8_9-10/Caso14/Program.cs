using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolle un programa que muestre los siguientes valores:
            //3,6,9,12,...,39,42,45

            /*
            for (int i = 3;i<=45;i+=3)
            {
                Console.WriteLine(i);
            }
            */


            /*
            int i = 3;
            while (i <= 45)
            {
                Console.WriteLine(i);
                i += 3;
            }
            */


            int i = 3;
            do
            {
                Console.WriteLine(i);
                i += 3;
            }
            while (i <= 45);
        }
    }
}
