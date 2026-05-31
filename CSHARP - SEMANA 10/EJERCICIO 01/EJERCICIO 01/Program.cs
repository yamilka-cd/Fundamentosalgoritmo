using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_01
{
    internal class Program
    {
        static double CalcularSalario(double valorhora, int hora)
        {
            if (hora <= 192)
            {
                return valorhora * hora;
            }
            int horasExtra = hora - 192;
            double pagoNormal = valorhora * hora;
            double pagoExtra = horasExtra * valorhora * 1.50;

            return pagoExtra + pagoNormal;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== PLANILLA INDUSTRIAL =====");

            Console.WriteLine("Ingrese la cantidad de obreros: ");
            int n = int.Parse(Console.ReadLine());

            double total_planilla = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Obrero {i}");

                Console.WriteLine("Valor por hora: ");
                double valor_hora = double.Parse(Console.ReadLine());

                Console.WriteLine("Horas trabajadas: ");
                int horas_trabajadas = int.Parse(Console.ReadLine());

                double salario = CalcularSalario(valor_hora, horas_trabajadas);

                total_planilla = total_planilla + salario;

                Console.WriteLine($"El salario es: {salario:F2}");

            }
            Console.WriteLine($"El total de la planilla es: {total_planilla:F2}");
            Console.ReadKey();
        }
    }
}
