using System;

namespace P1E9
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 9
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
            double _base = 0;
            double _exponente = 0;
            double _resultado = 0;

            bool _bandera = false;


            // Operaciones
            _exponente = 0;
            _base = 2;
            _resultado = _base;

            while (_bandera == false)
            {
                Console.Clear();
                Console.Write("Ingrese la potencia que desea para elevar el numero 2: ");

                if (double.TryParse(Console.ReadLine(), out _exponente))
                {
                    if (_exponente > 0)
                    {
                        _resultado = Math.Pow(_base, _exponente);

                        Console.WriteLine($"\nEl resultado de {_base} elevado a la potencia {_exponente} es: {_resultado}.");
                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");
                    }
                    
                    else if (_exponente == 0)
                    {
                        Console.WriteLine($"\nEl resultado de {_base} elevado a la potencia {_exponente} es: 1.");
                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");
                    }

                    else if (_exponente < 0)
                    {
                        Console.WriteLine($"\nERROR: Usted ingreso un numero negativo, por favor ingrese un numero positivo.");
                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");

                    } // if

                }

                else
                {
                    Console.WriteLine("\nERROR: Ingrese un caracter numerico valido.");
                    Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                    Console.WriteLine("\nPrecione una tecla para reiniciar.");

                } // if

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }

            } // while
            
        }
    }
}
