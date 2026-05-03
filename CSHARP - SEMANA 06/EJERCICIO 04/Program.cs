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
            Random rand = new Random();
            int secreto = rand.Next(0, 51);

            int intentos = 0;
            int maxIntentos = 7;
            bool adivino = false;

            Console.WriteLine("Adivina el numero entre 1 y 50, tienes 7 intentos: ");

            while (intentos < maxIntentos && adivino == false)
            {
                intentos++;
                Console.WriteLine($"Intento: {intentos}");
                int intento = int.Parse(Console.ReadLine());

                if (intento == secreto)
                {
                    adivino = true;
                }
                else if (intento < secreto)
                {
                    Console.WriteLine("El numero secreto es MAYOR");
                }
                else
                {
                    Console.WriteLine("El numero secreto es MENOR");
                }
            }
            if (adivino == true)
            {
                Console.WriteLine($"Ganaste en {intentos} intentos.");
            }
            else
            {
                Console.WriteLine($"Perdiste, el numero secreto era {secreto}");
            }
            Console.ReadKey();
        }
    }
}
