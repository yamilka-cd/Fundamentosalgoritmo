using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglo para guardar los precios de 5 productos.
            double[] precios = new double[5];

            // Variables para buscar y actualizar el precio.
            double buscado;
            double nuevo;

            // Se inicia en -1 porque todavía no se encontró el precio.
            int posicion = -1;

            // Primer recorrido: registrar los precios.
            for (int i = 0; i < precios.Length; i++)
            {
                Console.Write($"Ingrese el precio del producto {i + 1}: S/ ");
                precios[i] = double.Parse(Console.ReadLine());
            }

            // Solicitamos el precio exacto que se desea buscar.
            Console.Write("\nIngrese el precio a buscar: S/ ");
            buscado = double.Parse(Console.ReadLine());

            // Segundo recorrido: buscar el precio dentro del arreglo.
            for (int i = 0; i < precios.Length; i++)
            {
                if (precios[i] == buscado)
                {
                    posicion = i;
                }
            }

            // Si la posición cambió, significa que el precio fue encontrado.
            if (posicion != -1)
            {
                Console.Write("Ingrese el nuevo precio: S/ ");
                nuevo = double.Parse(Console.ReadLine());

                // Reemplazamos el precio encontrado por el nuevo valor.
                precios[posicion] = nuevo;

                Console.WriteLine("Precio actualizado");
            }
            else
            {
                Console.WriteLine("Precio no encontrado");
            }

            // Mostramos todos los precios del arreglo.
            Console.WriteLine("\n=== LISTA ACTUALIZADA DE PRECIOS ===");

            for (int i = 0; i < precios.Length; i++)
            {
                Console.WriteLine($"Índice {i}: S/ {precios[i]:F2}");
            }
            Console.ReadKey();
        }
    }
}
