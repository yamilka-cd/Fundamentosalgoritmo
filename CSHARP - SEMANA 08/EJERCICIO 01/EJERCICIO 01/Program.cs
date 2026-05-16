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
            Console.WriteLine("Ingrese la cantidad comprada: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio unitario");
            double precioUnitario = double.Parse(Console.ReadLine());

            double subtotal = CalcularSubtotal(cantidad, precioUnitario);
            double igv = Calcularigv(subtotal);
            double total = CalcularTotal(subtotal, igv);

            Console.WriteLine("===== BOLETA DE VENTA =====");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Precio unitario: {precioUnitario}");
            Console.WriteLine($"Subtotal: {subtotal}");
            Console.WriteLine($"IGV: {igv}");
            Console.WriteLine($"Total: {total}");
            Console.ReadKey();

        }

        static double CalcularSubtotal(int cantidad, double precioUnitario)
        {
            double subtotal = cantidad * precioUnitario;
            return subtotal;
        }

        static double Calcularigv(double subtotal)
        {
            double igv = 0.18 * subtotal;
            return igv;
        }
        static double CalcularTotal(double subtotal, double igv)
        {
            double total = subtotal + igv;
            return total;
        }
    }
}
