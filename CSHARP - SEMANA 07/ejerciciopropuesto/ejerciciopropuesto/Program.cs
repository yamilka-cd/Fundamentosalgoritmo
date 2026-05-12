using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciopropuesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votosAna = 0, votosCarlos = 0, votosLucia = 0, nulos = 0, voto;
            
            do
            {
                Console.WriteLine("\n***ELECCIONES***");
                Console.WriteLine("1. Ana Torres");
                Console.WriteLine("2. Carlos Mendoza");
                Console.WriteLine("3. Lucía Paredes");
                Console.WriteLine("0. Cerrar votación");

                Console.Write("Ingrese su voto:");
                voto = int.Parse(Console.ReadLine());

                if (voto == 1)
                    votosAna++;
                else if (voto == 2)
                    votosCarlos++;
                else if (voto == 3)
                    votosLucia++;
                else if (voto == 0)
                    Console.WriteLine("Cerrando votación...");
                else
                {
                    nulos++;
                    Console.WriteLine("Voto nulo");
                }

            } while (voto != 0);

            int total = votosAna + votosCarlos + votosLucia + nulos;

            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine($"Ana Torres: {votosAna}");
            Console.WriteLine($"Carlos Mendoza: {votosCarlos}");
            Console.WriteLine($"Lucía Paredes: {votosLucia}");
            Console.WriteLine($"Nulos: {nulos}");
            Console.WriteLine($"Total: {total}");

            if (votosAna > votosCarlos && votosAna > votosLucia)
                Console.WriteLine("Ganadora: Ana Torres");
            else if (votosCarlos > votosAna && votosCarlos > votosLucia)
                Console.WriteLine("Ganador: Carlos Mendoza");
            else if (votosLucia > votosAna && votosLucia > votosCarlos)
                Console.WriteLine("Ganadora: Lucía Paredes");
            else
                Console.WriteLine("Empate");
        }
    }
    
}
