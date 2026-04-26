using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 0)
            {
                Console.WriteLine("ERROR!!! La edad no puede ser negativa...");
            }
            else
            {
                if (edad <= 5)
                {
                    Console.WriteLine("Viaja gratis, no requiere de medio pasaje...");
                }
                else
                {
                    if (edad <= 17)
                    {
                        Console.WriteLine("¿Presenta carnet de estudiante, S/N?");
                        string carnet = Console.ReadLine().ToUpper();
                        if (carnet == "S")
                        {
                            Console.WriteLine("Si accede al medio pasaje escolar");
                        }
                        else
                        {
                            Console.WriteLine("No accede al medio pasaje escolar por que no presento carnet");
                        }

                    }
                    else
                    {
                        Console.WriteLine("No accede al medio pasaje escolar por edad");
                    }

                }
                Console.ReadKey();
            }
        }
    }
}       
