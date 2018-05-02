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
 * Ejercicio:           N° 7
 * 
 * Appelido y nombre:   Chiappelo Bruno
 * DNI:                 40217247
 * 
 */

namespace P1E7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Color De Consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            // Variables
            decimal _numero = 0m;
            bool _bandera = false;


            // Operaciones
            while (_bandera == false)
            {
                Console.Clear();

                Console.Write("Ingrese un numero para saber si es par o impar: ");
                if (decimal.TryParse(Console.ReadLine(), out _numero))
                {
                    if (_numero == 0)
                    {
                        Console.WriteLine("\nEl numero ingresado es 0.");
                    }

                    else
                    {
                        if (_numero % 2 == 0)
                        {
                            Console.WriteLine("\nEl numero ingresado es par.");
                        }

                        else
                        {
                            if (_numero % 2 != 0)
                            {
                                Console.WriteLine("\nEl numero ingresado es impar.");

                            } // if

                        } // if

                    } // if
                    
                }

                else
                {
                    Console.WriteLine("\nERROR: Ingrese un caracter numerico valido.\nPresione una tecla para reiniciar");

                } // if

                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                Console.WriteLine("\nPrecione una tecla para reiniciar.");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }

            } // while
        }
    }
}
