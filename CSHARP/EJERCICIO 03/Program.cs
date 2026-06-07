using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] codigos = new int[5];

            for (int i = 0; i < codigos.Length; i++)
            {
                Console.Write($"Codigo {i+1}: ");
                codigos[i] = int.Parse( Console.ReadLine() );
            }
            Console.WriteLine("Codigo a buscar: ");
            int buscado = int.Parse( Console.ReadLine() );

            // Se inicia en -1 porque todavía no se ha encontrado el código.
            // Si después de buscar sigue en -1, significa que no existe.
            int posicion = -1; // SERIA COMO UN VACIO EN EL ARREGLO

            for (int i = 0; i < codigos.Length; i++)
            {
                // Comparamos el código actual con el código buscado.
                if (codigos[i] == buscado)
                {
                    // Guardamos el índice donde se encontró el código.
                    posicion = i;
                }
            }

            // Si posición cambió, significa que el código fue encontrado.
            if (posicion != -1)
            {
                Console.WriteLine($"Código encontrado en índice {posicion}");
            }
            else
            {
                Console.WriteLine("Código no encontrado");
            }
            Console.ReadKey();
        }
    }
}
