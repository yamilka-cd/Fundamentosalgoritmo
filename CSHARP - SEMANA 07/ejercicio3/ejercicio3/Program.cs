using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;

            // Validar entrada con do-while
            do
            {
                Console.Write("Ingrese nota (0-20): ");
                nota = int.Parse(Console.ReadLine());

                if (nota < 0 || nota > 20) // Condición de nota inválida
                {
                    Console.WriteLine("Error: nota debe ser entre 0 y 20.");
                }

            } while (nota < 0 || nota > 20); // Repetir mientras la nota sea inválida

            // Clasificar la nota válida
            if (nota >= 18 && nota <= 20) // Excelente
            {
                Console.WriteLine("Clasificación: EXCELENTE");
            }
            else if (nota >= 14 && nota <= 17) // Bueno
            {
                Console.WriteLine("Clasificación: BUENO");
            }
            else if (nota >= 11 && nota <= 13) // Regular
            {
                Console.WriteLine("Clasificación: REGULAR");
            }
            else
            {
                Console.WriteLine("Clasificación: DESAPROBADO");
            }
        }
    }
}
