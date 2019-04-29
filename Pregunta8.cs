using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar numero entero positivo:");
            int numero = int.Parse(Console.ReadLine());
            int contador = 0,contador2=0;
            Console.WriteLine("De uno en uno:");

            for (int i = 0; i <= numero; i++)
            {
                
                Console.WriteLine(i);

            }
            Console.WriteLine("De dos en dos:");

            do
            {
                contador=contador+2;
                Console.WriteLine(contador);
            } while (contador<numero);
            Console.WriteLine("De tres en tres:");
            do
            {
                contador2 = contador2 + 3;
                Console.WriteLine(contador2);
            } while (contador2<numero);
            Console.ReadLine();
        }
    }
}
