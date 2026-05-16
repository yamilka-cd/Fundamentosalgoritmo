using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            int puntajeJ = 0;
            int puntajePC = 0;
            int ronda = 0;

            do
            {
                ronda++;

                Console.WriteLine($"\n--- Ronda {ronda} ---");
                Console.Write("1=Piedra, 2=Papel, 3=Tijera: ");
                int jugador = int.Parse(Console.ReadLine());

                int pc = rand.Next(1, 4); // Genera valores entre 1 y 3

                Console.WriteLine($"La PC eligió: {pc}");

                if (jugador < 1 || jugador > 3)
                {
                    Console.WriteLine("Opción no válida. La ronda no cuenta.");
                    ronda--;
                }
                else if (jugador == pc)
                {
                    Console.WriteLine("Empate.");
                }
                else if ((jugador == 1 && pc == 3) ||
                         (jugador == 2 && pc == 1) ||
                         (jugador == 3 && pc == 2)) // Condición para que gane el jugador
                {
                    Console.WriteLine("Ganaste esta ronda.");
                    puntajeJ++; // Incrementar puntaje del jugador
                }
                else
                {
                    Console.WriteLine("Ganó la PC.");
                    puntajePC++; // Incrementar puntaje de la PC
                }

                Console.WriteLine($"Marcador: Tú {puntajeJ} - PC {puntajePC}");

            } while (puntajeJ < 3 && puntajePC < 3); // Repetir mientras nadie llegue a 3 puntos

            if (puntajeJ == 3)
            {
                Console.WriteLine("GANASTE EL JUEGO.");
            }
            else
            {
                Console.WriteLine("GANÓ LA COMPUTADORA.");
            }
            Console.ReadKey();
        }
    }
}
