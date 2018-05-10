using System;

namespace P1E12
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 12
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
            int _numero = 0;

            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();
                Console.Write("Ingrese un numero par para conocer sus anteriores pares: ");

                if (int.TryParse(Console.ReadLine(), out _numero) && _numero % 2 == 0)
                {
                    if (_numero > 0)
                    {
                        Console.WriteLine($"\nLos numeros pares anteriores son:");
                        for (int _i = _numero; _i >= 2; _i -= 2)
                        {
                            Console.WriteLine($"\n{_i}");

                        } // for

                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");
                    }

                    else if (_numero < 0)
                    {
                        Console.WriteLine("\nERROR: Usted ingreso un numero negativo, por favor ingrese un numero positivo.");
                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");

                    } // if
                }

                else
                {
                    Console.WriteLine("\nERROR: Introduzca un caracter numerico valido.");
                    Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                    Console.WriteLine("\nPrecione una tecla para reiniciar.");

                } // if

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    _cerrarPrograma = true;

                } // if

            } // while
        }
    }
}
