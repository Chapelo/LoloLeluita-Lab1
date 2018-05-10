using System;

namespace P1E1
{
    class Program
    {
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

        static void Main(string[] args)
        {
            // Cambiamos El Color De La Consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            // Variables
            decimal _base = 0m;
            decimal _superficie = 0m;
            bool _cerrarPrograma = false;
            
            
            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();

                Console.Write("Introduzca la base: ");

                if (decimal.TryParse(Console.ReadLine(), out _base))
                {
                    if (_base < 0)
                    {
                        Console.WriteLine("\nERROR: Usted ingreso un numero negativo, por favor ingrese un numero positivo.");
                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");
                    }

                    else
                    {
                        _superficie = _base * (_base * 3) / 2;

                        Console.WriteLine($"\nLa superficie del triangulo rectangulo, cuya altura es el triple de su base, es {_superficie}.");
                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");

                    } // if

                }
                
                else
                {
                    Console.WriteLine("\nERROR: Ingrese un caracter numerico valido, intentelo de nuevo.");
                    Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                    Console.WriteLine("\nPrecione una tecla para reiniciar.");

                } // if

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    _cerrarPrograma = true;
                }

            } // while
        }
    }
}
