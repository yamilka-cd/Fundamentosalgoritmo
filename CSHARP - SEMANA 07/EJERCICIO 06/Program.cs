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
            int votosAna = 0;
            int votosCarlos = 0;
            int votosLucia = 0;
            int votosNulos = 0;
            int voto;
            int totalVotantes;

            do
            {
                Console.WriteLine("\n=== SISTEMA DE VOTACIÓN ===");
                Console.WriteLine("1. Ana Torres");
                Console.WriteLine("2. Carlos Mendoza");
                Console.WriteLine("3. Lucía Paredes");
                Console.WriteLine("0. Cerrar votación");
                Console.Write("Ingrese voto: ");

                voto = int.Parse(Console.ReadLine());

                if (voto == 1)
                {
                    votosAna = votosAna + 1;
                }
                else if (voto == 2)
                {
                    votosCarlos = votosCarlos + 1;
                }
                else if (voto == 3)
                {
                    votosLucia = votosLucia + 1;
                }
                else if (voto != 0)
                {
                    votosNulos = votosNulos + 1;
                }

            } while (voto != 0);

            totalVotantes = votosAna + votosCarlos + votosLucia + votosNulos;

            Console.WriteLine("\n=== RESULTADOS ===");
            Console.WriteLine("Ana Torres: " + votosAna);
            Console.WriteLine("Carlos Mendoza: " + votosCarlos);
            Console.WriteLine("Lucía Paredes: " + votosLucia);
            Console.WriteLine("Votos nulos: " + votosNulos);
            Console.WriteLine("Total de votantes: " + totalVotantes);

            if (votosAna > votosCarlos && votosAna > votosLucia)
            {
                Console.WriteLine("Ganadora: Ana Torres");
            }
            else if (votosCarlos > votosAna && votosCarlos > votosLucia)
            {
                Console.WriteLine("Ganador: Carlos Mendoza");
            }
            else if (votosLucia > votosAna && votosLucia > votosCarlos)
            {
                Console.WriteLine("Ganadora: Lucía Paredes");
            }
            else
            {
                Console.WriteLine("Resultado: EMPATE");
            }
            Console.ReadKey();

        }
    }
}
