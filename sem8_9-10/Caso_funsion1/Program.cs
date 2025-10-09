using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_funsion1
{
    internal class Program
    {
        //función que retorna un entero que es la suma de 2 números 
        static int SumaNumeros()
        {
            int a = 5, b = 10, suma;
            suma = a + b;
            return suma; //La función retorna la suma

        }
        static int RestaNumeros()
        {
            int a = 5, b = 10, resta;
            resta = a - b;
            return resta; //La función retorna la resta

        }
        static int MultiNumeros()
        {
            int a = 5, b = 10, multi;
            multi = a * b;
            return multi; //La función retorna la mmultiplicación

        }
        static int DiviNumeros()
        {
            int a = 5, b = 10, divi;
            divi = a / b;
            return divi; //La función retorna la división

        }
        static void Main(string[] args)
        {
            int sumaNum;
            //Llamamos o invocamos a la función con RETORNO
            sumaNum = SumaNumeros();
            Console.WriteLine("Suma:" + sumaNum);

            int restaNum;
            //Llamamos o invocamos a la función con RETORNO
            restaNum = RestaNumeros();
            Console.WriteLine("Resta:" + restaNum);

            int multiNum;
            //Llamamos o invocamos a la función con RETORNO
            multiNum = MultiNumeros();
            Console.WriteLine("Multiplicación:" + multiNum);

            int diviNum;
            //Llamamos o invocamos a la función con RETORNO
            diviNum = DiviNumeros();
            Console.WriteLine("División:" + diviNum);
        }
    }
}

