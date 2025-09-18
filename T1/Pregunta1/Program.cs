using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Pregunta1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ang;
            string clasi;

            Console.WriteLine("Angulo:");
            ang= double.Parse(Console.ReadLine());

            if (ang >= 0 && ang <= 360)
            {
                if (ang == 0)
                    clasi = "Nulo";
                else if (ang < 90)
                    clasi = "Agudo";
                else if (ang == 90)
                    clasi = "Agudo";
                else if (ang == 180)
                    clasi = "Llano";
                else if (ang < 360)
                    clasi = "Concavo";
                else
                    clasi = "Completo";
                Console.WriteLine("El angulo es:"+ clasi);
            }
            else
                Console.WriteLine("Angulo incorrecto!!!");
            Console.ReadLine();
        }
    }
}
