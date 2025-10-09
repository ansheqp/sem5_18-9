using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso_funcion2
{
    internal class Program
    {
        static int SumaNumeros(int a, int b)
        {
            int suma;
            suma = a + b;
            return suma;

        }
        //Función sin retorno de valor o función vacía
        static void ImprimeDatos()
        {
            Console.WriteLine("Funciones en C#");

        }
        static void Main(string[] args)
        {
            //Llamamos a la función con retorno y con parámetros
            int sumaValores = SumaNumeros(5, 10);
            //Llamamos a la función tipo VOID o vacío (Sin retorno)
            ImprimeDatos();
            Console.WriteLine("SUMA:" + sumaValores);
                
        }
    }
}
