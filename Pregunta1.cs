using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiagoDelgado3A.Tarea
{

    public class Pregunta1
    {

        public static void Main(String[] args)
        {
            int mayor = 0;
            Console.WriteLine("Colocar la cantidad de numeros a ingresar: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingresar numero: ");
                int valor = int.Parse(Console.ReadLine());
                if (mayor < valor)
                {
                    mayor = valor;
                }


            }
            Console.WriteLine("El numero mayor es: " + mayor);
            Console.ReadLine();
        }


    }
}
