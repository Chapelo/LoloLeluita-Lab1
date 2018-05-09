using System;

namespace P1E24
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 24
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
            decimal _base = 0m;
            decimal _altura = 0m;
            decimal _perimetro = 0m;

            decimal _cantidadPostes = 0m;
            decimal _precioPoste = 8m;
            decimal _precioPosteFinal = 0m;

            decimal _cantidadAlambre = 0m;
            decimal _precioAlambre = 0.8m;
            decimal _precioAlambreFinal = 0m;

            decimal _precioFinal = 0m;

            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();

                Console.Write("Ingrese la base del terreno en metros: ");
                if (decimal.TryParse(Console.ReadLine(), out _base) && _base > 0)
                {
                    Console.Write("\nIngrese la altura del terreno en metros: ");
                    if (decimal.TryParse(Console.ReadLine(), out _altura) && _altura > 0)
                    {
                        _perimetro = (_base * 2) + (_altura * 2);

                        _cantidadAlambre = _perimetro * 5;
                        _precioAlambreFinal = _cantidadAlambre * _precioAlambre;

                        _cantidadPostes = _perimetro / 2;
                        _precioPosteFinal = _cantidadPostes * _precioPoste;

                        _precioFinal = _precioPosteFinal + _precioAlambreFinal;
                        
                        Console.WriteLine($"\nSe necesitan {_cantidadPostes} postes, {_cantidadAlambre} Mts. de alambre.\nCosto Total = {_precioFinal}");

                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");
                    }

                    else
                    {
                        Console.WriteLine("\nERROR: Introduzca un caracter numerico valido.");
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
                    Environment.Exit(0);

                } // if

            } // While
        }
    }
}
