﻿using System;

namespace P1E14
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 14
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
            decimal _unMetroEnMillas = 1852m;
            decimal _millas = 0m;
            decimal _resultado = 0m;

            bool _cerrarPrograma = false;


            // Operaciones

            while (_cerrarPrograma == false)
            {
                Console.Clear();
                Console.WriteLine("Conversor de millas marinas a metros.");

                Console.Write("\nIngrese las millas marinas: ");
                if (decimal.TryParse(Console.ReadLine(), out _millas))
                {
                    if (_millas > 0)
                    {
                        _resultado = _unMetroEnMillas * _millas;
                        Console.WriteLine($"\n{_millas} Milla/as Marinas son {_resultado} Metros.");
                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");
                    }

                    else if (_millas < 0)
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

            } // While
        }
    }
}
