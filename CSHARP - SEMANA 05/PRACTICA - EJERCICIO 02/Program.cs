using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el consumo en kwh");
            int kwh = int.Parse(Console.ReadLine());

            double monto = 0;

            if(kwh <= 0)
            {
                Console.WriteLine("ERROR!!! el consumo debe ser positivo...");
            }
            else if(kwh <= 100)
            {
                monto = kwh * 0.50;
            }
            else if(kwh <= 300)
            {
                monto = 100 * 0.50 + (kwh - 100) * 0.75;
            }
            else
            {
                monto = 100 * 0.50 + 200 * 0.75 + (kwh - 300) * 1.20;
            }
            Console.WriteLine($"Monto a pagar es: {monto}");
            Console.ReadKey();

        }
    }
}
