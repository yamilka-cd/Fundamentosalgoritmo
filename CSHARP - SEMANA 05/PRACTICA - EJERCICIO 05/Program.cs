using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese número de días: ");
            int dias = int.Parse(Console.ReadLine());

            double total = 0;

            int excelente = 0, bueno = 0, regular = 0, malo = 0;

            double mayorVenta = double.MinValue;
            double menorVenta = double.MaxValue;
            int diaMayor = 0, diaMenor = 0;

            for (int i = 1; i <= dias; i++)
            {
                Console.Write("\nDía " + i + " - Venta: ");
                double venta = double.Parse(Console.ReadLine());

                total = total + venta;

                if (venta >= 500)
                {
                    excelente = excelente + 1;
                }
                else if (venta >= 200)
                {
                    bueno = bueno + 1;
                }
                else if (venta >= 50)
                {
                    regular = regular + 1;
                }
                else
                {
                    malo = malo + 1;
                }

                if (venta > mayorVenta)
                {
                    mayorVenta = venta;
                    diaMayor = i;
                }

                if (venta < menorVenta)
                {
                    menorVenta = venta;
                    diaMenor = i;
                }
            }

            double promedio = total / dias;

            Console.WriteLine("\n----- RESULTADOS -----");
            Console.WriteLine("Total de ventas: S/ " + total);
            Console.WriteLine("Promedio diario: S/ " + promedio);

            Console.WriteLine("Mayor venta: Día " + diaMayor + " con S/ " + mayorVenta);
            Console.WriteLine("Menor venta: Día " + diaMenor + " con S/ " + menorVenta);

            Console.WriteLine("\nClasificación:");
            Console.WriteLine("Excelente: " + excelente);
            Console.WriteLine("Bueno: " + bueno);
            Console.WriteLine("Regular: " + regular);
            Console.WriteLine("Malo: " + malo);

            Console.ReadKey();



        }
    }
}
