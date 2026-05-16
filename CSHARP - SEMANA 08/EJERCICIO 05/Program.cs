using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_05
{
    internal class Program
    {

        static bool NotaValida(double nota)
        {
            if (nota >= 0 && nota <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string ClasificarNota(double nota)
        {
            if (nota >= 18)
            {
                return "EXCELENTE";
            }
            else if (nota >= 14)
            {
                return "BUENO";
            }
            else if (nota >= 11)
            {
                return "REGULAR";
            }
            else
            {
                return "DESAPROBADO";
            }
        }

        static void MostrarReporte(double nota, string clasificacion)
        {
            Console.WriteLine($"Nota ingresada: {nota}");
            Console.WriteLine($"Clasificacion: {clasificacion}");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota del alumno: ");
            double nota = double.Parse(Console.ReadLine());

            if (NotaValida(nota))
            {
                string clasificacion = ClasificarNota(nota);
                MostrarReporte(nota, clasificacion);
            }
            else
            {
                Console.WriteLine("ERROR!!!, la nota debe estar entre 0 y 20...");
            }
        }
    }
}
