using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double precio_unitario = 5;

            Console.WriteLine("Cantidad | Subtotal | descuento | total");
            Console.WriteLine("-------- | -------- | --------- | -----");

            for (int cantidad = 1; cantidad <= 20; cantidad++)
            {
                double subtotal = cantidad * precio_unitario;
                double descuento;

                if(cantidad <= 5)
                {
                    descuento = 0;
                }
                else if(cantidad <= 12)
                {
                    descuento = 0.10;
                }
                else
                {
                    descuento = 0.20;
                }

                double total = subtotal * (1 - descuento);

                Console.WriteLine($"{cantidad}       | S/. {subtotal}    | {descuento * 100}         | S/. {total}");
            }
            Console.ReadKey();
        }
    }
}
