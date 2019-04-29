using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1,suma=0;
            for (int i = 0; i <contador; i++)
            {
                contador++;
                Console.WriteLine("Ingresar cantidad vendida:");
                int cantidad = int.Parse(Console.ReadLine());
                if (cantidad == 0)
                {
                    contador = i;
                }
                else
                {
                    Console.WriteLine("Ingresar el precio del producto:");
                    int precio = int.Parse(Console.ReadLine());
                    int subtotal = cantidad * precio;
                    suma = suma + subtotal;
                    
                }
                
            }
            Console.WriteLine("El total es:" + suma);
            Console.ReadLine();
        }
    }
}
