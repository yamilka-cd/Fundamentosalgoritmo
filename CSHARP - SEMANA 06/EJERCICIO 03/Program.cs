using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stock = 500;
            int totalVendido = 0;

            Console.WriteLine("Unidades vendidas (0 para salir): ");
            int venta = int.Parse(Console.ReadLine());

            while (venta != 0)
            {
                if (venta < 0)
                {
                    Console.WriteLine("Error: cantidad no puede ser negativa");
                }
                else if (venta > stock)
                {
                    Console.WriteLine($"Error: stock insuficiente, quedan {stock}");
                }
                else
                {
                    stock = stock - venta;
                    totalVendido++;

                    Console.WriteLine($"Venta registrada. stock: {stock}");
                }
                Console.WriteLine("Unidades vendidas (0 para salir): ");
                venta = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Stock restante: {stock}");
            Console.WriteLine($"Total vendido: {totalVendido}");
            Console.ReadKey();
        }
    }
}
