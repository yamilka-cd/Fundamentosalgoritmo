using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_02
{
    internal class Program
    {
        static double CalcularImporte(int cantidad, double precio)
        {
            return cantidad * precio;
        }
        static void MostrarPedido(string plato, int cantidad, double importe)
        {
            Console.WriteLine($"Pedido: {plato} | Cantidad: {cantidad} | Importe: S/{importe:F2}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== CONTROL DE PEDIDOS DEL DÍA ===");

            double total_dia = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Pedido {i}");

                Console.WriteLine("Ingrese el nombre del plato: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Precio unitario: ");
                double unitario = double.Parse(Console.ReadLine());

                double importe = CalcularImporte(cantidad, unitario);

                total_dia = total_dia + importe;

                MostrarPedido(nombre, cantidad, importe);
            }
            Console.WriteLine($"Total dia: {total_dia}");
            Console.ReadKey();
        }
    }
}
