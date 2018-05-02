using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Universidad Tecnologica Nacional
 * Tecnicatura Superior En Programacion
 * Laboratorio 1 Com. 2
 * 
 * Trabajo Pactico:     N° 1
 * Ejercicio:           N° 2
 * 
 * Appelido y nombre:   Chiappelo Bruno
 * DNI:                 40217247
 * 
 */

namespace P1E2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Color De La Consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            // Variables
            decimal _base = 0m;
            decimal _altura = 0m;
            decimal _superficie = 0m;
            decimal _perimetro = 0m;
            bool _bandera = false;
            

            // Operaciones
            while(_bandera == false)
            {
                Console.Clear();

                Console.Write("Introduzca la base: ");

                if (decimal.TryParse(Console.ReadLine(), out _base))
                {
                    Console.Write("\nIntroduzca la altura: ");

                    if (decimal.TryParse(Console.ReadLine(), out _altura))
                    {
                        _superficie = (_base * _altura) / 2;
                        _perimetro = ((_base * 2) + (_altura * 2));
                        Console.WriteLine($"\nEl perimetro es {_perimetro} y la superficie {_superficie}");
                        Console.WriteLine("\nPrecione una tecla para reiniciar");
                    }
                    else
                    {
                        Console.WriteLine("\nERROR: Por favor introduzca un caracter numerico valido.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar");

                    } // if

                }
                else
                {
                    Console.WriteLine("\nERROR: Por favor introduzca un caracter numerico valido.");
                    Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                    Console.WriteLine("\nPrecione una tecla para reiniciar.");

                } // if

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }

            } // while

            _bandera = true;
        }
    }
}
