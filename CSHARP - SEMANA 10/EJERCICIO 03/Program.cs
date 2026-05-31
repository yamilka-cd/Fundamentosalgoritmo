using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_03
{
    internal class Program
    {
        static double obtenerTarifa(int opcion)
        {
            if (opcion == 1)
            {
                return 30;
            }
            else if (opcion == 2)
            {
                return 60;
            }
            else if (opcion == 3)
            {
                return 90;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== SERVICIO TÉCNICO ===");
            Console.WriteLine("1. Diagnóstico - S/30");
            Console.WriteLine("2. Mantenimiento - S/60");
            Console.WriteLine("3. Reparación - S/90");

            Console.WriteLine("Ingrese una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            double tarifa = obtenerTarifa(opcion);

            if (tarifa == 0)
            {
                Console.WriteLine("Datos no válidos.");
                return;
            }
            Console.WriteLine("Cantidad de equipos: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (cantidad > 0)
            {
                double total = cantidad * tarifa;
                Console.WriteLine($"Total a pagar: S/{total:F2}");
            }
            else
            {
                Console.WriteLine("Datos no válidos.");
            }
            Console.ReadKey();
        }
    }
}
