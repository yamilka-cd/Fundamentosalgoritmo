using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglo para guardar el stock de 4 productos.
            int[] stock = new int[4];
            // Primer recorrido: registrar el stock inicial.
            for (int i = 0; i < stock.Length; i++)
            {
                Console.Write($"Stock del producto {i}: ");
                stock[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Índice a modificar: ");
            int indice = int.Parse(Console.ReadLine());
            // Validamos que el índice esté dentro del rango permitido.
            // En este arreglo los índices válidos son 0, 1, 2 y 3.
            if (indice >= 0 && indice < stock.Length)
            {
                Console.Write("Nuevo stock: ");
                int nuevo = int.Parse(Console.ReadLine());
                // Se modifica la posición indicada por el usuario.
                stock[indice] = nuevo;
            }
            else
            {
                Console.WriteLine("Índice no válido");
            }
            Console.WriteLine("\nStock actualizado:");
            // Segundo recorrido: mostrar el arreglo actualizado.
            for (int i = 0; i < stock.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {stock[i]}");
            }
            Console.ReadKey();
        }
    }
}
