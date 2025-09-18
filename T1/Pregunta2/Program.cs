using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cat;
            double pension,prom, descuento,nuevaPension;
            

            Console.WriteLine("Ingrese la categoría:");
            cat=Console.ReadLine();

            Console.WriteLine("Ingrese el promedio:");
            prom=double.Parse(Console.ReadLine());

            //Calcular pension

            if (cat == "A")
                pension = 550;
            else if (cat == "B")
                pension = 500;
            else if (cat == "C")
                pension = 460;
            else 
                pension = 400;

            //Calcular promedio

            if (prom >= 0 && prom <= 13.99)
                descuento = 0;
            else if (prom <= 15.99)
                descuento = 0.10 * pension;
            else if (prom <= 17.99)
                descuento = 0.12 * pension;
            else 
                descuento =0.15*pension;

            //Calcular nueva pension
            nuevaPension = pension - descuento;

            //Resultados
            Console.WriteLine("Pension:" + pension);
            Console.WriteLine("Descuento:" + descuento);
            Console.WriteLine("Nueva Pension:" + nuevaPension);


        }
    }
}
