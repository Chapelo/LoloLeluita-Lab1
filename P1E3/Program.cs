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
 * Ejercicio:           N° 3
 * 
 * Appelido y nombre:   Chiappelo Bruno
 * DNI:                 40217247
 * 
 */

namespace P1E3
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

                Console.WriteLine("Introduzca un numero\nEn caso de ser negativo utilice el - (Menos) por delante del numero sin dejar espacios.");
                Console.Write("\nNumero: ");

                if (decimal.TryParse(Console.ReadLine(), out _numero))
                {
                    if (_numero == 0)
                    {
                        Console.WriteLine($"\nEl numero {_numero} es neutro.");
                        Console.WriteLine("\nPresione una tecla para reiniciar");

                    } // if

                    if (_numero < 0)
                    {
                        Console.WriteLine($"\nEl numero {_numero} es negativo.");
                        Console.WriteLine("\nPresione una tecla para reiniciar");

                    } // if

                    if (_numero > 0)
                    {
                        Console.WriteLine($"\nEl numero {_numero} es positivo.");
                        Console.WriteLine("\nPresione una tecla para reiniciar");

                    } // if

                }
                else
                {
                    Console.WriteLine("\n ERROR: Por favor ingrese un caracter numerico valido.");
                    Console.WriteLine("\nPresione una tecla para reiniciar");

                } // if
                
                Console.ReadKey();

            } // while
            
        }
    }
}
