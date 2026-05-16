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
            double subtotal = 0, igv, total;
            int platos = 0;

            int opcion;

            do
            {
                Console.WriteLine("===== MENU DEL RESTAURANTE =====");
                Console.WriteLine("1. LOMO SALTADO a 25 soles");
                Console.WriteLine("2. CEVICHE a 30 soles");
                Console.WriteLine("3. AJI DE GALLINA a 20 soles");
                Console.WriteLine("4. POLLO A LA BRASA a 35 soles");
                Console.WriteLine("0. PEDIR LA CUENTA...");
                Console.WriteLine("Elija una opcion!!!");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    subtotal = subtotal + 25;
                    platos++;
                    Console.WriteLine("Agregado LOMO SALTADO");
                }
                else if (opcion == 2)
                {
                    subtotal = subtotal + 30;
                    platos++;
                    Console.WriteLine("Agregado CEVICHE");
                }
                else if (opcion == 3)
                {
                    subtotal = subtotal + 20;
                    platos++;
                    Console.WriteLine("Agregado AJI DE GALLINA");
                }
                else if (opcion == 4)
                {
                    subtotal = subtotal + 35;
                    platos++;
                    Console.WriteLine("Agregado POLLO A LA BRASA");
                }
                else if (opcion != 0)
                {
                    Console.WriteLine("Opcion invalida...");
                }
            } while (opcion != 0);

            igv = 0.18 * subtotal;
            total = subtotal + igv;

            Console.WriteLine("===== VENTA =====");
            Console.WriteLine($"Platos pedidos: {platos}");
            Console.WriteLine($"Sub total: {subtotal:F2}");
            Console.WriteLine($"IGV: {igv:F2}");
            Console.WriteLine($"Total: {total:F2}");
            Console.ReadKey();
        }
    }
}
