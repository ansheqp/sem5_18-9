using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolle un programa que genere números aleatorios de 4 dígitos
            //hasta obtener un numero impar que 1800
            //rnd es un objeto de la clase random

    Random rnd = new Random();
    int aleatorio,suma=0,cantidadPares=0,sumaPares=0, cantidadImpares=0, sumaImpares=0;
    do
    {
        aleatorio=rnd.Next(1000,10000);//genera  un aleatorio
        Console.WriteLine(aleatorio);//imprime el aleatorio

        suma += aleatorio;//suma o acumula aleatorios

        if (aleatorio % 2 == 0)
        {
            cantidadPares++;
            sumaPares += aleatorio;
        }
        else
        {
            cantidadImpares++;
            sumaImpares += aleatorio;
        }
    }while (!(aleatorio%2==1 && aleatorio<1800));

    //imprimimos la suma calculada
    Console.WriteLine("Suma:"+suma);
    Console.WriteLine("Cantidad de pares:"+cantidadPares); 
    Console.WriteLine("Suma de pares:"+sumaPares);
    Console.WriteLine("Cantidad de Impares:" + cantidadImpares);
    Console.WriteLine("Suma de Impares:" + sumaImpares);


        }

    }
}
