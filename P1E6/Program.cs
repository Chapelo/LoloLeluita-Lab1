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
 * Ejercicio:           N° 6
 * 
 * Appelido y nombre:   Chiappelo Bruno
 * DNI:                 40217247
 * 
 */

namespace P1E6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Color De Consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            // Variables
            int _numero = 1;

            Console.Clear();


            // Operaciones
            Console.WriteLine("Listado de numeros con sus respectivos cuadrados:");

            while (_numero <= 100)
            {
                Console.WriteLine($"\nEl cuadrado del numero {_numero} es: {_numero * _numero}");
                _numero++;

            } // while

            Console.WriteLine();
            Console.WriteLine("\nPresione una tecla para finalizar el programa.");
            Console.ReadLine();
        }
    }
}
