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
 * Ejercicio:           N° 9
 * 
 * Appelido y nombre:   Chiappelo Bruno
 * DNI:                 40217247
 * 
 */

namespace P1E9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Color De Consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            // Variables
            decimal _base = 0m;
            decimal _exponente = 0m;
            decimal _resultado = 0m;
            int _contador = 0;

            bool _bandera = false;


            // Operaciones
            _contador = 1;
            _base = 2m;
            _resultado = _base;

            while (_bandera == false)
            {
                Console.Clear();
                Console.Write("Ingrese la potencia que desea para elevar el numero 2: ");

                if (decimal.TryParse(Console.ReadLine(), out _exponente))
                {
                    if (_exponente > 0)
                    {
                        while (_contador < _exponente)
                        {
                            _resultado = _resultado * _base;
                            _contador++;

                        } // while

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
