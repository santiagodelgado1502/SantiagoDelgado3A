using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar tamano de cuadrado:");
            int tamano = int.Parse(Console.ReadLine());
            for (int i = 0; i < tamano; i++)
            {
                Console.WriteLine("*");
            }
            Console.ReadLine();
        }
    }
}
