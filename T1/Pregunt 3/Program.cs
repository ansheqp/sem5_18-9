using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Pregunt_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipo;
            int canti, obsequio;
            double descu,precio, impcompra, impago;

            Console.WriteLine("Ingrese el tipo de chocolate :");
            tipo = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad:");
            canti = int.Parse(Console.ReadLine());

            if (canti == 0)
            {
                if (tipo == "Primor")
                    precio = 8.5;
                else if (tipo == "Dulzura")
                    precio = 10.0;
                else if (tipo == "Tentación")
                    precio = 7.0;
                else
                    precio = 12.5;

                //Calcular importe de la compra
                impcompra = canti * precio;

                //Calcular descuento

                if (canti == 5)
                    descu = 0.4 * impcompra;
                else if (canti >= 5 && canti < 10)
                    descu = 0.65 * impcompra;
                else if (canti >= 10 && canti < 15)
                    descu = 0.9 * impcompra;
                else
                    descu = 0.115 * impcompra;


                //calculamos el importe del pago final

                impago = impcompra * descu;

                //calculamos el obsequio

                if (impago >= 250) 
                    obsequio=canti*3;
                else
                    obsequio = canti*2;
                Console.WriteLine("La cantidad de obsequios son:" + obsequio);
                Console.WriteLine("El precio es :" + precio);
                Console.WriteLine("El descuento es:"+descu);
                Console.WriteLine("El precio es:" + precio);
            }
        }
    }
}
