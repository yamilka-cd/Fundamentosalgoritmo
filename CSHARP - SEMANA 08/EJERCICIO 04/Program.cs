using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_04
{
    internal class Program
    {
        static double TipoCambio = 3.75;

        static double PorcentajeComision = 2;

        static double CalcularComision(double soles)
        {
            double comision = soles * PorcentajeComision / 100;
            return comision;
        }

        static double CalcularSolesNetos(double soles, double comision)
        {
            double SolesNeto = soles - comision;
            return SolesNeto;
        }

        static double ConvertirADolares(double SolesNeto)
        {
            double dolares = SolesNeto / TipoCambio;
            return dolares;
        }

        static void MostrarComprobante(double soles, double comision, double SolesNeto, double dolares)
        {
            Console.WriteLine("===== BOLETA =====");
            Console.WriteLine($"Monto ingresado: {soles:F2}");
            Console.WriteLine($"Comision 2%: {comision:F2}");
            Console.WriteLine($"Soles neto a cambiar: {SolesNeto:F2}");
            Console.WriteLine($"Dolares recibidos: {dolares:F2}");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("CASA DE CAMBIO");
            Console.WriteLine("Ingrese el monto en soles: ");
            double soles = double.Parse( Console.ReadLine() );

            double comision = CalcularComision(soles);
            double SolesNeto = CalcularSolesNetos(soles, comision);
            double dolares = ConvertirADolares(SolesNeto);
            MostrarComprobante(soles, comision, SolesNeto, dolares);

        }

    }
}
