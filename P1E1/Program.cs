using System;

/*
 * Universidad Tecnologica Nacional
 * Tecnicatura Superior En Programacion
 * Laboratorio 1 Com. 2
 * 
 * Trabajo Pactico:     N° 1
 * Ejercicio:           N° 1
 * 
 * Appelido y nombre:   Chiappelo Bruno
 * DNI:                 40217247
 * 
 */

namespace P1E1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cambiamos El Color De La Consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            // Variables
            decimal _base = 0m;
            decimal _superficie = 0m;
            bool _bandera = false;
            
            
            // Operaciones
            while (_bandera == false)
            {
                Console.Clear();

                Console.Write("Introduzca la base: ");

                if (decimal.TryParse(Console.ReadLine(), out _base))
                {
                    _superficie = _base * (_base * 3) / 2;

                    Console.WriteLine($"\nLa superficie del triangulo rectangulo, cuya altura es el triple de su base, es {_superficie}.");
                    Console.WriteLine("\nPrecione una tecla para reiniciar");
                }
                
                else
                {
                    Console.WriteLine("\nERROR: Ingrese un caracter numerico valido, intentelo de nuevo.");
                    Console.WriteLine("\nPrecione una tecla para reiniciar");

                } // if
                
                Console.ReadKey();

            } // while

            _bandera = true;
        }
    }
}
