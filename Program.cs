using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pago = 0,Extra=0,Extratotal=0,total=0;
            Console.WriteLine("Ingresar horas trabajadas:");
            int horas = int.Parse(Console.ReadLine());
            if (horas <= 35)
            {
                total = horas * 15;
            }
            else
            {
                Extra = horas - 35;
                Pago = 35 * 15;
                Extratotal = Extra * 22;
                total = Extra + Pago;

            }
            Console.WriteLine("La horas trabajadas son: "+horas);
            Console.WriteLine("Horas extras trabajadas: "+Extra);
            Console.WriteLine("Pago total: "+total);
            Console.ReadLine();
        }
    }
}
