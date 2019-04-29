using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta7
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 100;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine((i+1)+"        "+contador);
                contador--;

            }
            Console.ReadLine();
        }
    }
}
