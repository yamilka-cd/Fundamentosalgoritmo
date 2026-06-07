using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglo para guardar la asistencia de 5 sesiones.
            int[] asistencia = new int[5];

            // Variable lógica para saber si existe una sesión con 0 asistentes.
            bool existeCero = false;

            // Variables para modificar una asistencia.
            int indiceModificar;
            int nuevoValor;

            // =====================================================
            // 1. REGISTRAR LA ASISTENCIA DE CADA SESIÓN
            // =====================================================

            for (int i = 0; i < asistencia.Length; i++)
            {
                Console.Write($"Ingrese la asistencia de la sesión {i}: ");
                asistencia[i] = int.Parse(Console.ReadLine());
            }

            // =====================================================
            // 2. MOSTRAR TODAS LAS ASISTENCIAS REGISTRADAS
            // =====================================================

            Console.WriteLine("\n=== ASISTENCIAS REGISTRADAS ===");

            for (int i = 0; i < asistencia.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {asistencia[i]} asistentes");
            }

            // =====================================================
            // 3. VERIFICAR SI ALGUNA SESIÓN TUVO 0 ASISTENTES
            // =====================================================

            for (int i = 0; i < asistencia.Length; i++)
            {
                if (asistencia[i] == 0)
                {
                    existeCero = true;
                }
            }

            if (existeCero)
            {
                Console.WriteLine("\nAlerta: existe una sesión con 0 asistentes");
            }
            else
            {
                Console.WriteLine("\nNo hay sesión con 0 asistentes");
            }

            // =====================================================
            // 4. MODIFICAR UNA ASISTENCIA INDICANDO SU ÍNDICE
            // =====================================================

            Console.Write("\nIngrese el índice de la sesión que desea modificar: ");
            indiceModificar = int.Parse(Console.ReadLine());

            if (indiceModificar >= 0 && indiceModificar < asistencia.Length)
            {
                Console.Write("Ingrese el nuevo valor de asistencia: ");
                nuevoValor = int.Parse(Console.ReadLine());

                asistencia[indiceModificar] = nuevoValor;
            }
            else
            {
                Console.WriteLine("Índice no válido");
            }

            // =====================================================
            // 5. MOSTRAR LAS ASISTENCIAS ACTUALIZADAS
            // =====================================================

            Console.WriteLine("\n=== ASISTENCIAS ACTUALIZADAS ===");

            for (int i = 0; i < asistencia.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {asistencia[i]} asistentes");
            }

            Console.ReadKey();
        }
    }
}
