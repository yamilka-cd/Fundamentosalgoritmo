using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_05
{
    internal class Program
    {
        static double calcularPorcentaje(double presentes, double matriculados)
        {
            return presentes * 100 / matriculados;
        }

        static void Main(string[] args)
        {
            double suma_porcentaje = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Ingrese la cantidad de alumnos presentes: ");
                double presentes = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de alumnos matriculados: ");
                double matriculados = double.Parse(Console.ReadLine());

                double porcentaje = calcularPorcentaje(presentes, matriculados);

                Console.WriteLine($"El porcentaje es {porcentaje}%");

                suma_porcentaje = suma_porcentaje + porcentaje;
            }
            double promedio = suma_porcentaje / 4;

            Console.WriteLine($"El promedio de asistencia es {promedio:F2}%");

            if (promedio >= 75)
            {
                Console.WriteLine("Participacion Adecuada");
            }
            else
            {
                Console.WriteLine("Reforzar asistencia");
            }
            Console.ReadKey();
        }
    }
}
