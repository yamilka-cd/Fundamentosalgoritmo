using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_03
{
    internal class Program
    {

        static double CalcularBruto(double horas)
        {
            return horas * 12.50;
        }

        static double CalcularDescuento(double bruto)
        {
            return bruto * 0.05;
        }

        static double CarlcularNeto(double bruto, double descuento)
        {
            return bruto - descuento;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Diga las horas trabajadas: ");
            double horas = double.Parse(Console.ReadLine());

            double bruto = CalcularBruto(horas);
            double descuento = CalcularDescuento(bruto);
            double neto = CarlcularNeto(bruto, descuento);

            Console.WriteLine("===== BOLETA DE SUELDO =====");
            Console.WriteLine($"Sueldo bruto: {bruto:F2}");
            Console.WriteLine($"Descuento 5%: {descuento:F2}");
            Console.WriteLine($"Sueldo neto: {neto:F2}");
            Console.ReadKey();

        }

    }
}
