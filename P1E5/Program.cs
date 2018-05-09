using System;

namespace P1E5
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 5
         * 
         * Appelido y nombre:   Chiappelo Bruno
         * DNI:                 40217247
         * 
         */

        static void Main(string[] args)
        {
            // Color De Consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            // Variables
            int _numero = 1;


            // Operaciones
            Console.WriteLine("Numeros del 1 al 10:");
            while (_numero <= 10)
            {
                Console.WriteLine($"\n{_numero}");
                _numero++;

            } // while
            
            Console.WriteLine("\nPrecione una tecla para reiniciar.");
            Console.ReadKey();
        }
    }
}
