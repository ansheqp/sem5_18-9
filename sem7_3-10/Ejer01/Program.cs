using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secreto = rnd.Next(1, 21);
            int intentos = 3;


             Console.WriteLine("***********************************************************************************");
             Console.WriteLine("*                                                                                 *");
             Console.WriteLine("*                    BIENVENIDOS  AL  JUEGO  ADIVINADOR                           *");
             Console.WriteLine("*                                                                                 *");
             Console.WriteLine("*  1. Usted deberá adivinar el numero entre 1 y 20                                *");
             Console.WriteLine("*  2. Usted tiene tres intentos                                                   *");
             Console.WriteLine("*  3. Por cada falla se dará una pista                                            *");
             Console.WriteLine("***********************************************************************************");


            do
            {

                Console.WriteLine($"Ingrese numero(intento{intentos}):");
                int num=int.Parse(Console.ReadLine());

                if (num == secreto)
                {
                    Console.WriteLine("Felicidad. Adivinaste!!");
                    return;
                }
                else
                {
                    intentos--;
                    if (num < secreto)
                        Console.WriteLine("El numero es mayor");
                    else
                        Console.WriteLine("El numero es menor");
                }



            }while (intentos>0);
            Console.WriteLine("\nNo lograste adivinar el numero" + secreto);
            
        
        }
    }
}
