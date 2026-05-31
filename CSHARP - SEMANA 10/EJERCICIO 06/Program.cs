using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_06
{
    internal class Program
    {
        static double CalcularVentaTurno(int cantidad, double precio)
        {
            return cantidad * precio;
        }
        static void Main(string[] args)
        {
            double totalDia = 0;

            for (int turno = 1; turno <= 3; turno++)
            {
                Console.WriteLine($"Turno {turno}");

                int cantidad;

                do
                {
                    Console.Write("Ingrese la cantidad de productos vendidos: ");
                    cantidad = int.Parse(Console.ReadLine());

                    if (cantidad <= 0)
                    {
                        Console.WriteLine("Error: la cantidad debe ser mayor que 0");
                    }

                } while (cantidad <= 0);

                double precio;

                do
                {
                    Console.Write("Ingrese el precio unitario: ");
                    precio = double.Parse(Console.ReadLine());

                    if (precio <= 0)
                    {
                        Console.WriteLine("Error: el precio debe ser mayor que 0");
                    }

                } while (precio <= 0);

                double venta = CalcularVentaTurno(cantidad, precio);

                totalDia = totalDia + venta;

                Console.WriteLine($"Venta del turno: S/ {venta:F2}");
            }

            Console.WriteLine($"\nTotal vendido del día: S/ {totalDia:F2}");
            Console.ReadKey();
        }
    }
}
