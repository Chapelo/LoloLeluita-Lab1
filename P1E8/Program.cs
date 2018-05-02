using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Tecnicatura Superior En Programacion
 * Laboratorio 1 Com. 2
 * 
 * Trabajo Pactico:     N° 1
 * Ejercicio:           N° 8
 * 
 * Appelido y nombre:   Chiappelo Bruno
 * DNI:                 40217247
 * 
 */

namespace P1E8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Color De Consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            // Variables
            decimal _numero = 1;

            Console.Clear();

            // Operaciones
            Console.WriteLine("Listado de numeros impares del 1 al 999:");
            Console.WriteLine();

            while (_numero < 1000)
            {
                // Console.WriteLine(_numero);  --> // Para verlos uno debajo del otro
                Console.Write($" {_numero} ");      // Para verlos uno al lado del otro
                _numero += 2;

            } // while

            Console.WriteLine();
            Console.WriteLine("\nPresione una tecla para ver los numeros pares del 2 al 1000.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Listado de numeros pares del 2 al 1000:");
            Console.WriteLine();

            _numero = 2;

            while (_numero <= 1000)
            {
                // Console.WriteLine(_numero);  --> // Para verlos uno debajo del otro
                Console.Write($" {_numero}");      // Para verlos uno al lado del otro
                _numero += 2;

            } // while

            Console.WriteLine();
            Console.WriteLine("\nPresione una tecla para cerrar el programa.");

            Console.ReadKey();
        }
    }
}
