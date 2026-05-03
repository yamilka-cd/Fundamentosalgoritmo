using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 1000.00;
            int retiros = 0;

            Console.WriteLine("=== CAJERO AUTOMATICO ===");
            Console.WriteLine($"Saldo disponible: S/. {saldo:F2}");

            Console.WriteLine("Monto a retirar (0 para salir)");
            double monto = double.Parse( Console.ReadLine() );

            while (monto != 0)
            {
                if (monto < 0)
                {
                    Console.WriteLine("Error monto invalido!!!");
                }
                else if (monto > saldo)
                {
                    Console.WriteLine("Error saldo insuficiente!!!");
                }
                else
                {
                    saldo = saldo - monto;
                    retiros = retiros + 1;

                    Console.WriteLine($"Retiro exitoso. saldo: S/. {saldo:F2}");
                }

                Console.WriteLine("Monto a retirar (0 para salir)")
                monto = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("--- RESUMEN ---");
            Console.WriteLine($"Retiros realizados: {retiros}");
            Console.WriteLine($"Saldo final: S/. {saldo:F2}");
            Console.ReadKey();
        }
    }
}
