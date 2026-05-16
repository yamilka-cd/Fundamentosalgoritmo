using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_02
{
    internal class Program
    {
        static double NotaAprobatoria = 11;

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota 1");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 3");
            double nota3 = double.Parse(Console.ReadLine());

            double promedio = CalcularPromedio(nota1, nota2, nota3);

            string estado = ClasificarEstudiante(promedio);

            MostrarReporte(promedio, estado);
            Console.ReadKey();

        }

        static double CalcularPromedio(double nota1, double nota2, double nota3)
        {
            double promedio = (nota1 + nota2 + nota3) / 3;
            return promedio;
        }

        static string ClasificarEstudiante(double promedio)
        {
            if (promedio >= NotaAprobatoria)
            {
                return "Aprobado";
            }
            else
            {
                return "Desaprobado";
            }
        }
        static void MostrarReporte(double promedio,string estado)
        {
            Console.WriteLine("===== REPORTE DE NOTAS =====");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Estado: {estado}");

        }

    }
}
