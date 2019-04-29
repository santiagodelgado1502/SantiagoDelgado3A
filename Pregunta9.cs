using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta9
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicacion = 0;
            Console.WriteLine("Ingresar valor para hacer la tabla:");
            int valor=int.Parse(Console.ReadLine());
            for (int i = 0; i <= 15; i++)
            {
                multiplicacion = i * valor;
                Console.WriteLine((i)+"  x  "+valor+"=  "+multiplicacion);
            }
            Console.ReadLine();
        }
    }
}
