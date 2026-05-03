using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double montoInicial;
            double meta;
            double ahorro;
            double interesMensual = 0.015;
            int meses = 0;

            Console.WriteLine("=== CÁLCULO DE INTERES DE AHORRO ===");

            Console.WriteLine($"Ingrese el monto inicial: S/. ");
            montoInicial = double.Parse(Console.ReadLine());

            Console.WriteLine($"Ingrese la meta de ahorro: S/. ");
            meta = double.Parse(Console.ReadLine());

            ahorro = montoInicial;

            while (ahorro < meta)
            {
                ahorro = ahorro + (ahorro * interesMensual);
                meses++;
            }
            Console.WriteLine("\n=== RESULTADO ===");
            Console.WriteLine($"Monto inicial: S/. {montoInicial}");
            Console.WriteLine($"Meta: S/. {meta}");
            Console.WriteLine($"Meses necesarios: {meses}");
            Console.WriteLine($"Monto final: S/. {ahorro}");
        }
    }
}
