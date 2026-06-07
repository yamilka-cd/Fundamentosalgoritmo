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
            string[] estudiantes = new string [3];

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.Write($"El nombre del estudiante {i+1}: ");
                estudiantes[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Estudiantes registrados");

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"Indice {i}: {estudiantes[i]}");
            }
            Console.ReadKey();
        }
    }
}
