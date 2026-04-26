using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas_extras;
            double sueldo_bruto, sueldo_neto, total_planilla = 0;

            Console.WriteLine("Ingresar la cantidad de empleados: ");
            int numero_empleados = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero_empleados; i++)
            {
                Console.WriteLine($"Empleado {i}");
                Console.WriteLine($"Nombre del empleado: ");
                string nombres = Console.ReadLine();

                Console.WriteLine("Ingresar las horas trabajadas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.WriteLine("----- BOLETA DEL EMPLEADO -----");

                if (horas <= 160)
                {
                    sueldo_bruto = horas * 12.50;
                    horas_extras = 0;
                }
                else
                {
                    horas_extras = horas - 160;
                    sueldo_bruto = 160 * 12.50 + horas_extras * 25;
                }

                double descuento = sueldo_bruto * 0.05;
                sueldo_neto = sueldo_bruto - descuento;
                total_planilla = total_planilla + sueldo_neto;

                
                Console.WriteLine($"Nombre: {nombres}");
                Console.WriteLine($"Horas normales: {horas}");
                Console.WriteLine($"Horas extras: {horas_extras}");
                Console.WriteLine($"Sueldo bruto: S/. {sueldo_bruto}");
                Console.WriteLine($"Descuento: S/. {descuento}");
                Console.WriteLine($"Sueldo neto: S/. {sueldo_neto}");
                Console.WriteLine("----- BOLETA DEL EMPLEADO -----");
            }
            Console.WriteLine($"Total planilla: S/. {total_planilla}");
            Console.ReadKey();
        }
    }
}
