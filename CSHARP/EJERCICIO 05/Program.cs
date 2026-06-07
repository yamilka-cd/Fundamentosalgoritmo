using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[7];
            int dia_encontrado = -1;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"INGRESE LA TEMPERATURA DEL DIA {i+1}: ");
                temperaturas[i] = double.Parse(Console.ReadLine());

            }
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > 30 && dia_encontrado == -1)
                {
                    dia_encontrado = i;
                }
            }
            if (dia_encontrado != -1)
            {
                Console.WriteLine($"Primera alerta del dia, {dia_encontrado + 1}");
            }
            else
            {
                Console.WriteLine("No hubo alerta de temperatura");
            }
            Console.ReadKey();
        }
    }
}
