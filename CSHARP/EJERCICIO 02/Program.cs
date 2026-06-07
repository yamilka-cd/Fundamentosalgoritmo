using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de estudiantes: ");
            int n = int.Parse(Console.ReadLine());

            double[] notas = new double[n];
            double suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Nota {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());

                suma = suma + notas[i];
            }

            double nota_minima = notas[0];
            double nota_maxima = notas[0];

            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > nota_maxima)
                {
                    nota_maxima = notas[i];
                }
                if (notas[i] < nota_minima)
                {
                    nota_minima = notas[i];
                }
            }
            Console.WriteLine($"Promedio: {suma / n:F2}");
            Console.WriteLine($"Nota mínima: {nota_minima:F2}");
            Console.WriteLine($"Nota máxima: {nota_maxima:F2}");
            Console.ReadKey();
        }
    }
}
