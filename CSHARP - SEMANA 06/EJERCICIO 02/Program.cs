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
            double suma = 0;
            int contador = 0;
            double mayor = 0;
            double menor = double.MaxValue;

            Console.WriteLine("Ingrese nota (-1 para terminar): ");
            double nota = double.Parse(Console.ReadLine());

            while (nota != -1)
            {
                if (nota < 0 || nota > 20)
                {
                    Console.WriteLine("Nota invalida!!!. tiene que ser entre 0 y 20");
                }
                else
                {
                    suma = suma + nota;
                    contador++;

                    if (nota > mayor)
                    {
                        mayor = nota;
                    }
                    if (nota < menor)
                    {
                        menor = nota;
                    }
                }
                Console.WriteLine("Ingrese nota (-1 para terminar): ");
                nota = double.Parse(Console.ReadLine());
            }

            if (contador > 0)
            {
                double promedio = suma / contador;
                Console.WriteLine($"Notas ingresadas: {contador}");
                Console.WriteLine($"Nota mas alta: {mayor}");
                Console.WriteLine($"Nota mas baja: {menor}");
                Console.WriteLine($"Promedio: {promedio:F2}");
            }
            else
            {
                Console.WriteLine("No se ingresaron notas validas");
            }
            Console.ReadKey();
        }
    }
}
