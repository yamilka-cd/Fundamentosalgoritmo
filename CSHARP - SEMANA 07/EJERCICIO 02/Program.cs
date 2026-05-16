using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string claveCorrecta = "UPN2026";
            int maxIntentos = 3;
            int intentos = 0;
            bool acceso = false;

            string clave;

            do
            {
                intentos = intentos + 1;

                Console.Write($"Intento {intentos}/{maxIntentos} - Clave: ");
                clave = Console.ReadLine();

                if (clave == claveCorrecta)
                {
                    acceso = true;
                }
                else
                {
                    int restantes = maxIntentos - intentos;

                    if (restantes > 0)
                    {
                        Console.WriteLine($"Clave incorrecta. Quedan {restantes} intentos.");
                    }
                }

            } while (!acceso && intentos < maxIntentos);

            if (acceso)
            {
                Console.WriteLine("Acceso concedido. Bienvenido.");
            }
            else
            {
                Console.WriteLine("Cuenta bloqueada. Contacte al administrador.");
            }
            Console.ReadKey();
        }
    }
}
