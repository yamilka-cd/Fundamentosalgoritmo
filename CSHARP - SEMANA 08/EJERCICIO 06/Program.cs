using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_06
{
    internal class Program
    {

        static double CalcularCostoAgua(double m3)
        {
            if (m3 <= 20)
            {
                double costo = m3 * 1.80;
                return costo;
            }
            else
            {
                double costo = 20 * 1.80 + (m3 - 20) * 2.50;
                return costo;
            }
        }

        static void MostrarRecibo(double m3, double costo)
        {
            Console.WriteLine($"El consumo en m3 es {m3}");
            Console.WriteLine($"El costo total es {costo}");
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de m3 consumidos: ");
            double m3 = double.Parse( Console.ReadLine() );

            double costo = CalcularCostoAgua(m3);
            MostrarRecibo(m3, costo);

        }
    }
}
